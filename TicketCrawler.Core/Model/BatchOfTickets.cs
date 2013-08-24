using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Core.Model
{
    public class BatchOfTickets
    {
        public Event CurrentEvent { get; private set; }
        public Location LocationOfEvent { get; private set; }
        public List<Ticket> TicketsOnEvent { get; private set; }

        public BatchOfTickets(Event currentEvent, Location locationOfEvent, List<Ticket> ticketsOnEvent)
        {
            this.CurrentEvent = currentEvent;
            this.LocationOfEvent = locationOfEvent;
            this.TicketsOnEvent = ticketsOnEvent;
        }
    }
}
