using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Silvio.Service;
namespace CyptoManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PoloniexConnector con = new PoloniexConnector();
            con.SetupConnection();
            return View();
        }
    }
}
