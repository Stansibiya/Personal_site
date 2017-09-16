using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TshepoSibiya.Models;

namespace TshepoSibiya.Controllers
{
    public class ManageController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        //
        // GET: /Manage/
        public ActionResult Profile(string FN)
        {
            ProfileModel me = db.profile.FirstOrDefault(x => x.ID == 2);
            return View(me);
        }
	}
}