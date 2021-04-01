using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            double cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
        }

        // break down of a method: static returnType methodName
        // when you create a method that returns a value, the returnType is the data type that you will return

        static double cube(int num)
        {
            double result = Math.Pow(num, 3);
            return result;
        }
    }
}
