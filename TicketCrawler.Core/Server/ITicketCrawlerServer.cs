using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TicketCrawler.Core.Server
{
    [ServiceContract]
    public interface ITicketCrawlerServer
    {
        [OperationContract(IsOneWay = true)]
        void RegisterWorker(string workerEndpointUrl);

        [OperationContract(IsOneWay=true)]
        void MakeRequest(Core.Event.EventRequest request);
    }
}
