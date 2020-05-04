using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    class RAM
    {
        public double totalGigabyte;
        public string brandName;

        public RAM(string brandNames, double totalGigabytes)
        {
            totalGigabyte = totalGigabytes;
            brandName = brandNames;
        }
    }
}
