using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication7.Models
{
    class Supplier
    {
        private int supplier_id;
        private string name;
        private string address;
        private string no_telp;

        public int SupplierId
        {
            get { return supplier_id; }
            set { supplier_id = value; }
        }

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
