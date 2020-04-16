using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.OCP
{
    public class SizeSpecification: ISpecification<MyBook>
    {
        private readonly Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(MyBook book)
        {
            return book.Size == size;
        }
    }
}
