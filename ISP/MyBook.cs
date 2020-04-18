using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.ISP
{
    public class MyBook: Book, IReadable
    {
        public string Author { get; set; }

        public MyBook(string title, string author, int pages): base(title, pages)
        {
            Author = author;
        }

        public override void OpenPage(int page)
        {
            if (Pages > page)
                Console.WriteLine($"You opened a page {page} of the book \"{Title}\" by {Author}.");
            else
                Console.WriteLine($"There is no page {page} in the book \"{Title}\" by {Author}.");
        }

        public override void OpenTableOfContent()
        {
            Console.WriteLine($"You have opened a table of content of the book \"{Title}\" by {Author}.");
        }

        public void ReadPage(int page)
        {
            if (Pages > page)
                Console.WriteLine($"You read a page {page} of the book \"{Title}\" by {Author}.");
            else
                Console.WriteLine($"There is no page {page} in the book \"{Title}\" by {Author}.");
        }
    }
}
