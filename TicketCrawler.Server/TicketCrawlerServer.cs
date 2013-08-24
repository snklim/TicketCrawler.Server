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

        private Dictionary<Guid, TaskRequest> _tasks = new Dictionary<Guid, TaskRequest>();

        public void RegisterWorker(string workerEndpointUrl)
        {
            log.Info("The RegisterWorker called");
            _workers.Add(new ChannelFactory<Core.Worker.ITicketCrawlerWorker>(new BasicHttpBinding(), new EndpointAddress(workerEndpointUrl)).CreateChannel());
        }

        public void MakeRequest(Core.Event.EventRequest request)
        {
            log.Info("The MakeRequest called");

            TaskRequest taskRequest = new TaskRequest
            {
                Request = request,
                Workers = _workers.ToList(),
                Responses = new List<Core.Event.EventResponse>()
            };

            _tasks.Add(taskRequest.TaskId, taskRequest);

            ProsessTaskRequest(taskRequest);
        }

        public void ProcessResponseFromWorker(Core.Event.EventResponse response)
        {
            if (response.RequestProcessedStatus == Core.Event.EventResponse.EventRequestProcessedStatus.SUCCESS)
            {
            }
            else
            {
                var taskRequest = _tasks[response.Request.RequestId];
                ProsessTaskRequest(taskRequest);
            }
        }

        private void ProsessTaskRequest(TaskRequest taskRequest)
        {
            if (taskRequest.Workers.Count > 0)
            {
                var worker = taskRequest.Workers[0];
                worker.AssigneRequest(taskRequest.Request);
                taskRequest.Workers.RemoveAt(0);
            }
        }
    }
}
