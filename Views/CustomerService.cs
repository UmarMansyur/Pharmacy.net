using System;
using System.Windows.Forms;

namespace WindowsFormsApplication7.Views
{
    public partial class CustomerService : MetroFramework.Forms.MetroForm
    {
        Controllers.User userController;
        private bool isClick = false;
        string args;
        public CustomerService()
        {
            InitializeComponent();
            this.userController = new Controllers.User();
            EnabledForm(false);
            edit.Enabled = false;
        }

        private void DisableButton() {
            if (username.Text == "" || password.Text == "" || confirmationPassword.Text == "" || role.Text == "" || name.Text == "" || address.Text == "" || phone.Text == "") {
                insert.Enabled = false;
            } else {
                insert.Enabled = true;
            }
        }

        private void EnabledForm(bool status)
        {
            groupBox2.Enabled = status;
            username.Enabled = status;
            password.Enabled = status;
            confirmationPassword.Enabled = status;
            role.Enabled = status;
            insert.Enabled = true;
        }

        private void CustomerService_Load(object sender, EventArgs e)
        {
            role.Items.Add(Utils.Roles.GetAdmin());
            role.Items.Add(Utils.Roles.GetCustomer());
            Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            fetchData();

        }

        public void fetchData()
        {
            Users.DataSource = userController.getAllData();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            DisableButton();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if(groupBox2.Enabled == true && insert.Text == "Simpan" && isClick != true)
                {
                    if (password.Text == confirmationPassword.Text)
                    {
                        userController.create(contentUser(), contentDetailUser());
                        EnabledForm(false);
                        insert.Enabled = true;
                        changeButtonToTambah();
                    }
                    else
                    {
                        Utils.Notify.notifyError(null, "Password tidak sesuai!");
                        insert.Enabled = true;

                    }
                }
                else if (isClick == true)
                {

                    userController.updateUser(contentUser(), contentDetailUser(), args);
                    insert.Enabled = true;
                    changeButtonToTambah();
                    isClick = false;
                }
                else
                {
                    EnabledForm(true);
                    insert.Text = "Simpan";
                    insert.BackColor = System.Drawing.Color.FromArgb(75, 166, 239);
                    

                }
                ClearForm();
                fetchData();
            } catch (Exception error)
            {
                Utils.Notify.notifyError(error);
            }


        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableButton();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            DisableButton();
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            DisableButton();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            DisableButton();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            DisableButton();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            DisableButton();
        }

        private void Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                name.Text = Users.Rows[e.RowIndex].Cells[1].Value.ToString();
                phone.Text = Users.Rows[e.RowIndex].Cells[3].Value.ToString();
                address.Text = Users.Rows[e.RowIndex].Cells[2].Value.ToString();
                username.Text = Users.Rows[e.RowIndex].Cells[0].Value.ToString();
                password.Text = Users.Rows[e.RowIndex].Cells[4].Value.ToString();
                confirmationPassword.Text = Users.Rows[e.RowIndex].Cells[4].Value.ToString();
                role.Text = Users.Rows[e.RowIndex].Cells[5].Value.ToString();
                edit.Enabled = true;
                delete.Enabled = true;
                changeButtonToTambah();
                EnabledForm(false);
                edit.Enabled = true;
            }
            catch (Exception Error)
            {
                Utils.Notify.notifyError(Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(Utils.Notify.notifyDelete())
            {
                Models.User user = new Models.User();
                user.Username = username.Text;

                userController.destroy(user);
                fetchData();
                ClearForm();
            }
            
        }


        private void ClearForm()
        {
            password.Text = "";
            confirmationPassword.Text = "";
            username.Text = "";
            name.Text = "";
            address.Text = "";
            phone.Text = "";
        }

        private void edit_Click(object sender, EventArgs e)
        {
            
            if (edit.Text == "Batal")
            {
                changeButtonToTambah();
                isClick = false;
                ClearForm();
                edit.Text = "Ubah";
                edit.BackColor = System.Drawing.Color.FromArgb(255, 191, 83);
                EnabledForm(false);
                insert.Enabled = true;
                edit.Enabled = false;
            } else
            {
                args = username.Text;
                EnabledForm(true);
                isClick = true;
                insert.Text = "Simpan";
                insert.BackColor = System.Drawing.Color.FromArgb(75, 166, 239);
                role.SelectedItem = role.Text;
                delete.Enabled = false;
                edit.Text = "Batal";
                edit.BackColor = System.Drawing.Color.Gray;
            }

        }

        private Models.User contentUser()
        {
            Models.User user = new Models.User();
            user.Username = username.Text;
            user.Password = password.Text;
            user.Role = role.SelectedItem.ToString();
            return user;
        }
        private Models.UserDetail contentDetailUser()
        {
            Models.UserDetail detail = new Models.UserDetail();
            detail.Name = name.Text;
            detail.Address = address.Text;
            detail.NoTelp = phone.Text;
            return detail;
        }

        private void changeButtonToTambah()
        {
            insert.Text = "Tambah";
            insert.BackColor = System.Drawing.Color.FromArgb(81, 86, 190);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
