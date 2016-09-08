using ConsoleMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3.Exercises
{
    class Exercise_7 : Exercise
    {
        private double sum = 0;
        private double Sum(double one, double two) 
        {
            sum = one + two;
            return sum;
        }

        private double product = 0;
        private double Product(double one, double two)
        {
            product = one * two;
            return product;
        }

        private double average = 0;
        private double Average(double one, double two)
        {
            average = (one + two) / 2;
            return average;
        }

        private double squared = 0;
        private double Squared(double one, double two)
        {
            squared = Math.Pow(one, two);
            return squared;
        }

        private void Input()
        {
            Console.Write("Enter a number: ");
            double one = double.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            double two = double.Parse(Console.ReadLine());
            Sum(one, two);
            Product(one, two);
            Average(one, two);
            Squared(one, two);
        }

        private void Print() 
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nSUM: {0,16} \n" +
                              "----------------------\n" +
                              "PRODUCT: {1,12} \n" +
                              "----------------------\n" +
                              "AVERAGE: {2,12} \n" +
                              "----------------------\n" +
                              "SQUARED: {3,12} \n",
                              sum, product, average, squared);
            Console.ResetColor();
        }

        public override void Run()
        {
            Console.WriteLine("Math Magic\n");
            Input();
            Print();
        }
    }
}
