
namespace WindowsFormsApplication7.Views
{
    partial class Unit
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.purchase = new System.Windows.Forms.TextBox();
            this.satuan = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 178);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(98)))), ((int)(((byte)(94)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 6;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(258, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 83;
            this.button1.Text = "Hapus";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(86)))), ((int)(((byte)(190)))));
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 6;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(183, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 27);
            this.button3.TabIndex = 82;
            this.button3.Text = "Tambah";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 26);
            this.label5.TabIndex = 78;
            this.label5.Text = "Anda dapat mengosongi form di atas ini jika, anda tidak ingin menambah\r\nunit baru" +
    ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nama:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(109, 22);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(224, 29);
            this.textBox6.TabIndex = 46;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.purchase);
            this.groupBox1.Controls.Add(this.satuan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.qty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(396, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 178);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Obat";
            // 
            // sale
            // 
            this.sale.BackColor = System.Drawing.Color.White;
            this.sale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sale.Cursor = System.Windows.Forms.Cursors.Default;
            this.sale.Enabled = false;
            this.sale.ForeColor = System.Drawing.Color.Black;
            this.sale.Location = new System.Drawing.Point(107, 95);
            this.sale.Multiline = true;
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(249, 29);
            this.sale.TabIndex = 77;
            this.sale.TextChanged += new System.EventHandler(this.sale_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Harga Jual:";
            // 
            // purchase
            // 
            this.purchase.BackColor = System.Drawing.Color.White;
            this.purchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchase.Cursor = System.Windows.Forms.Cursors.Default;
            this.purchase.Enabled = false;
            this.purchase.ForeColor = System.Drawing.Color.Black;
            this.purchase.Location = new System.Drawing.Point(107, 56);
            this.purchase.Multiline = true;
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(249, 29);
            this.purchase.TabIndex = 75;
            this.purchase.TextChanged += new System.EventHandler(this.purchase_TextChanged);
            // 
            // satuan
            // 
            this.satuan.FormattingEnabled = true;
            this.satuan.ItemHeight = 23;
            this.satuan.Location = new System.Drawing.Point(246, 135);
            this.satuan.Name = "satuan";
            this.satuan.Size = new System.Drawing.Size(110, 29);
            this.satuan.TabIndex = 74;
            this.satuan.UseSelectable = true;
            this.satuan.SelectedIndexChanged += new System.EventHandler(this.satuan_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Satuan:";
            // 
            // qty
            // 
            this.qty.BackColor = System.Drawing.SystemColors.Window;
            this.qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qty.Location = new System.Drawing.Point(107, 136);
            this.qty.Multiline = true;
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(74, 29);
            this.qty.TabIndex = 70;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Jumlah:";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(181)))), ((int)(((byte)(125)))));
            this.iconButton1.Enabled = false;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.SystemColors.Window;
            this.iconButton1.IconSize = 15;
            this.iconButton1.Location = new System.Drawing.Point(384, 133);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(85, 34);
            this.iconButton1.TabIndex = 69;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(384, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 29);
            this.button2.TabIndex = 65;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Harga Beli:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nama Obat:";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Cursor = System.Windows.Forms.Cursors.Default;
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(107, 19);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(249, 29);
            this.name.TabIndex = 46;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 167);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(396, 251);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(480, 167);
            this.dataGridView2.TabIndex = 76;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(98)))), ((int)(((byte)(94)))));
            this.button4.FlatAppearance.BorderSize = 6;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(288, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 79;
            this.button4.Text = "Hapus";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(98)))), ((int)(((byte)(94)))));
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton2.IconColor = System.Drawing.SystemColors.Window;
            this.iconButton2.IconSize = 15;
            this.iconButton2.Location = new System.Drawing.Point(837, 209);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(39, 34);
            this.iconButton2.TabIndex = 78;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(83)))));
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.iconButton3.IconColor = System.Drawing.SystemColors.Window;
            this.iconButton3.IconSize = 15;
            this.iconButton3.Location = new System.Drawing.Point(795, 209);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(39, 34);
            this.iconButton3.TabIndex = 80;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Silver;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconButton4.IconColor = System.Drawing.SystemColors.Window;
            this.iconButton4.IconSize = 15;
            this.iconButton4.Location = new System.Drawing.Point(751, 209);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(42, 34);
            this.iconButton4.TabIndex = 81;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Unit";
            this.Text = "Unit";
            this.Load += new System.EventHandler(this.Unit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox satuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox purchase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sale;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label label2;
    }
}