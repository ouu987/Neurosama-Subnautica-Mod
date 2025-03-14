using System.Diagnostics.CodeAnalysis;

namespace SCHIZO.SwarmControl.Models.Game.Messages;

[method: SetsRequiredMembers]
public sealed record HelloMessage() : GameMessage
{
    public override MessageType MessageType => MessageType.Hello;
    public string Version { get; init; }
}
