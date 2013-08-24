using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TicketCrawler.Core.Worker
{
    [ServiceContract]
    public interface ITicketCrawlerWorker
    {
        [OperationContract(IsOneWay=true)]
        void AssigneRequest(Core.Event.EventRequest request);
    }
}
