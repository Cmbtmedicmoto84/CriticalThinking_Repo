using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    public class Applications
    {
        public string appName;
        public string appType;
        public double requiredRAM;
        public double requiredStorage;

        
        public Applications(string appName, string appType, double requiredRAM, double requiredStorage)
        {
            this.appName = appName;
            this.appType = appType;
            this.requiredRAM = requiredRAM;
            this.requiredStorage = requiredStorage;
        }
    }
}
