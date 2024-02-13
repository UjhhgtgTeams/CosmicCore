using CosmicCore.Protos;
using CosmicCore.Server.Utilities.Account;
using CosmicCore.Server.Utilities.Command;

namespace CosmicCore.Server.Utilities.Chat;

public class ChatManager(Account.Account account) : AccountManager(account)
{
    public void SendChat(long targetId, string? message)
    {
        if (string.IsNullOrWhiteSpace(message)) return;

        SendChat(OwnerId, targetId, message);
        if (targetId == Account.Account.Console.Id) // if sent to console...
        {
            if (message.StartsWith('/')) // ...and message is command, execute it
            {
                CommandManager.ExecuteCommand(message[1..], Owner);
                return;
            }
            else // ..and message is not command, broadcast to world message
            {
                foreach (var account in Program.AccountDatabase.Accounts.Where(acc => acc.IsLoggedIn))
                {
                    account.PrivateChat.SendChat(Account.Account.Console.Id, account.Id, $"[sc] <{Owner.NickName} ({Owner.Id})> {message}");
                }

                return;
            }
        }
        else // if sent to normal users...
        {
            // ...just send
            Program.AccountDatabase[targetId].PrivateChat.SendChat(Owner.Id, targetId, message);
        }
    }

    public void SendChat(long fromId, long toId, object message /* message can be string (text) or int (emote) */ )
    {
        var packet = new RevcMsgScNotify
        {
            ChatType = ChatType.ChatTypePrivate,
            FromUid = (uint)fromId,
            ToUid = (uint)toId
        };

        switch (message)
        {
            case string:
                packet.MsgType = MsgType.MsgTypeCustomText;
                packet.Text = (string)message;
                break;
            case int:
                packet.MsgType = MsgType.MsgTypeEmoji;
                packet.Emote = (uint)message;
                break;
        }

        Owner.Session?.Send(CmdId.CmdRevcMsgScNotify, packet);
    }
}
