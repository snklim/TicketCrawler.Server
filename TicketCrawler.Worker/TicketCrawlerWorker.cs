using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace TicketCrawler.Worker
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class TicketCrawlerWorker : Core.Worker.ITicketCrawlerWorker
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private TicketCrawlerServer.TicketCrawlerServerClient _server;

        public TicketCrawlerWorker()
        {
            _server = new TicketCrawlerServer.TicketCrawlerServerClient(new InstanceContext(new TicketCrawlerServerCallback()));
            _server.RegisterWorker("http://localhost:8733/TicketCrawlerWorker");
        }

        public void AssigneRequest(Core.Event.EventRequest request)
        {
            log.Info("The AssigneRequest called");
            Core.Feeder.IFeeder feeder = new Feeders.FakeFeeder();
            Task<Core.Event.EventResponse> response = feeder.GetTicketsOnEvents(request);
            response.Result.Request = request;

            _server.ProcessResponseFromWorker(response.Result);
        }
    }

    public class TicketCrawlerServerCallback : Core.Server.ITicketCrawlerServerCallback
    {
        public void ReturnResponse(Core.Event.EventResponse response)
        {
            throw new NotImplementedException();
        }
    }
}
