using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            //2d arrays
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 },
            };
            // array with two rows, and 3 colums
            int[,] myArray = new int[2, 3];

            // 3d array
            int[,,] threeDee =
            {
                {
                    {5,6 },
                    {7,8 }
                },
                {
                    {9,10 },
                    {11, 12 }
                },
                {
                    {13,14 },
                    {15,16 }
                }
            };

            Console.WriteLine(threeDee[0, 0, 0]); // prints 5
            Console.WriteLine(threeDee[2, 1, 0]); // prints 15
            Console.WriteLine(numberGrid[0, 0]); // prints 1
            Console.WriteLine(numberGrid[1, 1]); // prints 4
        }
        
    }
}
