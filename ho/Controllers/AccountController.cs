using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ho.ViewModel;
using ho.Models;
using ho.Security;
namespace ho.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            if (SessionPersister.Username != null)
            {
                return RedirectToAction("Authenticated");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
            var account = new AccountModel();

            if (string.IsNullOrEmpty(avm.Account.Username) ||
                string.IsNullOrEmpty(avm.Account.Password) ||
                account.login(avm.Account.Username, avm.Account.Password) == null)
            {
                ViewBag.Error = "Account Invalid";
                return View("Index");
            }else
            {
                SessionPersister.Username = avm.Account.Username;
                return View("Success");
            }
            
        }

        public ActionResult Authenticated()
        {
            if (SessionPersister.Username != null)
            {
                return View("Success");
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
        }

        public ActionResult Logout()
        {
            SessionPersister.Username = null;
            return RedirectToAction("Index");
        }
    }
}