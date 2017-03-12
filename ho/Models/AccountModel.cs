using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ho.Models
{
    public class AccountModel
    {
        private List<Account> listaccount = new List<Account>();

        public AccountModel()
        {
            listaccount.Add(new Account { Username = "acc1", Password = "123", Roles = new string[] { "superadmin", "admin", "emplooye" } });
            listaccount.Add(new Account { Username = "acc2", Password = "123", Roles = new string[] { "admin" } });
            listaccount.Add(new Account { Username = "acc3", Password = "123", Roles = new string[] { "emplooye" } });
        }

        public Account find(string username)
        {
            return listaccount.Where(acc => acc.Username.Equals(username)).FirstOrDefault();
        }

        public Account login(string username, string password)
        {
            return listaccount.Where(acc => acc.Username.Equals(username) && acc.Password.Equals(password)).FirstOrDefault();
        }

    }
}