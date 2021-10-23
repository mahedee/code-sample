using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IteratorPattern
{
    /// <summary>
    /// Concrete aggregate class
    /// </summary>
    
    public class Collection : ICollection
    {
        private ArrayList lstFoodItem = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }


        // Get counted items
        public int Count
        {
            get 
            { 
                return lstFoodItem.Count;
            }

        }



        // Indexer

        public object this[int index]
        {

            get { return lstFoodItem[index]; }

            set { lstFoodItem.Add(value); }

        }
    }
}
