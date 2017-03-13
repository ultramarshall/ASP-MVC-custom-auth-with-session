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
        // GET: Account
        public ActionResult Index()
        {
            if (SessionPersister.Username == String.Empty)
            {
                return View();
            }
            else
            {
                return View("Success");
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
            }
            SessionPersister.Username = avm.Account.Username;
            Session["nama"] = "marshall";
            return View("Success");
        }

        public ActionResult Logout()
        {
            SessionPersister.Username = String.Empty;
            return RedirectToAction("Index");
        }
    }
}