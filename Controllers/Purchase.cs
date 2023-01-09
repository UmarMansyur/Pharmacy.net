using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication7.Config;
using WindowsFormsApplication7.Models;
namespace WindowsFormsApplication7.Controllers
{
    class Purchase
    {

        private Connection connection;
        public Purchase()
        {
            this.connection = Connection.getInstance();
        }
        public int createSupplier(Supplier supplier)
        {
            try
            {
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();
                MySqlCommand query = new MySqlCommand();
                query.CommandType = CommandType.Text;
                query.CommandText = "INSERT INTO suppliers (name, address, no_telp) VALUES (@name, @address, @phone); SELECT LAST_INSERT_ID()";
                query.Connection = this.connection.getConnection();

                query.Parameters.AddWithValue("@name", supplier.Name);
                query.Parameters.AddWithValue("@address", supplier.Address);
                query.Parameters.AddWithValue("@phone", supplier.NoTelp);

                query.Prepare();
                int id = Convert.ToInt32(query.ExecuteScalar());
                this.connection.getConnection().Close();
                return id;
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
                throw;
            }
        }

        public int createWholeSale(int supplier_id, Models.WholeSale wholeSale)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.CommandType = CommandType.Text;
                query.CommandText = "INSERT INTO wholesales (supplier_id, date, total) VALUES (@supplier_id, @date, @total); SELECT LAST_INSERT_ID()";
                query.Connection = this.connection.getConnection();
                query.Connection.Open();

                query.Parameters.AddWithValue("@supplier_id", supplier_id);
                query.Parameters.AddWithValue("@date", wholeSale.date);
                query.Parameters.AddWithValue("@total", wholeSale.total);
                
                query.Prepare();
                int wholeSaleId = Convert.ToInt32(query.ExecuteScalar());
                this.connection.getConnection().Close();
                return wholeSaleId;
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
                throw;
            }
        }

        

        public void createDetailWholeSale(int wholeSale_id, DataGridView medicines)
        {
            try {


                foreach (DataGridViewRow data in medicines.Rows)
                {
                    MySqlCommand query = new MySqlCommand();
                    query.CommandType = CommandType.Text;
                    query.Connection = this.connection.getConnection();
                    query.Connection.Open();

                    query.CommandText = "SELECT id FROM units WHERE unit = @unit";
                    query.Parameters.AddWithValue("@unit", data.Cells["Satuan"].Value.ToString());

                    query.Prepare();
                    int unitId = Convert.ToInt32(query.ExecuteScalar());

                    query.CommandText = "INSERT INTO medicines VALUES(NULL, @Reg, @namaObat, @expired, NOW(), NOW()); SELECT LAST_INSERT_ID()";
                    query.Parameters.AddWithValue("@namaObat", data.Cells["Nama Obat"].Value.ToString());
                    query.Parameters.AddWithValue("@Reg", data.Cells["No. Registrasi"].Value.ToString());
                    query.Parameters.AddWithValue("@expired", data.Cells["Tanggal Kadaluarsa"].Value.ToString());

                    query.Prepare();
                    int medicineId = Convert.ToInt32(query.ExecuteScalar());

                    query.CommandText = "INSERT INTO medicine_stocks VALUES (NULL, @medicine_id, @unitid, @quantity, @purchase_price, @sale_price, NOW(), NOW(), NULL)";
                    query.Parameters.AddWithValue("@medicine_id", medicineId);
                    query.Parameters.AddWithValue("@unitid", unitId);
                    query.Parameters.AddWithValue("@quantity", data.Cells["Jumlah"].Value.ToString());
                    query.Parameters.AddWithValue("@purchase_price", data.Cells["Harga Beli"].Value.ToString());
                    query.Parameters.AddWithValue("@sale_price", data.Cells["Harga Jual"].Value.ToString());

                    query.Prepare();
                    query.ExecuteNonQuery();


                    query.CommandText = "INSERT INTO wholesale_details (wholesale_id, medicine_id, qty, unit_id, price) VALUES (@whole_sale_id, @medicineId, @qty, @satuan, @price)";
                    query.Parameters.AddWithValue("@whole_sale_id", wholeSale_id);
                    query.Parameters.AddWithValue("@medicineId", medicineId);
                    query.Parameters.AddWithValue("@qty", data.Cells["Jumlah"].Value.ToString());
                    query.Parameters.AddWithValue("@satuan", unitId);
                    query.Parameters.AddWithValue("@price", data.Cells["Harga Beli"].Value.ToString());

                    query.Prepare();
                    query.ExecuteNonQuery();

                    query.Connection.Close();
                };
                MessageBox.Show("Data Berhasil Ditambahkan!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch (Exception error)
            {
                Utils.Notify.notifyError(error);
            }
        }

    }
}
