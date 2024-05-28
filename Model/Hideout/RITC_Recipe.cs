using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    /// <summary>
    /// 藏身处配方
    /// </summary>
    public class RITC_RecipeItem
    {
        public string? ID { get; set; }
        public int Area { get; set; }
        public int AreaLevel { get; set; }
        public string? Output { get; set; }
        public int OutputCount { get; set; }
        public int Time { get; set; }
        public bool NeedFuel { get; set; }
        public bool Locked { get; set; }
        public string? Quest { get; set; }
        public Require? Require { get; set; }
    }

    public class Require
    {
        public Dictionary<string,int>? Tool { get; set; }
        public Dictionary<string, int>? Item { get; set; }
    }

}
