using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11.Exercises.Ex9
{
    abstract class TicketReservation
    {
        public string TicketID { get; set; }
        public string EventName { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public TicketReservation(DateTime dateStart, DateTime dateEnd, 
            string ticketID = "???", string eventName = "???", string location = "???", decimal price = 0)
        {
            DateStart = dateStart;
            DateEnd = dateEnd;
            TicketID = ticketID;
            EventName = eventName;
            Location = location;
            Price = price;
        }

        public virtual string PrintTicket()
        {
            return String.Format(
                "ID: {0}\n" +
                "Event: {1}\n" +
                "Location: {2}\n" +
                "Price: {3:C}\n" +
                "Date: {4} - {5}\n",
                TicketID, EventName, Location, Price, DateStart.ToShortDateString(), DateEnd.ToShortDateString()
                );
        }
    }
}
