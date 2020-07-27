using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FotballApp.Models
{
    public partial class LeagueName
    {
        public kffg Api { get; set; }
    }

    public class kffg
    {       
        public List<LeagueElement> Leagues { get; set; }
    }

    public class LeagueElement
    {
        public string Name { get; set; }
    }
}
