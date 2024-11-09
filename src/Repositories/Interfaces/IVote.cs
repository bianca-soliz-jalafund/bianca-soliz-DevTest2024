using pollBack.src.Domain.DTOs.Requests;

namespace pollBack.src.Repositories.Interfaces;

public interface IVote
{
    Task<Vote> VotesAsync(CreateVoteRequest vote);
}
