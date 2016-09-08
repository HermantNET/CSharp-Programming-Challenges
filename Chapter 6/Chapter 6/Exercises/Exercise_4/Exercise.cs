using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.Exercises.Exercise_4
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Console.WriteLine("Cost Estimator\n\nEnter price of each product,");
            decimal total = GetPurchaseTotal();
            decimal tax = CalculateTax(total);
            decimal shipping = ShippingCost(total);
            Console.WriteLine("\nSubtotal | ${0,10:N2}\n" +
                                "     Tax | ${1,10:N2}\n" +
                                "Shipping | ${2,10:N2}\n" +
                                "   Total | ${3,10:N2}\n",
                                total, tax, shipping, total + tax + shipping);
        }

        private decimal GetPurchaseTotal()
        {
            string input = "0";
            decimal total = 0;
            while (input != "done") 
            {
                try
                {
                    total += decimal.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Invalid Entry.");
                }
                Console.Write("\nCurrent Total: {0:C}\nType 'done' to finish.\nPrice: \t$", total);
                input = Console.ReadLine();
                Console.Clear();
            }
            return total;
        }

        private decimal ShippingCost(decimal total) 
        {
            if (total < 0)
                return 0;
            else if (total <= 250)
                return 5;
            else if (total <= 500)
                return 8;
            else if (total <= 1000)
                return 10;
            else if (total <= 5000)
                return 15;
            else
                return 20;
        }

        private decimal CalculateTax(decimal total) 
        {
            const decimal TAX_RATE = .07M;
            return total * TAX_RATE;
        }
    }
}
