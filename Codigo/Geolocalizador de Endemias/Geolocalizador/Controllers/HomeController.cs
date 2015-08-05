using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Geolocalizador.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Authorize(Roles = "Administrator, Operator")]
        public ActionResult Index()
        {
            return View();
        }
    }
}