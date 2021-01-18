using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CineCartelera.Controllers
{
    public class CineController : Controller
    {
        // GET: Cine
        public ActionResult Index()
        {
            return View();
        }
    }
}