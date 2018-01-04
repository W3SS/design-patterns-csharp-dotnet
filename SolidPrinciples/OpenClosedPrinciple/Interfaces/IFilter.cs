using System;
using System.Collections.Generic;

namespace SolidPrinciples.OpenClosedPrinciple.Interfaces
{
    // we introduce two new interfaces that are open for extension
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
