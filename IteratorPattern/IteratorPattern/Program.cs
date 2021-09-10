using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Collection collection = new Collection();

            collection[0] = new FruitItem() { Id = "1", Name = "Mango" };
            collection[1] = new FruitItem() { Id = "2", Name = "Orange" };
            collection[2] = new FruitItem() { Id = "3", Name = "Banana" };
            collection[3] = new FruitItem() { Id = "4", Name = "Apple" };
            collection[4] = new FruitItem() { Id = "5", Name = "Lichi" };
            collection[5] = new FruitItem() { Id = "7", Name = "Tamarind" };


            // Create iterator
            Iterator iterator = new Iterator(collection);
            Console.WriteLine("Items by iterating over collection");

            for (FruitItem item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}
