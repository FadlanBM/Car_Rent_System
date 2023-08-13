namespace Car_Rental
{
    partial class Admin_Add_User
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
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rd_admin = new System.Windows.Forms.RadioButton();
            this.rd_karyawan = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_informasi = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(35, 73);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(306, 20);
            this.tb_nama.TabIndex = 2;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(35, 125);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(306, 20);
            this.tb_username.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(35, 175);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(306, 20);
            this.tb_password.TabIndex = 6;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Level";
            // 
            // rd_admin
            // 
            this.rd_admin.AutoSize = true;
            this.rd_admin.Location = new System.Drawing.Point(170, 254);
            this.rd_admin.Name = "rd_admin";
            this.rd_admin.Size = new System.Drawing.Size(85, 17);
            this.rd_admin.TabIndex = 8;
            this.rd_admin.TabStop = true;
            this.rd_admin.Text = "Administrator";
            this.rd_admin.UseVisualStyleBackColor = true;
            this.rd_admin.CheckedChanged += new System.EventHandler(this.rd_admin_CheckedChanged);
            // 
            // rd_karyawan
            // 
            this.rd_karyawan.AutoSize = true;
            this.rd_karyawan.Location = new System.Drawing.Point(266, 254);
            this.rd_karyawan.Name = "rd_karyawan";
            this.rd_karyawan.Size = new System.Drawing.Size(72, 17);
            this.rd_karyawan.TabIndex = 9;
            this.rd_karyawan.TabStop = true;
            this.rd_karyawan.Text = "Karyawan";
            this.rd_karyawan.UseVisualStyleBackColor = true;
            this.rd_karyawan.CheckedChanged += new System.EventHandler(this.rd_karyawan_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_informasi
            // 
            this.lb_informasi.AutoSize = true;
            this.lb_informasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_informasi.Location = new System.Drawing.Point(83, 207);
            this.lb_informasi.Name = "lb_informasi";
            this.lb_informasi.Size = new System.Drawing.Size(218, 32);
            this.lb_informasi.TabIndex = 12;
            this.lb_informasi.Text = "jika tadak ingin merubah password \r\nsilahkan kosongkan form password";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(35, 292);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 29);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Reset Password";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Admin_Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 333);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lb_informasi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rd_karyawan);
            this.Controls.Add(this.rd_admin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Add_User";
            this.Text = "Admin_Add_User";
            this.Load += new System.EventHandler(this.Admin_Add_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rd_admin;
        private System.Windows.Forms.RadioButton rd_karyawan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_informasi;
        private System.Windows.Forms.Button btn_reset;
    }
}