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
    public partial class Karyawan_Add_Transaksi : Form
    {
        AppDbContextDataContext context;
        public Karyawan_Add_Transaksi(Form mid)
        {
            context=new AppDbContextDataContext();
            this.MdiParent = mid;
            InitializeComponent();
        }

        private void showDatacb() { 
            var data =(from c in context.customers
                       orderby c.nama_customer ascending
                       select c).ToList();
            foreach (var item in data)
            {
                cb_pelanggan.Items.Add(item.nama_customer);
            }

            var car = (from m in context.cars
                       orderby m.brand ascending
                       select m).ToList();
            foreach (var item in car)
            {
                cb_mobile.Items.Add(item.brand);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cb_mobile.Text==""||cb_pelanggan.Text==""||tb_pricerental.Text==""||dt_rentalstart.Text==""||dt_rentalstop.Text=="")
            {
                MessageBox.Show(null, "Form belum terisi semua", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }

        private void Karyawan_Add_Transaksi_Load(object sender, EventArgs e)
        {
            showDatacb();
        }
    }
}
