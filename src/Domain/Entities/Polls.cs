using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;

namespace pollBack.src.Domain.Entities;

public class Polls : EntitiBase
{
    public required string Name { get; set; }

    public required List<Options> OptionPoll { get; set; }
}
