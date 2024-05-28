using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{

    public class RITC_Quest_Reward
    {
        public string? Condition { get; set; }
        public string? Type { get; set; }
        public string? Quest { get; set; }
        public float Count { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public string? TraderID { get; set; }
        public string? Trader { get; set; }
        public AKI_Item[]? Items { get; set; }
        public string? Skill { get; set; }
    }

    public class Repairable
    {
        public int MaxDurability { get; set; }
        public int Durability { get; set; }
    }

}
