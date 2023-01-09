using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication7.Models
{
    class TransactionDetail
    {
        private int transaction_id;
        private int medicine_id;
        private int qty;
        private double price;

        public int TransactionId
        {
            get { return transaction_id; }
            set { transaction_id = value; }
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

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
