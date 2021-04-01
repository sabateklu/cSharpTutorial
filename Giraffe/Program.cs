using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            int index = 6;

            do // executes the code in the block before checking the condition
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5) ;


        }
       
    }
}
