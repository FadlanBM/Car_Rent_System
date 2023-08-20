namespace Car_Rental
{
    partial class Admin_Add_Car
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_brand = new System.Windows.Forms.TextBox();
            this.tb_plate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_kursi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_addImage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Mobil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand";
            // 
            // tb_brand
            // 
            this.tb_brand.Location = new System.Drawing.Point(22, 75);
            this.tb_brand.Name = "tb_brand";
            this.tb_brand.Size = new System.Drawing.Size(273, 20);
            this.tb_brand.TabIndex = 2;
            // 
            // tb_plate
            // 
            this.tb_plate.Location = new System.Drawing.Point(22, 120);
            this.tb_plate.Name = "tb_plate";
            this.tb_plate.Size = new System.Drawing.Size(273, 20);
            this.tb_plate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Plate";
            // 
            // tb_color
            // 
            this.tb_color.Location = new System.Drawing.Point(22, 164);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(273, 20);
            this.tb_color.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Color";
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(22, 211);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(273, 20);
            this.dt_date.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.AutoCompleteCustomSource.AddRange(new string[] {
            "Sewa",
            "Kembali"});
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Sewa",
            "Kembali"});
            this.cb_status.Location = new System.Drawing.Point(22, 256);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(273, 21);
            this.cb_status.TabIndex = 10;
            // 
            // cb_kursi
            // 
            this.cb_kursi.FormattingEnabled = true;
            this.cb_kursi.Location = new System.Drawing.Point(22, 348);
            this.cb_kursi.Name = "cb_kursi";
            this.cb_kursi.Size = new System.Drawing.Size(273, 21);
            this.cb_kursi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Jumlah Kursi";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(51, 303);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(244, 20);
            this.tb_price.TabIndex = 14;
            this.tb_price.TextChanged += new System.EventHandler(this.tb_price_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Harga rental";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Gambar";
            // 
            // bt_addImage
            // 
            this.bt_addImage.Location = new System.Drawing.Point(22, 393);
            this.bt_addImage.Name = "bt_addImage";
            this.bt_addImage.Size = new System.Drawing.Size(217, 35);
            this.bt_addImage.TabIndex = 16;
            this.bt_addImage.Text = "Add Image";
            this.bt_addImage.UseVisualStyleBackColor = true;
            this.bt_addImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 32);
            this.button4.TabIndex = 19;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Rp";
            // 
            // Admin_Add_Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(336, 340);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_addImage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_kursi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.tb_color);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_plate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_brand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Add_Car";
            this.Text = "Admin_Add_Car";
            this.Load += new System.EventHandler(this.Admin_Add_Car_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_brand;
        private System.Windows.Forms.TextBox tb_plate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_kursi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_addImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
    }
}