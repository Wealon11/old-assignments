using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FotballApp.Models;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace FotballApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            string api_url = "https://api-football-v1.p.rapidapi.com/v2/fixtures/live";
            string result = FootballRequest(api_url);
            var bb = JsonConvert.DeserializeObject<Livescore>(result);

            var FixturesData = bb.Api.Fixtures;
            

            List<ModelData> Q = new List<ModelData>();

            foreach (var items in FixturesData)
            {
                Q.Add(new ModelData
                {
                    Fixture_Id = items.Fixture_Id, LeagueId = items.LeagueId, EventDate = items.EventDate,
                    EventTimestamp = items.EventTimestamp,
                    FirstHalfStart = items.FirstHalfStart, SecondHalfStart = items.SecondHalfStart, Round = items.Round,
                    Status = items.Status,
                    StatusShort = items.StatusShort, Elapsed = items.Elapsed, Venue = items.Venue,
                    Referee = items.Referee, GoalsHomeTeam = items.GoalsHomeTeam,
                    GoalsAwayTeam = items.GoalsAwayTeam, HomeTeam_Id = items.HomeTeam.Team_Id,
                    HomeTeam_Name = items.HomeTeam.Team_Name,
                    HomeTeam_Logo = items.HomeTeam.Logo, AwayTeam_Id = items.AwayTeam.Team_Id,
                    AwayTeam_Name = items.AwayTeam.Team_Name,
                    AwayTeam_Logo = items.AwayTeam.Logo
                });
            }
            return View(Q);
        }

        public ActionResult MatchesToday(string date)
        {   string api_url = "https://api-football-v1.p.rapidapi.com/v2/fixtures/date/"+date;
            string result = FootballRequest(api_url);

            DateTime Title = DateTime.Parse(date);
            var fds= Title.ToString("M");
            ViewData["date"] = fds;

            DateTime parse = DateTime.Parse(date);
            var nextDay = parse.AddDays(1);
            var lastday = parse.AddDays(-1);
            ViewData["nextDay"] = nextDay.ToString("yyyy-MM-dd");
            ViewData["lastday"] = lastday.ToString("yyyy-MM-dd");
                      
            var bb = JsonConvert.DeserializeObject<MatchesToday>(result);
           var FixturesData = bb.Api.Fixtures;
            List<ModelDataa> Q = new List<ModelDataa>();
            foreach (var items in FixturesData)
            {Q.Add(new ModelDataa
                {
                    FixtureId = items.FixtureId, LeagueId = items.LeagueId, EventDate = items.Event_Date, EventTimestamp = items.EventTimestamp,
                    FirstHalfStart = items.FirstHalfStart, SecondHalfStart = items.SecondHalfStart, Round = items.Round, Status = items.Status,
                    StatusShort = items.StatusShort, Elapsed = items.Elapsed, Venue = items.Venue, Referee = items.Referee,
                    GoalsHomeTeam = items.GoalsHomeTeam, GoalsAwayTeam = items.GoalsAwayTeam, HomeTeam_Id = items.HomeTeam.Team_Id,
                    HomeTeam_Name = items.HomeTeam.Team_Name, HomeTeam_Logo = items.HomeTeam.Logo, AwayTeam_Id = items.AwayTeam.Team_Id,
                    AwayTeam_Name = items.AwayTeam.Team_Name, AwayTeam_Logo = items.AwayTeam.Logo,

                });}
            return View(Q);
        }


        public string jaja(long abc)
        {
            string api_url = "https://api-football-v1.p.rapidapi.com/v2/leagues/league/" + abc;
            string result = FootballRequest(api_url);

            var bb = JsonConvert.DeserializeObject<CountryFixture>(result);

            var test = bb.Api.Leagues;

            foreach (var item in test)
            {
                return item.Name;
            }

            return null;

        }


        public ActionResult statisticsR(string fixtureidd)
        {

            string api_url = "https://api-football-v1.p.rapidapi.com/v2/statistics/fixture/" + fixtureidd;
            string result = FootballRequest(api_url);
            var bb = JsonConvert.DeserializeObject<statistics>(result);

            Debug.Write(result);
            var StatisticsData = bb.Api.Statistics;






            List<StatisticsModel> Q = new List<StatisticsModel>();


                Q.Add(new StatisticsModel
                {
                    ShotsOnGoalHome = StatisticsData.FirstOrDefault(x => x.Key == "Shots on Goal").Value.Home,
                    ShotsOnGoalAway = StatisticsData.FirstOrDefault(x => x.Key == "Shots on Goal").Value.Away,
                    ShotsOffGoalHome = StatisticsData.FirstOrDefault(x => x.Key == "Shots off Goal").Value.Home,
                    ShotsOffGoalAway = StatisticsData.FirstOrDefault(x => x.Key == "Shots off Goal").Value.Away,
                    TotalShotsHome = StatisticsData.FirstOrDefault(x => x.Key == "Total Shots").Value.Home,
                    TotalShotsAway = StatisticsData.FirstOrDefault(x => x.Key == "Total Shots").Value.Away,
                    BlockedShotsHome = StatisticsData.FirstOrDefault(x => x.Key == "Blocked Shots").Value.Home,
                    BlockedShotsAway = StatisticsData.FirstOrDefault(x => x.Key == "Blocked Shots").Value.Away,
                    ShotsInsideBoxHome= StatisticsData.FirstOrDefault(x => x.Key == "Shots insidebox").Value.Home,
                    ShotsInsideBoxAway = StatisticsData.FirstOrDefault(x => x.Key == "Shots insidebox").Value.Away,
                    ShotsoutsideBoxHome = StatisticsData.FirstOrDefault(x => x.Key == "Shots outsidebox").Value.Home,
                    ShotsoutsideBoxAway = StatisticsData.FirstOrDefault(x => x.Key == "Shots outsidebox").Value.Away,
                    FoulsHome = StatisticsData.FirstOrDefault(x => x.Key == "Fouls").Value.Home,
                    FoulsAway = StatisticsData.FirstOrDefault(x => x.Key == "Fouls").Value.Away,
                    CornerKicksHome = StatisticsData.FirstOrDefault(x => x.Key == "Corner Kicks").Value.Home,
                    CornerKicksAway = StatisticsData.FirstOrDefault(x => x.Key == "Corner Kicks").Value.Away,
                    OffsidesHome = StatisticsData.FirstOrDefault(x => x.Key == "Offsides").Value.Home,
                    OffsidesAway = StatisticsData.FirstOrDefault(x => x.Key == "Offsides").Value.Away,                
                    BallPossessionHome = StatisticsData.FirstOrDefault(x => x.Key == "Ball Possession").Value.Home,
                    BallPossessionAway = StatisticsData.FirstOrDefault(x => x.Key == "Ball Possession").Value.Away,
                    YellowCardsHome = StatisticsData.FirstOrDefault(x => x.Key == "Yellow Cards").Value.Home,
                    YellowCardsAway = StatisticsData.FirstOrDefault(x => x.Key == "Yellow Cards").Value.Away,
                    RedCardsHome = StatisticsData.FirstOrDefault(x => x.Key == "Red Cards").Value.Home,
                    RedCardsAway = StatisticsData.FirstOrDefault(x => x.Key == "Red Cards").Value.Away,
                    GoalkeeperSavesHome = StatisticsData.FirstOrDefault(x => x.Key == "Goalkeeper Saves").Value.Home,
                    GoalkeeperSavesAway = StatisticsData.FirstOrDefault(x => x.Key == "Goalkeeper Saves").Value.Away,
                    TotalpassesHome = StatisticsData.FirstOrDefault(x => x.Key == "Total passes").Value.Home,
                    TotalpassesAway = StatisticsData.FirstOrDefault(x => x.Key == "Total passes").Value.Away,
                    PassesaccurateHome = StatisticsData.FirstOrDefault(x => x.Key == "Passes accurate").Value.Home,
                    PassesaccurateAway = StatisticsData.FirstOrDefault(x => x.Key == "Passes accurate").Value.Away,
                    PassesHome = StatisticsData.FirstOrDefault(x => x.Key == "Passes %").Value.Home,
                    PassesAway = StatisticsData.FirstOrDefault(x => x.Key == "Passes %").Value.Away,

                });


                string apik_url = "https://api-football-v1.p.rapidapi.com/v2/fixtures/id/" + fixtureidd;
                string resultk = FootballRequest(apik_url);
                var bbk = JsonConvert.DeserializeObject<staticsticsTeaminfo>(resultk);

                Debug.Write(resultk);
                var StatisticsDatak = bbk.Api.Fixtures;

                foreach (var item in StatisticsDatak)
                {
                ViewData["HomeTeam"] = item.HomeTeam.Team_Name;
                ViewData["AwayTeam"] = item.AwayTeam.Team_Name;
                ViewData["AwayTeamLogo"] = item.AwayTeam.Logo;
                ViewData["HomeTeamLogo"] = item.HomeTeam.Logo;
                ViewData["Status"] = item.Status;
                ViewData["ScoreFulltime"] = item.Score.Fulltime;
                }






            return View(Q);
        }



        public ActionResult Team(string teamId)
        {

            string api_url = "https://api-football-v1.p.rapidapi.com//v2/fixtures/team/"+teamId;
            string result = FootballRequest(api_url);
            var bb = JsonConvert.DeserializeObject<Teeam>(result);

            var TeeamData = bb.Api.Fixtures;


            List<TeeamModel> teamModel = new List<TeeamModel>();

            foreach (var items in TeeamData)
            {
        
                teamModel.Add(new TeeamModel
                {
                    Fixture_Id = items.Fixture_Id,
                    LeagueId = items.LeagueId,


                    Event_Date = items.Event_Date,
                    EventTimestamp = items.EventTimestamp,
                    FirstHalfStart = items.FirstHalfStart,
                    SecondHalfStart = items.SecondHalfStart,
                    Round = items.Round,
                    Status = items.Status,
                    StatusShort = items.StatusShort,
                    Elapsed = items.Elapsed,
                    Venue = items.Venue,                
                    GoalsHomeTeam = items.GoalsHomeTeam,
                    GoalsAwayTeam = items.GoalsAwayTeam,
                    HomeTeamId = items.HomeTeam.Team_Id,
                    HomeTeamName = items.HomeTeam.Team_Name,
                    HomeLogo = items.HomeTeam.Logo,
                    AwayTeamId = items.AwayTeam.Team_Id,
                    AwayTeamName = items.AwayTeam.Team_Name,
                    AwayLogo = items.AwayTeam.Logo,
                    Score = items.score.Fulltime,
                    
                    
        
              
    });
             
            }

            var list = teamModel.OrderByDescending(x => x.Event_Date).ToList();



            string api_urll = "https://api-football-v1.p.rapidapi.com/v2/teams/team/" + teamId;
            string resultt = FootballRequest(api_urll);
            var bbb = JsonConvert.DeserializeObject<Teaam>(resultt);

            var TeeamDataa = bbb.Api.Teams;

            foreach (var item in TeeamDataa)
            {
                ViewData["Team_Id"] = item.Team_Id;
                ViewData["Name"] = item.Name;
                ViewData["Code"] = item.Code;
                ViewData["Logo"] = item.Logo;
                ViewData["Country"] = item.Country;
                ViewData["Founded"] = item.Founded;
                ViewData["Venue_Name"] = item.Venue_Name;
                ViewData["Venue_Surface"] = item.Venue_Surface;
                ViewData["Venue_Address"] = item.Venue_Address;
                ViewData["Venue_City"] = item.Venue_City;
                ViewData["Venue_Capacity"] = item.Venue_Capacity;

            }






            return View(list);
        }





        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private string FootballRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers["X-RapidAPI-Host"] = "api-football-v1.p.rapidapi.com";
            request.Headers["X-RapidAPI-Key"] = "74cb8decdamsh9f9118647b5cf37p1f5a98jsn14269e5c4cc8";
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse er = ex.Response;
                using (Stream stream = er.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, encoding: Encoding.GetEncoding("utf-8"));
                    string errortext = reader.ReadToEnd();
                }
                throw;
            }
        }


    }
}
