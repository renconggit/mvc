using MvcDemo1.DAL;
using MvcDemo1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo1.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext db = new AccountContext();
        // GET: Account
        public ActionResult Index()
        {
            return View(db.SysUsers);
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
            var user = db.SysUsers.Where(b => b.Email == email & b.Password == pwd);
            if (user.Count() > 0)
            {
                ViewBag.state = "登陆成功";
            }
            else
            {
                ViewBag.state = "用户名不存在或者密码不正确";
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            return View(db.SysUsers.Find(id));
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SysUser sysuser)
        {
            db.SysUsers.Add(sysuser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id) {
            SysUser s= db.SysUsers.Find(id);
            return View(s);
        }
        [HttpPost]
        public ActionResult Edit(SysUser sysuser)
        {
            db.Entry(sysuser).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            SysUser sysUser = db.SysUsers.Find(id);
            return View(sysUser);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SysUser sysUser = db.SysUsers.Find(id);
            db.SysUsers.Remove(sysUser);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}