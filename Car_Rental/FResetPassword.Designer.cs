namespace Car_Rental
{
    partial class FResetPassword
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
            this.tb_comfimPas = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_passold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_passnew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_comfimPas
            // 
            this.tb_comfimPas.Location = new System.Drawing.Point(27, 169);
            this.tb_comfimPas.Name = "tb_comfimPas";
            this.tb_comfimPas.Size = new System.Drawing.Size(273, 20);
            this.tb_comfimPas.TabIndex = 57;
            this.tb_comfimPas.UseSystemPasswordChar = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 32);
            this.button3.TabIndex = 53;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 32);
            this.button4.TabIndex = 52;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Comfim Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tambah Transaksi";
            // 
            // tb_passold
            // 
            this.tb_passold.Location = new System.Drawing.Point(27, 69);
            this.tb_passold.Name = "tb_passold";
            this.tb_passold.Size = new System.Drawing.Size(273, 20);
            this.tb_passold.TabIndex = 59;
            this.tb_passold.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Password Old";
            // 
            // tb_passnew
            // 
            this.tb_passnew.Location = new System.Drawing.Point(27, 118);
            this.tb_passnew.Name = "tb_passnew";
            this.tb_passnew.Size = new System.Drawing.Size(273, 20);
            this.tb_passnew.TabIndex = 61;
            this.tb_passnew.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Password New";
            // 
            // FResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 277);
            this.Controls.Add(this.tb_passnew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_passold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_comfimPas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FResetPassword";
            this.Text = "FResetPassword";
            this.Load += new System.EventHandler(this.FResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_comfimPas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_passold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_passnew;
        private System.Windows.Forms.Label label3;
    }
}