using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication7.Models
{
    class Stock : Medicine
    {
        private int medicine_id;
        private int unit_id;
        private int parent_id;
        private int qty;
        private string purchase_price;
        private string sale_price;


        public int Id { get; set; }
        public int MedicineId
        {
            get { return medicine_id; }
            set { medicine_id = value; }
        }

        public int UnitId
        {
            get { return unit_id; }
            set { unit_id = value; }
        }

        public int ParentId
        {
            get { return parent_id; }
            set { parent_id = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public string PurchasePrice
        {
            get { return purchase_price; }
            set { purchase_price = value; }
        }

        public string SalePrice
        {
            get { return sale_price; }
            set { sale_price = value; }
        }

    }
}
