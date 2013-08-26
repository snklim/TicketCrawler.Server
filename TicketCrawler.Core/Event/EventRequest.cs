using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace TicketCrawler.Core.Event
{
    [DataContract]
    public class EventRequest
    {
        [DataMember]
        public Guid RequestId { get; set; }
        [DataMember]
        public string SearchTerm { get; set; }
    }
}
