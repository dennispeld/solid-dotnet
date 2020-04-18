using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.DIP
{
    public static class Starter
    {
        public static void Run()
        {
            var library = Init();

            var statistics = new BookshelfStatistics(library);

            foreach (ShelfType shelfType in Enum.GetValues(typeof(ShelfType))) {
                var books = statistics.GetBooksInShelf(shelfType);

                Console.WriteLine($"There are {books.Count} books found in the {shelfType} shelf:");

                foreach (var book in books) {
                    Console.WriteLine(book.ToString());
                }

                Console.WriteLine();
            }
        }

        private static BookshelfOrganizer Init()
        {
            // create a library
            BookshelfOrganizer library = new BookshelfOrganizer();

            // init all crime books and add them to a crime bookshelf
            List<MyBook> crimeBooks = new List<MyBook>() {
                new MyBook("The snowman", "Jo Nesbö", 467),
                new MyBook("And then there were none", "Agatha Christie", 145),
                new MyBook("The Bourne identity", "Robert Lidlum", 579)
            };
            library.AddBookshelf(new MyBookshelf(ShelfType.Crime, crimeBooks));

            // init all classics books and add them to a classics bookshelf
            List<MyBook> classicBooks = new List<MyBook>() {
                new MyBook("1984", "George Orwell", 369),
                new MyBook("The Great Gatsby", "F. Scott Fitzerald", 413)
            };
            library.AddBookshelf(new MyBookshelf(ShelfType.Classics, classicBooks));

            // init all fairytailes and add them to a fairytaile bookshelf
            List<MyBook> fairytaleBooks = new List<MyBook>() {
                new MyBook("Red Hat", "unknown author", 113)
            };
            library.AddBookshelf(new MyBookshelf(ShelfType.Fairytale, fairytaleBooks));

            return library;
        }
    }
}
