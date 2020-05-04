using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    class HardDrive
    {
        public double totalStorage;
        public double availableStorage;


        public HardDrive(double totalStorages, double availableStorages)
        {
            totalStorage = totalStorages;
            availableStorage = availableStorages;      
        }

        public void InstallApplication(Applications applications)
        {
            Applications application = new Applications("Slack", "Messenger Service", 4.0, 0.512);


            
        }
    }
}
