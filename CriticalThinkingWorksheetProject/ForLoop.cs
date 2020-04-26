using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    class ForLoop
    {
        //variables
        string greeting;
        int i;
        int number;
        


        //constructor
        public ForLoop()
        {
            
            greeting = "Hello World";
            i = 0;
            //number = 5;

        }

        //methods
        public void GreetingLooped()
        {
            string userInput;
            Console.Write("Enter word: ");
            userInput = Console.ReadLine();

            int i = 0;
            for (; i >= userInput.Length; i++)
            {
                Console.WriteLine(userInput);
                i++;
                continue;
            }
        }

        
        public void RunLoop()
        {
            //string greeting = "";
            for (int i = greeting.Length; i < greeting.Length; i++)
            {
                if (i != greeting.Length)
                {
                    continue;
                }
                Console.WriteLine(greeting);
                Console.ReadLine();
            }
        }
        public void RunReverseLoop()
        {
            for (int i = 0; i < 9; i--)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }

    }
}
