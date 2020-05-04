using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    class RAM
    {
        public double TotalGigabytes;
        public string BrandName;

        public RAM(string brandName, double totalGigabytes)
        {
            TotalGigabytes = totalGigabytes;
            BrandName = brandName;

            //Console.WriteLine("Type in the desired manufacturer for your RAM: ");
            //string valueOneRam = Console.ReadLine();
            //Console.WriteLine("Please type in the desired model name for your chosen manufacturer: ");
            //double valueTwoRam = double.Parse(Console.ReadLine());
        }
    }
}
