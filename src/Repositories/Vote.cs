using Dapper;
using pollBack.src.Data.Interfaces;
using pollBack.src.Domain.DTOs.Requests;
using pollBack.src.Repositories.Interfaces;

namespace pollBack.src.Repositories;

public class Vote : IVote
{
  private readonly IDBConnectionFactory _dbConnection;

  public Vote(IDBConnectionFactory dBConnectionFactory)
  {
    _dbConnection = dBConnectionFactory;
  }
    public async Task<Vote> VotesAsync(CreateVoteRequest vote)
    {
      const string query = @"
      INSERT INTO Votes (id, pollId, voterEmail, option)
      VALUES (@Id, @PollID, @VoterEmail, @Option)
      ";

      using var  connection = await _dbConnection.ConnectionAsync();
      var affectedRows = await connection.ExecuteAsync(query, vote);
    
    }
}
