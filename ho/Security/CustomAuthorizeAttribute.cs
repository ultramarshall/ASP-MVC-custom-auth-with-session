using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ho.Security;
using ho.Models;
namespace ho.Security
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (string.IsNullOrEmpty(SessionPersister.Username))
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new
                        {
                            controller  = "Account",
                            action      = "Index"
                        }));
            }
            else
            {
                var AccountModel = new AccountModel();
                var CustomPrincipal = new CustomPrincipal(
                    AccountModel.find(SessionPersister.Username)
                );
                if (!CustomPrincipal.IsInRole(Roles))
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new
                            {
                                controller  = "AccessDenied",
                                action      = "Index"
                            }));
                }

            }
        }
    }
}