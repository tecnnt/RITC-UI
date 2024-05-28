using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{

    public class AKI_Item
    {
        public string? _id { get; set; }
        public string? _tpl { get; set; }
        public string? parentId { get; set; }
        public string? slotId { get; set; }
        public AKI_Item_Upd? upd { get; set; }
    }

    public class AKI_Item_Upd
    {
        public int? BuyRestrictionMax { get; set; }
        public int? BuyRestrictionCurrent { get; set; }
        public int? StackObjectsCount { get; set; }
        public bool? UnlimitedCount { get; set; }
        public AKI_Item_Firemode? FireMode { get; set; }
        public AKI_Item_Foldable? Foldable { get; set; }
        public AKI_Item_Sight? Sight { get; set; }
        public AKI_Item_Light? Light { get; set; }
    }

    public class AKI_Item_Firemode
    {
        public string? FireMode { get; set; }
    }

    public class AKI_Item_Foldable
    {
        public bool Folded { get; set; }
    }


    public class AKI_Item_Light
    {
        public bool IsActive { get; set; }
        public int SelectedMode { get; set; }
    }
    public class AKI_Item_Sight
    {
        public int[]? ScopesCurrentCalibPointIndexes { get; set; }
        public int[]? ScopesSelectedModes { get; set; }
        public int SelectedScope { get; set; }
    }
}
