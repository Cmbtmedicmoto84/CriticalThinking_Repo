﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    class Applications
    {
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRAM;
        public double RequiredStorage;

        public Applications()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging service";
            RequiredRAM = 4.0;
            RequiredStorage = 0.512;


        }
    }
}
