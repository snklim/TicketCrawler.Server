using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Core.Model
{
    public class Event
    {
        public Guid EventId { get; set; }
        public DateTime DateOfEvent { get; set; }
    }
}
