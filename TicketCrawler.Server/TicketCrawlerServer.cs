using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TicketCrawler.Server
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class TicketCrawlerServer : Core.Server.ITicketCrawlerServer
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private List<Core.Worker.ITicketCrawlerWorker> _workers = new List<Core.Worker.ITicketCrawlerWorker>();

        public void RegisterWorker(string workerEndpointUrl)
        {
            log.Info("The RegisterWorker called");
            _workers.Add(new ChannelFactory<Core.Worker.ITicketCrawlerWorker>(new WSDualHttpBinding(), new EndpointAddress(workerEndpointUrl)).CreateChannel());
        }

        public void MakeRequest(Core.Event.EventRequest request)
        {
            log.Info("The MakeRequest called");

            foreach (var worker in _workers)
                worker.AssigneRequest(request);
        }
    }
}
