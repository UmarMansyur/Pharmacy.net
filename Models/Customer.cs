using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication7.Models
{
    class Customer
    {
        private string name;
        private string address;
        private string no_telp;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string NoTelp
        {
            get { return no_telp; }
            set { no_telp = value; }
        }
    }
}
