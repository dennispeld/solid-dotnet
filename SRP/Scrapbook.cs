using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.SRP
{
    public class Scrapbook: Book, IWritable
    {
        public readonly List<Entry> entries = new List<Entry>();
        public static int count = 0;

        public Scrapbook(string title, int pages): base(title, pages) { }

        public void AddEntry(Entry entry)
        {
            entry.Content = $"{++count}: {entry.Content}";
            entries.Add(entry);
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }
    }
}
