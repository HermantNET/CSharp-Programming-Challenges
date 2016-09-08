using ConsoleMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mallem
{
    class Convert_ToCoinAmount
    {
        public Convert_ToCoinAmount(double num)
        {
            Amount = num;
            int toCount = (int)Math.Round(amount * 100);
            quarters = calcQuarters(ref toCount);
            dimes = calcDimes(ref toCount);
            nickels = calcNickels(ref toCount);
            pennies = toCount;
        }

        public Convert_ToCoinAmount(int dollars, int cents)
        {
            Amount = dollars + ((double)cents / 100);
            int toCount = (int)Math.Round(amount * 100);
            quarters = calcQuarters(ref toCount);
            dimes = calcDimes(ref toCount);
            nickels = calcNickels(ref toCount);
            pennies = toCount;
        }

        private double amount = 0;
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }                  
        }

        private int quarters = 0;
        public int Quarters { get { return quarters; } }

        private int dimes = 0;
        public int Dimes { get { return dimes; } }

        private int nickels = 0;
        public int Nickels { get { return nickels; } }

        private int pennies = 0;
        public int Pennies { get { return pennies; } }

        private int Count(int val, int num) 
        {
            int count = 0;
            for (int i = val; i <= num; i += val) 
            {
                count++;
            }
            return count;
        }

        private int calcQuarters(ref int num)
        {
            int val = 25;
            int count = Count(val, num);
            num -= count * val;
            return count;
        }

        private int calcDimes(ref int num)
        {
            int val = 10;
            int count = Count(val, num);
            num -= count * val;
            return count;
        }

        private int calcNickels(ref int num)
        {
            int val = 5;
            int count = Count(val, num);
            num -= count * val;
            return count;
        }

        public string Print()
        {
            return string.Format("Quartes: {0}, Dimes: {1}, Nickels: {2}, Pennies: {3}",
                              quarters, dimes, nickels, pennies);
        }
    }
}
