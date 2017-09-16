using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TshepoSibiya.Context;
using TshepoSibiya.Models;

namespace TshepoSibiya.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Main()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SendEmail()
        {
            var messageModel = new EmailMessage();
            return View(messageModel);
        }
        [HttpPost]
        public ActionResult SendEmail(EmailMessage emailmessage)
        {
            if(ModelState.IsValid)
            {
                db.Messages.Add(emailmessage);
                db.SaveChanges();
                ViewBag.Message = "Email sent!";
                System.Threading.Thread.Sleep(3000);
                return RedirectToAction("Main","Home");
            }
            return View();
        }
        
        [HttpGet]

        public ActionResult Login()
        {
            //LoginModel login = new LoginModel();
            return View();
        }
        [HttpPost]
        //public ActionResult Login(LoginModel login)
        //{
        //    //var username = login.Username;
        //    var user = db.Logins.Where(x => x.Username == login.Username || x.Email == login.Email && x.Password == login.Password).SingleOrDefault();
        //    if(user != null)
        //    {
        //        Session["sessionName"] = user.Username + "-UX-" + user.ID;
        //        ViewBag.Data = Session["sessionName"];
        //        return View("Manage");
        //    }
            
        //    return View();
        //}
        public ActionResult Manage()
        {
            return View();
        }

        public ActionResult RegisterSample()
        {
            return View();
        }
    }
}