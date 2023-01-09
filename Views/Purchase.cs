using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7.Views
{
    public partial class Purchase : MetroFramework.Forms.MetroForm
    {


        DataTable medicines = new DataTable();

        Controllers.Unit controllerUnit = new Controllers.Unit();

        Controllers.Purchase controllerPurchase;

        bool isClick = false;

        public Purchase()
        {
            InitializeComponent();
            enabledButton();
            this.controllerPurchase = new Controllers.Purchase();
            MySqlDataReader data = controllerUnit.getUnit();
            while (data.Read())
            {
                unit.Items.Add(data.GetString(1));
            }
            data.Close();

            expired.Format = DateTimePickerFormat.Custom;
            expired.CustomFormat = "yyyy-MM-dd";

            tanggal.Format = DateTimePickerFormat.Custom;
            tanggal.CustomFormat = "yyyy-MM-dd";

            addColumns();
            listMedicines.DataSource = medicines;

        }

        public void addColumns()
        {
            medicines.Columns.Add("Nama Obat");
            medicines.Columns.Add("No. Registrasi");
            medicines.Columns.Add("Harga Beli");
            medicines.Columns.Add("Harga Jual");
            medicines.Columns.Add("Tanggal Kadaluarsa");
            medicines.Columns.Add("Jumlah");
            medicines.Columns.Add("Satuan");
        }

        public void enabledButton()
        {
            if (medicines.Rows.Count < 1 || name.Text == "" || handphone.Text == "" || address.Text == "")
            {
                save.Enabled = false;
            } else
            {
                save.Enabled = true;
            }
        }

        private void disableButtonInsert()
        {
            if (medicine.Text == "" || price.Text == "" || sale.Text == "" || registration.Text == "" || expired.Text == "" || quantity.Text == "" || unit.Text == "" )
            {
                insert.Enabled = false;
            } else
            {
                insert.Enabled = true;
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                if(isClick)
                {
                    medicines.Rows[listMedicines.CurrentRow.Index]["Nama Obat"] = medicine.Text;
                    medicines.Rows[listMedicines.CurrentRow.Index]["No. Registrasi"] = registration.Text;
                    medicines.Rows[listMedicines.CurrentRow.Index]["Harga Beli"] = price.Text;
                    medicines.Rows[listMedicines.CurrentRow.Index]["Harga Jual"] = sale.Text;
                    medicines.Rows[listMedicines.CurrentRow.Index]["Tanggal Kadaluarsa"] = expired.Text;
                    medicines.Rows[listMedicines.CurrentRow.Index]["Jumlah"] = quantity.Text;
                    medicines.Rows[listMedicines.CurrentRow.Index]["Satuan"] = unit.SelectedItem.ToString();
                    isClick = false;
                } else
                {
                    string[] data = new string[7];
                    data[0] = medicine.Text;
                    data[1] = registration.Text;
                    data[2] = price.Text;
                    data[3] = sale.Text;
                    data[4] = expired.Text;
                    data[5] = quantity.Text;
                    data[6] = unit.SelectedItem.ToString();
                                   
                    medicines.Rows.Add(data);
                    save.Enabled = true;
                }
               
                clearForm();
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);
                throw;
            }
            enabledButton();
            ceckCost();

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            insert.Enabled = false;
        }

        private void enabledForm(bool status)
        {
            medicine.Enabled = status;
            registration.Enabled = status;
            price.Enabled = status;
            sale.Enabled = status;
            expired.Enabled = status;
            quantity.Enabled = status;
            unit.Enabled = status;
            insert.Enabled = status;

        }
        private void clearForm()
        {
            medicine.Clear();
            price.Clear();
            sale.Clear();
            registration.Clear();
            expired.Text = "";
            quantity.Clear();
            totalHarga.Clear();
            qtymd.Clear();
            tanggal.Text = "";
            unit.Text = "";
            name.Clear();
            handphone.Clear();
            address.Clear();

        }

        private void listMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            medicine.Text = listMedicines.CurrentRow.Cells[0].Value.ToString();
            registration.Text = listMedicines.CurrentRow.Cells[1].Value.ToString();
            price.Text = listMedicines.CurrentRow.Cells[2].Value.ToString();
            sale.Text = listMedicines.CurrentRow.Cells[3].Value.ToString();
            expired.Text = listMedicines.CurrentRow.Cells[4].Value.ToString();
            quantity.Text = listMedicines.CurrentRow.Cells[5].Value.ToString();
            unit.Text = listMedicines.CurrentRow.Cells[6].Value.ToString();

            edit.Enabled = true;
            hapus.Enabled = true;
            enabledForm(false);
            
        }

        private void edit_Click(object sender, EventArgs e)
        {
            
            if(edit.Text == "Batal")
            {
                edit.Text = "Edit";
                edit.BackColor = System.Drawing.Color.FromArgb(255, 191, 83);
                insert.Enabled = true;
                clearForm();
                isClick = false;
                edit.Enabled = false;

            }
            else
            {
                edit.Enabled = true;
                edit.Text = "Batal";
                edit.BackColor = Color.Gray;
                enabledForm(true);
                isClick = true;
                insert.Enabled = true;

            }
        }

        private void hapus_Click(object sender, EventArgs e)
        {

            if(Utils.Notify.notifyDelete())
            {
                int i = listMedicines.CurrentRow.Index;
                if (listMedicines.RowCount > 0)
                {
                    medicines.Rows[i].Delete();
                    clearForm();
                    edit.Enabled = false;
                    hapus.Enabled = false;
                    enabledForm(true);
                    hapus.Enabled = false;
                } else
                {
                    Utils.Notify.notifyError(null, "Data Kosong!");
                }
            }

            
        }

        private void save_Click(object sender, EventArgs e)
        {
            enabledButton();
            ceckCost();
            listMedicines.AllowUserToAddRows = false;

            Models.Supplier supplier = new Models.Supplier();
            supplier.Name = name.Text;
            supplier.NoTelp = handphone.Text;
            supplier.Address = address.Text;

            int supplier_id = controllerPurchase.createSupplier(supplier);

            Models.WholeSale wholeSale = new Models.WholeSale();

            wholeSale.date = tanggal.Text;
            wholeSale.total = totalHarga.Text;
            int wholeSale_id = controllerPurchase.createWholeSale(supplier_id, wholeSale);

            controllerPurchase.createDetailWholeSale(wholeSale_id, listMedicines);

            listMedicines.DataSource = null;

            medicines = new DataTable();
            addColumns();

            listMedicines.DataSource = medicines;
            clearForm();

        }

        private void unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            disableButtonInsert();

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            enabledButton();
        }

        private void handphone_TextChanged(object sender, EventArgs e)
        {
            enabledButton();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            enabledButton();
        }

        private void ceckCost()
        {
            
            int total = 0;
            listMedicines.AllowUserToAddRows = false;

            foreach (DataGridViewRow data in listMedicines.Rows)
            {
                
                total = total + int.Parse(data.Cells["Harga Beli"].Value.ToString());
            }

            qtymd.Text = medicines.Rows.Count.ToString();
            totalHarga.Text = total.ToString();
        }

        private void medicine_TextChanged(object sender, EventArgs e)
        {
            disableButtonInsert();
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            disableButtonInsert();

        }

        private void sale_TextChanged(object sender, EventArgs e)
        {
            disableButtonInsert();

        }

        private void registration_TextChanged(object sender, EventArgs e)
        {
            disableButtonInsert();

        }

        private void expired_ValueChanged(object sender, EventArgs e)
        {
            disableButtonInsert();

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            disableButtonInsert();

        }
    }
}
