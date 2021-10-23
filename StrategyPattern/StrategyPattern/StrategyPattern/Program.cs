using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Client class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            int[] sortedList = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Instance of context to follow different strategies
            SearchList objSearchList = new SearchList();

            objSearchList.SetSearchStrategy(new BinarySearch());
            objSearchList.Search(sortedList, 4);

            objSearchList.SetSearchStrategy(new LinearSearch());
            objSearchList.Search(sortedList, 7);

            Console.ReadLine();
        }
    }
}
