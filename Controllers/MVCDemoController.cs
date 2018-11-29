using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo1.Controllers
{
    public class MVCDemoController : Controller
    {
        // GET: MVCDemo
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult ShowWidget() {
            return PartialView("~/Views/Shared/_PartialPageWidget.cshtml");
        }
    }
}