using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.DIP
{
    public class MyBook: Book
    {
        public string Author { get; set; }

        public MyBook(string title, string author, int pages): base(title, pages)
        {
            Author = author;
        }

        public override string ToString() => $"\"{Title}\" by {Author}";

        public override void OpenPage(int page)
        {
            if (Pages > page)
                Console.WriteLine($"You opened a page {page} of the book \"{Title}\" by {Author}.");
            else
                Console.WriteLine($"There is no page {page} in the book \"{Title}\" by {Author}.");
        }

        public override void OpenTableOfContent()
        {
            Console.WriteLine($"There is no table of content in the {Title}.");
        }
    }
}
