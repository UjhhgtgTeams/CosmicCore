using System.Security;
using MessagePack;
using Serilog;

namespace CosmicCore.Server.Utilities.Account;

public class AccountDatabase
{
    private List<Account> Accounts { get; set; } = [];

    public int NextId
    {
        get
        {
            if (Accounts.Count == 0)
                return 10000;
            else
                return (int)(Accounts.Last().Id + 1);
        }
    }

    public IEnumerable<Account> OnlineAccounts => Accounts.Where(acc => acc.IsLoggedIn);

    public void InitializeDatabase(StringPath path)
    {
        Log.Information("Loading accounts...");
        if (File.Exists(path))
        {
            try
            {
                Accounts = MessagePackSerializer.Typeless.Deserialize(File.ReadAllBytes(path)) as List<Account> ?? [];
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException
                                           or SecurityException or MessagePackSerializationException)
            {
                Log.Fatal(ex, "Exception happened while loading accounts from {Path}!", path.ToString());
            }

            Log.Information("{0} accounts loaded from file {1}", Accounts.Count, path);
        }
        else
        {
            Accounts = [];
            Log.Warning("Account database not found; new database created");
        }
    }

    public bool SaveToFile(StringPath path)
    {
        Log.Information("Saving account database...");
        try
        {
            File.WriteAllBytes(path, MessagePackSerializer.Typeless.Serialize(Accounts));
            Log.Information("Account database saved");
            return true;
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException
                                       or SecurityException or MessagePackSerializationException)
        {
            Log.Fatal("Failed to save account database to {Path}!", path.ToString());
            return false;
        }
    }

    public bool AddAccount(Account account)
    {
        var hasRepeatedIdOrUserName = Accounts.Any(acc => acc.Id == account.Id || acc.UserName == account.UserName);

        if (!hasRepeatedIdOrUserName)
        {
            Accounts.Add(account);
            EnsureSorted();
        }

        return !hasRepeatedIdOrUserName;
    }

    public bool DeleteAccount(long id)
    {
        var amount = Accounts.RemoveAll(acc => acc.Id == id);
        if (amount > 1)
        {
            Log.Error("Account database inconsistent: more than 1 account with id {Id} exists!", id);
        }

        return amount >= 1;
    }

    public bool ContainsAccount(long id)
    {
        return Accounts.Any(acc => acc.Id == id);
    }

    public bool ContainsAccount(string username)
    {
        return Accounts.Any(acc => acc.UserName == username);
    }

    public IEnumerable<T> Cast<T>()
    {
        return Accounts.Cast<T>();
    }

    private void EnsureSorted()
    {
        Accounts = Accounts.OrderBy(acc => acc.Id).ToList();
    }

    #region Get/Set Methods

    public Account this[long id]
    {
        get { return Accounts.First(acc => acc.Id == id); }
        set { Accounts[Accounts.IndexOf(Accounts.First(acc => acc.Id == id))] /* uhh */ = value; }
    }

    public Account this[string username]
    {
        get { return Accounts.First(acc => acc.UserName == username); }
        set { Accounts[Accounts.IndexOf(Accounts.First(acc => acc.UserName == username))] /* uhh */ = value; }
    }

    #endregion
}
