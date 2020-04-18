using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.ISP
{
    public static class Starter
    {
        public static void Run()
        {
            foreach(var item in Init()) {
                if (item is MyBook myBook) {
                    myBook.ReadPage(262);
                }
                else if (item is MyWorkbook<Entry> myWorkbook) {
                    myWorkbook.ReadPage(262);
                    myWorkbook.Add(new Entry("New scribble"));
                }
                else {
                    throw new NotImplementedException($"The item of type {item.GetType()} is not implemented.");
                }
            }
        }

        private static List<object> Init()
        {
            return new List<object>() {
                new MyBook("The beach", "Alex Garland", 356),
                new MyWorkbook<Entry>(250)
            };
        }
    }
}
