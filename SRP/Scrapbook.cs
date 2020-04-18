using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.SRP
{
    public class Scrapbook<T>: Book, IWritable<T>, IEnumerable<T>
        where T: Entry
    {
        public readonly List<T> _scrapbook = new List<T>();
        public int count = 0;

        public Scrapbook(string title, int pages): base(title, pages) { }

        public void Add(T entry)
        {
            entry.Content = $"{++count}: {entry.Content}";
            _scrapbook.Add(entry);
        }

        public void Erase(int index)
        {
            _scrapbook.RemoveAt(index);
        }

        public override void OpenPage(int page)
        {
            if (Pages > page)
                Console.WriteLine($"You opened a page {page} of the scrapbook.");
            else
                Console.WriteLine($"There is no page {page} if the scrapbook.");
        }

        public override void OpenTableOfContent()
        {
            Console.WriteLine($"The scrapbook doesn't have a table of content");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_scrapbook).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
