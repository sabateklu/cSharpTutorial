using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            bool isFemale = false;
            bool isTall = true;

            if (isFemale && isTall)
            {
                Console.WriteLine("you are female and tall");
            } else if (isFemale && !isTall)
            {
                Console.WriteLine("you are a short female");
            } else if (!isFemale && isTall)
            {
                Console.WriteLine("you are not female and you're tall");
            } else
            {
                Console.WriteLine("you are neither a female or tall");
            }
        }
    }
}
