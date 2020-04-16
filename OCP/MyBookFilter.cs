using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.OCP
{
    public class MyBookFilter : IFilter<MyBook>
    {
        public IEnumerable<MyBook> Filter(IEnumerable<MyBook> items, ISpecification<MyBook> spec)
        {
            foreach (var i in items) {
                if (spec.IsSatisfied(i)) {
                    yield return i;
                }
            }
        }
    }
}
