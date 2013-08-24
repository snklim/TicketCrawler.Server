using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Core.Model
{
    public class Ticket
    {
        public Guid TicketId { get; set; }
        public string Sector { get; set; }
        public string Row { get; set; }
        public string Price { get; set; }
        
        public Event Event { get; set; }
    }
}
