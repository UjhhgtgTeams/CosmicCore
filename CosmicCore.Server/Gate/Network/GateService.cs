using System.Net;
using System.Net.Sockets;
using CosmicCore.Server.Gate.Manager;
using CosmicCore.Server.Gate.Manager.Handlers;
using CosmicCore.Server.Gate.Network.Handlers.Decoder;
using CosmicCore.Server.Gate.Network.Handlers.Encoder;
using CosmicCore.Server.Gate.Network.Handlers.Manager;
using CosmicCore.Server.Utilities.Config;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using CosmicCore.Server.Utilities;
using Serilog;

namespace CosmicCore.Server.Gate.Network;

public static class GateService
{
    private static ServerBootstrap _bootstrap;
    private static IChannel _serverChannel;

    public static void Start(GateServerConfig config)
    {
        NotifyManager.AddReqGroupHandler(typeof(PlayerReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(MailReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(TutorialReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(ItemReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(AvatarReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(LineupReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(MissionReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(QuestReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(ChallengeReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(SceneReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(GachaReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(NpcReqGroup));
        NotifyManager.AddReqGroupHandler(typeof(BattleReqGroup));
        NotifyManager.Initialize();

        var bossGroup = new MultithreadEventLoopGroup();
        var workerGroup = new MultithreadEventLoopGroup();

        _bootstrap = new ServerBootstrap()
            .Group(bossGroup, workerGroup)
            .Channel<TcpServerSocketChannel>()
            .Option(ChannelOption.SoBacklog, 120)
            .Option(ChannelOption.TcpNodelay, true)
            .Option(ChannelOption.SoKeepalive, true)
            .ChildHandler(
                new ActionChannelInitializer<IChannel>(channel =>
                {
                    var session = new NetSession(channel);
                    var pipeline = channel.Pipeline;

                    pipeline.AddFirst(new HeaderDecoder());
                    pipeline.AddLast(new PacketDecoder());
                    pipeline.AddLast(new PacketEncoder());
                    pipeline.AddLast(new PacketHandler(session));
                })
            );

        try
        {
            _serverChannel = _bootstrap.BindAsync(IPAddress.Parse(config.Address), config.Port).RunSync();
        }
        catch (SocketException)
        {
            Log.Error("Failed to start gate server: address/port already in use");
            Environment.Exit(1);
        }
    }

    public static void Stop()
    {
        _serverChannel.DisconnectAsync().RunSync();
    }
}
