using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.Exercises.Exercise_6
{
    class Money
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }

        #region Converters
        private int ConvertToDollars(ref double val) 
        {
            int result = Convert.ToInt32(Math.Floor(val));
            val = val - result;
            return  result;
        }

        private int ConvertToCents(double val) 
        {
            return Convert.ToInt32(val * 100);
        }
        #endregion

        #region Constructors
        public Money(double money) 
        {
            Dollars = ConvertToDollars(ref money);
            Cents = ConvertToCents(money);
        }

        public Money(int dollars, int cents) 
        {
            Dollars = dollars;
            Cents = cents;
        }
        #endregion

        #region Opeartions
        public void IncrementMoney(double val) 
        {
            Dollars += ConvertToDollars(ref val);
            Cents += ConvertToCents(val);
        }

        public void DecrementMoney(double val) 
        {
            Dollars -= ConvertToDollars(ref val);
            Cents -= ConvertToCents(val);
        }
        #endregion

        #region Public Returns
        public string ToCoinAmount() 
        {
            var toCoin = new Mallem.Convert_ToCoinAmount(Dollars, Cents);
            return toCoin.Print();
        }

        public override string ToString()
        {
            return string.Format("{0:C}", (double)Dollars + (Cents / 100D));
        }
        #endregion
    }
}
