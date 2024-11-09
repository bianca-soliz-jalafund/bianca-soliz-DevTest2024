using pollBack.src.Domain.Entities;

namespace pollBack.src.Domain.DTOs.Requests;


public class CreateVoteRequest
{
    public required string voterEmail { get; set;}
    public Guid Option { get; set; }
}

