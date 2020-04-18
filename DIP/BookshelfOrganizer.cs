using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.NET.DIP
{
    public class BookshelfOrganizer: IBookshelfSearchable
    {
        private readonly List<MyBookshelf> _library;

        public BookshelfOrganizer()
        {
            _library = new List<MyBookshelf>();
        }

        public void AddBookshelf(MyBookshelf bookshelf)
        {
            _library.Add(bookshelf);
        }

        public IEnumerable<MyBookshelf> GetBookshelvesByType(ShelfType type)
        {
            return _library.Where(shelf => shelf.ShelfType == type);
        }
    }
}
