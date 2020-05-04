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
        public string manufacturer;
        public double effectiveMemory;

        public GPU(string manufacturers, double effectiveMemorys)
        {

            manufacturer = manufacturers;
            effectiveMemory = effectiveMemorys;
        }  
    }
}
