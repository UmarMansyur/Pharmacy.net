
namespace WindowsFormsApplication7.Views
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.handphone = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.TextBox();
            this.insert = new FontAwesome.Sharp.IconButton();
            this.unit = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.expired = new MetroFramework.Controls.MetroDateTime();
            this.sale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.medicine = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tanggal = new MetroFramework.Controls.MetroDateTime();
            this.qtymd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalHarga = new System.Windows.Forms.TextBox();
            this.listMedicines = new MetroFramework.Controls.MetroGrid();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.handphone);
            this.groupBox2.Controls.Add(this.address);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Location = new System.Drawing.Point(562, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 264);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supplier";
            // 
            // handphone
            // 
            this.handphone.BackColor = System.Drawing.Color.White;
            this.handphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.handphone.Cursor = System.Windows.Forms.Cursors.Default;
            this.handphone.ForeColor = System.Drawing.Color.Black;
            this.handphone.Location = new System.Drawing.Point(106, 81);
            this.handphone.Multiline = true;
            this.handphone.Name = "handphone";
            this.handphone.Size = new System.Drawing.Size(245, 29);
            this.handphone.TabIndex = 72;
            this.handphone.TextChanged += new System.EventHandler(this.handphone_TextChanged);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.Window;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Location = new System.Drawing.Point(106, 126);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(245, 114);
            this.address.TabIndex = 70;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
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
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Cursor = System.Windows.Forms.Cursors.Default;
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(106, 35);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(245, 29);
            this.name.TabIndex = 46;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.registration);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.unit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.expired);
            this.groupBox1.Controls.Add(this.sale);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.medicine);
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 264);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obat";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 86;
            this.label13.Text = "No. Registrasi:";
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.White;
            this.registration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registration.Cursor = System.Windows.Forms.Cursors.Default;
            this.registration.ForeColor = System.Drawing.Color.Black;
            this.registration.Location = new System.Drawing.Point(113, 126);
            this.registration.Multiline = true;
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(367, 29);
            this.registration.TabIndex = 85;
            this.registration.TextChanged += new System.EventHandler(this.registration_TextChanged);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(166)))), ((int)(((byte)(239)))));
            this.insert.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insert.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.insert.IconColor = System.Drawing.SystemColors.Window;
            this.insert.IconSize = 20;
            this.insert.Location = new System.Drawing.Point(413, 209);
            this.insert.Name = "insert";
            this.insert.Rotation = 0D;
            this.insert.Size = new System.Drawing.Size(67, 34);
            this.insert.TabIndex = 84;
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // unit
            // 
            this.unit.FormattingEnabled = true;
            this.unit.ItemHeight = 23;
            this.unit.Location = new System.Drawing.Point(279, 211);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(102, 29);
            this.unit.TabIndex = 83;
            this.unit.UseSelectable = true;
            this.unit.SelectedIndexChanged += new System.EventHandler(this.unit_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "Satuan:";
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.SystemColors.Window;
            this.quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity.Location = new System.Drawing.Point(114, 212);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(93, 29);
            this.quantity.TabIndex = 80;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Jumlah:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 79;
            this.label12.Text = "Kadaluarsa:";
            // 
            // expired
            // 
            this.expired.CustomFormat = "yyyy:MM:dd";
            this.expired.Location = new System.Drawing.Point(113, 168);
            this.expired.MinimumSize = new System.Drawing.Size(0, 29);
            this.expired.Name = "expired";
            this.expired.Size = new System.Drawing.Size(367, 29);
            this.expired.TabIndex = 79;
            this.expired.UseCustomBackColor = true;
            this.expired.UseCustomForeColor = true;
            this.expired.UseStyleColors = true;
            this.expired.ValueChanged += new System.EventHandler(this.expired_ValueChanged);
            // 
            // sale
            // 
            this.sale.BackColor = System.Drawing.Color.White;
            this.sale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sale.Cursor = System.Windows.Forms.Cursors.Default;
            this.sale.ForeColor = System.Drawing.Color.Black;
            this.sale.Location = new System.Drawing.Point(337, 81);
            this.sale.Multiline = true;
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(143, 29);
            this.sale.TabIndex = 77;
            this.sale.TextChanged += new System.EventHandler(this.sale_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Harga Jual:";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.White;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Cursor = System.Windows.Forms.Cursors.Default;
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.Location = new System.Drawing.Point(113, 81);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(135, 29);
            this.price.TabIndex = 75;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Harga Beli:";
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
            // medicine
            // 
            this.medicine.BackColor = System.Drawing.Color.White;
            this.medicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicine.Cursor = System.Windows.Forms.Cursors.Default;
            this.medicine.ForeColor = System.Drawing.Color.Black;
            this.medicine.Location = new System.Drawing.Point(113, 35);
            this.medicine.Multiline = true;
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(367, 29);
            this.medicine.TabIndex = 46;
            this.medicine.TextChanged += new System.EventHandler(this.medicine_TextChanged);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(86)))), ((int)(((byte)(190)))));
            this.save.Enabled = false;
            this.save.FlatAppearance.BorderSize = 6;
            this.save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(160, 186);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(191, 36);
            this.save.TabIndex = 78;
            this.save.Text = "Tambah";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // hapus
            // 
            this.hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(98)))), ((int)(((byte)(94)))));
            this.hapus.Enabled = false;
            this.hapus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus.ForeColor = System.Drawing.Color.White;
            this.hapus.Location = new System.Drawing.Point(435, 308);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(87, 36);
            this.hapus.TabIndex = 77;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = false;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(83)))));
            this.edit.Enabled = false;
            this.edit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(342, 308);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(87, 36);
            this.edit.TabIndex = 76;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tanggal);
            this.groupBox3.Controls.Add(this.qtymd);
            this.groupBox3.Controls.Add(this.save);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.totalHarga);
            this.groupBox3.Location = new System.Drawing.Point(562, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 247);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(160, 58);
            this.tanggal.MinimumSize = new System.Drawing.Size(4, 29);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(191, 29);
            this.tanggal.TabIndex = 80;
            // 
            // qtymd
            // 
            this.qtymd.BackColor = System.Drawing.Color.White;
            this.qtymd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtymd.Cursor = System.Windows.Forms.Cursors.Default;
            this.qtymd.ForeColor = System.Drawing.Color.Black;
            this.qtymd.Location = new System.Drawing.Point(160, 19);
            this.qtymd.Multiline = true;
            this.qtymd.Name = "qtymd";
            this.qtymd.ReadOnly = true;
            this.qtymd.Size = new System.Drawing.Size(191, 29);
            this.qtymd.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 71;
            this.label9.Text = "Total Harga:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "Tanggal Pembelian:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "Jumlah Obat:";
            // 
            // totalHarga
            // 
            this.totalHarga.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalHarga.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHarga.ForeColor = System.Drawing.SystemColors.WindowText;
            this.totalHarga.Location = new System.Drawing.Point(160, 105);
            this.totalHarga.Multiline = true;
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.Size = new System.Drawing.Size(191, 62);
            this.totalHarga.TabIndex = 46;
            this.totalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listMedicines
            // 
            this.listMedicines.AllowUserToResizeRows = false;
            this.listMedicines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listMedicines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.listMedicines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.listMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listMedicines.DefaultCellStyle = dataGridViewCellStyle17;
            this.listMedicines.EnableHeadersVisualStyles = false;
            this.listMedicines.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listMedicines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listMedicines.Location = new System.Drawing.Point(23, 350);
            this.listMedicines.Name = "listMedicines";
            this.listMedicines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listMedicines.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.listMedicines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listMedicines.Size = new System.Drawing.Size(499, 205);
            this.listMedicines.TabIndex = 81;
            this.listMedicines.UseCustomBackColor = true;
            this.listMedicines.UseCustomForeColor = true;
            this.listMedicines.UseStyleColors = true;
            this.listMedicines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listMedicines_CellContentClick);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 587);
            this.Controls.Add(this.listMedicines);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listMedicines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox handphone;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medicine;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox qtymd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox totalHarga;
        private MetroFramework.Controls.MetroDateTime expired;
        private FontAwesome.Sharp.IconButton insert;
        private MetroFramework.Controls.MetroComboBox unit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroDateTime tanggal;
        private MetroFramework.Controls.MetroGrid listMedicines;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox registration;
    }
}