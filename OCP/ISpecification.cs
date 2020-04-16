using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.OCP
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
