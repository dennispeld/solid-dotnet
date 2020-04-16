using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET
{
    internal interface IWritable
    {
        public void AddEntry(Entry entry);
        public void RemoveEntry(int index);
    }
}
