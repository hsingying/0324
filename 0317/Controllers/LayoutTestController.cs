using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0317.Controllers
{
    public class LayoutTestController : Controller
    {
        /// <summary>
        /// 主版頁面測試
        /// </summary>
        /// <returns></returns>
        // GET: LayoutTest
        public ActionResult Index()
        {
            return View();
        }
    }
}

