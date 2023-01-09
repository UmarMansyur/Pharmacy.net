using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication7.Config;
using WindowsFormsApplication7.Utils;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication7.Controllers
{
    class Medicine
    {
        Connection connection;

        public Medicine()
        {
            this.connection = Config.Connection.getInstance();

        }

        public void create(Models.Stock medicine)
        {
            try
            {
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();
                
                MySqlCommand query = new MySqlCommand();

                query.Connection = this.connection.getConnection();
                query.CommandType = CommandType.Text;
                query.CommandText = "INSERT INTO medicines VALUES (NULL, @registration_number, @name, @expired, NOW(), NOW()); SELECT LAST_INSERT_ID()";

                query.Parameters.AddWithValue("@registration_number", medicine.RegistrationNumber);
                query.Parameters.AddWithValue("@name", medicine.Name);
                query.Parameters.AddWithValue("@expired", medicine.Expired);

                query.Prepare();
                int medicineId = Convert.ToInt32(query.ExecuteScalar());

                query.CommandText = "INSERT INTO medicine_stocks VALUES (NULL, @medicine_id, @unit_id, @qty, @purchase, @sale, NOW(), NOW(), NULL)";

                query.Parameters.AddWithValue("@medicine_id", medicineId);
                query.Parameters.AddWithValue("@unit_id", medicine.UnitId);
                query.Parameters.AddWithValue("@qty", medicine.Qty);
                query.Parameters.AddWithValue("@purchase", medicine.PurchasePrice);
                query.Parameters.AddWithValue("@sale", medicine.SalePrice);

                query.Prepare();
                query.ExecuteNonQuery();

                this.connection.getConnection().Close();
                MessageBox.Show("Data Berhasil Ditambahkan!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                Notify.notifyError(Error);
            }
        }

        public DataTable getAllData()
        {
            try
            {
                DataTable data = new DataTable();
                MySqlDataReader response = Config.Connection.getInstance().Query("SELECT medicines.id, medicine_stocks.id as stockId, medicines.name as `Nama Obat`, medicines.registration_number as `No Registrasi`, medicine_stocks.purchase_price as `Harga Beli`, medicine_stocks.sale_price as `Harga Jual`, medicines.expired as `Tanggal Kadaluarsa`, medicine_stocks.qty as `Jumlah`, units.unit AS `Satuan` FROM medicines INNER JOIN medicine_stocks ON medicines.id = medicine_stocks.medicine_id INNER JOIN units ON medicine_stocks.unit_id = units.id;");
                data.Load(response);
                return data;
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);

                throw;
            }
        }

        public void update(Models.Stock medicine, int id)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.connection.getConnection();
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();

                query.CommandType = CommandType.Text;
                query.CommandText = "UPDATE medicines SET name = @name, registration_number = @registration, expired = @expired WHERE id = @id";
                query.Parameters.AddWithValue("@id", id);
                query.Parameters.AddWithValue("@registration", medicine.RegistrationNumber);
                query.Parameters.AddWithValue("@name", medicine.Name);
                query.Parameters.AddWithValue("@expired", medicine.Expired);

                query.Prepare();
                query.ExecuteNonQuery();

                query.CommandText = "UPDATE medicine_stocks SET unit_id = @unit_id, qty = @qty, purchase_price = @purchase, sale_price = @sale, updatedAt = NOW() WHERE medicine_id = @medicineId";
                query.Parameters.AddWithValue("@medicineId", id);
                query.Parameters.AddWithValue("@unit_id", medicine.UnitId);
                query.Parameters.AddWithValue("@qty", medicine.Qty);
                query.Parameters.AddWithValue("@purchase", medicine.PurchasePrice);
                query.Parameters.AddWithValue("@sale", medicine.SalePrice);

                query.Prepare();
                query.ExecuteNonQuery();

                this.connection.getConnection().Close();
                MessageBox.Show("Data Berhasil Diubah!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception Error)
            {
                Notify.notifyError(Error);
                throw;
            }
        }

        public void delete(int id)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.connection.getConnection();
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();
                query.CommandType = CommandType.Text;
                query.CommandText = "DELETE FROM medicines WHERE id = @id";
                query.Parameters.AddWithValue("@id", id);

                query.Prepare();
                query.ExecuteNonQuery();

                this.connection.getConnection().Close();
                MessageBox.Show("Data Berhasil Dihapus!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception Error)
            {
                Notify.notifyError(Error);
                throw;
            }
        }

        public DataTable getDataByName(string name)
        {
            try
            {
                DataTable data = new DataTable();
                MySqlDataReader response = Config.Connection.getInstance().Query("SELECT medicines.id, medicine_stocks.id as stockId, medicines.name as `Nama Obat`, medicines.registration_number as `No Registrasi`, medicine_stocks.purchase_price as `Harga Beli`, medicine_stocks.sale_price as `Harga Jual`, medicines.expired as `Tanggal Kadaluarsa`, medicine_stocks.qty as `Jumlah`, units.unit AS `Satuan` FROM medicines INNER JOIN medicine_stocks ON medicines.id = medicine_stocks.medicine_id INNER JOIN units ON medicine_stocks.unit_id = units.id WHERE medicines.name LIKE " + "'%" + name.ToString() + "%'");

                data.Load(response);

                if(data.Rows.Count < 1)
                {
                    Utils.Notify.notifyError(null, "Data tidak ditemukan !");
                    return getAllData();
                }
                return data;
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);

                throw;
            }
        }
    }
}
