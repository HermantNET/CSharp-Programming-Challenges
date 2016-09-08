using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7.Exercises.Exercise_5
{
    class Exercise : ConsoleMenu.Exercise
    {
        private string[] names;

        public override void Run()
        {
            string[] nameContainer = new string[999];
            int count = 0;
            string input = "";
            // It would be best to use a List<>, but said approach wouldn't involve using a sentinel which is an important part of the lesson.
            while (input != "-99") 
            {
                Console.WriteLine("Name Sorter\nEnter names, last name first.");
                nameContainer[count] = input;
                count++;

                if (count > 1)
                    Console.WriteLine("\nLast Submitted: {0}", nameContainer[count - 1]);

                Console.Write("\nName: \nType -99 to finish.");
                Console.SetCursorPosition(6, Console.CursorTop -1);
                input = Console.ReadLine().ToUpper();

                Console.Clear();
            }

            names = new string[count - 1];
            Array.Copy(nameContainer, 1, names, 0, names.Length);

            Console.Clear();
            Array.ForEach(names.OrderBy(name => name).ToArray(), 
                (name) => Console.WriteLine(name));
        }
    }
}
