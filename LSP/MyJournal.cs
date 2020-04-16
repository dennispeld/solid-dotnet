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
    }
}
