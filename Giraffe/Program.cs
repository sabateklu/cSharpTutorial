using System;

namespace Giraffe
{
    class Program
    {
        // only code that is run within Main, so if you want to run code you have to call it in Main
        static void Main(string[] args)
        {
            Song holiday = new Song("holiday", "green day", 3);
            Song kashmir = new Song("kashmir", "led", 2);

            // as of now, each instance has normal attributes that are unique to each object
            // a static attribute is the same for each instance and unique to the class

            Console.WriteLine(Song.songCount);

            // you cant access the static attribute via the instance so this wont work: Console.WriteLine(kashmir.songCount);
            Console.WriteLine(holiday.getSongCount());
        }
        
    }
}
