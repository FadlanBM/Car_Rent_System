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
    public partial class Admin_dashboard : Form
    {
        public Admin_dashboard()
        {
            InitializeComponent();            
        }

     

        private void ribbon1_Click(object sender, EventArgs e)
        {
         
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            var managementUser=new Admin_Management_User();
            managementUser.MdiParent = this;
            managementUser.StartPosition = FormStartPosition.CenterScreen;
            managementUser.Show();
        }

        private void Admin_dashboard_Load(object sender, EventArgs e)
        {
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            var formcar=new Admin_Management_Car();
            formcar.MdiParent = this;
            formcar.StartPosition = FormStartPosition.CenterScreen;
            formcar.Show();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            var frtipeidnetity=new Admin_Management_TipeIdentitas();
            frtipeidnetity.MdiParent = this;
            frtipeidnetity.StartPosition= FormStartPosition.CenterScreen;   
            frtipeidnetity.Show();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            var frCarseet=new Admin_Management_Carseet();   
            frCarseet.MdiParent= this;
            frCarseet.StartPosition= FormStartPosition.CenterScreen;    
            frCarseet.Show();            
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            var fManagement_Transaksi=new Admin_Management_Transaksi();
            fManagement_Transaksi.StartPosition= FormStartPosition.CenterScreen;
            fManagement_Transaksi.MdiParent=this;
            fManagement_Transaksi.Show();
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            var FManagementCustomer=new Admin_Management_Customer();
            FManagementCustomer.MdiParent= this;
            FManagementCustomer.StartPosition= FormStartPosition.CenterScreen;
            FManagementCustomer.Show();
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(null, "Apakah anda  yakin ingin logout", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
            new Login().Show();
            this.Close();   
            }
           
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            var fResetPass=new FResetPassword();
            fResetPass.StartPosition= FormStartPosition.CenterScreen;
            fResetPass.MdiParent=this;
            fResetPass.FormClosing += (object asa, FormClosingEventArgs asq) =>
            {
                if (DialogResult.OK == fResetPass.DialogResult)
                {
                    this.Hide();
                }
            };
           fResetPass.Show();
        }
    }
}
