using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8.Exercises.Exercise_4
{
    class Exercise : ConsoleMenu.Exercise
    {
        public override void Run()
        {
            Customer cust = Input();
            Console.WriteLine(MailingLabel(cust));
        }

        private Customer Input()
        {
            Customer newCustomer = new Customer();

            Console.WriteLine("Enter name, First then Last, seperated with a space:");
            string[] name = Console.ReadLine().Split(' ');
            newCustomer.FirstName = name[0];
            newCustomer.LastName = name[1];

            Console.WriteLine("Enter birthdate in mm/dd/yyyy format:");
            newCustomer.BirthDate = DateTime.ParseExact(Console.ReadLine(), "mm/dd/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the corresponding number of the Month Purchased:");
            newCustomer.MonthPurchased = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter zipcode:");
            newCustomer.ZipCode = Console.ReadLine();

            return newCustomer;
        }

        private string MailingLabel(Customer cust)
        {
            return String.Format("{0}{1}{2}{3}",cust.LastName, cust.BirthDate.Year.ToString().Substring(2), 
                CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(cust.MonthPurchased).Substring(0,3),
                cust.ZipCode.Substring(cust.ZipCode.Length - 2));
        }
    }
}
