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
        private ArrayList lstFruitItem = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }


        // Get counted items
        public int Count
        {
            get { return lstFruitItem.Count; }

        }



        // Indexer

        public object this[int index]
        {

            get { return lstFruitItem[index]; }

            set { lstFruitItem.Add(value); }

        }
    }
}
