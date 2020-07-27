using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FotballApp.Models
{
    public class Standings
    {
        public Standingss Api { get; set; }
    }

    public class Standingss
    {
        public long Results { get; set; }
        public List<List<Standing>> Standings { get; set; }
    }

    public class Standing
    {
        public long Rank { get; set; }
        public long Team_Id { get; set; }
        public string TeamName { get; set; }
        public string Logo { get; set; }
        public string Group { get; set; }
        public string Forme { get; set; }
        public string Description { get; set; }
        public All All { get; set; }
        public All Home { get; set; }
        public All Away { get; set; }
        public long GoalsDiff { get; set; }
        public long Points { get; set; }
    }

    public class All
    {
        public long MatchsPlayed { get; set; }
        public long Win { get; set; }
        public long Draw { get; set; }
        public long Lose { get; set; }
        public long GoalsFor { get; set; }
        public long GoalsAgainst { get; set; }
    }


    public class StandingModel
    {
       
        public long Rank { get; set; }
        [DisplayName("Team Name")]
        public string TeamName { get; set; }
        public string Logo { get; set; }
        public string Forme { get; set; }
        public string Description { get; set; }
        public long Points { get; set; }

        [DisplayName("Played")]
        public long AllMatchsPlayed { get; set; }
        [DisplayName("Wins")]
        public long AllWin { get; set; }
        [DisplayName("Draws")]
        public long AllDraw { get; set; }
        [DisplayName("Losts")]
        public long AllLose { get; set; }
        [DisplayName("Goals For")]
        public long AllGoalsFor { get; set; }
        [DisplayName("Goals Against")]
        public long AllGoalsAgainst { get; set; }

        public long HMatchsPlayed { get; set; }
        public long HWin { get; set; }
        public long HDraw { get; set; }
        public long HLose { get; set; }
        public long HGoalsFor { get; set; }
        public long HGoalsAgainst { get; set; }
        public long TeamId { get; set; }
        public long AMatchsPlayed { get; set; }
        public long AWin { get; set; }
        public long ADraw { get; set; }
        public long ALose { get; set; }
        public long AGoalsFor { get; set; }
        public long AGoalsAgainst { get; set; }
    }
}

