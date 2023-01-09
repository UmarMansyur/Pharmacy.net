using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication7.Utils
{
    static class Roles
    {
        private static readonly string admin = "admin";
        private static readonly string customer = "customer_services";

        public static string GetAdmin()  
        {
            return admin;
        }

        public static string GetCustomer()
        {
            return customer;
        }
    }
}
