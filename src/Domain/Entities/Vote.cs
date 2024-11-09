namespace pollBack.src.Domain.Entities;

public class Votes : EntitiBase
{
    public Guid PollId { get; set; }
    public required string VoterEmail { get; set;}
    public Guid Option { get; set; }
}
