using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7.Controllers
{
    class Unit
    {
        Config.Connection connection;

        public Unit()
        {
            this.connection = Config.Connection.getInstance();
        }

        public MySqlDataReader getUnit()
        {
            return this.connection.Query("SELECT id, unit FROM units");
        }

        public DataTable getAllData()
        {
            try
            {
                DataTable data = new DataTable();
                MySqlDataReader response = Config.Connection.getInstance().Query("SELECT id, unit FROM units");
                data.Load(response);
                return data;
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);

                throw;
            }
        }

        public void updateParent(Models.Stock medicine)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.connection.getConnection();
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();

                query.CommandType = CommandType.Text;

                query.CommandText = "INSERT INTO medicine_stocks VALUES (NULL,@medicineId, @unit_id, @qty, @purchase, @sale, NOW(), NOW(), @parentId)";
                query.Parameters.AddWithValue("@medicineId", medicine.MedicineId);
                query.Parameters.AddWithValue("@unit_id", medicine.UnitId);
                query.Parameters.AddWithValue("@qty", medicine.Qty);
                query.Parameters.AddWithValue("@purchase", medicine.PurchasePrice);
                query.Parameters.AddWithValue("@sale", medicine.SalePrice);
                query.Parameters.AddWithValue("@parentId", medicine.ParentId);

                query.Prepare();
                query.ExecuteNonQuery();

                this.connection.getConnection().Close();
                MessageBox.Show("Data Berhasil Ditambah!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {

                throw;
            }
        }

        public void update(Models.Stock medicine)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.connection.getConnection();
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();

                query.CommandType = CommandType.Text;

                query.CommandText = "UPDATE medicine_stocks SET unit_id = @unit_id, qty = @qty, purchase_price = @purchase, sale_price = @sale, updatedAt = NOW() WHERE medicine_id = @medicineId";
                query.Parameters.AddWithValue("@medicineId", medicine.MedicineId);
                query.Parameters.AddWithValue("@unit_id", medicine.UnitId);
                query.Parameters.AddWithValue("@qty", medicine.Qty);
                query.Parameters.AddWithValue("@purchase", medicine.PurchasePrice);
                query.Parameters.AddWithValue("@sale", medicine.SalePrice);
                query.Parameters.AddWithValue("@parentId", medicine.ParentId);

                query.Prepare();
                query.ExecuteNonQuery();

                this.connection.getConnection().Close();
                MessageBox.Show("Data Berhasil Diubah!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {

                throw;
            }
        }

        public void delete (int id)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.connection.getConnection();
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();
                query.CommandType = CommandType.Text;
                query.CommandText = "DELETE FROM medicine_stocks WHERE id = @id";
                query.Parameters.AddWithValue("@id", id);

                query.Prepare();
                query.ExecuteNonQuery();

                this.connection.getConnection().Close();
                MessageBox.Show("Data Berhasil Dihapus!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
                throw;
            }
        }

        public void create(Models.Unit unit)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.connection.getConnection();
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();

                query.CommandType = CommandType.Text;
                MessageBox.Show(unit.Name);
                query.CommandText = "INSERT INTO units VALUES (NULL, @unit, NOW(), NOW())";
                query.Parameters.AddWithValue("@unit", unit.Name);

                query.Prepare();
                query.ExecuteNonQuery();

                this.connection.getConnection().Close();
                MessageBox.Show("Data Berhasil Ditambah!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
            }
        }
        public void updateUnit(Models.Unit unit)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.connection.getConnection();
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();

                query.CommandType = CommandType.Text;

                query.CommandText = "UPDATE units SET unit = @unit, updatedAt = NOW() WHERE id = @id";
                query.Parameters.AddWithValue("@id", unit.Id);
                query.Parameters.AddWithValue("@unit", unit.Name);

                query.Prepare();
                query.ExecuteNonQuery();

                this.connection.getConnection().Close();
                MessageBox.Show("Data Berhasil Dirubah!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
            }
        }

        public void deleteUnit(int id)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.connection.getConnection();
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();

                query.CommandType = CommandType.Text;

                query.CommandText = "DELETE FROM units WHERE id = @id";
                query.Parameters.AddWithValue("@id", id);


                query.Prepare();
                query.ExecuteNonQuery();

                this.connection.getConnection().Close();
                MessageBox.Show("Data Berhasil Dihapus!", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
            }
        }
    }
}
