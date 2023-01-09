using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication7.Config;

namespace WindowsFormsApplication7.Controllers
{
    class Transaction
    {
        private Connection connection;
        public Transaction()
        {
            this.connection = Connection.getInstance();
        }
        public bool cekStock(int id, int qty, int unitId) {

            try {
            MySqlCommand query = new MySqlCommand();
            query.Connection = this.connection.getConnection();
            this.connection.getConnection().Close();
            this.connection.getConnection().Open();

            query.CommandText = "SELECT qty FROM medicine_stocks WHERE id = @id AND unit_id = @unit_id";
            query.Parameters.AddWithValue("@id", id);
            query.Parameters.AddWithValue("@unit_id", unitId);
            query.Prepare();
            int stock = Convert.ToInt32(query.ExecuteScalar());
            this.connection.getConnection().Close();
            if (stock >= qty) {
                return true;
            }
            return false;
            } catch (Exception error) {
                Utils.Notify.notifyError(error);
                throw;
            }
        }

        public int createTransaction(Models.Transaction transaction) {
            try {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.connection.getConnection();
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();

                query.CommandText = "INSERT INTO transactions VALUES (NULL, @customer_id, @user_id, @total, @pay, @money_changes, NOW(), NOW()); SELECT LAST_INSERT_ID()";
                query.Parameters.AddWithValue("@customer_id", transaction.CustomerId);
                query.Parameters.AddWithValue("@user_id", transaction.UserId);
                query.Parameters.AddWithValue("@total", transaction.Total);
                query.Parameters.AddWithValue("@pay", transaction.Pay);
                query.Parameters.AddWithValue("@money_changes", transaction.MoneyChange);
                
                query.Prepare();
                int id = Convert.ToInt32(query.ExecuteScalar());
                this.connection.getConnection().Close();
                return id;
            } catch (Exception error) {
                Utils.Notify.notifyError(error);
                throw;
            }
        }

        public void addTransaction(DataGridView transaction, int transactionId) {
            try {
               foreach (DataGridViewRow row in transaction.Rows) {

                    MySqlCommand query = new MySqlCommand();

                    query.Connection = this.connection.getConnection();
                    query.CommandType = CommandType.Text;
                    this.connection.getConnection().Close();
                    this.connection.getConnection().Open();

                    query.CommandText = "SELECT id FROM units WHERE unit = @unit";
                    query.Parameters.AddWithValue("@unit", row.Cells["Satuan"].Value.ToString());

                    query.Prepare();
                    int unitId = Convert.ToInt32(query.ExecuteScalar());

                    query.CommandText = "INSERT INTO transaction_details (transaction_id, medicine_id, qty, unit_id, price, createdAt, updatedAt) VALUES (@transaction_id, @medicine_id, @qty, @unit_id, @price, NOW(), NOW())";
                    query.Parameters.AddWithValue("@transaction_id", transactionId);
                    query.Parameters.AddWithValue("@medicine_id", row.Cells["id"].Value);
                    query.Parameters.AddWithValue("@qty", row.Cells["Jumlah"].Value);
                    query.Parameters.AddWithValue("@unit_id", unitId);
                    query.Parameters.AddWithValue("@price", row.Cells["Harga"].Value);

                    query.Prepare();
                    query.ExecuteNonQuery();

                    query.CommandText = "UPDATE medicine_stocks SET qty = qty - @jumlah WHERE medicine_id = @medicineId AND unit_id = @unitId";
                    query.Parameters.AddWithValue("@medicineId", row.Cells["id"].Value);
                    query.Parameters.AddWithValue("@jumlah", row.Cells["Jumlah"].Value);
                    query.Parameters.AddWithValue("@unitId", unitId);
                    query.Prepare();
                    query.ExecuteNonQuery();
                    
                    this.connection.getConnection().Close();
                }
                MessageBox.Show("Transaksi berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception error) {
                Utils.Notify.notifyError(error);
                throw;
            }
        }

        public int CreateCustomer(Models.Customer customer) {
            try {
                MySqlCommand query = new MySqlCommand();
                query.Connection = this.connection.getConnection();
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();

                query.CommandText = "INSERT INTO customers VALUES (NULL, @name, @address, @phone, NOW(), NOW()); SELECT LAST_INSERT_ID()";
                query.Parameters.AddWithValue("@name", customer.Name);
                query.Parameters.AddWithValue("@address", customer.Address);
                query.Parameters.AddWithValue("@phone", customer.NoTelp);
                query.Prepare();
                int id = Convert.ToInt32(query.ExecuteScalar());
                this.connection.getConnection().Close();
                return id;
            } catch (Exception error) {
                Utils.Notify.notifyError(error);
                throw;
            }
        }
        
    }
}
