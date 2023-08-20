using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Karyawan_dashboard : Form
    {
        public Karyawan_dashboard()
        {
            InitializeComponent();
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            var fCustomer=new Karyawan_Management_Customer();
            fCustomer.StartPosition = FormStartPosition.CenterScreen;
            fCustomer.MdiParent = this;
            fCustomer.Show();
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            var fManagementTransaksi= new Karyawan_Management_Transaksi();
            fManagementTransaksi.StartPosition= FormStartPosition.CenterScreen;
            fManagementTransaksi.MdiParent = this;
            fManagementTransaksi.Show();
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            var fResetPass=new FResetPassword();
            fResetPass.StartPosition = FormStartPosition.CenterScreen;
            fResetPass.MdiParent = this;
            fResetPass.FormClosing += (object saas, FormClosingEventArgs ada) =>
            {
                if (DialogResult.OK == fResetPass.DialogResult)
                {
                    this.Hide();
                }
            };
            fResetPass.Show();  
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(null, "Apakah anda yakin ingin logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                 new Login().Show();
                this.Close();
            }
            
        }
    }
}
