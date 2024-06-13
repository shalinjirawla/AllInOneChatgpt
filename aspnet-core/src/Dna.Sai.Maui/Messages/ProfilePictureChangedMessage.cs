using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Dna.Sai.Maui.Messages;

public class ProfilePictureChangedMessage : ValueChangedMessage<string>
{
    public ProfilePictureChangedMessage(string value) : base(value)
    {
    }
}
