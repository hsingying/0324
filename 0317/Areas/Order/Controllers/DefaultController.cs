using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSale.Areas.Order.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Order/Default
        public ActionResult Index()
        {
            ViewBag.Desc = "hello order";
            return View();
        }
    }
}