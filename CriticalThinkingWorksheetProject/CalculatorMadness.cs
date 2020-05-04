using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingWorksheetProject
{
    public class CalculatorMadness
    {        
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            Console.WriteLine("The result of this additions is: " + result);
            return result;
        }
        public int SubtractNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            Console.WriteLine("The result of this subtractions is: " + result);
            return result;
        }
        public int MultiplyNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            Console.WriteLine("The result of this multiplication is: " + result);
            return result;
        }
        public int DivideNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            Console.WriteLine("The result of the division is: " + result);
            return result;
        }


        public void RunCalculations()
        {
            AddTwoNumbers(48, 250);
            Console.WriteLine("Please enter the first number to add:");
            int valueOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number to add:");
            int valueTwo = int.Parse(Console.ReadLine());
            int output = AddTwoNumbers(valueOne, valueTwo);
            
            Console.WriteLine("The result is: " + output);
            Console.ReadLine();

        }

    }
}
