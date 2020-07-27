using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FotballApp.Models
{
   
        public class Livescore
        {
            public kk Api { get; set; }
        }

        public class kk
        {
            public int Results { get; set; }
            public List<Fixture> Fixtures { get; set; }
        }

        public class Fixture
        {
            public int Fixture_Id { get; set; }
            public long LeagueId { get; set; }
            public DateTime EventDate { get; set; }
            public long EventTimestamp { get; set; }
            public long? FirstHalfStart { get; set; }
            public long? SecondHalfStart { get; set; }
            public string Round { get; set; }
            public string Status { get; set; }
            public string StatusShort { get; set; }
            public long Elapsed { get; set; }
            public string Venue { get; set; }
            public object Referee { get; set; }
            public Team HomeTeam { get; set; }
            public Team AwayTeam { get; set; }
            public long? GoalsHomeTeam { get; set; }
            public long? GoalsAwayTeam { get; set; }
            public Score Score { get; set; }
        }

        public class Team
        {
            public int Team_Id { get; set; }
            public string Team_Name { get; set; }
            public string Logo { get; set; }
        }

        public class Score
        {
            public string Halftime { get; set; }
            public string Fulltime { get; set; }
            public object Extratime { get; set; }
            public object Penalty { get; set; }
        }


    public partial class ModelData
        {
            public long Fixture_Id { get; set; }
            public long LeagueId { get; set; }
            public DateTime EventDate { get; set; }
            public long EventTimestamp { get; set; }
            public long? FirstHalfStart { get; set; }
            public long? SecondHalfStart { get; set; }
            public string Round { get; set; }
            public string Status { get; set; }
            public string StatusShort { get; set; }
            public long Elapsed { get; set; }
            public string Venue { get; set; }
            public object Referee { get; set; }
            public long? GoalsHomeTeam { get; set; }
            public long? GoalsAwayTeam { get; set; }
            public int HomeTeam_Id { get; set; }
            public string HomeTeam_Name { get; set; }
            public string HomeTeam_Logo { get; set; }
            public int AwayTeam_Id { get; set; }
            public string AwayTeam_Name { get; set; }
            public string AwayTeam_Logo { get; set; }

        }
    
}
