using CosmicCore.Server.Gate.Services.Inventory;
using CosmicCore.Server.Utilities.Account;

namespace CosmicCore.Server.Gate.Services.Mail;

public class Mail : AccountManager
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Sender { get; set; }
    public string Content { get; set; }
    public long SendTime { get; set; }
    public long Expiry { get; set; }
    public bool IsRead { get; set; }
    public List<Item> Attachments { get; set; } = [];

    public Mail(string title, string sender, string content) : base(null)
    {
        Title = title;
        Sender = sender;
        Content = content;
        SendTime = DateTimeOffset.Now.ToUnixTimeSeconds();
        Expiry = (long)(SendTime + new TimeSpan(30, 0, 0, 0).TotalSeconds);
    }

    // TODO
}
