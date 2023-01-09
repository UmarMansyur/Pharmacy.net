using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication7.Models
{
    class WholeSaleDetail
    {
        private int wholesale_id;
        private int medicine_id;
        private int qty;
        private int price;

        public int WholeSaleId
        {
            get { return wholesale_id; }
            set { wholesale_id = value; }
        }

        public int MedicineId
        {
            get { return medicine_id; }
            set { medicine_id = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
