using CosmicCore.Server.Utilities.Account;

namespace CosmicCore.Server.Gate.Services.Friend;

public class Friendlist(Account account) : AccountManager(account)
{
    private Dictionary<int, Friendship> _friends = [];
    private Dictionary<int, Friendship> _pendingFriends = [];

}
