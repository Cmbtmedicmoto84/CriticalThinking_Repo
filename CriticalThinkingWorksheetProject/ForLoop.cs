using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
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

            greeting = "Hello World";
            i = 0;
            //number = 5;

        }

        //methods
        public void GreetingLooped_ForLengthOfWord()
        {
            string greeting;
            greeting = "Hello World";
            for (i = 0; i < greeting.Length; i++)
            {
                Console.Write(i + ",");
                //Console.ReadLine();
            }
        }


        public void RunLoop_AsLongAsUserWants()
        {
            string userInput;
            Console.Write("Enter word: ");
            userInput = Console.ReadLine();

            for (; i <= userInput.Length;)
            {
                Console.WriteLine(userInput);
                Console.ReadLine(); 
            }
            Console.ReadLine();
            return;
        }
        public void RunLoop_ByIndividualLetter()
        {
            string userInput;
            Console.Write("Enter word: ");
            userInput = Console.ReadLine();

            foreach (char c in userInput)
            {
                Console.WriteLine(c);
                Console.ReadLine();
            }
            
        }

    }



    //for (int i = 0; i < userInput.Length; i++)
    //{
    //    Console.WriteLine(userInput[i]);
    //    i++;
    //    continue;
    //}
}
