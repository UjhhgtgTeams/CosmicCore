using CosmicCore.Server.Utilities;
using CosmicCore.Protos;
using CosmicCore.Server.Dispatch.Utils;

namespace CosmicCore.Server.Gate.Manager.Handlers;

using Core;
using Network;
using Protos;
using System;

internal static class PlayerReqGroup
{
    [Handler(CmdId.CmdPlayerHeartBeatCsReq)]
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

    [Handler(CmdId.CmdGetHeroBasicTypeInfoCsReq)]
    public static void OnGetHeroBasicTypeInfoCsReq(NetSession session, int cmdId, object _)
    {
        session.Send(CmdId.CmdGetHeroBasicTypeInfoScRsp, new GetHeroBasicTypeInfoScRsp
        {
            Retcode = (uint)Retcode.Success,
            Gender = Gender.GenderMan,
            BasicTypeInfoList =
            {
                new HeroBasicTypeInfo
                {
                    BasicType = HeroBasicType.BoyWarrior,
                    Rank = 1
                }
            },
            CurBasicType = HeroBasicType.BoyWarrior
        });
    }

    [Handler(CmdId.CmdGetBasicInfoCsReq)]
    public static void OnGetBasicInfoCsReq(NetSession session, int cmdId, object _)
    {
        session.Send(CmdId.CmdGetBasicInfoScRsp, new GetBasicInfoScRsp
        {
            CurDay = 1,
            ExchangeTimes = 0,
            Retcode = 0,
            NextRecoverTime = 2281337,
            WeekCocoonFinishedCount = 0
        });
    }

    [Handler(CmdId.CmdPlayerLoginCsReq)]
    public static void OnPlayerLoginCsReq(NetSession session, int cmdId, object data)
    {
        // var request = data as PlayerLoginCsReq;
        dynamic request = data; // FIXME (no proto)

        session.Send(CmdId.CmdPlayerLoginScRsp, new PlayerLoginScRsp
        {
            Retcode = (uint)Retcode.Success,
            LoginRandom = request.LoginRandom,
            Stamina = 100,
            ServerTimestampMs = (ulong)DateTimeOffset.Now.ToUnixTimeSeconds() * 1000,
            BasicInfo = new PlayerBasicInfo // FIXME: hardcode
            {
                Nickname = "xeondev",
                Level = 70,
                Exp = 0,
                Stamina = 100,
                Mcoin = 0,
                Hcoin = 0,
                Scoin = 0,
                WorldLevel = 6
            }
        });
    }

    [Handler(CmdId.CmdPlayerGetTokenCsReq)]
    public static void OnPlayerGetTokenCsReq(NetSession session, int cmdId, object data)
    {
        session.Send(CmdId.CmdPlayerGetTokenScRsp, new PlayerGetTokenScRsp
        {
            Retcode = (uint)Retcode.Success,
            Uid = 1337, // FIXME: hardcode
            Msg = "OK",
            SecretKeySeed = 0
        });

        // var annData = new
        // {
        //     BeginTime = 0,
        //     EndTime = DateTimeOffset.Now.ToUnixTimeSeconds() + 10, // FIXME: hardcode
        //     Jhjbgmmpccj = Encoding.UTF8.GetString(Convert.FromBase64String("RnJlZVNSIGlzIGEgZnJlZSBhbmQgb3Blbi1zb3VyY2Ugc29mdHdhcmUsIGlmIHlvdSBwYWlkIGZvciB0aGlzLCB5b3UgaGF2ZSBiZWVuIHNjYW1tZWQhIEZyZWVTUuaYr+S4gOS4quWFjei0ueS4lOW8gOa6kOeahOi9r+S7tu+8jOWmguaenOS9oOaYr+iKsemSseS5sOadpeeahO+8jOivtOaYjuS9oOiiq+mql+S6hu+8gXJlcG9zaXRvcnkgbGluayDku5PlupPlnLDlnYA6aHR0cHM6Ly9naXQueGVvbmRldi5jb20vTW91eDIzMzMzL0ZyZWVTUg=="))
        // };
        //
        // session.Send(CmdType.CmdServerAnnounceNotify, new AnnounceNotify
        // {
        //      = {annData},
        // });
    }
}
