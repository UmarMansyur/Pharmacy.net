using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7.Controllers
{
    class User
    {
        Config.Connection connection;

        public User()
        {
            this.connection = Config.Connection.getInstance();
        }

        public void create(Models.User user, Models.UserDetail detail)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.CommandType = CommandType.Text;
                
                query.CommandText = "INSERT INTO users (username, password, hash, salt, role, createdAt, updatedAt) VALUES (@username, @password, @hash, @salt, @role, NOW(), NOW()); SELECT LAST_INSERT_ID();";

                query.Connection = this.connection.getConnection();

                Models.User bcrypt = Models.User.GenerateSaltedHash(64, user.Password);

                query.Parameters.AddWithValue("@username", user.Username);
                query.Parameters.AddWithValue("@password", user.Password);
                query.Parameters.AddWithValue("@hash", bcrypt.Hash);
                query.Parameters.AddWithValue("@salt", bcrypt.Salt);
                query.Parameters.AddWithValue("@role", user.Role);
                query.Prepare();
                int id = Convert.ToInt32(query.ExecuteScalar());

                CreateDetailUser(detail, id);
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
            }
        }

        public void CreateDetailUser(Models.UserDetail user, int id) {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.CommandType = CommandType.Text;
                
                query.CommandText = "INSERT INTO user_details (name, address, no_telp, user_id, createdAt, updatedAt) VALUES (@name, @address, @phone, @user_id, NOW(), NOW());";

                query.Connection = this.connection.getConnection();

                query.Parameters.AddWithValue("@name", user.Name);
                query.Parameters.AddWithValue("@address", user.Address);
                query.Parameters.AddWithValue("@phone", user.NoTelp);
                query.Parameters.AddWithValue("@user_id", id);

                MessageBox.Show("Data Berhasil Ditambahkan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                query.Prepare();
                query.ExecuteNonQuery();
                this.connection.getConnection().Close();
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);

                throw;
            }
        }

        public DataTable getAllData()
        {
            try
            {
                DataTable data = new DataTable();
                MySqlDataReader response = Config.Connection.getInstance().Query("SELECT users.username as Username, user_details.name as Nama, user_details.address as Alamat, user_details.no_telp as No_Telp, users.password as Password, users.role as Role FROM users INNER JOIN user_details ON users.id = user_details.user_id");
                data.Load(response);
                return data;
            }
            catch (Exception Error)
            {

                throw;
            }
        }


        public void destroy(Models.User user)
        {
            try
            {

                Config.Connection.getInstance().getConnection().Close();
                Config.Connection.getInstance().getConnection().Open();
                MySqlCommand query = new MySqlCommand();
                query.Connection = Config.Connection.getInstance().getConnection();

                query.CommandType = CommandType.Text;
                query.CommandText = "DELETE FROM users WHERE username = @username";

                query.Parameters.AddWithValue("@username", user.Username);
               
                MessageBox.Show("Data Berhasil Dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                query.Prepare();
                query.ExecuteNonQuery();
                Config.Connection.getInstance().getConnection().Close();
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);
                throw;
            }
        }

        public void updateUser(Models.User user, Models.UserDetail detail, string args)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.CommandType = CommandType.Text;

                query.CommandText = "UPDATE users SET username = @username, password = @password, hash = @hash, salt = @salt, role = @role, updatedAt = NOW() WHERE username = @args; SELECT id FROM users WHERE username = @args;";
                this.connection.getConnection().Close();
                this.connection.getConnection().Open();

                query.Connection = this.connection.getConnection();
                
                Models.User bcrypt = Models.User.GenerateSaltedHash(64, user.Password);

                query.Parameters.AddWithValue("@args", args);
                query.Parameters.AddWithValue("@username", user.Username);
                query.Parameters.AddWithValue("@password", user.Password);
                query.Parameters.AddWithValue("@hash", bcrypt.Hash);
                query.Parameters.AddWithValue("@salt", bcrypt.Salt);
                query.Parameters.AddWithValue("@role", user.Role);
                query.Prepare();
                int id = Convert.ToInt32(query.ExecuteScalar());
                updateDetailUser(detail, id);
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
                throw;
            }
            
        }

        public void updateDetailUser(Models.UserDetail user, int id)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                query.CommandType = CommandType.Text;

                query.CommandText = "UPDATE user_details SET name = @name, address = @address, no_telp = @phone, updatedAt = NOW() WHERE user_id = @user_id;";

                query.Connection = this.connection.getConnection();
                query.Parameters.AddWithValue("@name", user.Name);
                query.Parameters.AddWithValue("@address", user.Address);
                query.Parameters.AddWithValue("@phone", user.NoTelp);
                query.Parameters.AddWithValue("@user_id", id);

                query.Prepare();
                query.ExecuteNonQuery();
                this.connection.getConnection().Close();
                MessageBox.Show("Data Berhasil Dirubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);

                throw;
            }
        }


    }
}
