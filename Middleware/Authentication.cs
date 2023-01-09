using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication7.Middleware
{
    static class Authentication
    {
        public static Models.User user = new Models.User();

        public static bool isLogin()
        {
            if (user.Username != null && user.Password != null && user.Role != null)
            {
                return true;
            }
            return false;
        }

        public static bool isAdmin()
        {
            if (user.Role != "admin")
            {
                return false;
            }
            return true;
        }
    }
}
