using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_Gift
    {
        public string? name { get; set; }
        public RITC_Gift_Basereward? basereward { get; set; }
        public RITC_Gift_Itempool? itempool { get; set; }
    }
    public class RITC_Gift_Item
    {
        public string? name { get; set; }
        public string? itemid { get; set; }
        //List<AKI_Item> 或 String
        public object? item { get; set; }
        /// <summary>
        /// CustomPreset,VanillaPreset,Item,AmmoBox
        /// </summary>
        public string? type { get; set; }
        public int stackcount { get; set; }
    }

    public class RITC_Gift_Basereward
    {
        public RITC_Gift_Superrare? superrare { get; set; }
        public RITC_Gift_Rare? rare { get; set; }
        public RITC_Gift_Normal? normal { get; set; }
    }

    public class RITC_Gift_Superrare
    {
        public bool havebasereward { get; set; }
        public float chance { get; set; }
        public float upchance { get; set; }
        public float upaddchance { get; set; }
        public int chancegrowcount { get; set; }
        public float chancegrowpercount { get; set; }
    }

    public class RITC_Gift_Rare
    {
        public bool havebasereward { get; set; }
        public float chance { get; set; }
        public float upchance { get; set; }
        public float upaddchance { get; set; }
        public int chancegrowcount { get; set; }
        public float chancegrowpercount { get; set; }
    }

    public class RITC_Gift_Normal
    {
        public int upchance { get; set; }
    }

    public class RITC_Gift_Itempool
    {
        public RITC_Gift_Itempool_Chance? superrare { get; set; }
        public RITC_Gift_Itempool_Chance? rare { get; set; }
        public RITC_Gift_Itempool_Chance? normal { get; set; }
    }

    public class RITC_Gift_Itempool_Chance
    {
        public List<RITC_Gift_Item>[]? chanceup { get; set; }
        public List<RITC_Gift_Item>[]? normal { get; set; }
    }
}
