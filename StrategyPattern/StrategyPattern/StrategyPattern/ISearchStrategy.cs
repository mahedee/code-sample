using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Strategy defines how algorithm will be called
    /// </summary>
    public interface ISearchStrategy
    {
        int Search(int[] list, int item);
    }
}
