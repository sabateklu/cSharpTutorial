using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            // using getters and setters
            // controls the access to attributes of instances
            Movies avengers = new Movies("The Avengers", "Joss Whedon", "PG-13");
            Movies shrek = new Movies("Shrek", "Adam Adamson", "PG");

            //Potential ratings: G, PG, PG-13, R, NR
            // how do we enforce that the rating input is immutable and only one of the five ratings?

            // 1. we need to close off access to the rating attribute using private in the variable declaration
            // 2. we need to create getters and setters to allow outside code to access and modify the rating

            avengers.Rating = "Dog";
            Console.WriteLine(avengers.Rating);
            
        }
        
    }
}
