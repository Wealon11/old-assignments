using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FotballApp.Models
{
   



    public partial class staticsticsTeaminfo
    {
        public Aepi Api { get; set; }
    }

    public partial class Aepi
    {
        public long Results { get; set; }
        public List<Feixture> Fixtures { get; set; }
    }

    public partial class Feixture
    {
        public long FixtureId { get; set; }
        public long LeagueId { get; set; }
        public DateTimeOffset EventDate { get; set; }
        public long EventTimestamp { get; set; }
        public long FirstHalfStart { get; set; }
        public long SecondHalfStart { get; set; }
        public string Round { get; set; }
        public string Status { get; set; }
        public string StatusShort { get; set; }
        public long Elapsed { get; set; }
        public string Venue { get; set; }
        public object Referee { get; set; }
        public Taeeam HomeTeam { get; set; }
        public Taeeam AwayTeam { get; set; }
        public long GoalsHomeTeam { get; set; }
        public long GoalsAwayTeam { get; set; }
        public Skcore Score { get; set; }
       
        public Lineups Lineups { get; set; }
        public Dictionary<string, Sktatistic> Statistics { get; set; }
    }

    public partial class Taeeam
    {
        public long Team_Id { get; set; }
        public string Team_Name { get; set; }
        public string Logo { get; set; }
    }



    public partial class Lineups
    {
        public Everton Tottenham { get; set; }
        public Everton Everton { get; set; }
    }

    public partial class Everton
    {
        public string Formation { get; set; }
        public List<StartXi> StartXi { get; set; }
        public List<StartXi> Substitutes { get; set; }
    }

    public partial class StartXi
    {
        public string Player { get; set; }
        public long Number { get; set; }
    }

    public partial class Skcore
    {
        public string Halftime { get; set; }
        public string Fulltime { get; set; }
        public object Extratime { get; set; }
        public object Penalty { get; set; }
    }

    public partial class Sktatistic
    {
        public string Home { get; set; }
        public string Away { get; set; }
    }


}
