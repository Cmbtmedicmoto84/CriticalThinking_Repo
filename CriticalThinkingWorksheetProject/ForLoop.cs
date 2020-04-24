using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    class ForLoop
    {
        //variables
        int i;

        //constructor
        public ForLoop()
        {
            i = 0;
        }   

        //methods
        public void RunLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }

    }
}
