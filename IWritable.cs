using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET
{
    /// <summary>
    /// We assume writable books are the type of books you can add entries to or erase entries from.
    /// </summary>
    internal interface IWritable
    {
        public void AddEntry(Entry entry);
        public void RemoveEntry(int index);
    }
}
