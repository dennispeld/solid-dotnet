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

            foreach (var entry in entries) {
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
