using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    public abstract class Applications
    {
        public string appName;
        public string appType;
        public double requiredRAM;
        public double requiredStorage;

        
        public Applications(string appName, string appType, double requiredRAM, double requiredStorage)
        {
            appName = "Slack";
            appType = "Messaging service";
            requiredRAM = 4.0;
            requiredStorage = 0.512;
        }
    }
}
