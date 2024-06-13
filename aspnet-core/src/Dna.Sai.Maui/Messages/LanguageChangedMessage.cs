using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Dna.Sai.Maui.Messages;

public class LanguageChangedMessage : ValueChangedMessage<string?>
{
    public LanguageChangedMessage(string? value) : base(value)
    {
    }
}
