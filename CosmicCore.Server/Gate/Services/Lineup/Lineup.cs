using CosmicCore.Protos;
using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.Account;

namespace CosmicCore.Server.Gate.Services.Lineup;

public class Lineup(Account account, int index) : AccountManager(account)
{
    public string Name { get; set; } = "Team " + (index + 1);
    public int Index { get; set; } = index;
    public List<int> Avatars { get; set; } = [];
    public int LeaderIndex { get; set; }

    public void Heal(int amount, bool revive)
    {
        var hasHealed = false;

        foreach (var avatarId in Avatars)
        {
            var avatar = Owner.AvatarInventory.Avatars.TryGetValue(avatarId);
            if (avatar is null) return;

            if (avatar.CurrentHp <= 0 && !revive) continue;

            if (avatar.CurrentHp < 10000)
            {
                avatar.CurrentHp = Math.Min(avatar.CurrentHp + Math.Max(Math.Min(amount, 10000), 0), 10000);
                hasHealed = true;
            }
        }

        if (hasHealed)
        {
            SyncLineup();
        }
    }

    public bool IsActiveSlot(int slot)
    {
        return slot >= 0 && slot <= Avatars.Count;
    }

    public bool AddAvatar(int avatarId, int slot)
    {
        var avatar = Owner.AvatarInventory.Avatars.TryGetValue(avatarId);
        if (avatar is null) return false;

        if (IsActiveSlot(slot))
        {
            Avatars[slot] = avatarId;
        }
        else if (Avatars.Count < Const.MaxAvatarsInTeam)
        {
            Avatars.Add(avatarId);
        }
        else
        {
            return false;
        }

        if (Owner.LineupManager.CurrentLineup == this)
        {
            // Owner.Scene.SyncLineup();
        }

        SyncLineup();
        return true;
    }

    public bool RemoveAvatar(int avatarId)
    {
        if (Avatars.Count <= 1)
        {
            return false;
        }

        if (!Avatars.Remove(avatarId))
        {
            return false;
        }

        if (Owner.LineupManager.CurrentLineup == this)
        {
            // Owner.Scene.SyncLineup();
        }

        SyncLineup();
        return true;
    }

    public bool SwapAvatar(int src, int dest)
    {
        if (src == dest) return false;
        if (!IsActiveSlot(src) || !IsActiveSlot(dest)) return false;

        var srcId = Avatars[src];
        var destId = Avatars[dest];
        Avatars[src] = destId;
        Avatars[dest] = srcId;

        SyncLineup();
        return true;
    }

    public bool ReplaceLineup(List<int> lineupList)
    {
        if (Owner.LineupManager.CurrentLineup == this && lineupList.Count == 0)
        {
            return false;
        }

        Avatars.Clear();

        foreach (var avatarId in lineupList)
        {
            var avatar = Owner.AvatarInventory.Avatars.TryGetValue(avatarId);
            if (avatar is not null)
            {
                Avatars.Add(avatarId);
            }
        }

        ValidateLeader();

        if (Owner.LineupManager.CurrentLineup == this)
        {
            // Owner.Scene.SyncLineup();
        }
        SyncLineup();
        return true;
    }

    public void SyncLineup()
    {
        Owner.Session?.Send(CmdId.CmdSyncLineupNotify, new SyncLineupNotify { Lineup = ToProto() });
    }

    public void ValidateLeader()
    {
        if (LeaderIndex > Avatars.Count - 1)
        {
            LeaderIndex = 0;
        }
    }

    public LineupInfo ToProto()
    {
        var proto = new LineupInfo
        {
            Index = (uint)Index,
            LeaderSlot = (uint)LeaderIndex,
            Mp = (uint)Owner.LineupManager.Mp,
            MaxMp = (uint)Const.MaxMp,
            ExtraLineupType = 0,
            Name = Name
        };

        for (var slot = 0; slot < Avatars.Count; slot++)
        {
            var avatar = Owner.AvatarInventory.Avatars.TryGetValue(Avatars[slot]);
            if (avatar is null) continue;

            proto.AvatarList.Add(avatar.ToLineupAvatarProto(this, slot));
        }

        return proto;
    }
}
