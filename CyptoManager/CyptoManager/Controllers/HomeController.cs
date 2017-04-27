using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Silvio.Service;
using Silvio.Service.DataConnector;
using SilvioSite.Service.DataConnector;

namespace CyptoManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
