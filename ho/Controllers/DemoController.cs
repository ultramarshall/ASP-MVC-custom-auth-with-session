using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ho.Security;
using ho.Models;

namespace ho.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorize(Roles = "emplooye")]
        public ActionResult Work1()
        {
            return View("Work1");
        }

        [CustomAuthorize(Roles = "admin")]
        public ActionResult Work2()
        {
            return View("Work2");
        }

        [CustomAuthorize(Roles = "superadmin, admin, emplooye")]
        public ActionResult Work3()
        {
            return View("Work3");
        }
    }
}