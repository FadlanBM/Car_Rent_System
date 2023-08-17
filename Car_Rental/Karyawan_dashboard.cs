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
    }
}
