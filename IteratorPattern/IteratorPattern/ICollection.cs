using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// Interface for Aggregate class
    /// </summary>
    public interface ICollection
    {
        Iterator CreateIterator();
    }
}
