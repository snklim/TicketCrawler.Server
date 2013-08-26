using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TicketCrawler.Core.Event
{
    [DataContract]
    public class EventResponse
    {
        [DataContract]
        public enum EventRequestProcessedStatus
        {
            SUCCESS,
            FAILURE
        }

        [DataMember]
        public EventRequest Request { get; set; }
        [DataMember]
        public EventRequestProcessedStatus RequestProcessedStatus { get; set; }
        [DataMember]
        public List<Model.Event> TicketsOnEvents { get; set; }
    }
}
