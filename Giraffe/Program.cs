using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            // building a guessing game where the user has to continue guessing the word until they get it correct

            string secretWord = "giraffe";
            string guess = "";
            int guessLimit = 3;
            int guessCount = 0;
            bool outOfGuesses = false;
            

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

            }
            if (outOfGuesses)
            {
                Console.WriteLine("you lose!");
            }
            else
            {
                Console.WriteLine("you win!");
            }
        }
       
    }
}
