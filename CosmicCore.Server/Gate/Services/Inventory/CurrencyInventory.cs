using CosmicCore.Server.Utilities.Account;

namespace CosmicCore.Server.Gate.Services.Inventory;

public class CurrencyInventory(Account account) : AccountManager(account)
{
    public long Credit { get; set; } = 0;
    public long Jade { get; set; } = 0;
    public long Crystal { get; set; } = 0;
    public long SCoin
    {
        get => Credit;
        set => Credit = value;
    }
    public long HCoin
    {
        get => Jade;
        set => Jade = value;
    }
    public long MCoin
    {
        get => Crystal;
        set => Crystal = value;
    }
}
