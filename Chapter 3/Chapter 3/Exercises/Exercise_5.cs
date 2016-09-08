using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMenu;

namespace Chapter_3.Exercises
{
    class Exercise_5 : Exercise
    {
        private double fahrenheit = 0;
        public double Fahrenheit { get { return fahrenheit; } }

        private double celsius = 0;
        public double Celsius { get { return celsius; }
                                set { celsius = value;
                                Convert(celsius);
                                } }

        private void Input() 
        {
            try
            {
                Console.Write("Celsius: ");
                Celsius = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a number.");
                Input();
            }
        }

        private void Convert(double c)
        {
            fahrenheit = c * 1.8 + 32;
        }

        private void Print()
        {
            Console.WriteLine("-----------------------------\n" +
                              " Celsius     | Fahrenheit    \n" +
                              "-----------------------------\n" +
                              "{0,12} |{1,14}", Celsius.ToString("f2"), Fahrenheit.ToString("f2"));
        }

        public override void Run()
        {
            Console.WriteLine("Celsius to Fahrenheit Converter\n");
            Input();
            Print();
        }
    }
}
