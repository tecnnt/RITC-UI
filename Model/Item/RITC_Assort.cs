using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_AssortItem
    {
        public string? ID { get; set; }
        public string? Trader { get; set; }
        public AKI_Item[]? Item { get; set; }
        public Dictionary<string, DogtagItem>? DogTag { get; set; }
        public Dictionary<string,int>? Barter { get; set; }
        public int TrustLevel { get; set; }
        public bool isWeapon { get; set; }
        public bool Locked { get; set; }
        public string? Quest { get; set; }
    }

    public class DogtagItem
    {
        public int count { get; set; }
        public int level { get; set; }
        public string? side { get; set; }
    }

 

}
