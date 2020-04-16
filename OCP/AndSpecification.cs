﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.NET.OCP
{
    /// <summary>
    /// A composite specification (for logical AND)
    /// </summary>
    public class AndSpecification<T>: ISpecification<T>
    {
        private readonly ISpecification<T> first, second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }
}
