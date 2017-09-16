using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TshepoSibiya.Models;
using TshepoSibiya.Models;

namespace TshepoSibiya.Controllers
{
    public class ContentController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Content/
        [HttpGet]
        public ActionResult Experience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Experience(int? Id)
        {
            var data = db.Contents.Where(x => x.Technology != null).ToList();
            //System.Threading.Thread.Sleep(2000);
            return Json(data);
        }
    }
}