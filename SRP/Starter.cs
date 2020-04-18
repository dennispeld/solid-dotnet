using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.NET.SRP
{
    public static class Starter
    {
        private static readonly List<Entry> scrapbook = new List<Entry>();

        public static void Run()
        {
            Init();

            foreach (var entry in scrapbook) {
                Console.WriteLine(entry.ToString());
            }

            // write the scrapbook to file
            ScrapbookManager scrapbookManager = new ScrapbookManager();
            scrapbookManager.SaveToFile(scrapbook, $"{Directory.GetCurrentDirectory()}\\scrapbook.txt", true);
        }

        private static void Init()
        {
            scrapbook.Add(new Entry("First entry"));
            scrapbook.Add(new Entry("Second entry"));
            scrapbook.Add(new Entry("Third entry with a twist"));
        }
    }
}
