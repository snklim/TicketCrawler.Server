using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TicketCrawler.Core.Server
{
    [ServiceContract(CallbackContract = typeof(ITicketCrawlerServerCallback))]
    public interface ITicketCrawlerServer
    {
        [OperationContract(IsOneWay = true)]
        void RegisterWorker(string workerEndpointUrl);

        [OperationContract(IsOneWay = true)]
        void MakeRequest(Core.Event.EventRequest request);

        [OperationContract(IsOneWay = true)]
        void ProcessResponseFromWorker(Core.Event.EventResponse response);
    }

    public interface ITicketCrawlerServerCallback
    {
        [OperationContract(IsOneWay = true)]
        void ReturnResponse(Core.Event.EventResponse response);
    }
}
