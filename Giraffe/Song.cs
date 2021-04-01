using System;
namespace Giraffe
{
    public class Song
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;

            songCount++;
        }
        // method created to access static attribute via object instance
        public int getSongCount()
        {
            return songCount;
        }
    }
}
