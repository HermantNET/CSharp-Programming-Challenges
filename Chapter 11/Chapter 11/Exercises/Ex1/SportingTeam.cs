using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex1
{
    abstract class SportingTeam
    {
        public SportingTeam(string coach, string sport)
        {
            Coach = coach;
            Sport = sport;
        }

        public string Coach;
        public string Sport;

        public virtual string Motto() {return "Sports";}

        public string Fact = "Outside the US, Soccer is reffered to as Football!";
    }
}
