namespace Collaboration.Domain.Entities;

public class Channel : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public Guid TeamId { get; set; }

    public Team Team { get; set; } = null!;
}