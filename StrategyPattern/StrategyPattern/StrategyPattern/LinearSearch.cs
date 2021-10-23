using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Concrete strategy(Linear Search Algorithm)
    /// </summary>
    public class LinearSearch : ISearchStrategy
    {
        #region ISearchStrategy Members

        public int Search(int[] list, int item)
        {
            Console.WriteLine("Linear Search");
            int position = 0;

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i] == item)
                {
                    position = i;
                    break;
                }
            }

            return position;
        }

        #endregion
    }
}
