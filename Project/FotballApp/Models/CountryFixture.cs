using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FotballApp.Models
{
public partial class CountryFixture
    {
    public CountryFixtures Api { get; set; }
}

public partial class CountryFixtures
    {
    public long Results { get; set; }
    public List<Leaguee> Leagues { get; set; }
}

public partial class Leaguee
{
    public long LeagueId { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public string CountryCode { get; set; }
    public long Season { get; set; }
    public DateTimeOffset SeasonStart { get; set; }
    public DateTimeOffset SeasonEnd { get; set; }
    public Uri Logo { get; set; }
    public Uri Flag { get; set; }
    public long Standings { get; set; }
    public long IsCurrent { get; set; }
}
}
