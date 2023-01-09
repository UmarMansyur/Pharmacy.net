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
    public partial class Unit : MetroFramework.Forms.MetroForm
    {
        private Controllers.Medicine medicineController;
        private Controllers.Unit controllerUnit;

        private Models.Stock medicine = new Models.Stock();
        private Models.Unit unitObject = new Models.Unit();
        public Unit()
        {
            InitializeComponent();
            this.medicineController = new Controllers.Medicine();

            this.controllerUnit = new Controllers.Unit();
            MySqlDataReader data = this.controllerUnit.getUnit();

            while (data.Read())
            {
                satuan.Items.Add(new Helpers.ComboBox(int.Parse(data.GetString(0)), data.GetString(1)));
            }
            data.Close();
            fetchData();
        }
        private void fetchData()
        {
            try
            {
                dataGridView2.DataSource = medicineController.getAllData();
                dataGridView2.Columns["id"].Visible = false;
                dataGridView2.Columns["stockId"].Visible = false;
                dataGridView1.DataSource = controllerUnit.getAllData();
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                button3.Text = "Simpan";
                button3.BackColor = System.Drawing.Color.FromArgb(75, 166, 239);
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);
                throw;
            }
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = medicineController.getDataByName(name.Text);
                dataGridView2.Columns["id"].Visible = false;
                dataGridView2.Columns["stockId"].Visible = false;

            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            fetchData();
            name.Clear();
            purchase.Clear();
            sale.Clear();
            qty.Clear();
            satuan.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.medicine.MedicineId = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString());
                this.medicine.ParentId = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["stockId"].Value.ToString());
                this.medicine.Id = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["stockId"].Value.ToString());
                name.Text = dataGridView2.Rows[e.RowIndex].Cells["Nama Obat"].Value.ToString();
                qty.Text = dataGridView2.Rows[e.RowIndex].Cells["Jumlah"].Value.ToString();
                satuan.Text = dataGridView2.Rows[e.RowIndex].Cells["Satuan"].Value.ToString();
                purchase.Text = dataGridView2.Rows[e.RowIndex].Cells["Harga Beli"].Value.ToString();
                sale.Text = dataGridView2.Rows[e.RowIndex].Cells["Harga Jual"].Value.ToString();
                purchase.Enabled = true;
                sale.Enabled = true;
                iconButton2.Enabled = true;
                iconButton3.Enabled = true;
                iconButton1.Enabled = true;
            }
            catch (Exception error)
            {

                Utils.Notify.notifyError(error);
            }
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                controllerUnit.updateParent(contentBody());
                fetchData();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private Models.Stock contentBody()
        {
            Helpers.ComboBox unitSelected = (Helpers.ComboBox)satuan.SelectedItem;
            this.medicine.UnitId = unitSelected.Id;
            this.medicine.Qty = int.Parse(qty.Text);
            this.medicine.PurchasePrice = purchase.Text;
            this.medicine.SalePrice = sale.Text;
            return this.medicine;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                controllerUnit.update(contentBody());
                fetchData();
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
                throw;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView2.Rows.Count > 1)
                {
                    if(Utils.Notify.notifyDelete())
                    {
                        controllerUnit.delete(this.medicine.Id);
                    }
                }
                fetchData();

            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (button3.Text == "Tambah")
                {
                    this.unitObject.Name = textBox6.Text;
                    controllerUnit.create(this.unitObject);
                    
                }
                else
                {
                    this.unitObject.Name = textBox6.Text;
                    controllerUnit.updateUnit(this.unitObject);
                    button3.Text = "Tambah";
                    button3.BackColor = System.Drawing.Color.FromArgb(81, 86, 190);
                    this.unitObject.Name = "";
                    textBox6.Clear();
                }
                fetchData();
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);
                throw;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(Utils.Notify.notifyDelete())
                {
                    if (dataGridView1.RowCount > 1)
                    {
                        controllerUnit.deleteUnit(this.unitObject.Id);
                    }
                }
                fetchData();
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);
                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.unitObject.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
                this.unitObject.Name = dataGridView1.Rows[e.RowIndex].Cells["unit"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["unit"].Value.ToString();

                button3.Text = "Simpan";
                button3.BackColor = System.Drawing.Color.FromArgb(75, 166, 239);
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Text = "Tambah";
            button3.BackColor = System.Drawing.Color.FromArgb(81, 86, 190);
            textBox6.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if(textBox6.Text.Length > 0)
            {
                button3.Enabled = true;
                button1.Enabled = true;
            } else
            {
                button3.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void satuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (name.Text == "" || purchase.Text == "" || sale.Text == "" || qty.Text == "" || satuan.Text == "")
            {
                iconButton1.Enabled = false;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text == "" || purchase.Text == "" || sale.Text == "" || qty.Text == "" || satuan.Text == "")
            {
                iconButton1.Enabled = false;
            }
        }

        private void purchase_TextChanged(object sender, EventArgs e)
        {
            if (name.Text == "" || purchase.Text == "" || sale.Text == "" || qty.Text == "" || satuan.Text == "")
            {
                iconButton1.Enabled = false;
            }
        }

        private void sale_TextChanged(object sender, EventArgs e)
        {
            if (name.Text == "" || purchase.Text == "" || sale.Text == "" || qty.Text == "" || satuan.Text == "")
            {
                iconButton1.Enabled = false;
            }
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            if (name.Text == "" || purchase.Text == "" || sale.Text == "" || qty.Text == "" || satuan.Text == "")
            {
                iconButton1.Enabled = false;
            }
        }
    }
}
