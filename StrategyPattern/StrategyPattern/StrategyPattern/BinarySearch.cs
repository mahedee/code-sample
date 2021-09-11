using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Concrete strategy(Binary Search Algorithm)
    /// </summary>
    public class BinarySearch : ISearchStrategy
    {
        #region ISearchStrategy Members

        public int Search(int[] list, int item)
        {
            Console.WriteLine("Binary Search");

            int beg = 0;
            int end = list.Count() - 1;
            int mid = (int)((beg + end)/2);
            int position = 0;

            while (beg <= end && list[mid] != item)
            {
                if(item < list[mid])
                    end = mid - 1;
                else
                    beg = mid + 1;

                mid = (int)((beg + end)/2);
            }

            if (list[mid] == item)
                position = mid;
            else
                position = 0;


            return position;
        }

        #endregion
    }
}
