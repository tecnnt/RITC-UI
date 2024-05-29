using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_Item
    {
        public string? _id { get; set; }
        public string? targetid { get; set; }
        public string? _name { get; set; }
        public RITC_Item_Props? _props { get; set; }
    }

    public class RITC_Item_Props
    {
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public string? Description { get; set; }
        public float Weight { get; set; }
        public string? BackgroundColor { get; set; }
        public int DefaultPrice { get; set; }
        public string? RagfairType { get; set; }
        public bool CanFindInRaid { get; set; }
        public bool CustomLoot { get; set; }
        public string? CustomLootTarget { get; set; }
        public bool isMoney { get; set; }
        public bool isadvGiftBox { get; set; }
        public RITC_Item_AdvBoxData? advBoxData { get; set; }
        public RITC_Item_StaticBoxData? StaticBoxData { get; set; }
        public RITC_Item_BoxData? BoxData { get; set; }
        public int StackMaxSize { get; set; }
    }

    public class RITC_Item_AdvBoxData
    {
        public int count { get; set; }
        public bool forcefindinraid { get; set; }
        public string? giftdata { get; set; }
    }

    public class RITC_Item_StaticBoxData
    {
        public int count { get; set; }
        public bool forcefindinraid { get; set; }
        public List<RITC_Gift_Item>? giftdata { get; set; }
    }

    public class RITC_Item_BoxData
    {
        public int Count { get; set; }
        public Dictionary<string, int>? Rewards { get; set; }
    }



}
