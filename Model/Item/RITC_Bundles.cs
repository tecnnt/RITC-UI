﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RITC_UI.Model
{

    public class RITC_Bundles
    {
        public List<Manifest>? manifest { get; set; }
    }

    public class Manifest
    {
        public string? key { get; set; }
        public List<string>? dependencyKeys { get; set; }
    }

}
