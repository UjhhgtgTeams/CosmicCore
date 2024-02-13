using CosmicCore.Server.Utilities.Account;

namespace CosmicCore.Server.Gate.Services.Friend;

public class Friendship(Account self, Account other)
{
    public long Id { get; set; } = GetUniqueId(self.Id, other.Id);
    public long SelfId { get; set; } = self.Id;
    public long OtherId { get; set; } = other.Id;

    private static long GetUniqueId(long self, long other)
    {
        return (self << 32) + other;
    }
}
