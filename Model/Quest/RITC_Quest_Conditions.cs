using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{

    public class RITC_Quest_Conditions
    {
        public RITC_Quest_Start? Start { get; set; }
        public RITC_Quest_Finish? Finish { get; set; }
        public RITC_Quest_Fail? Fail { get; set; }
    }

    public class RITC_Quest_Start
    {
        public RITC_Quest_Start_Conditions[]? Data { get; set; }
        public bool Override { get; set; }
    }
    public class RITC_Quest_Start_Conditions
    {
    }


    public class RITC_Quest_Finish
    {
        public RITC_Quest_Finish_Conditions[]? Data { get; set; }
        public bool Override { get; set; }
    }

    public class RITC_Quest_Finish_Conditions
    {
        public string? id { get; set; }
        public string? type { get; set; }
        public int count { get; set; }
        public int time { get; set; }
        public string? itemid { get; set; }
        public string? zoneid { get; set; }
        public string? skill { get; set; }
        public string? locale { get; set; }
        public string? enlocale { get; set; }
        public bool inraid { get; set; }
    }

    public class RITC_Quest_Fail
    {
        public RITC_Quest_Fail_Conditions[]? Data { get; set; }
        public bool Override { get; set; }
    }

    public class RITC_Quest_Fail_Conditions
    {
        public string? id { get; set; }
        public string? type { get; set; }
        public bool oneraid { get; set; }
        public int count { get; set; }
        public string[]? location { get; set; }
        public string[]? status { get; set; }
        public bool chosenextractpoint { get; set; }
        public string? extractpoint { get; set; }
    }

}
