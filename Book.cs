using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET
{
    public abstract class Book
    {
        public string Title { get; }
        public int Pages { get; }

        protected Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }
    }
}
