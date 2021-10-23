using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{

    /// <summary>
    /// Context class
    /// </summary>
    public class SearchList
    {

        private ISearchStrategy objISearchStrategy;

        public void SetSearchStrategy(ISearchStrategy objSearchStrategy)
        {
            objISearchStrategy = objSearchStrategy;
        }

        public void Search(int[] list, int item)
        {
            int postion = objISearchStrategy.Search(list, item);
            Console.WriteLine("Position of the item: " + item + " is " + postion);

        }
    }
}
