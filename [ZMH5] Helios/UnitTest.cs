﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZatsHackBase.Core;
using ZatsHackBase.Core.Timing;
using ZatsHackBase.UI;

namespace _ZMH5__Helios
{
    public class UnitTest : Hack
    {
        public UnitTest() : base("notepad", 60, true)
        {
            this.Run();
        }
    }
}
