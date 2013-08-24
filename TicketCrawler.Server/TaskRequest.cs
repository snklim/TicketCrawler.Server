using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Server
{
    class TaskRequest
    {
        public Guid TaskId { get { return Request.RequestId; } }
        public Core.Event.EventRequest Request { get; set; }
        public List<Core.Event.EventResponse> Responses { get; set; }
        public List<Core.Worker.ITicketCrawlerWorker> Workers { get; set; }
    }
}
