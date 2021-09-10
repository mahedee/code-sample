using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// Interface for Iterator
    /// </summary>
    public interface IIterator
    {
        FruitItem First();
        FruitItem Next();
        FruitItem CurrentItem { get; }
        bool IsDone { get; }
    }
}
