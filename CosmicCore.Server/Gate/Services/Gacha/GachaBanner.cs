using CosmicCore.Server.Utilities.Account;
using Newtonsoft.Json;

namespace CosmicCore.Server.Gate.Services.Gacha;

public class GachaBanner
{
    [JsonProperty("id")]
    public int Id { get; private set; } // id should match one of the ids in GachaBasicInfo.json
    [JsonProperty("gachaType")]
    public GachaType GachaType { get; private set; }
    [JsonProperty("beginTime")]
    public int BeginTime { get; private set; }
    [JsonProperty("endTime")]
    public int EndTime { get; private set; }
    [JsonProperty("rateUpItems5")]
    public List<int> RateUpItems5 { get; private set; }
    [JsonProperty("rateUpItems4")]
    public List<int> RateUpItems4 { get; private set; }
    [JsonProperty("eventChance")]
    public int EventChance { get; private set; } = 50;

    public Protos.GachaInfo ToProto(Account account)
    {
        var info = new Protos.GachaInfo
        {
            GachaId = Convert.ToUInt32(Id),
            DetailUrl = "",
            HistoryUrl = ""
        };

        if (GachaType != GachaType.Normal)
        {
            info.BeginTime = BeginTime;
            info.EndTime = EndTime;
        }

        var upInfo = new List<uint>();
        if (Id == 1001)
        {
            info.GachaCeiling = account.Gacha.ToCeilingProto(account);

            upInfo.AddRange(GachaService.DefaultPurpleAvatars.AsEnumerable().Select(Convert.ToUInt32));
            upInfo.AddRange(GachaService.DefaultYellowAvatars.AsEnumerable().Select(Convert.ToUInt32));
            upInfo.AddRange(GachaService.DefaultPurpleWeapons.AsEnumerable().Select(Convert.ToUInt32));
            upInfo.AddRange(GachaService.DefaultYellowWeapons.AsEnumerable().Select(Convert.ToUInt32));

            info.Featured = GachaService.DefaultFeaturedIds.AsEnumerable().Select(Convert.ToUInt32).ToArray();
        }
        else
        {
            if (RateUpItems4.Count > 0)
            {
                upInfo.AddRange(RateUpItems4.AsEnumerable().Select(Convert.ToUInt32));
            }

            if (RateUpItems5.Count > 0)
            {
                upInfo.AddRange(RateUpItems5.AsEnumerable().Select(Convert.ToUInt32));
                info.Featured = RateUpItems4.AsEnumerable().Select(Convert.ToUInt32).ToArray();
            }
        }

        info.UpInfo = upInfo.ToArray();

        return info;
    }
}
