using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    class GPU
    {
        public string Manufacturer;
        public double EffectiveMemory;

        public GPU(string manufacturer, double effectiveMemory)
        {

            Manufacturer = manufacturer;
            EffectiveMemory = effectiveMemory;
            
            //Console.WriteLine("Type in the desired manufacturer for your new GPU: ");
            //string valueOneGpu = Console.ReadLine();
            //Console.WriteLine("Please type in the desired memory for your chosen GPU: ");
            //double valueTwoGpu = double.Parse(Console.ReadLine());
        }  
    }
}
