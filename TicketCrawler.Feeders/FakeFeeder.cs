using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCrawler.Feeders
{
    public class FakeFeeder : TicketCrawler.Core.Feeder.IFeeder
    {
        public Task<Core.Event.EventResponse> GetTicketsOnEvents(Core.Event.EventRequest eventRequest)
        {
            TaskCompletionSource<Core.Event.EventResponse> tcs = new TaskCompletionSource<Core.Event.EventResponse>();

            tcs.SetResult(new Core.Event.EventResponse
            {
                RequestProcessedStatus = Core.Event.EventResponse.EventRequestProcessedStatus.SUCCESS,
                TicketsOnEvents = new List<Core.Model.Event>
                {
                    new Core.Model.Event
                    {
                        DateOfEvent = DateTime.Now,
                        Location = new Core.Model.Location
                        {
                            Name = "Wilson Theatre",
                            State = "US",
                            Town = "New York"
                        },
                        Tickets = new List<Core.Model.Ticket>
                        {
                            new Core.Model.Ticket
                            {
                                Sector = "Orchestra Rear Sides M-ZZ",
                                Row = "Row Z  |  Seats Guaranteed together",
                                Price = "127.99"
                            },
                            new Core.Model.Ticket
                            {
                                Sector = "Orchestra Rear Sides M-ZZ",
                                Row = "Row Z  |  Seats Guaranteed together",
                                Price = "127.99"
                            },
                            new Core.Model.Ticket
                            {
                                Sector = "Orchestra Rear Sides M-ZZ",
                                Row = "Row Z  |  Seats Guaranteed together",
                                Price = "127.99"
                            },
                            new Core.Model.Ticket
                            {
                                Sector = "Orchestra Rear Sides M-ZZ",
                                Row = "Row Z  |  Seats Guaranteed together",
                                Price = "127.99"
                            },
                            new Core.Model.Ticket
                            {
                                Sector = "Orchestra Rear Sides M-ZZ",
                                Row = "Row Z  |  Seats Guaranteed together",
                                Price = "127.99"
                            }
                        }
                    }
                }
            });

            return tcs.Task;
        }
    }
}
