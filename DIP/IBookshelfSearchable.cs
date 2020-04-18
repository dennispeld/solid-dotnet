using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.DIP
{
    public interface IBookshelfSearchable
    {
        IEnumerable<MyBookshelf> GetBookshelvesByType(ShelfType type);
    }
}
