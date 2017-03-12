using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using ho.Models;

namespace ho.Security
{
    public class CustomPrincipal : IPrincipal
    {
        private Account Account;

        public CustomPrincipal(Account Account)
        {
            this.Account = Account;
            this.Identity = new GenericIdentity(Account.Username);
        }

        public IIdentity Identity { get; set; }

        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ',' });
            return roles.Any(r => this.Account.Roles.Contains(r));
        }
    }
}