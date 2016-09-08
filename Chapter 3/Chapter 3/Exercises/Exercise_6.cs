using ConsoleMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3.Exercises
{
    class Exercise_6 : Exercise
    {
        private double amount = 0;
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value >= 1)
                {
                    throw new System.ArgumentOutOfRangeException(paramName: null, message: "Value is over $0.99");
                }
                else
                {
                    amount = value;
                }
            }                  
        }

        private int quarters = 0;
        private int dimes = 0;
        private int nickels = 0;
        private int pennies = 0;

        private int Count(int val, int num) 
        {
            int count = 0;
            for (int i = val; i < num; i += val) 
            {
                count++;
            }
            return count;
        }

        private int Quarters(ref int num)
        {
            int val = 25;
            int count = Count(val, num);
            num -= count * val;
            return count;
        }

        private int Dimes(ref int num)
        {
            int val = 10;
            int count = Count(val, num);
            num -= count * val;
            return count;
        }

        private int Nickels(ref int num)
        {
            int val = 5;
            int count = Count(val, num);
            num -= count * val;
            return count;
        }

        private void Input() 
        {
            try
            {
                Amount = double.Parse(Console.ReadLine());
                int toCount = (int)(amount * 100);
                quarters = Quarters(ref toCount);
                dimes = Dimes(ref toCount);
                nickels = Nickels(ref toCount);
                pennies = toCount;
            }
            catch (System.Exception e)
            {
                if (e is System.ArgumentOutOfRangeException) 
                {
                    Console.WriteLine(e.Message);
                } 
                else 
                {
                    Console.WriteLine("Please enter a number.");
                }
                Input();
            }
        }

        private void Print()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n                                      \n" +
                              "Total Amount: {0,5}                   \n" +
                              "--------------------------------------\n" +
                              " Quarters | Dimes | Nickels | Pennies \n" +
                              "--------------------------------------\n" +
                              "{1,9} |{2,6} |{3,8} |{4,8} \n" +
                              "                                      ",
                              Amount.ToString("C"), quarters, dimes, nickels, pennies);
            Console.ResetColor();
        }

        public override void Run()
        {
            Console.WriteLine("Change Calculator\n");
            Input();
            Print();
        }
    }
}
