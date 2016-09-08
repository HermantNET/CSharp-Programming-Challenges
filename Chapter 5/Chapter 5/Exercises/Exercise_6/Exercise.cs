using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.Exercises.Exercise_6
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Console.WriteLine(
                " 1 - Circle\n" +
                " 2 - Rectangle\n" +
                " 3 - Cylinder\n");
            Console.Write("#: ");
            switch (Console.ReadLine()) 
            {
                case "circle":
                case "1":
                    Circle();
                    break;
                case "rectangle":
                case "2":
                    Rectangle();
                    break;
                case "cylinder":
                case "3":
                    Cylinder();
                    break;
            }
        }

        private void Cylinder()
        {
            Console.Write("radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + Math.PI * (radius * 2) * height);
        }

        private void Rectangle()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + width * length);
        }

        private void Circle()
        {
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + Math.PI * (radius * 2));
        }
    }
}
