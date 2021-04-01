using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            // Classes and Objects
            // object methods in C#: instances of an object can use these method

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors()); // should return false;
            Console.WriteLine(student2.HasHonors()); // should return true;
        }
        
    }
}
