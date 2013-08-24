using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Core.Event
{
    public class EventRequest
    {
        public Guid RequestId { get; set; }
        public string SearchTerm { get; set; }
    }
}
