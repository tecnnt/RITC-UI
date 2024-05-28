using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_ScavCase
    {
        public string? id { get; set; }
        public int time { get; set; }
        public Dictionary<string, int>? requires { get; set; }
        public Rewards? rewards { get; set; }
    }

    public class Rewards
    {
        public int[]? common { get; set; }
        public int[]? rare { get; set; }
        public int[]? superrare { get; set; }
    }

}
