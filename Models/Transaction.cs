using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication7.Models
{
    class Transaction
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public int Total { get; set; }
        public int Pay { get; set; }
        public int MoneyChange { get; set; }
    }
}
