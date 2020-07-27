using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FotballApp.Models
{
   
        public  class Teeam
        {
            public Apij Api { get; set; }
        }

        
        public partial class Apij
        {
            public long Results { get; set; }
            public List<Fixtureee> Fixtures { get; set; }
        }

        public class Fixtureee
    {
            public long Fixture_Id { get; set; }
            public long LeagueId { get; set; }
            public DateTime Event_Date { get; set; }
            public long EventTimestamp { get; set; }
            public long? FirstHalfStart { get; set; }
            public long? SecondHalfStart { get; set; }
            public string Round { get; set; }
            public string Status { get; set; }
            public string StatusShort { get; set; }
            public long Elapsed { get; set; }
            public string Venue { get; set; }
            public Sscoreee score { get; set; }
            public TeamClass HomeTeam { get; set; }
            public TeamClass AwayTeam { get; set; }
            public long? GoalsHomeTeam { get; set; }
            public long? GoalsAwayTeam { get; set; }
        }

        public  class Sscoreee
        {
            public string Halftime { get; set; }
            public string Fulltime { get; set; }
            public string Extratime { get; set; }
            public string Penalty { get; set; }
        }


    public  class TeamClass
        {
            public long Team_Id { get; set; }
            public string Team_Name { get; set; }
            public string Logo { get; set; }
        }


    public partial class Teaam
    {
        public Apppi Api { get; set; }
    }

    public partial class Apppi
    {
        public long Results { get; set; }
        public List<Tteeam> Teams { get; set; }
    }

    public partial class Tteeam
    {
        public long Team_Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Logo { get; set; }
        public string Country { get; set; }
        public long Founded { get; set; }
        public string Venue_Name { get; set; }
        public string Venue_Surface { get; set; }
        public string Venue_Address { get; set; }
        public string Venue_City { get; set; }
        public long Venue_Capacity { get; set; }
    }






    public class TeeamModel
{
    public long Fixture_Id { get; set; }
    public long LeagueId { get; set; }
    public DateTime Event_Date { get; set; }
    public long EventTimestamp { get; set; }
    public long? FirstHalfStart { get; set; }
    public long? SecondHalfStart { get; set; }
    public string Round { get; set; }
    public string Status { get; set; }
    public string StatusShort { get; set; }
    public long Elapsed { get; set; }
    public string Venue { get; set; }
    public string fulltime { get; set; }
        public long? GoalsHomeTeam { get; set; }
    public long? GoalsAwayTeam { get; set; }
    public string Score { get; set; }
    public long HomeTeamId { get; set; }
    public string HomeTeamName { get; set; }
    public string HomeLogo { get; set; }
    public long AwayTeamId { get; set; }
    public string AwayTeamName { get; set; }
    public string AwayLogo { get; set; }

}


}




