using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SOLID.NET
{
    public class Entry : IComparable<Entry>, IFormattable
    {
        public string Content { get; set; }
        public DateTime DateAdded { get; set; }

        public Entry(string content)
        {
            Content = content;
            DateAdded = DateTime.Now;
        }

        public int CompareTo(Entry other)
        {
            int compare = DateAdded.CompareTo(other?.DateAdded);

            if (compare == 0) {
                return Content?.CompareTo(other?.Content) ?? -1;
            }

            return compare;
        }

        public override string ToString()
        {
            return $"\"{Content}\" added on {DateAdded:dd.MM.yyyy}";
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null) format = "A";

            return (format.ToUpper()) switch
            {
                "A" => ToString(), // A for All
                "C" => Content, // C for Content
                "D" => DateAdded.ToString("dd.MM.yyyy"), // D for DateAdded
                _ => throw new FormatException(String.Format(formatProvider, $"Format {format} is not supported.")),
            };
        }
    }
}
