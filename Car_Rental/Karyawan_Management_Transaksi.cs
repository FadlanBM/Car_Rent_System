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
    public partial class Karyawan_Management_Transaksi : Form
    {
        public Karyawan_Management_Transaksi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fAddTransaksi=new Karyawan_Add_Transaksi(this.MdiParent);
            fAddTransaksi.StartPosition = FormStartPosition.CenterScreen;
            fAddTransaksi.FormClosing += (object sda, FormClosingEventArgs sada) =>
            {
                if (DialogResult.OK == fAddTransaksi.DialogResult)
                {

                }
            };
            fAddTransaksi.Show();
        }
    }
}
