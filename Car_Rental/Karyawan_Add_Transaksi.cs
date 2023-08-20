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
        private TimeSpan numberday;
        public int? id { get; set; }=null;
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

            if (id==null)
            {
                transaction transaction = new transaction();
                var customer = context.customers.Where(c => c.nama_customer == cb_pelanggan.Text).FirstOrDefault();
                var car = context.cars.Where(cr => cr.brand == cb_mobile.Text).FirstOrDefault();
                transaction.user_id = Helper.Helper.user.user_id;
                transaction.customer_id = customer.customer_id;
                transaction.car_id = car.car_id;
                transaction.rent_date = dt_rentalstart.Value;
                transaction.return_date = dt_rentalstop.Value;
                transaction.total_price = float.Parse(tb_pricerental.Text);
                context.transactions.InsertOnSubmit(transaction);
                context.SubmitChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show(null, "Berhasil Input data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var transaction=context.transactions.Where(t=>t.transaction_id==id).FirstOrDefault();
                var customer = context.customers.Where(c => c.nama_customer == cb_pelanggan.Text).FirstOrDefault();
                var car = context.cars.Where(cr => cr.brand == cb_mobile.Text).FirstOrDefault();
                transaction.user_id = Helper.Helper.user.user_id;
                transaction.customer_id = customer.customer_id;
                transaction.car_id = car.car_id;
                transaction.rent_date = dt_rentalstart.Value;
                transaction.return_date = dt_rentalstop.Value;
                transaction.total_price = float.Parse(tb_pricerental.Text);
                context.SubmitChanges(); 
                MessageBox.Show(null, "Berhasil Update data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
                return;
            }


        }

        private void loadData() {
            var data = context.transactions.Where(t => t.transaction_id == id).FirstOrDefault();
            if (data != null)
            {
                var car=context.cars.Where(c=>c.car_id==data.car_id).FirstOrDefault();
                var customer = context.customers.Where(cus => cus.customer_id == data.customer_id).FirstOrDefault();
                cb_pelanggan.Text = customer.nama_customer;
                cb_mobile.Text = car.brand;
                dt_rentalstart.Value = data.rent_date;
                dt_rentalstop.Value = data.return_date;
                tb_pricerental.Text = string.Format("{0:n}", data.total_price);
            }
            
        }

        private void Karyawan_Add_Transaksi_Load(object sender, EventArgs e)
        {
            showDatacb();
            logicform();
            if (id!=null)
            {                
            loadData();          
            }
        }

        private void logicform() {
            
            if (cb_mobile.Text=="")
            {
                dt_rentalstart.Enabled = false;
                dt_rentalstop.Enabled = false;
                tb_pricerental.Enabled = false;
            }
            else
            {
                dt_rentalstart.Enabled = true;
                dt_rentalstop.Enabled = true;
                tb_pricerental.Enabled = true;
            }

            if (cb_pelanggan.Text == "")
            {
                cb_mobile.Enabled = false;
            }
            else
            {
                cb_mobile.Enabled = true;
            }
        }

        private void dt_rentalstop_ValueChanged(object sender, EventArgs e)
        {
            if (dt_rentalstop.Value>dt_rentalstart.Value)
            {
                DateTime dt = dt_rentalstop.Value.Date;
            numberday= dt.Subtract(dt_rentalstart.Value.Date);

            var mobile = context.cars.Where(c => c.brand == cb_mobile.Text).FirstOrDefault();
            var price =mobile.rental_price*float.Parse(numberday.ToString().Replace("0", "").Replace(":", "").Replace(".", ""));        
            tb_pricerental.Text = string.Format("{0:n}",price);
            }
            else
            {
                MessageBox.Show(null, "Tanggal pengembalian tidak boleh kurang dari hari peminjaman ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt_rentalstop.Value=DateTime.Now.AddDays(1);
            }

        }

        private void dt_rentalstart_ValueChanged(object sender, EventArgs e)
        {
            if (id==null)
            {
                if (dt_rentalstart.Value<DateTime.Now.Date)            

            {
                MessageBox.Show(null, "Tanggal peminjaman tidak boleh kurang dari hari sekarang", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt_rentalstart.Value = DateTime.Now;
            }
            }
            else
            {
                var data =context.transactions.Where(t=>t.transaction_id==id).FirstOrDefault();
                if (dt_rentalstart.Value<data.rent_date)
                {
                    MessageBox.Show(null, "Tanggal peminjaman tidak boleh kurang dari hari sekarang", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt_rentalstart.Value=data.rent_date;
                }
            }

        }

        private void cb_mobile_SelectedIndexChanged(object sender, EventArgs e)
        {
            logicform();
        }

        private void cb_pelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            logicform();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
