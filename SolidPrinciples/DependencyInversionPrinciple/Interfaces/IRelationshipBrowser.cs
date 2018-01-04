using System;
using System.Collections.Generic;

namespace SolidPrinciples.DependencyInversionPrinciple.Interfaces
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
