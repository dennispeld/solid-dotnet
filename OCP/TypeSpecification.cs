using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.OCP
{
    public class TypeSpecification: ISpecification<MyBook>
    {
        private readonly Type type;

        public TypeSpecification(Type type)
        {
            this.type = type;
        }

        public bool IsSatisfied(MyBook book)
        {
            return book.Type == type;
        }
    }
}
