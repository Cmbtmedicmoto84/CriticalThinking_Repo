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
        //private string greeting;
        private int i;
        //private int number;

        //constructor
        public ForLoop()
        {
            //greeting = "Hello World";
            i = 0;
            //number = 5;
        }

        //methods
        public void RunLoop_AsLongAsUserWants()
        {
            string greeting;
            greeting = "Hello World";
            for (; i <= greeting.Length;)
            {
                Console.WriteLine(greeting);
                Console.ReadLine();
            }
            Console.ReadLine();
            return;
        }

        public void GreetingLooped_ForLengthOfWord()
        {
            string greeting;
            greeting = "Hello World";
            for (i = 0; i <= greeting.Length; i++)
            {
                Console.Write(i + ",");
                //Console.ReadLine();
            }
        }

        public void RunLoop_ByIndividualLetter()
        {
            string greeting;
            greeting = "Hello World";
            foreach (char c in greeting)
            {
                Console.WriteLine(c);
                //Console.ReadLine();
            }
            
        }
        public void RunLoop_EveryOtherLetter()
        {
            string greeting;
            greeting = "Hello World";       
            for (int i = 0; i < greeting.Length; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(greeting[i]);
                }
                
            }
        }

        public void RunLoop_ifDivisibleByThree()
        {
            string greeting;
            greeting = "Hello World";
            for (int i = 0; i < greeting.Length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(greeting[i]);
                }

            }
        }

        public void WhileLoop_excercise()
        {
            Console.Write("Enter desired number value: ");
            int userInput = int.Parse(Console.ReadLine());
            int count = 0;
            while (count < userInput)
            {
                count++;
                Console.WriteLine(count);
                continue;
            }
            Console.ReadLine();
        }

        public void WhileLoop_FortyTwo()  //coming  back to this one
        {
            Console.Write("Please enter the number 42: ");
            int userInput = int.Parse(Console.ReadLine());
            int expected = 42;
            while (userInput != expected)
            {
                Console.WriteLine("Incorrect value entered, please enther the number 42 in order to continue!");
                return;
            }
            if (userInput == 42)
            {
                Console.WriteLine("Thank you!  That is correct!!");
                return;
            }
            Console.ReadLine();
        }   


    }



    //for (int i = 0; i < userInput.Length; i++)
    //{
    //    Console.WriteLine(userInput[i]);
    //    i++;
    //    continue;
    //}
}
