using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.Exercises.Exercise_1
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            var bob = new Employee(3, "Bobby", new DateTime(2009, 5, 2), 2200M);
            Console.WriteLine(bob.ToString());

            var jill = new Employee();
            Console.WriteLine(jill.ToString());

            var henry = new Employee(2, "Henry");
            Console.WriteLine(henry.ToString());
        }
    }
}
