using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.SRP
{
    public static class Starter
    {
        private static readonly List<Entry> entries = new List<Entry>();

        public static void Run()
        {
            Init();

            Scrapbook scrapbook = new Scrapbook("My scrapbook", 300);

            foreach (var entry in entries) {
                scrapbook.AddEntry(entry);
            }

            Display(scrapbook);
        }

        private static void Display(Scrapbook scrapbook)
        {
            foreach (var entry in scrapbook.entries) {
                Console.WriteLine(entry.ToString());
            }
        }

        private static void Init()
        {
            entries.Add(new Entry("First entry"));
            entries.Add(new Entry("Second entry"));
            entries.Add(new Entry("Third entry with a twist"));
        }
    }
}
