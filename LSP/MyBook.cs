using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.LSP
{
    #nullable enable
    public class MyBook: Book
    {
        public string Author { get; set; }

        public MyBook(string title, string? author, int pages): base(title, pages)
        {
            Author = author ?? "Unknown";
        }

        public void OpenPage(int page)
        {
            if (Pages > page)
                Console.WriteLine($"You opened a page {page} of a book \"{Title}\" by {Author}.");
            else
                Console.WriteLine($"There is no page {page} in a book \"{Title}\" by {Author}.");
        }

        public void OpenTableOfContent()
        {
            if (this is MyJournal)
                Console.WriteLine($"The journal doesn't have a table of content");
            else
                Console.WriteLine($"You have opened a table of content of a book \"{Title}\" by {Author}.");
        }
    }
}
