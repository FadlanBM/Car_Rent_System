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
    public partial class Admin_Management_TipeIdentitas : Form
    {
        public Admin_Management_TipeIdentitas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FrAddIdentity = new Admin_Add_Identitas();
            FrAddIdentity.StartPosition = FormStartPosition.CenterScreen;
            FrAddIdentity.FormClosing+=(object sd, FormClosingEventArgs ss) => {
                if (FrAddIdentity.ShowDialog()==DialogResult.OK)
                {
                    
                }
            }
        }
    }
}
