using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex1
{
    class VolleyballTeam : SportingTeam, ITraveler
    {
        public VolleyballTeam(string coach)
            : base(coach, "Volleyball")
        {

        }

        public bool HasNet = true;

        public override string Motto()
        {
            return "Head Bop!";
        }

        public bool HomeOrAway()
        {
            return false;
        }
    }
}
