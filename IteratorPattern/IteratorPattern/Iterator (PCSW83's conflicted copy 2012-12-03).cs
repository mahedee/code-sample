using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// Concrete Iterator Class
    /// </summary>
    public class Iterator : IIterator
    {

        private Collection collection;
        private int current = 0;
        private int step = 1; //Default
        private int startFrom = 0;

        public Iterator(Collection vCollection)
        {
            this.collection = vCollection;
        }

        public FruitItem First()
        {
            current = 0;
            return (FruitItem)collection[current];
        }

        public FruitItem Next()
        {
            current += step;

            if (!IsDone)

                return (FruitItem)collection[current];

            else

                return null;
        }


        public bool IsDone
        {
            //Return true or false against the condition.
            get { return current >= collection.Count; }
        }


        public FruitItem CurrentItem
        {
            get { return (FruitItem) collection[current]; }
        }


        // Gets or sets stepsize
        public int Step
        {
            get { return step; }
            set { step = value; }
        }

    }
}
