using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(1000, 45, 200));
            Console.WriteLine(GetEquality("hi", "hi"));
        }
        // write a method to that takes two integers and returns the max
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            // comparison operators include ==, <=, >=, >, <, !=
            // you can also compare characters and strings
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }

            return result;
        }

        static bool GetEquality(string first, string second)
        {
            if (first == second)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
