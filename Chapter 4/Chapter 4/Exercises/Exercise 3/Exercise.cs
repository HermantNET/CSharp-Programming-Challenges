using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.Exercises.Exercise_3
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            var me = new Student("Thomas", "Herman", 3.5, "Junior", "Pancakes Studies");
            Console.WriteLine(me.ToString());
        }
    }
}
