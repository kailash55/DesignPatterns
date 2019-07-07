using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap6.EventTickets.Model
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Allocation { get; set; }
        public List<TicketReservation> ReservedTickets { get; set; }
        public List<TicketPurchase> PurchasedTickets { get; set; }

        public Event()
        {
            ReservedTickets = new List<TicketReservation>();
            PurchasedTickets = new List<TicketPurchase>();
        }

        public int AvailableAllocation()
        {
            int salesAndReservation = 0;

            PurchasedTickets.ForEach(t => salesAndReservation += t.TicketQuantity);
            ReservedTickets.FindAll(r => r.IsStillAlive())
                .ForEach(r => salesAndReservation += r.TicketQuantity);

            return Allocation - salesAndReservation;
        }

        public bool CanPurchaseTicketWith(Guid reservationId)
        {
            if (HasReservationWith(reservationId))
                return GetReservationWith(reservationId).IsStillAlive();

            return false;
        }

        private TicketReservation GetReservationWith(Guid reservationId)
        {
            throw new NotImplementedException();
        }

        private bool HasReservationWith(Guid reservationId)
        {
            throw new NotImplementedException();
        }
    }
}
