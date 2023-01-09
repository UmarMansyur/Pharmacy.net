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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Controllers.Authentication authentication = new Controllers.Authentication();

        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            Models.UserDetail user = new Models.UserDetail();
            user.Username = username.Text;
            user.Password = password.Text;

            if(authentication.Login(user))
            {

                this.Close();
            }
        }
    }
}
