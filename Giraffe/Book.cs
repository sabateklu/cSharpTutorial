using System;
namespace Giraffe
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string name, string writtenBy, int numOfPages)
        {
            title = name;
            author = writtenBy;
            pages = numOfPages;
        }
    }
}
