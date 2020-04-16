using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.OCP
{
    public static class Starter
    {
        private static readonly List<MyBook> books = new List<MyBook>();

        public static void Run()
        {
            Init();

            MyBookFilter myBookFilter = new MyBookFilter();

            // using logical AND to filter all books that are classic and longread
            var specification = new AndSpecification<MyBook>(
                new TypeSpecification(Type.Classic),
                new SizeSpecification(Size.Longread));

            foreach (var book in myBookFilter.Filter(books, specification)) {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }

        private static void Init()
        {
            books.Add(new MyBook("The beach", "Alex Garland", 356, Type.Novel, Size.Ordinary));
            books.Add(new MyBook("Steppenwolf", "Hermann Hesse", 214, Type.Classic, Size.Ordinary));
            books.Add(new MyBook("Red Hat", null, 60, Type.Fairytale, Size.Pocket));
            books.Add(new MyBook("The snowman", "Jo Nesbo", 451, Type.Crime, Size.Longread));
            books.Add(new MyBook("1Q94", "Haruki Murakami", 1624, Type.Novel, Size.Longread));
            books.Add(new MyBook("The Catcher in the Rye", "J. D. Salinger", 394, Type.Classic, Size.Longread));
        }
    }
}
