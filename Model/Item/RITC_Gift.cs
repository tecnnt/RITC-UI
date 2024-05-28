using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_GiftItem
    {
        public string? name { get; set; }
        public Basereward? basereward { get; set; }
        public Itempool? itempool { get; set; }
    }

    public class Basereward
    {
        public Superrare? superrare { get; set; }
        public Rare? rare { get; set; }
        public Normal? normal { get; set; }
    }

    public class Superrare
    {
        public bool havebasereward { get; set; }
        public float chance { get; set; }
        public float upchance { get; set; }
        public float upaddchance { get; set; }
        public int chancegrowcount { get; set; }
        public float chancegrowpercount { get; set; }
    }

    public class Rare
    {
        public bool havebasereward { get; set; }
        public float chance { get; set; }
        public float upchance { get; set; }
        public float upaddchance { get; set; }
        public int chancegrowcount { get; set; }
        public float chancegrowpercount { get; set; }
    }

    public class Normal
    {
        public int upchance { get; set; }
    }

    public class Itempool
    {
        public Superrare1? superrare { get; set; }
        public Rare1? rare { get; set; }
        public Normal3? normal { get; set; }
    }

    public class Superrare1
    {
        public Chanceup[]? chanceup { get; set; }
        public Normal1[]? normal { get; set; }
    }

    public class Chanceup
    {
        public string? name { get; set; }
        public string? itemid { get; set; }
        public string? type { get; set; }
        public int stackcount { get; set; }
    }

    public class Normal1
    {
        public string? name { get; set; }
        public string? itemid { get; set; }
        public string? type { get; set; }
        public int stackcount { get; set; }
    }

    public class Rare1
    {
        public Chanceup1[]? chanceup { get; set; }
        public Normal2[]? normal { get; set; }
    }

    public class Chanceup1
    {
        public string? name { get; set; }
        public string? itemid { get; set; }
        public string? type { get; set; }
        public int stackcount { get; set; }
    }

    public class Normal2
    {
        public string? name { get; set; }
        public string? itemid { get; set; }
        public string? type { get; set; }
        public int stackcount { get; set; }
    }

    public class Normal3
    {
        public Chanceup2[]? chanceup { get; set; }
        public Normal4[]? normal { get; set; }
    }

    public class Chanceup2
    {
        public string? name { get; set; }
        public string? itemid { get; set; }
        public string? type { get; set; }
        public int stackcount { get; set; }
    }

    public class Normal4
    {
        public string? name { get; set; }
        public string? itemid { get; set; }
        public string? type { get; set; }
        public int stackcount { get; set; }
    }

}
