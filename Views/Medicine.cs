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
    public partial class Medicine : MetroFramework.Forms.MetroForm
    {
        private Controllers.Medicine medicineController;
        private Controllers.Unit controllerUnit;
        private bool isClick = false;
        private string medicinesId;

        DataTable medicines = new DataTable();
        public Medicine()

        {
            InitializeComponent();
            this.medicineController = new Controllers.Medicine();

            this.controllerUnit = new Controllers.Unit();
            MySqlDataReader data = this.controllerUnit.getUnit();

            while (data.Read())
            {
                unit.Items.Add(new Helpers.ComboBox(int.Parse(data.GetString(0)), data.GetString(1)));
            }
            data.Close();

            enabledForm(false);



            fetchData();
            expired.Format = DateTimePickerFormat.Custom;
            expired.CustomFormat = "yyyy-MM-dd";

        }

        private void fetchData()
        {
            dataGridView1.DataSource = medicineController.getAllData();
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["stockId"].Visible = false;
        }

        private void clearForm()
        {
            name.Clear();
            registrasion_number.Clear();
            expired.Text = "";
            qty.Clear();
            sale.Clear();
            purchase.Clear();
            unit.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(insert.Text == "Tambah")
            {
                insert.Text = "Simpan";
                insert.BackColor = System.Drawing.Color.FromArgb(75, 166, 239);
                enabledForm(true);
                edit.Enabled = true;
                edit.Text = "Batal";
                edit.BackColor = System.Drawing.Color.Gray;

            }
            else if(isClick)
            {
                medicineController.update(contentBody(), int.Parse(medicinesId));
                isClick = false;
                changeButtonToTambah();

            }
            else
            {
                medicineController.create(contentBody());
                enabledForm(false);
                changeButtonToTambah();
                edit.Text = "Ubah";
                edit.BackColor = System.Drawing.Color.FromArgb(255, 191, 83);
                edit.Enabled = false;

            }
            clearForm();
            fetchData();
        }

        private void enabledForm(bool status)
        {
            groupBox1.Enabled = status;
            groupBox2.Enabled = status;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            medicinesId = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            name.Text = dataGridView1.Rows[e.RowIndex].Cells["Nama Obat"].Value.ToString();
            registrasion_number.Text = dataGridView1.Rows[e.RowIndex].Cells["No Registrasi"].Value.ToString();
            expired.Text = dataGridView1.Rows[e.RowIndex].Cells["Tanggal Kadaluarsa"].Value.ToString();
            qty.Text = dataGridView1.Rows[e.RowIndex].Cells["Jumlah"].Value.ToString();
            unit.Text = dataGridView1.Rows[e.RowIndex].Cells["Satuan"].Value.ToString();
            purchase.Text = dataGridView1.Rows[e.RowIndex].Cells["Harga Beli"].Value.ToString();
            sale.Text = dataGridView1.Rows[e.RowIndex].Cells["Harga Jual"].Value.ToString();
            edit.Enabled = true;
            delete.Enabled = true;
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            edit.Enabled = false;
            delete.Enabled = false;
            enabledForm(false);
        }

        private Models.Stock contentBody()
        {
            Models.Stock stock = new Models.Stock();
            stock.RegistrationNumber = registrasion_number.Text;
            stock.Name = name.Text;
            stock.Expired = expired.Text;
            Helpers.ComboBox unitSelected = (Helpers.ComboBox)unit.SelectedItem;
            stock.UnitId = unitSelected.Id;
            stock.Qty = int.Parse(qty.Text);
            stock.PurchasePrice = purchase.Text;
            stock.SalePrice = sale.Text;
            return stock;
        }

        private void changeButtonToTambah()
        {
            insert.Text = "Tambah";
            insert.BackColor = System.Drawing.Color.FromArgb(81, 86, 190);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount > 1)
            {
                if (edit.Text == "Batal")
                {
                    clearForm();
                    isClick = false;
                    edit.Text = "Ubah";
                    edit.BackColor = System.Drawing.Color.FromArgb(255, 191, 83);
                    changeButtonToTambah();
                    enabledForm(false);
                    insert.Enabled = true;
                    edit.Enabled = false;
                    delete.Enabled = false;
                } else
                {
                    insert.Text = "Simpan";
                    insert.BackColor = System.Drawing.Color.FromArgb(75, 166, 239);
                    edit.Text = "Batal";
                    edit.BackColor = System.Drawing.Color.Gray;
                    enabledForm(true);
                    isClick = true;
                    delete.Enabled = false;
                }
               
            }
            else
            {
                Utils.Notify.notifyError(null, "Data Kosong");
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                if(Utils.Notify.notifyDelete())
                {
                    medicineController.delete(int.Parse(medicinesId));
                    clearForm();
                    fetchData();
                }
            } else
            {
                Utils.Notify.notifyError(null, "Data Kosong");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage.menu.redirectUnit();
        }
    }
}
