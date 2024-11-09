namespace pollBack.src.Domain.Entities;

public class Options : EntitiBase
{
    public required string Name { get; set; }
    public int Votes { get; set; }
}
