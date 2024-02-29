using System.Collections.Immutable;
using System.Linq.Expressions;
using System.Reflection;
using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities.Logger;
using Nito.AsyncEx;
using Serilog;

namespace CosmicCore.Server.Gate.Manager;

public static class NotifyManager
{
    private static readonly List<Type> HandlerTypes = [];

    private static ImmutableDictionary<int, (PacketHandlerAttribute, PacketHandlerAttribute.HandlerDelegate)>
        _notifyReqGroup = null!;

    public static void Initialize()
    {
        var handlers = ImmutableDictionary
            .CreateBuilder<int, (PacketHandlerAttribute, PacketHandlerAttribute.HandlerDelegate)>();

        foreach (var type in HandlerTypes)
        foreach (var method in type.GetMethods())
        {
            var attribute = method.GetCustomAttribute<PacketHandlerAttribute>();
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

            var lambda = Expression.Lambda<PacketHandlerAttribute.HandlerDelegate>(call,
                sessionParameter, cmdIdParameter, dataParameter);

            if (!handlers.TryGetKey(attribute.CmdId, out _))
            {
                Log.Information("Registered handler for cmd id {0}({1})", (CmdId)attribute.CmdId, attribute.CmdId);
                handlers.Add(attribute.CmdId, (attribute, lambda.Compile()));
            }
            else
            {
                Log.Warning("Trying to re-register handler for already registered cmd id {0}({1})!",
                    (CmdId)attribute.CmdId, attribute.CmdId);
            }
        }

        Log.Information("Registered {0} handlers in total", handlers.Count);
        _notifyReqGroup = handlers.ToImmutable();
    }

    public static void AddReqGroupHandler(Type type)
    {
        HandlerTypes.Add(type);
    }

    public static bool Notify(NetSession session, int cmdId, object? data)
    {
        if (_notifyReqGroup.TryGetValue(cmdId, out var handler))
        {
            if (LoggerManager.IsCmdIdLogged(cmdId))
                Log.Information("{0}({1}): Received and handling", (CmdId)cmdId, cmdId);

            AsyncContext.Run(void () => handler.Item2.Invoke(session, cmdId, data));
            return true;
        }
        else
        {
            Log.Information("{0}({1}): Received but does not have registered handler", (CmdId)cmdId, cmdId);
            return false;
        }
    }
}
