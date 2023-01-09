
namespace WindowsFormsApplication7.Views
{
    partial class Medicine
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
            this.registrasion_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.expired = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.unit = new MetroFramework.Controls.MetroComboBox();
            this.purchase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrasion_number
            // 
            this.registrasion_number.BackColor = System.Drawing.SystemColors.Window;
            this.registrasion_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrasion_number.Location = new System.Drawing.Point(164, 51);
            this.registrasion_number.Multiline = true;
            this.registrasion_number.Name = "registrasion_number";
            this.registrasion_number.Size = new System.Drawing.Size(225, 29);
            this.registrasion_number.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Stok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "No. Registrasi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nama";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Cursor = System.Windows.Forms.Cursors.Default;
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(164, 16);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(225, 29);
            this.name.TabIndex = 46;
            // 
            // expired
            // 
            this.expired.Location = new System.Drawing.Point(164, 92);
            this.expired.MinimumSize = new System.Drawing.Size(0, 29);
            this.expired.Name = "expired";
            this.expired.Size = new System.Drawing.Size(225, 29);
            this.expired.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tanggal Kadaluarsa:";
            // 
            // qty
            // 
            this.qty.BackColor = System.Drawing.SystemColors.Window;
            this.qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qty.Location = new System.Drawing.Point(100, 17);
            this.qty.Multiline = true;
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(80, 29);
            this.qty.TabIndex = 54;
            // 
            // unit
            // 
            this.unit.FormattingEnabled = true;
            this.unit.ItemHeight = 23;
            this.unit.Location = new System.Drawing.Point(204, 16);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(121, 29);
            this.unit.TabIndex = 55;
            this.unit.UseSelectable = true;
            // 
            // purchase
            // 
            this.purchase.BackColor = System.Drawing.SystemColors.Window;
            this.purchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchase.Location = new System.Drawing.Point(100, 56);
            this.purchase.Multiline = true;
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(225, 29);
            this.purchase.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Harga Beli:";
            // 
            // sale
            // 
            this.sale.BackColor = System.Drawing.SystemColors.Window;
            this.sale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sale.Location = new System.Drawing.Point(100, 97);
            this.sale.Multiline = true;
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(225, 29);
            this.sale.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Harga Jual:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 214);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(98)))), ((int)(((byte)(94)))));
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(677, 206);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(87, 36);
            this.delete.TabIndex = 63;
            this.delete.Text = "Hapus";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(83)))));
            this.edit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(584, 206);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(87, 36);
            this.edit.TabIndex = 62;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.expired);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.registrasion_number);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 137);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sale);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.purchase);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.unit);
            this.groupBox2.Controls.Add(this.qty);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(426, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 138);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ketersediaan";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(166)))), ((int)(((byte)(239)))));
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButton1.IconColor = System.Drawing.SystemColors.Window;
            this.iconButton1.IconSize = 15;
            this.iconButton1.Location = new System.Drawing.Point(716, 164);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(48, 33);
            this.iconButton1.TabIndex = 64;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(86)))), ((int)(((byte)(190)))));
            this.insert.FlatAppearance.BorderSize = 6;
            this.insert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.White;
            this.insert.Location = new System.Drawing.Point(491, 206);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(87, 36);
            this.insert.TabIndex = 67;
            this.insert.Text = "Tambah";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.button2_Click);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 514);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Medicine";
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox registrasion_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private MetroFramework.Controls.MetroDateTime expired;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qty;
        private MetroFramework.Controls.MetroComboBox unit;
        private System.Windows.Forms.TextBox purchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button insert;
    }
}