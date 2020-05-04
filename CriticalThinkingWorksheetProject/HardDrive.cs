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

        public void InstallApplication(Applications app, HardDrive hadrDrive, RAM ram)
        {
            List<Applications> AppsInHardDrive = new List<Applications>();

            AppsInHardDrive.Add(appName);
            AppsInHardDrive.Add(appType);
            AppsInHardDrive.Add(requiredRAM);
            AppsInHardDrive.Add(requiredStorage);
        }
    }
}
