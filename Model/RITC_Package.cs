using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_Package
    {
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public string? pathname { get; set; }
        public RITC_Package_Config? Config { get; set; }
    }

    public class RITC_Package_Config
    {
        public string[]? LootBlackList { get; set; }
        public Dictionary<string,string>? GenerateList { get; set; }
        public string[]? CustomMoney { get; set; }
    }
}