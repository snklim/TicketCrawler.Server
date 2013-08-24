using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TickerCrawler.WebTicketSiteOne.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoSearch(string searchStr, int start, int rows)
        {
            return View();
        }

    }
}
