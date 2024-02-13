using CosmicCore.Server.Utilities;
using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;

namespace CosmicCore.Server.Gate.Manager.Handlers;


public class PlayerReqGroup
{
    [PacketHandler(CmdId.CmdPlayerHeartBeatCsReq)]
    public static void OnPlayerHeartBeatCsReq(NetSession session, int cmdId, object data)
    {
        var heartbeatReq = data as PlayerHeartbeatCsReq;

        session.Send(CmdId.CmdPlayerHeartBeatScRsp, new PlayerHeartbeatScRsp
        {
            Retcode = (uint)Retcode.Success,
            ClientTimeMs = heartbeatReq.ClientTimeMs,
            ServerTimeMs = (ulong)DateTimeOffset.Now.ToUnixTimeMilliseconds()
        });
    }

    [PacketHandler(CmdId.CmdGetHeroBasicTypeInfoCsReq)]
    public static void OnGetHeroBasicTypeInfoCsReq(NetSession session, int cmdId, object _)
    {
        if (session.State == NetSessionState.Active)
        {
            session.Send(CmdId.CmdGetHeroBasicTypeInfoScRsp, new GetHeroBasicTypeInfoScRsp
            {
                Retcode = (uint)Retcode.Success,
                Gender = (Gender)session.Owner.Gender,
                BasicTypeInfoList =
                {
                    new HeroBasicTypeInfo
                    {
                        BasicType = HeroBasicType.BoyWarrior, // FIXME: hardcode
                        Rank = 1
                    }
                },
                CurBasicType = HeroBasicType.BoyWarrior
            });
        }
    }

    [PacketHandler(CmdId.CmdGetBasicInfoCsReq)]
    public static void OnGetBasicInfoCsReq(NetSession session, int cmdId, object _)
    {
        if (session.State == NetSessionState.Active)
        {
            session.Send(CmdId.CmdGetBasicInfoScRsp, new GetBasicInfoScRsp
            {
                CurDay = 1, // FIXME: hardcode
                ExchangeTimes = 0,
                Retcode = (uint)Retcode.Success,
                NextRecoverTime = 2281337,
                WeekCocoonFinishedCount = 0
            });
        }
    }

    [PacketHandler(CmdId.CmdPlayerLoginCsReq)]
    public static void OnPlayerLoginCsReq(NetSession session, int cmdId, object data)
    {
        if (session.State == NetSessionState.WaitingForLogin)
        {
            var account = session.Owner;
            session.State = NetSessionState.Active;
            session.Send(CmdId.CmdPlayerLoginScRsp, new PlayerLoginScRsp
            {
                Retcode = (uint)Retcode.Success,
                Stamina = (uint)account.Stamina,
                ServerTimestampMs = (ulong)DateTimeOffset.Now.ToUnixTimeSeconds() * 1000,
                BasicInfo = new PlayerBasicInfo
                {
                    Nickname = account.NickName,
                    Level = (uint)account.Level,
                    Exp = (uint)account.Experience,
                    Stamina = (uint)account.Stamina,
                    Mcoin = (uint)account.Currency.MCoin,
                    Hcoin = (uint)account.Currency.HCoin,
                    Scoin = (uint)account.Currency.SCoin,
                    WorldLevel = (uint)account.WorldLevel
                },
                CurTimezone = Const.CurrentZoneOffset
            });
        }
    }

    [PacketHandler(CmdId.CmdPlayerGetTokenCsReq)]
    public static void OnPlayerGetTokenCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as PlayerGetTokenCsReq;

        // basic verification
        if (request is null)
        {
            return;
        }

        var account = Program.AccountDatabase[Convert.ToInt64(request.AccountUid)];

        // verify successful login
        if (request.Token != account.ComboToken)
        {
            return;
        }

        session.Owner = account;
        session.State = NetSessionState.WaitingForLogin;
        session.Send(CmdId.CmdPlayerGetTokenScRsp, new PlayerGetTokenScRsp
        {
            Retcode = (uint)Retcode.Success,
            Uid = (uint)account.Id,
            BlackInfo = new BlackInfo()
        });
    }
}
