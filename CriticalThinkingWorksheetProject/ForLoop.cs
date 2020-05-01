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
        private string greeting;
        private int i;
        private int number;



        //constructor
        public ForLoop()
        {

            greeting = "";
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
            for (; i <= userInput.Length; i++)
            {
                Console.WriteLine(userInput);
                i++;
                continue;
            }
        }


        public void RunLoop()
        {
            string userInput;
            Console.Write("Enter word: ");
            userInput = Console.ReadLine();

            for (; i <= userInput.Length;)
            {
                //if (i == userInput.Length)
                //{

                //}
                Console.WriteLine(userInput);
                Console.ReadLine();
                //i++;

                
            }
            Console.ReadLine();
            return;
        }
        public void RunReverseLoop()
        {
            for (int i = 0; i < 9; i--)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }

        public void RunForever()
        {

        }

    }
}
