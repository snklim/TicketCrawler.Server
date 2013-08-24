using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Core.Feeder
{
    public interface IFeeder
    {
        Task<Event.EventResponse> GetTicketsOnEvents(Event.EventRequest eventRequest);
    }
}
