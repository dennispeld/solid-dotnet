using System;
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
            Author = author ?? "Unknown";
            Type = type;
            Size = size;
        }
    }
}
