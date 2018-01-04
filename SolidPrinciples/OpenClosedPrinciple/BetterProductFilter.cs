using SolidPrinciples.OpenClosedPrinciple.Interfaces;
using System.Collections.Generic;

namespace SolidPrinciples.OpenClosedPrinciple
{
    public class BetterProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.IsSatisfied(i))
                {
                    yield return i;
                }
            }
        }
    }
}
