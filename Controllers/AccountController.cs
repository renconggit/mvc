using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo1.Controllers
{
	public class AccountController : Controller
	{
		// GET: Account
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult Login()
		{
			ViewBag.state = "登录前啊..................";
			return View();
		}
		[HttpPost]
		public ActionResult Login(FormCollection fc)
		{
			string email = fc["inputEmail3"];
			string pwd = fc["inputPassword3"];
			ViewBag.state = "登录后前啊.................."+ email+"___"+ pwd;
			return View();
		}
		public ActionResult Register()
		{
			return View();
		}
	}
}