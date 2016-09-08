using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex1
{
    class FootballTeam : SportingTeam, ITraveler
    {
        public FootballTeam(string coach)
            : base(coach, "Football")
        {

        }

        public override string Motto()
        {
            return Sport + " is the best!";
            //return base.Motto();
        }

        public bool HomeOrAway()
        {
            return true;
        }
    }
}
