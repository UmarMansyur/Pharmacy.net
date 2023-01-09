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
    public partial class Transaction : MetroFramework.Forms.MetroForm
    {
        private Controllers.Medicine medicineController;
        private Controllers.Unit controllerUnit;
        private Controllers.Transaction transactionController;

        private Models.Customer customerModel;
        private Models.Transaction transactionModel;

        private string medicineStockId;
        private string medicineId;


        DataTable medicines = new DataTable();
        DataTable TableTransactions = new DataTable();



        public Transaction()
        {
            InitializeComponent();
            this.medicineController = new Controllers.Medicine();
            this.controllerUnit = new Controllers.Unit();
            this.transactionController = new Controllers.Transaction();

            this.transactionModel = new Models.Transaction();


            MySqlDataReader data = this.controllerUnit.getUnit();

            while (data.Read())
            {
                satuan.Items.Add(new Helpers.ComboBox(int.Parse(data.GetString(0)), data.GetString(1)));
            }
            data.Close();
            fetchData();
            addColumnTransactions();


            Transactions.DataSource = TableTransactions;
            Transactions.Columns["id"].Visible = false;
            Transactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Transactions.AllowUserToAddRows = false;
            Medicines.AllowUserToAddRows = false;
            this.customerModel = new Models.Customer();
        }

        private void addColumnTransactions()
        {
            TableTransactions.Columns.Add("id");
            TableTransactions.Columns.Add("Nama Obat");
            TableTransactions.Columns.Add("Satuan");
            TableTransactions.Columns.Add("Jumlah");
            TableTransactions.Columns.Add("Harga");

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void fetchData()
        {
            Medicines.DataSource = medicineController.getAllData();
            Medicines.Columns["id"].Visible = false;
            Medicines.Columns["stockId"].Visible = false;
            Medicines.Columns["Tanggal Kadaluarsa"].Visible = false;
            Medicines.Columns["No Registrasi"].Visible = false;
            Medicines.Columns["stockId"].Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Medicines.DataSource = medicineController.getDataByName(namaobat.Text);
                Medicines.Columns["id"].Visible = false;
                Medicines.Columns["stockId"].Visible = false;

            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(namaobat.TextLength > 0)
            {
                button2.Enabled = true;
            } 
            else
            {

                button2.Enabled = false;
            }
            enableCartButton();
        }

        private void Medicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Medicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineStockId = Medicines.Rows[e.RowIndex].Cells["stockId"].Value.ToString();
                namaobat.Text = Medicines.Rows[e.RowIndex].Cells["Nama Obat"].Value.ToString();
                harga.Text = Medicines.Rows[e.RowIndex].Cells["Harga Jual"].Value.ToString();
                medicineId = Medicines.Rows[e.RowIndex].Cells["id"].Value.ToString();
                jumlah.Enabled = true;
                satuan.Enabled = true;
                
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);
                throw;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {

                int unitId = int.Parse(((Helpers.ComboBox)satuan.SelectedItem).Id.ToString());
                if(this.transactionController.cekStock(int.Parse(medicineStockId), int.Parse(jumlah.Text), unitId))
                {
                    string totalHarganya = (int.Parse(jumlah.Text) * int.Parse(harga.Text)).ToString();
                    string[] row = new string[] {
                        medicineId,
                        namaobat.Text, 
                        satuan.Text, 
                        jumlah.Text,
                        totalHarganya
                    };
                    TableTransactions.Rows.Add(row);

                    clearForm();
                    int total = 0;
                    foreach (DataGridViewRow item in Transactions.Rows)
                    {
                        total += int.Parse(item.Cells["Harga"].Value.ToString());
                    }
                    totalharga.Text = total.ToString();

                    
                    


                } else
                {
                    Utils.Notify.notifyError(null, "Stok tidak tersedia");

                }
                    fetchData();
            }
            catch (Exception Error)
            {

                throw;
            }
        }

        private void enableCartButton()
        {
            if (jumlah.Text == "" || namaobat.Text == "" || harga.Text == "" || satuan.Text == "")
            {
                keranjang.Enabled = false;
            }
            else
            {
                keranjang.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            enableCartButton();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            enableCartButton();

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableCartButton();

        }

        public void clearForm()
        {
            pembeli.Text = "";
            alamat.Text = "";
            hp.Text = "";
            totalharga.Text = "";
            bayar.Text = "";
            kembali.Text = "";
            jumlah.Text = "";
            namaobat.Text = "";
            harga.Text = "";
            satuan.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TableTransactions.Rows.Count > 0)
                {
                    this.customerModel.Name = pembeli.Text;
                    this.customerModel.Address = alamat.Text;
                    this.customerModel.NoTelp = hp.Text;
                    int customerId = this.transactionController.CreateCustomer(this.customerModel);

                    this.transactionModel.CustomerId = customerId;
                    this.transactionModel.Total = int.Parse(totalharga.Text);
                    this.transactionModel.UserId = 1;
                    this.transactionModel.Pay = int.Parse(bayar.Text);
                    this.transactionModel.MoneyChange = int.Parse(kembali.Text);

                    int transactionId = this.transactionController.createTransaction(this.transactionModel);

                    this.transactionController.addTransaction(Transactions, transactionId);

                    clearForm();



                    TableTransactions.Rows.Clear();
                    fetchData();
                }
                else
                {
                    Utils.Notify.notifyError(null, "Tidak ada transaksi");
                }
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);

                throw;
            }
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (bayar.Text != "")
            {
                int total = int.Parse(totalharga.Text);
                int pay = int.Parse(bayar.Text);
                int change = pay - total;
                kembali.Text = change.ToString();
                if(change < 0)
                {
                    simpan.Enabled = false;
                }
            }

            validasiSimpan();

        }

        private void Transactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void validasiSimpan()
        {
            if (pembeli.Text == "" || totalharga.Text == "" || alamat.Text == "" || hp.Text == "" || bayar.Text == "" || kembali.Text == "" || Transactions.Rows.Count > 1)
            {
                simpan.Enabled = false;
            } else
            { 
                simpan.Enabled = true;
            }

        }

        private void pembeli_TextChanged(object sender, EventArgs e)
        {
            validasiSimpan();
        }

        private void hp_TextChanged(object sender, EventArgs e)
        {
            validasiSimpan();

        }

        private void alamat_TextChanged(object sender, EventArgs e)
        {
            validasiSimpan();

        }

        private void totalharga_TextChanged(object sender, EventArgs e)
        {
            validasiSimpan();

        }

        private void kembali_TextChanged(object sender, EventArgs e)
        {
            validasiSimpan();

        }
    }
}
