﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.OCP
{
    public enum Type
    {
        Crime, Novel, Fairytale, Guidebook, Classic
    }

    public enum Size
    {
        Pocket, Ordinary, Longread
    }

    #nullable enable
    public class MyBook: Book
    {
        public string Author { get; set; }
        public Type Type { get; set; }
        public Size Size { get; set; }

        public MyBook(string title, string? author, int pages, Type type, Size size): base(title, pages)
        {
            Author = author ?? "unknown author";
            Type = type;
            Size = size;
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
    }
}
