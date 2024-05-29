using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{
    public class RITC_Quest
    {
        public string? ID { get; set; }
        public string? Type { get; set; }
        public string? imagepath { get; set; }
        public string? TraderID { get; set; }
        public string? Location { get; set; }
        public bool Restartable { get; set; }
    }
}
