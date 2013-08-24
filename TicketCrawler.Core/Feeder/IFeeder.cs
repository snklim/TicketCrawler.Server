using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Core.Feeder
{
    public interface IFeeder
    {
        Model.BatchOfTickets GetTicketsOnEvent(string searchTerm);
    }
}
