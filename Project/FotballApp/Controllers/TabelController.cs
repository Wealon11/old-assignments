using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FotballApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FotballApp.Controllers
{
    public class TabelController : Controller
    {
        public IActionResult Index()
        {
            string api_url = "https://api-football-v1.p.rapidapi.com/v2/leagues";
            string result = FootballRequest(api_url);
            var bb = JsonConvert.DeserializeObject<Leagues>(result);

           var a= bb.Api.Leagues;


            return View(a);
        }


        public IActionResult Tabel(int leagueId)
        {
            string api_url = "https://api-football-v1.p.rapidapi.com/v2/leagueTable/" + leagueId;
            string result = FootballRequest(api_url);
            var bb = JsonConvert.DeserializeObject<Standings>(result);
            var a = bb.Api.Standings;
            List<StandingModel> j = new List<StandingModel>();
            foreach (var item in a)
            {
                foreach (var items in item.AsReadOnly())
                {
                    j.Add(new StandingModel
                    {   Rank = items.Rank, TeamName = items.TeamName, Logo = items.Logo, Forme = items.Forme, Description = items.Description,
                        Points = items.Points, AllMatchsPlayed = items.All.MatchsPlayed, AllWin = items.All.Win, AllDraw = items.All.Draw, AllLose = 
                        items.All.Lose, AllGoalsFor = items.All.GoalsFor, AllGoalsAgainst = items.All.GoalsAgainst, AMatchsPlayed = items.Away.MatchsPlayed,
                        AWin = items.Away.Win, ADraw = items.Away.Draw, ALose = items.All.Lose, AGoalsFor = items.Away.GoalsFor,
                        AGoalsAgainst = items.Away.GoalsAgainst, HMatchsPlayed = items.Away.MatchsPlayed,HWin = items.Away.Win, HDraw = items.Away.Draw,
                        HLose = items.All.Lose, HGoalsFor = items.Away.GoalsFor, HGoalsAgainst = items.Away.GoalsAgainst, TeamId = items.Team_Id
                    });
                }
            }

            
            string LeagueName_url = "https://api-football-v1.p.rapidapi.com/v2/leagues/league/" + leagueId;
            string LeagueName = FootballRequest(LeagueName_url);
            var Name = JsonConvert.DeserializeObject<LeagueName>(LeagueName);
            var listName = Name.Api.Leagues;
            foreach (var item in listName)
            {
                ViewData["LigaName"] = item.Name;
            }

            return View(j);
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