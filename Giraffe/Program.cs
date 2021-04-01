using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(3, 3));
        }
        // create method that takes two positive integer arguments and returns the first argument to the power of the second argument
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}
