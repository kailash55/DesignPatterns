using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap6.EventTickets.Model
{
    public class TicketReservationFactory
    {
        public static TicketReservation CreateReservation(Event Event, int tktQty)
        {
            TicketReservation ticketReservation = new TicketReservation();

            ticketReservation.Id = Guid.NewGuid();
            ticketReservation.Event = Event;
            ticketReservation.ExpiryTime = DateTime.Now.AddMinutes(1);
            ticketReservation.TicketQuantity = tktQty;

            return ticketReservation;
        }
    }
}
