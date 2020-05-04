using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    class HardDrive
    {
        public double TotalStorage;
        public double AvailableStorage;
        public List<Applications> ApplicationsinHardDrive;


        public HardDrive(double totalStorage, double availableStorage)
        {
            TotalStorage = totalStorage;
            AvailableStorage = availableStorage;
            
            //Console.WriteLine("Type in the desired amount of stroage for the hard drive: ");
            //double valueOneHdd = double.Parse(Console.ReadLine());
            //Console.WriteLine("Would you like to add a secondary hard drive to your setup?");
            //var userInput = Console.ReadLine();
      
        }
    }
}
