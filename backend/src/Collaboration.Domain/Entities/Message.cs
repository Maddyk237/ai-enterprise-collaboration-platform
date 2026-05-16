namespace Collaboration.Domain.Entities;

public class Message : BaseEntity
{
    public string Content { get; set; } = string.Empty;

    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    public Guid ChannelId { get; set; }

    public Channel Channel { get; set; } = null!;
}