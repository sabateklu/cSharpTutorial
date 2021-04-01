using System;
namespace Giraffe
{
    public class Movies
    {
        public string title, producer;
        // private makes it so only the code in the Movies class can access the rating
        private string rating;
        public Movies(string aTitle, string aProducer, string aRating)
        {
            title = aTitle;
            producer = aProducer;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating;}
            set {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
