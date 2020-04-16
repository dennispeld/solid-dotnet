using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.LSP
{
    public static class Starter
    {
        public static void Run()
        {
            const int page = 165;

            List<MyBook> library = Init();

            foreach (var item in library) {
                item.OpenPage(page);
                item.OpenTableOfContent();
            }
        }

        private static List<MyBook> Init()
        {
            return new List<MyBook>() {
                new MyBook("The beach", "Alex Garland", 254),
                new MyJournal("My textbook", 150, true) 
            };
        }
    }
}
