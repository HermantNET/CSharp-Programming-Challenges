using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7.Exercises.Exercise_3
{
    class Weather
    {
        private double[] weekWeather = new double[7];
        public double[] WeekWeather { get { return weekWeather; } }

        #region Constructors
        public Weather(double one, double two, double three, double four, double five, double six, double seven) 
        {
            weekWeather = new double[] { one, two, three, four, five, six, seven};
        }

        public Weather(double[] days) 
        {
            weekWeather = days;
        }
        #endregion

        #region public methods
        public double HighestTemp() 
        {
            return weekWeather.Max();
        }

        public double LowestTemp()
        {
            return weekWeather.Min();
        }

        public double AverageTemp()
        {
            return weekWeather.Average();
        }

        public double AverageTempExlLowest() 
        {
            double lowest = LowestTemp();
            return weekWeather.Where(temp => temp != lowest).Average();
        }

        public int DaysBelow(double temperature) 
        {
            return (int)weekWeather.Where((x) => x < temperature).Count();
        }
        #endregion
    }
}
