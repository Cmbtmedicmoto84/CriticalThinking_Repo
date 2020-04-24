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
        int number;

        //constructor
        public ForLoop()
        {
            i = 5;
            number = 5;
            
        }   

        //methods
        public void RunReverseLoop()
        {
            for (int i = number - 1; i <= 9; i--)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
