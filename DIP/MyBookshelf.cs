using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.DIP
{
    public enum ShelfType
    {
        Crime,
        NonFiction,
        Fairytale,
        Classics
    }

    public class MyBookshelf
    {
        public ShelfType ShelfType { get; }
        public List<MyBook> Books { get; }

        public MyBookshelf(ShelfType type, List<MyBook> books)
        {
            ShelfType = type;
            Books = books;
        }
    }
}
