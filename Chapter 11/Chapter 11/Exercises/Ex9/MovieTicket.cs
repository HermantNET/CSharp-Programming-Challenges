using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex9
{
    class MovieTicket : TicketReservation
    {
        public string Movie { get; set; }
        public DateTime Time { get; set; }

        public MovieTicket(DateTime dateStart, DateTime dateEnd, string movie, DateTime time,
            string ticketID = "???", string eventName = "???", string location = "???", decimal price = 0)
            : base(dateStart, dateEnd, ticketID, eventName, location, price)
        {
            Movie = movie;
            Time = time;
        }

        public override string PrintTicket()
        {
            return base.PrintTicket() + string.Format(
                "Movie: {0}\n" +
                "Time: {1}\n",
                Movie, Time.ToShortTimeString()
                );
        }
    }
}
