using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            // Classes and Objects
            // a class is a template of a data type and object is an instance of that data type
            Book book1 = new Book("Harry Potter", "Jk Rowling", 400);

            Console.WriteLine(book1.title);

            book1.title = "The hobbit";

            Console.WriteLine(book1.title);
        }
        
    }
}
