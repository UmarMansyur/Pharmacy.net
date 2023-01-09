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
    public partial class HomePage : Form
    {
        public static HomePage menu;
        CustomerService customerService;

        Login formLogin;
        Medicine medicine;
        Purchase purchase;
        Transaction transaction;
        Laporan laporan;
        Unit unit;


        public HomePage()
        {
            InitializeComponent();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

            unlockMenu(false);
            authentication();
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.customerService == null)
            {
                this.customerService = new CustomerService();
                customerService.FormClosed += new FormClosedEventHandler(pegawaiToolStripMenuItem_FormClosed);
                this.customerService.ShowDialog();
            }
            else
            {
                this.customerService.Activate();
            }
        }
        private void pegawaiToolStripMenuItem_FormClosed(object sender, EventArgs e)
        {
           this.customerService = null;
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.transaction == null)
            {
                this.transaction = new Transaction();
                transaction.FormClosed += new FormClosedEventHandler(penjualanToolStripMenuItem_FormClosed);
                this.transaction.ShowDialog();
            }
            else
            {
                this.transaction.Activate();
            }
        }
        private void penjualanToolStripMenuItem_FormClosed(object sender, EventArgs e)
        {
            this.transaction = null;
        }



        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.purchase == null)
            {
                this.purchase = new Purchase();
                purchase.FormClosed += new FormClosedEventHandler(pembelianToolStripMenuItem_FormClosed);
                this.purchase.ShowDialog();
            }
            else
            {
                this.purchase.Activate();
            }
        }
        private void pembelianToolStripMenuItem_FormClosed(object sender, EventArgs e)
        {
            this.purchase = null;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lihatObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.medicine == null)
            {
                this.medicine = new Medicine();
                medicine.FormClosed += new FormClosedEventHandler(lihatObatToolStripMenuItem_FormClosed);
                this.medicine.ShowDialog();
            }
            else
            {
                this.medicine.Activate();
            }
        }
        private void lihatObatToolStripMenuItem_FormClosed(object sender, EventArgs e)
        {
            this.medicine = null;
        }

        public void redirectUnit()
        {
            Unit showUnit = new Unit();
            showUnit.MdiParent = this;
            showUnit.Show();
        }

        public void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.unit == null)
            {
                this.unit = new Unit();
                unit.FormClosed += new FormClosedEventHandler(unitToolStripMenuItem_FormClosed);
                this.unit.ShowDialog();
            }
            else
            {
                this.unit.Activate();
            }
        }
        public void unitToolStripMenuItem_FormClosed(object sender, EventArgs e)
        {
            this.unit = null;
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public void unlockMenu(bool status)
        {
            masterToolStripMenuItem.Enabled = status;
            transaksiToolStripMenuItem.Enabled = status;
            settingToolStripMenuItem.Enabled = status;
            laporanPenjualanToolStripMenuItem.Enabled = status;
            loginToolStripMenuItem.Enabled = !status;
            menu = this;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.formLogin == null)
            {
                this.formLogin = new Login();
                formLogin.FormClosed += new FormClosedEventHandler(FormLogin_FormClosed);
                this.formLogin.ShowDialog();
            } else
            {
                this.formLogin.Activate();
            }
        }
        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.formLogin = null;
        }

        private void authentication()
        {
            if (this.formLogin == null) 
            {
                this.formLogin = new Login();
                this.formLogin.FormClosed += new FormClosedEventHandler(FormLogin_FormClosed);
                this.formLogin.ShowDialog();
            }
        }

        private void aksesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin Log Out ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                unlockMenu(false);
                Middleware.Authentication.user.Username = "";
                Middleware.Authentication.user.Password = "";
                Middleware.Authentication.user.Role = "";
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.customerService == null)
            {
                this.customerService = new CustomerService();
                customerService.FormClosed += new FormClosedEventHandler(pegawaiToolStripMenuItem_FormClosed);
                this.customerService.ShowDialog();
            }
            else
            {
                this.customerService.Activate();
            }
        }

        private void laporanPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.laporan == null)
            {
                this.laporan = new Laporan();
                laporan.FormClosed += new FormClosedEventHandler(laporanPenjualanToolStripMenuItem_FormClosed);
                this.laporan.ShowDialog();
            }
            else
            {
                this.laporan.Activate();
            }
        }
        private void laporanPenjualanToolStripMenuItem_FormClosed(object sender, EventArgs e)
        {
            this.laporan = null;
        }
    }
}
