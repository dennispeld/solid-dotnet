using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.NET.DIP
{
    public class BookshelfStatistics
    {
        private readonly IBookshelfSearchable _library;

        public BookshelfStatistics(IBookshelfSearchable library)
        {
            _library = library;
        }

        public List<MyBook> GetBooksInShelf(ShelfType type)
        {
            var bookshelves = _library.GetBookshelvesByType(type);

            List<MyBook> books = new List<MyBook>();

            foreach (var bookshelf in bookshelves) {
                books.AddRange(bookshelf.Books);
            }

            return books;
        }
    }
}
