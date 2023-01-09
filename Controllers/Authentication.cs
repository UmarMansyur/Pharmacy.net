using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApplication7.Config;

namespace WindowsFormsApplication7.Controllers
{
    class Authentication
    {
        private Connection connection;

        public Authentication()
        {
            this.connection = Config.Connection.getInstance();
        }
        public bool Login(Models.User user)
        {
            try
            {
                MySqlDataReader data = connection.Query("SELECT * FROM users WHERE username = '" + user.Username + "'");
                if (data.Read())
                {
                    bool isPasswordMatched = Models.User.VerifyPassword(user.Password, data.GetString(4), data.GetString(5));
                    if(isPasswordMatched)
                    {
                        user.Id = data.GetString(0);
                        user.Username = data.GetString(1);
                        user.Role = data.GetString(3);
                        Middleware.Authentication.user = user;
                        if(Middleware.Authentication.isAdmin())
                        {
                            Views.HomePage.menu.unlockMenu(true);

                        } else
                        {
                            Views.HomePage.menu.unlockMenu(true);
                            Views.HomePage.menu.settingToolStripMenuItem.Enabled = false;
                            Views.HomePage.menu.laporanPenjualanToolStripMenuItem.Enabled = false;
                        }

                        MessageBox.Show("Selamat Datang " + user.Username);

                        return true;
                    } else
                    {
                        Utils.Notify.notifyError(null, "Incorrect password");

                        return false;
                    }
                    data.Close();
                } else
                {
                    Utils.Notify.notifyError(null, "Account Not Found");
                    return false;

                }

                return false;
            }
            catch (Exception error)
            {
                Utils.Notify.notifyError(error);
                throw;

            }
        }        
    }
}

