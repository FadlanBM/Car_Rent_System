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
    }
}
