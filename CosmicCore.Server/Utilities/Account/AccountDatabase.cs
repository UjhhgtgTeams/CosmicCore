using System.Security;
using Newtonsoft.Json;
using Serilog;

namespace CosmicCore.Server.Utilities.Account;

internal class AccountDatabase
{
    private List<Account> _accounts;

    public int NextId
    {
        get
        {
            if (_accounts.Count == 0)
                return 10000;
            else
                return (int)(_accounts.Last().Id + 1);
        }
    }

    public void InitializeDatabase(StringPath path)
    {
        Log.Information("Loading accounts...");
        if (File.Exists(path))
        {
            _accounts = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(path)) ?? [];
            Log.Information("{0} accounts loaded from file {1}", _accounts.Count, path);
        }
        else
        {
            _accounts = [];
            Log.Warning("Account database not found; new database created");
        }
    }

    public bool SaveToFile(StringPath path)
    {
        Log.Information("Saving account database");
        try
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(_accounts, Formatting.Indented));
            Log.Information("Account database saved");
            return true;
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException or SecurityException)
        {
            Log.Error("Failed to save account database!");
            return false;
        }
    }

    public bool AddAccount(Account account)
    {
        var hasRepeatedIdOrUserName = _accounts.Any(acc => acc.Id == account.Id || acc.UserName == account.UserName);

        if (!hasRepeatedIdOrUserName)
        {
            _accounts.Add(account);
            EnsureSorted();
        }

        return !hasRepeatedIdOrUserName;
    }

    public int DeleteAccount(long id)
    {
        return _accounts.RemoveAll(acc => acc.Id == id);
    }

    public bool ContainsAccount(long id)
    {
        return _accounts.Any(acc => acc.Id == id);
    }

    public bool ContainsAccount(string username)
    {
        return _accounts.Any(acc => acc.UserName == username);
    }

    public IEnumerable<T> Cast<T>()
    {
        return _accounts.Cast<T>();
    }

    private void EnsureSorted()
    {
        _accounts = _accounts.OrderBy(acc => acc.Id).ToList();
    }

    #region Get/Set Methods

    public Account this[long id]
    {
        get { return _accounts.First(acc => acc.Id == id); }
        set { _accounts[_accounts.IndexOf(_accounts.First(acc => acc.Id == id))] /* uhh */ = value; }
    }

    public Account this[string username]
    {
        get { return _accounts.First(acc => acc.UserName == username); }
        set { _accounts[_accounts.IndexOf(_accounts.First(acc => acc.UserName == username))] /* uhh */ = value; }
    }

    #endregion
}
