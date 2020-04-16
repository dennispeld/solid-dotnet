using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.NET.SRP
{
    public class ScrapbookManager
    {
        public void SaveToFile(Scrapbook scrapbook, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename)) {
                foreach (var entry in scrapbook.entries)
                    File.AppendAllText(filename, entry.ToString() + "\r\n");
            }
        }
    }
}
