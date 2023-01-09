
namespace WindowsFormsApplication7.Views
{
    partial class Laporan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laporan Penjualan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(141, 133);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(182, 29);
            this.metroDateTime1.TabIndex = 2;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pilih Tanggal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satuan:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(596, 133);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(162, 29);
            this.metroComboBox1.TabIndex = 5;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Laporan";
            this.Load += new System.EventHandler(this.Laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}