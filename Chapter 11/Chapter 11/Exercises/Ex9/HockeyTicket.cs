using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex9
{
    class HockeyTicket : TicketReservation
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string SeatNumber { get; set; }

        public HockeyTicket(DateTime dateStart, DateTime dateEnd, string team1, string team2, string seatNumber, DateTime time,
            string ticketID = "???", string eventName = "???", string location = "???", decimal price = 0)
            : base(dateStart, dateEnd, ticketID, eventName, location, price)
        {
            Team1 = team1;
            Team2 = team2;
            SeatNumber = seatNumber;
        }

        public override string PrintTicket()
        {
            return base.PrintTicket() + string.Format(
                "{0} VS {1}\n",
                Team1, Team2
                );
        }
    }
}
