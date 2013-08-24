using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Core.Model
{
    public class Location
    {
        public Guid LocationId { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
    }
}
