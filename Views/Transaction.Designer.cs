
namespace WindowsFormsApplication7.Views
{
    partial class Transaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.satuan = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.jumlah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keranjang = new FontAwesome.Sharp.IconButton();
            this.button2 = new System.Windows.Forms.Button();
            this.harga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namaobat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hp = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pembeli = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalharga = new System.Windows.Forms.TextBox();
            this.simpan = new System.Windows.Forms.Button();
            this.kembali = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bayar = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Transactions = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Medicines = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Medicines)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.satuan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.jumlah);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.keranjang);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.harga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.namaobat);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 206);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obat";
            // 
            // satuan
            // 
            this.satuan.Enabled = false;
            this.satuan.FormattingEnabled = true;
            this.satuan.ItemHeight = 23;
            this.satuan.Location = new System.Drawing.Point(312, 125);
            this.satuan.Name = "satuan";
            this.satuan.Size = new System.Drawing.Size(138, 29);
            this.satuan.TabIndex = 74;
            this.satuan.UseSelectable = true;
            this.satuan.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Satuan:";
            // 
            // jumlah
            // 
            this.jumlah.BackColor = System.Drawing.SystemColors.Window;
            this.jumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jumlah.Enabled = false;
            this.jumlah.Location = new System.Drawing.Point(113, 126);
            this.jumlah.Multiline = true;
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(123, 29);
            this.jumlah.TabIndex = 70;
            this.jumlah.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Jumlah:";
            // 
            // keranjang
            // 
            this.keranjang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(166)))), ((int)(((byte)(239)))));
            this.keranjang.Enabled = false;
            this.keranjang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.keranjang.ForeColor = System.Drawing.SystemColors.Control;
            this.keranjang.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.keranjang.IconColor = System.Drawing.SystemColors.Window;
            this.keranjang.IconSize = 15;
            this.keranjang.Location = new System.Drawing.Point(464, 123);
            this.keranjang.Name = "keranjang";
            this.keranjang.Rotation = 0D;
            this.keranjang.Size = new System.Drawing.Size(85, 34);
            this.keranjang.TabIndex = 69;
            this.keranjang.UseVisualStyleBackColor = false;
            this.keranjang.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(464, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 33);
            this.button2.TabIndex = 65;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // harga
            // 
            this.harga.BackColor = System.Drawing.SystemColors.Control;
            this.harga.Location = new System.Drawing.Point(113, 81);
            this.harga.Multiline = true;
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(436, 29);
            this.harga.TabIndex = 48;
            this.harga.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Harga:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nama Obat:";
            // 
            // namaobat
            // 
            this.namaobat.BackColor = System.Drawing.Color.White;
            this.namaobat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namaobat.Cursor = System.Windows.Forms.Cursors.Default;
            this.namaobat.ForeColor = System.Drawing.Color.Black;
            this.namaobat.Location = new System.Drawing.Point(113, 35);
            this.namaobat.Multiline = true;
            this.namaobat.Name = "namaobat";
            this.namaobat.Size = new System.Drawing.Size(337, 29);
            this.namaobat.TabIndex = 46;
            this.namaobat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hp);
            this.groupBox2.Controls.Add(this.alamat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pembeli);
            this.groupBox2.Location = new System.Drawing.Point(599, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 206);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pembeli";
            // 
            // hp
            // 
            this.hp.BackColor = System.Drawing.Color.White;
            this.hp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hp.Cursor = System.Windows.Forms.Cursors.Default;
            this.hp.ForeColor = System.Drawing.Color.Black;
            this.hp.Location = new System.Drawing.Point(106, 81);
            this.hp.Multiline = true;
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(443, 29);
            this.hp.TabIndex = 72;
            this.hp.TextChanged += new System.EventHandler(this.hp_TextChanged);
            // 
            // alamat
            // 
            this.alamat.BackColor = System.Drawing.SystemColors.Window;
            this.alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alamat.Location = new System.Drawing.Point(106, 126);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(443, 55);
            this.alamat.TabIndex = 70;
            this.alamat.TextChanged += new System.EventHandler(this.alamat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Alamat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Hp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nama:";
            // 
            // pembeli
            // 
            this.pembeli.BackColor = System.Drawing.Color.White;
            this.pembeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pembeli.Cursor = System.Windows.Forms.Cursors.Default;
            this.pembeli.ForeColor = System.Drawing.Color.Black;
            this.pembeli.Location = new System.Drawing.Point(106, 35);
            this.pembeli.Multiline = true;
            this.pembeli.Name = "pembeli";
            this.pembeli.Size = new System.Drawing.Size(443, 29);
            this.pembeli.TabIndex = 46;
            this.pembeli.TextChanged += new System.EventHandler(this.pembeli_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.totalharga);
            this.groupBox3.Controls.Add(this.simpan);
            this.groupBox3.Controls.Add(this.kembali);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.bayar);
            this.groupBox3.Location = new System.Drawing.Point(599, 483);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 222);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pembayaran";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 77;
            this.label10.Text = "Total:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // totalharga
            // 
            this.totalharga.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.totalharga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalharga.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalharga.ForeColor = System.Drawing.Color.Black;
            this.totalharga.Location = new System.Drawing.Point(106, 29);
            this.totalharga.Multiline = true;
            this.totalharga.Name = "totalharga";
            this.totalharga.Size = new System.Drawing.Size(443, 63);
            this.totalharga.TabIndex = 76;
            this.totalharga.TextChanged += new System.EventHandler(this.totalharga_TextChanged);
            // 
            // simpan
            // 
            this.simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(86)))), ((int)(((byte)(190)))));
            this.simpan.Enabled = false;
            this.simpan.FlatAppearance.BorderSize = 6;
            this.simpan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan.ForeColor = System.Drawing.Color.White;
            this.simpan.Location = new System.Drawing.Point(106, 180);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(443, 36);
            this.simpan.TabIndex = 74;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = false;
            this.simpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // kembali
            // 
            this.kembali.BackColor = System.Drawing.Color.White;
            this.kembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kembali.Cursor = System.Windows.Forms.Cursors.Default;
            this.kembali.ForeColor = System.Drawing.Color.Black;
            this.kembali.Location = new System.Drawing.Point(106, 144);
            this.kembali.Multiline = true;
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(443, 29);
            this.kembali.TabIndex = 72;
            this.kembali.TextChanged += new System.EventHandler(this.kembali_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Kembali:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Bayar:";
            // 
            // bayar
            // 
            this.bayar.BackColor = System.Drawing.Color.White;
            this.bayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bayar.Cursor = System.Windows.Forms.Cursors.Default;
            this.bayar.ForeColor = System.Drawing.Color.Black;
            this.bayar.Location = new System.Drawing.Point(106, 103);
            this.bayar.Multiline = true;
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(443, 29);
            this.bayar.TabIndex = 46;
            this.bayar.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Transactions);
            this.groupBox4.Location = new System.Drawing.Point(599, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 244);
            this.groupBox4.TabIndex = 75;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transaksi";
            // 
            // Transactions
            // 
            this.Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transactions.Location = new System.Drawing.Point(11, 19);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(538, 206);
            this.Transactions.TabIndex = 68;
            this.Transactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Transactions_CellClick);
            this.Transactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Transactions_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Medicines);
            this.groupBox5.Location = new System.Drawing.Point(12, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(568, 472);
            this.groupBox5.TabIndex = 76;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Obat";
            // 
            // Medicines
            // 
            this.Medicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Medicines.Location = new System.Drawing.Point(11, 19);
            this.Medicines.Name = "Medicines";
            this.Medicines.Size = new System.Drawing.Size(538, 436);
            this.Medicines.TabIndex = 68;
            this.Medicines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Medicines_CellClick);
            this.Medicines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Medicines_CellContentClick);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 718);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Transactions)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Medicines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaobat;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton keranjang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox hp;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pembeli;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox kembali;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bayar;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalharga;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView Transactions;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView Medicines;
        private MetroFramework.Controls.MetroComboBox satuan;
    }
}