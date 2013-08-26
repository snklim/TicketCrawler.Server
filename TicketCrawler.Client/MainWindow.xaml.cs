using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ServiceModel;

namespace TicketCrawler.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_DoSearch(object sender, RoutedEventArgs e)
        {
            var server = new TicketCrawlerServer.TicketCrawlerServerClient(new InstanceContext(new TicketCrawlerServerCallback()));
            server.MakeRequest(new Core.Event.EventRequest { RequestId = Guid.NewGuid(), SearchTerm = tbDoSearch.Text });
        }
    }

    public class TicketCrawlerServerCallback : TicketCrawlerServer.ITicketCrawlerServerCallback
    {
        public void ReturnResponse(Core.Event.EventResponse response)
        {
            
        }
    }
}
