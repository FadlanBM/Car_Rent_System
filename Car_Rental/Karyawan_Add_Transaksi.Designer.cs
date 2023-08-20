namespace Car_Rental
{
    partial class Karyawan_Add_Transaksi
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_rentalstop = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pelanggan = new System.Windows.Forms.ComboBox();
            this.cb_mobile = new System.Windows.Forms.ComboBox();
            this.dt_rentalstart = new System.Windows.Forms.DateTimePicker();
            this.tb_pricerental = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 32);
            this.button3.TabIndex = 40;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(171, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 32);
            this.button4.TabIndex = 39;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Harga Rental";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tanggal Pengembalian";
            // 
            // dt_rentalstop
            // 
            this.dt_rentalstop.Location = new System.Drawing.Point(34, 213);
            this.dt_rentalstop.Name = "dt_rentalstop";
            this.dt_rentalstop.Size = new System.Drawing.Size(273, 20);
            this.dt_rentalstop.TabIndex = 28;
            this.dt_rentalstop.ValueChanged += new System.EventHandler(this.dt_rentalstop_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tanggal Rental";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mobile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tambah Transaksi";
            // 
            // cb_pelanggan
            // 
            this.cb_pelanggan.AutoCompleteCustomSource.AddRange(new string[] {
            "Sewa",
            "Kembali"});
            this.cb_pelanggan.FormattingEnabled = true;
            this.cb_pelanggan.Location = new System.Drawing.Point(34, 81);
            this.cb_pelanggan.Name = "cb_pelanggan";
            this.cb_pelanggan.Size = new System.Drawing.Size(273, 21);
            this.cb_pelanggan.TabIndex = 41;
            this.cb_pelanggan.SelectedIndexChanged += new System.EventHandler(this.cb_pelanggan_SelectedIndexChanged);
            // 
            // cb_mobile
            // 
            this.cb_mobile.AutoCompleteCustomSource.AddRange(new string[] {
            "Sewa",
            "Kembali"});
            this.cb_mobile.FormattingEnabled = true;
            this.cb_mobile.Location = new System.Drawing.Point(34, 125);
            this.cb_mobile.Name = "cb_mobile";
            this.cb_mobile.Size = new System.Drawing.Size(273, 21);
            this.cb_mobile.TabIndex = 42;
            this.cb_mobile.SelectedIndexChanged += new System.EventHandler(this.cb_mobile_SelectedIndexChanged);
            // 
            // dt_rentalstart
            // 
            this.dt_rentalstart.Location = new System.Drawing.Point(35, 170);
            this.dt_rentalstart.Name = "dt_rentalstart";
            this.dt_rentalstart.Size = new System.Drawing.Size(273, 20);
            this.dt_rentalstart.TabIndex = 43;
            this.dt_rentalstart.ValueChanged += new System.EventHandler(this.dt_rentalstart_ValueChanged);
            // 
            // tb_pricerental
            // 
            this.tb_pricerental.Location = new System.Drawing.Point(35, 261);
            this.tb_pricerental.Name = "tb_pricerental";
            this.tb_pricerental.Size = new System.Drawing.Size(273, 20);
            this.tb_pricerental.TabIndex = 44;
            // 
            // Karyawan_Add_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 349);
            this.Controls.Add(this.tb_pricerental);
            this.Controls.Add(this.dt_rentalstart);
            this.Controls.Add(this.cb_mobile);
            this.Controls.Add(this.cb_pelanggan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_rentalstop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Karyawan_Add_Transaksi";
            this.Text = "Karyawan_Add_Transaksi";
            this.Load += new System.EventHandler(this.Karyawan_Add_Transaksi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_rentalstop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_pelanggan;
        private System.Windows.Forms.ComboBox cb_mobile;
        private System.Windows.Forms.DateTimePicker dt_rentalstart;
        private System.Windows.Forms.TextBox tb_pricerental;
    }
}