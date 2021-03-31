using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            string[] friends = new string[5];

            friends[0] = "Jim";
            friends[1] = "Kelly";

            luckyNumbers[1] = 900;
            Console.WriteLine(friends[0]);
        }
    }
}
