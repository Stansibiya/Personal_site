﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TshepoSibiya.Controllers
{
    public class AccountManagerController : Controller
    {
        //
        // GET: /AccountManager/
        public ActionResult Login()
        {
            return View();
        }
    }
}