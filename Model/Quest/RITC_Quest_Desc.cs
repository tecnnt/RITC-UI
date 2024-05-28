using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_Quest_Desc
    {
        public string? name { get; set; }
        public string? note { get; set; }
        public Dictionary<string, string>? conditions { get; set; }
        public string? description { get; set; }
        public string? failMessageText { get; set; }
        public string? startedMessageText { get; set; }
        public string? successMessageText { get; set; }
        public string? location { get; set; }
    }
}
