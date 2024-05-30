using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RITC_UI.Model
{
    public class RITC_Package
    {
        public RITC_Package()
        {
            Name = "";
            Desc = "";
            Config = new RITC_Package_Config();
        }
        public string Name { get; set; }
        public string? Desc { get; set; }
        public string? pathname { get { return PackageData.ModelPath?.Folder?.Name; } }
        [JsonIgnore]
        public string? Directory { get { return PackageData.ModelPath?.Folder?.FullName; } }
        public RITC_Package_Config Config { get; set; }
    }

    public class RITC_Package_Config
    {
        public RITC_Package_Config()
        {
            LootBlackList = new List<string>();
            GenerateList = new Dictionary<string, string>();
            CustomMoney = new List<string>();
        }
        public List<string> LootBlackList { get; set; }
        public Dictionary<string, string> GenerateList { get; set; }
        public List<string> CustomMoney { get; set; }
    }
}