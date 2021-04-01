using System;
namespace Giraffe
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        // you can still use this method to create an instance of the class 
        public Book()
        {

        }

        // constructor method: the constructor is a method that is called when an instance of the class is created
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
