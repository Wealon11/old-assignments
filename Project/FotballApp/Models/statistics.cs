using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FotballApp.Models
{
  


        public  class statistics
        {
            public Apii Api { get; set; }
        }

        public  class Apii
        {
            public long Results { get; set; }
            public Dictionary<string, Statistic> Statistics { get; set; }
        }

        public  class Statistic
        {
            public string Home { get; set; }
            public string Away { get; set; }
        }


        public  class StatisticsModel
    {
        public string ShotsOnGoalHome { get; set; }
        public string ShotsOnGoalAway { get; set; }
        public string ShotsOffGoalHome { get; set; }
        public string ShotsOffGoalAway { get; set; }
        public string TotalShotsHome { get; set; }
        public string TotalShotsAway { get; set; }
        public string BlockedShotsHome { get; set; }
        public string BlockedShotsAway { get; set; }
        public string ShotsInsideBoxHome { get; set; }
        public string ShotsInsideBoxAway { get; set; }
        public string ShotsoutsideBoxHome { get; set; }
        public string ShotsoutsideBoxAway { get; set; }
        public string FoulsHome { get; set; }
        public string FoulsAway { get; set; }
        public string CornerKicksHome { get; set; }
        public string CornerKicksAway { get; set; }
        public string OffsidesHome { get; set; }
        public string OffsidesAway { get; set; }
        public string BallPossessionHome { get; set; }
        public string BallPossessionAway { get; set; }
        public string YellowCardsHome { get; set; }
        public string YellowCardsAway { get; set; }
        public string RedCardsHome { get; set; }
        public string RedCardsAway { get; set; }
        public string GoalkeeperSavesHome { get; set; }
        public string GoalkeeperSavesAway { get; set; }
        public string TotalpassesHome { get; set; }
        public string TotalpassesAway { get; set; }
        public string PassesaccurateHome { get; set; }
        public string PassesaccurateAway { get; set; }
        public string PassesHome { get; set; }
        public string PassesAway { get; set; }

    }





}

