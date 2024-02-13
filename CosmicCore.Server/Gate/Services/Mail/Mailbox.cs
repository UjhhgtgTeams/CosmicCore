using CosmicCore.Server.Utilities.Account;

namespace CosmicCore.Server.Gate.Services.Mail;

// TODO
public class Mailbox(Account account) : AccountManager(account)
{
    private Dictionary<long, Mail> _mails = new();
    private long NextMailId => (_mails.Values.LastOrDefault(mail => true) ?? new Mail("", "", "") { Id = 9999 }).Id + 1;

    public void Send(Mail mail)
    {
        mail.Owner = Owner;
        mail.Id = NextMailId;
        _mails.Add(mail.Id, mail);
        // TODO
    }

    public void MarkRead(Mail mail)
    {

    }

    private void EnsureSorted()
    {
        _mails = _mails.OrderBy(kv => kv.Key).ToDictionary();
    }
}
