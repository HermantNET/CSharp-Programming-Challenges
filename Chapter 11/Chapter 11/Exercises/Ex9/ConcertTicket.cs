using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex9
{
    class ConcertTicket : TicketReservation
    {
        public string Venue { get; set; }
        public int StageNumber { get; set; }

        public ConcertTicket(DateTime dateStart, DateTime dateEnd, string venue, int stage,
            string ticketID = "???", string eventName = "???", string location = "???", decimal price = 0)
            : base(dateStart, dateEnd, ticketID, eventName, location, price)
        {
            Venue = venue;
            StageNumber = stage;
        }

        public override string PrintTicket()
        {
            return base.PrintTicket() + string.Format(
                "Venue: {0}\n" +
                "Stage: {1}\n",
                Venue, StageNumber
                );
        }
    }
}
