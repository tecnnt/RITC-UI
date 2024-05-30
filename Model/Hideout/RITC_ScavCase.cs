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
        public RITC_ScavCase_Rewards? rewards { get; set; }
    }

    public class RITC_ScavCase_Rewards
    {
        public List<int>? common { get; set; }
        public List<int>? rare { get; set; }
        public List<int>? superrare { get; set; }
    }

}
