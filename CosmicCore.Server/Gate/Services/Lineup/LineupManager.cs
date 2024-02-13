using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.Account;
using Newtonsoft.Json;

namespace CosmicCore.Server.Gate.Services.Lineup;

public class LineupManager : AccountManager
{
    public Lineup[] Lineups = new Lineup[Const.DefaultTeams];
    public int Index { get; set; } = 0;
    [JsonProperty(nameof(Mp))] private int _mp = 5;

    public LineupManager(Account account) : base(account)
    {
        PopulateLineups();
    }

    [JsonIgnore]
    public int Mp
    {
        get => _mp;
        set
        {
            if (value > _mp)
            {
                _mp = Math.Min(value, Const.MaxMp);
                CurrentLineup.SyncLineup();
            }
            else if (value < _mp)
            {
                _mp = Math.Max(value, 0);
                CurrentLineup.SyncLineup();
            }
        }
    }
    [JsonIgnore] public Lineup? CurrentLineup => Lineups.TryGet(Index);

    public void PopulateLineups()
    {
        for (var i = 0; i < Const.DefaultTeams; i++)
        {
            var curLineup = Lineups.TryGet(i);
            if (curLineup is null)
            {
                Lineups[i] = new Lineup(Owner, i);
            }
            else
            {
                curLineup.Owner = Owner;
            }
        }

        var lineup = CurrentLineup;
        if (lineup is null)
        {
            Index = 0;
            lineup = CurrentLineup;
        }

        if (lineup.Avatars.Count == 0)
        {
            var avatar = Owner.AvatarInventory.Avatars.TryGetValue(Const.TrailblazerAvatarId);
            if (avatar is not null)
            {
                lineup.Avatars.Add(avatar.AvatarId);
            }
        }
    }
}
