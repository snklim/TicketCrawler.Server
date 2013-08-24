using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Core.Event
{
    public class EventResponse
    {
        public enum EventRequestProcessedStatus
        {
            SUCCESS,
            FAILURE
        }

        public EventRequest Request { get; set; }

        public EventRequestProcessedStatus RequestProcessedStatus { get; set; }
        public List<Model.Event> TicketsOnEvents { get; set; }
    }
}
