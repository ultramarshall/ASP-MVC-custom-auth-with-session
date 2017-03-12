using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ho.Security
{
    public static class SessionPersister
    {
        static string usernameSessionvar = "username";

        public static string Username
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;
                var SessionVar = HttpContext.Current.Session[usernameSessionvar];
                if (SessionVar != null)
                    return SessionVar as string;
                return null;
            }
            set
            {
                HttpContext.Current.Session[usernameSessionvar] = value;
            }
        }
    }
}