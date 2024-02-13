using System.Collections.Immutable;
using CosmicCore.Protos;
using CosmicCore.Server.Utilities.Resource;
using CosmicCore.Server.Utilities.Resource.Resources;

namespace CosmicCore.Server.Utilities.Account;

public class UnlockInfo : AccountManager
{
    private HashSet<int> _headIcons { get; } = [];
    public ImmutableList<int> HeadIcons => ImmutableList<int>.Empty.AddRange(_headIcons);
    private HashSet<int> _chatBubbles { get; } = [];
    public ImmutableList<int> ChatBubbles => ImmutableList<int>.Empty.AddRange(_chatBubbles);
    private HashSet<int> _phoneThemes { get; } = [];
    public ImmutableList<int> PhoneThemes => ImmutableList<int>.Empty.AddRange(_phoneThemes);

    public UnlockInfo(Account owner) : base(owner)
    {
        // add all head icons instead of only owned avatars' head icons
        // HeadIcons.AddRange(Const.DefaultHeadIcons);
        // HeadIcons.AddRange(Owner.Avatars.Avatars.Values.Select(ava => ava.HeadIconId));
        // _headIcons.AddRange(ResourceManager.AvatarExcels.Select(ava => ava.HeadIconId));
        //
        // _chatBubbles.AddRange(ResourceManager.ChatBubbleExcels.Where(bub => bub.ShowType == PersonalizeShowType.Always)
        //     .Select(bub => bub.Id));
        //
        // _phoneThemes.AddRange(ResourceManager.PhoneThemeExcels.Where(pho => pho.ShowType == PersonalizeShowType.Always)
        //     .Select(pho => pho.Id));
        foreach (var avatar in ResourceManager.AvatarExcels)
        {
            AddHeadIcon(avatar.HeadIconId);
        }

        foreach (var chatBubble in ResourceManager.ChatBubbleExcels.Where(bub => bub.ShowType == PersonalizeShowType.Always))
        {
            AddChatBubble(chatBubble.Id);
        }

        foreach (var phoneTheme in ResourceManager.PhoneThemeExcels.Where(pho => pho.ShowType == PersonalizeShowType.Always))
        {
            AddPhoneTheme(phoneTheme.Id);
        }
    }

    public void AddHeadIcon(int headIcon)
    {
        var succeeded = _headIcons.Add(headIcon);
        if (succeeded && Owner.IsLoggedIn)
        {
            SendPacket(CmdId.CmdPlayerSyncScNotify, new PlayerSyncScNotify
            {
                BoardDataSync = Owner.ToBoardDataProto()
            });
        }
    }

    public void AddChatBubble(int chatBubble)
    {
        var succeeded = _chatBubbles.Add(chatBubble);
        if (succeeded && Owner.IsLoggedIn)
        {
            SendPacket(CmdId.CmdUnlockChatBubbleScNotify, new UnlockChatBubbleScNotify
            {
                BubbleId = (uint)chatBubble
            });
        }
    }

    public void AddPhoneTheme(int phoneTheme)
    {
        var succeeded = _phoneThemes.Add(phoneTheme);
        if (succeeded && Owner.IsLoggedIn)
        {
            SendPacket(CmdId.CmdUnlockPhoneThemeScNotify, new UnlockPhoneThemeScNotify
            {
                ThemeId = (uint)phoneTheme
            });
        }
    }
}
