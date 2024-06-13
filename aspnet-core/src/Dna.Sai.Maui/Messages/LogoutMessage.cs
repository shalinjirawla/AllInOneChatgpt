using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Dna.Sai.Maui.Messages;
public class LogoutMessage : ValueChangedMessage<bool?>
{
    public LogoutMessage(bool? value = null) : base(value)
    {
    }
}