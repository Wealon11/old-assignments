using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FotballApp.Models
{

        public class Leagues
        {
            public Api Api { get; set; }
        }

        public class Api
        {
            
            public List<League> Leagues { get; set; }
        }

        public class League
        {
            public int League_Id { get; set; }
            public string Name { get; set; }
            public string Country { get; set; }
            public string Logo { get; set; }
            public int Is_Current { get; set; }
        }





}

