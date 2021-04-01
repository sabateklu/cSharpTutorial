using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {

            // Exception handling: the process of catching exceptions and handling them
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                // e is the exception and e.Message is the error message
                Console.WriteLine("Error: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                // code in a finally block is executed no matter what
                Console.WriteLine("Math is fun!");
            }


        }
        
    }
}
