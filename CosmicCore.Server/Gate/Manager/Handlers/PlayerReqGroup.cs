using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Gate.Network.Handlers.Manager;
using Serilog;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class PlayerReqGroup
{
    public static NetSession? PlayerSession { get; private set; }
    public static byte[]? RemoteExecutedLua { private get; set; }

    private static DateTimeOffset? LastHeartbeatTime { get; set; }

    [PacketHandler(CmdId.CmdPlayerHeartBeatCsReq)]
    public static void OnPlayerHeartBeatCsReq(NetSession session, int cmdId, object data)
    {
        var heartbeatReq = (PlayerHeartBeatCsReq)data;

        if (LastHeartbeatTime is not null)
        {
            // client may have disconnected
            if (DateTimeOffset.Now.Subtract(LastHeartbeatTime.Value).TotalSeconds > Const.HeartbeatTimeout)
            {
                Log.Warning("Closing a connection due to heartbeat timeout");
                session.Close();
                return;
            }
        }

        LastHeartbeatTime = DateTimeOffset.Now;

        session.Send(CmdId.CmdPlayerHeartBeatScRsp, new PlayerHeartBeatScRsp
        {
            Retcode = 0,
            DownloadData = new ClientDownloadData
            {
                Version = 51,
                Time = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                Data = RemoteExecutedLua
            },

            ClientTimeMs = heartbeatReq.ClientTimeMs,
            ServerTimeMs = (ulong)DateTimeOffset.Now.ToUnixTimeMilliseconds()
        });
    }

    [PacketHandler(CmdId.CmdGetHeroBasicTypeInfoCsReq)]
    public static void OnGetHeroBasicTypeInfoCsReq(NetSession session, int cmdId, object _)
    {
        session.Send(CmdId.CmdGetHeroBasicTypeInfoScRsp, new GetHeroBasicTypeInfoScRsp
        {
            Retcode = 0,
            Gender = Gender.GenderMan,
            BasicTypeInfoList =
            {
                new PlayerHeroBasicTypeInfo
                {
                    BasicType = HeroBasicType.BoyWarrior,
                    Rank = 1
                }
            },
            CurBasicType = HeroBasicType.BoyWarrior
        });
    }

    [PacketHandler(CmdId.CmdGetBasicInfoCsReq)]
    public static void OnGetBasicInfoCsReq(NetSession session, int cmdId, object data)
    {
        session.Send(CmdId.CmdGetBasicInfoScRsp, new GetBasicInfoScRsp
        {
            Retcode = 0,
            CurDay = 1,
            ExchangeTimes = 0,
            NextRecoverTime = 2281337,
            WeekCocoonFinishedCount = 0
        });
    }

    [PacketHandler(CmdId.CmdPlayerLoginCsReq)]
    public static void OnPlayerLoginCsReq(NetSession session, int cmdId, object data)
    {
        var request = (PlayerLoginCsReq)data;

        PlayerSession = session;

        session.Send(CmdId.CmdPlayerLoginScRsp, new PlayerLoginScRsp
        {
            Retcode = 0,
            // IsNewPlayer = false,
            LoginRandom = request.LoginRandom,
            Stamina = 240,
            ServerTimestampMs = (ulong)DateTimeOffset.Now.ToUnixTimeSeconds() * 1000,
            BasicInfo = new PlayerBasicInfo
            {
                Nickname = "ujhhgtg",
                Level = 70,
                Exp = 0,
                Stamina = 100,
                MCoin = 1337,
                HCoin = 1337,
                SCoin = 1337,
                WorldLevel = 6
            }
        });
    }

    [PacketHandler(CmdId.CmdPlayerGetTokenCsReq)]
    public static void OnPlayerGetTokenCsReq(NetSession session, int cmdId, object data)
    {
        session.Send(CmdId.CmdPlayerGetTokenScRsp, new PlayerGetTokenScRsp
        {
            Retcode = 0,
            Uid = 1337,
            // BlackInfo = new BlackInfo(),
            Msg = "OK",
            SecretKeySeed = 0
        });
    }

    [PacketHandler(CmdId.CmdPlayerLogoutCsReq)]
    public static void OnPlayerLogoutCsReq(NetSession session, int cmdId, object data)
    {
        session.Send(CmdId.CmdPlayerLoginScRsp, new PacketHandler.DummyPacket());
        session.Close();
        Log.Information("Closing a connection due to PlayerLogout packet");
    }
}
