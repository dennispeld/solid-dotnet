using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.ISP
{
    public class MyWorkbook<T> : IReadable, IWritable<T>, IEnumerable<T>
        where T : Entry
    {
        private readonly List<T> _workbook = new List<T>();

        public int Pages { get; }

        public MyWorkbook(int pages)
        {
            Pages = pages;
        }

        public void Add(T entry)
        {
            _workbook.Add(entry);
        }

        public void Erase(int index)
        {
            _workbook.RemoveAt(index);
        }

        public void ReadPage(int page)
        {
            if (Pages < page)
                Console.WriteLine($"There is no page {page} in this workbook.");
            else
                Console.WriteLine($"You have read the page {page} of the workbook.");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_workbook).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
