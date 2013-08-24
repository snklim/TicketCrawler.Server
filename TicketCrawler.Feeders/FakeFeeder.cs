using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Feeders
{
    public class FakeFeeder : TicketCrawler.Core.Feeder.IFeeder
    {
        public Core.Model.BatchOfTickets GetTicketsOnEvent(string searchTerm)
        {
            Core.Model.BatchOfTickets batch = new Core.Model.BatchOfTickets(
                new Core.Model.Event { EventId = Guid.NewGuid(), DateOfEvent = DateTime.Now },
                new Core.Model.Location { LocationId = Guid.NewGuid(), Name = "Wilson Theatre", State = "US", Town = "New York" },
                new List<Core.Model.Ticket>{
                    new Core.Model.Ticket
                    { 
                        TicketId = Guid.NewGuid(),
                        Sector = "Orchestra Rear Sides M-ZZ",
                        Row = "Row Z  |  Seats Guaranteed together",
                        Price = "127.99"
                    },
                    new Core.Model.Ticket
                    { 
                        TicketId = Guid.NewGuid(),
                        Sector = "Orchestra Rear Sides M-ZZ",
                        Row = "Row Z  |  Seats Guaranteed together",
                        Price = "127.99"
                    },
                    new Core.Model.Ticket
                    { 
                        TicketId = Guid.NewGuid(),
                        Sector = "Orchestra Rear Sides M-ZZ",
                        Row = "Row Z  |  Seats Guaranteed together",
                        Price = "127.99"
                    },
                    new Core.Model.Ticket
                    { 
                        TicketId = Guid.NewGuid(),
                        Sector = "Orchestra Rear Sides M-ZZ",
                        Row = "Row Z  |  Seats Guaranteed together",
                        Price = "127.99"
                    },
                    new Core.Model.Ticket
                    { 
                        TicketId = Guid.NewGuid(),
                        Sector = "Orchestra Rear Sides M-ZZ",
                        Row = "Row Z  |  Seats Guaranteed together",
                        Price = "127.99"
                    }
                });
            return batch;
        }
    }
}
