using System.Collections.Immutable;
using System.Linq.Expressions;
using System.Reflection;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using Nito.AsyncEx;
using Serilog;

namespace CosmicCore.Server.Gate.Manager;

internal static class NotifyManager
{
    private static List<Type> _handlerTypes = new();
    private static ImmutableDictionary<int, (HandlerAttribute, HandlerAttribute.HandlerDelegate)> _notifyReqGroup;

    public static void Initialize()
    {
        var handlers = ImmutableDictionary.CreateBuilder<int, (HandlerAttribute, HandlerAttribute.HandlerDelegate)>();

        foreach (var type in _handlerTypes)
        foreach (var method in type.GetMethods())
        {
            var attribute = method.GetCustomAttribute<HandlerAttribute>();
            if (attribute == null)
                continue;

            var parameterInfo = method.GetParameters();

            var sessionParameter = Expression.Parameter(typeof(NetSession));
            var cmdIdParameter = Expression.Parameter(typeof(int));
            var dataParameter = Expression.Parameter(typeof(object));

            var call = Expression.Call(method,
                Expression.Convert(sessionParameter, parameterInfo[0].ParameterType),
                Expression.Convert(cmdIdParameter, parameterInfo[1].ParameterType),
                Expression.Convert(dataParameter, parameterInfo[2].ParameterType));

            var lambda =
                Expression.Lambda<HandlerAttribute.HandlerDelegate>(call, sessionParameter, cmdIdParameter,
                    dataParameter);

            if (!handlers.TryGetKey(attribute.CmdId, out _))
                handlers.Add(attribute.CmdId, (attribute, lambda.Compile()));
        }

        _notifyReqGroup = handlers.ToImmutable();
    }

    public static void Notify(NetSession session, int cmdId, object? data)
    {
        if (_notifyReqGroup.TryGetValue(cmdId, out var handler))
            AsyncContext.Run(() => handler.Item2.Invoke(session, cmdId, data));
        else
            Log.Debug("Received packet with undefined handler {0}", cmdId);
    }

    public static void AddReqGroupHandler(Type type)
    {
        _handlerTypes.Add(type);
    }
}
