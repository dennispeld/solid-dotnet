using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.LSP
{
    public class MyJournal: MyBook
    {
        public bool HasScribbles { get; set; }

        public MyJournal(string title, int pages, bool hasScribbles): base(title, null, pages)
        {
            HasScribbles = hasScribbles;
        }

        public override void OpenPage(int page)
        {
            if (Pages > page)
                Console.WriteLine($"You opened a page {page} of the journal.");
            else
                Console.WriteLine($"There is no page {page} in the journal.");
        }
    }
}
