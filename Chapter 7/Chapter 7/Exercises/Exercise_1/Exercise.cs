using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7.Exercises.Exercise_1
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            int[] itemArray = { 1, 7, 2, 4, 2, 3, 8, 4, 6, 4, 4, 7 },
                  itemCount = new int[11];
            List<int> items = itemArray.ToList();

            Console.WriteLine("INPUTS:");
            items.ForEach((item) => {
                Console.Write(item + " ");
                itemCount[item]++;
            });
            Console.WriteLine("\n");

            int i = -1;
            Array.ForEach(itemCount,(count) => 
            {
                i++;
                if (count != 0) 
                Console.WriteLine("'{0}' Count = {1}", i, count);
            });
            Console.WriteLine("\nTotal Entries: {0}", items.Count);
        }

        //private List<int> Input()
        //{
        //    Random rand = new Random();
        //    int count = rand.Next(0,22);
        //    List<int> items = new List<int>();
        //    for (int i = 0; i < count; i++)
        //    {
        //        items.Add(rand.Next(0, 11));
        //    }
        //    return items;
        //}
    }
}
