using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketCrawler.Core.Feeder.IFeeder feeder = new TicketCrawler.Feeders.FakeFeeder();
            TicketCrawler.Core.Model.BatchOfTickets batch = feeder.GetTicketsOnEvent("Jersey Boys");
        }
    }
}
