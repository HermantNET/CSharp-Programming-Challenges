using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.Exercises.Exercise_5
{
    class Trip
    {
        public double DistanceTravelled { get; set; }
        public double GasolineCost { get; set; }
        public double GasolineUsed { get; set; }

        public Trip(double dist, double cost, double gasUsed) 
        {
            DistanceTravelled = dist;
            GasolineCost = cost;
            GasolineUsed = gasUsed;
        }

        public Trip(double dist, double gasUsed)
        {
            DistanceTravelled = dist;
            GasolineUsed = gasUsed;
        }

        public double CalculateMPG() {
            return DistanceTravelled / GasolineUsed;
        }

        public double CalculateCostPerMile()
        {
            return GasolineCost / DistanceTravelled / GasolineUsed;
        }

        public override string ToString()
        {
            return String.Format("Trip - MPG: {0}, Cost Per Mile: {1:C}", CalculateMPG(), CalculateCostPerMile());
        }
    }
}
