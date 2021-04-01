using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            SayHi("Saba", 28);
            SayHi("Axum", 29);
        }

        // create a new method that says hi to the user;
        // break down of a method: static returnType methodName

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age + " years old");
        }
    }
}
