using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+" )
            {
                Console.WriteLine(num1 + num2);
            } else if ( op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else
            {
                Console.WriteLine("Invalid operator");
            }
        }
       
    }
}
