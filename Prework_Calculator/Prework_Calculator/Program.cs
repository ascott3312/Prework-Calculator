using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6;
            int num2 = 2;
            int result;
            //Add
            result = num1 + num2;
            //Subtract
            Console.WriteLine("Value is {0}", result);
            result = num1 - num2;
            //Multiply
            Console.WriteLine("Value is {0}", result);
            result = num1 * num2;
            //Divide
            Console.WriteLine("Value is {0}", result);
            result = num1 / num2;
            Console.WriteLine("Value is {0}", result);
            result = num1 % num2;
            Console.ReadLine();

        }
    }
}
