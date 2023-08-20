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
    public partial class Admin_Management_Transaksi : Form
    {
        AppDbContextDataContext context;
        public Admin_Management_Transaksi()
        {
            context = new AppDbContextDataContext();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void showData() { 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data=(from t in context.transactions
                      join c in context.cars
                      on t.car_id equals c.car_id
                      join u in context.users
                      on t.user_id equals u.user_id
                      join cs in context.customers
                      on t.customer_id equals cs.customer_id
                      orderby u.user_id ascending
                      select new { 
                          id=t.transaction_id,
                          karyawan=u.name,
                          pelanggan=cs.nama_customer,
                          mobile=c.brand,
                          start=t.rent_date,
                          end=t.return_date,
                          price=t.total_price
                      }).ToList();

            if (tb_search.Text!=null)
            {
                data = data.Where(d => d.karyawan.ToLower().Contains(tb_search.Text.ToLower()) | d.pelanggan.ToLower().Contains(tb_search.Text.ToLower()) | d.mobile.ToLower().Contains(tb_search.Text.ToLower())).ToList();
            }
            int i = 0;
            foreach (var item in data)
            {
                i++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = i;
                dataGridView1.Rows[num].Cells[1].Value = item.id;
                dataGridView1.Rows[num].Cells[2].Value = item.karyawan;
                dataGridView1.Rows[num].Cells[3].Value = item.pelanggan;
                dataGridView1.Rows[num].Cells[4].Value = item.mobile;
                dataGridView1.Rows[num].Cells[5].Value = item.start;
                dataGridView1.Rows[num].Cells[6].Value = item.end;
                dataGridView1.Rows[num].Cells[7].Value = item.price;
            }
        } private void showDataDes() { 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data=(from t in context.transactions
                      join c in context.cars
                      on t.car_id equals c.car_id
                      join u in context.users
                      on t.user_id equals u.user_id
                      join cs in context.customers
                      on t.customer_id equals cs.customer_id
                      orderby u.user_id descending
                      select new { 
                          id=t.transaction_id,
                          karyawan=u.name,
                          pelanggan=cs.nama_customer,
                          mobile=c.brand,
                          start=t.rent_date,
                          end=t.return_date,
                          price=t.total_price
                      }).ToList();

            if (tb_search.Text != null)
            {
                data = data.Where(d => d.karyawan.ToLower().Contains(tb_search.Text.ToLower()) | d.pelanggan.ToLower().Contains(tb_search.Text.ToLower()) | d.mobile.ToLower().Contains(tb_search.Text.ToLower())).ToList();
            }
            int i = 0;
            foreach (var item in data)
            {
                i++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = i;
                dataGridView1.Rows[num].Cells[1].Value = item.id;
                dataGridView1.Rows[num].Cells[2].Value = item.karyawan;
                dataGridView1.Rows[num].Cells[3].Value = item.pelanggan;
                dataGridView1.Rows[num].Cells[4].Value = item.mobile;
                dataGridView1.Rows[num].Cells[5].Value = item.start;
                dataGridView1.Rows[num].Cells[6].Value = item.end;
                dataGridView1.Rows[num].Cells[7].Value = item.price;
            }
        }
        private void Admin_Management_Transaksi_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_orderList.Text== "Descending")
            {
                showDataDes();
            }
            else
            {
                showData();
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data = (from t in context.transactions
                        join c in context.cars
                        on t.car_id equals c.car_id
                        join u in context.users
                        on t.user_id equals u.user_id
                        join cs in context.customers
                        on t.customer_id equals cs.customer_id
                        orderby u.user_id descending
                        select new
                        {
                            id = t.transaction_id,
                            karyawan = u.name,
                            pelanggan = cs.nama_customer,
                            mobile = c.brand,
                            start = t.rent_date,
                            end = t.return_date,
                            price = t.total_price
                        }).ToList();

            if (tb_search.Text != null)
            {
                data = data.Where(d => d.karyawan.ToLower().Contains(tb_search.Text.ToLower()) | d.pelanggan.ToLower().Contains(tb_search.Text.ToLower()) | d.mobile.ToLower().Contains(tb_search.Text.ToLower())).ToList();
            }
            int i = 0;
            foreach (var item in data)
            {
                i++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = i;
                dataGridView1.Rows[num].Cells[1].Value = item.id;
                dataGridView1.Rows[num].Cells[2].Value = item.karyawan;
                dataGridView1.Rows[num].Cells[3].Value = item.pelanggan;
                dataGridView1.Rows[num].Cells[4].Value = item.mobile;
                dataGridView1.Rows[num].Cells[5].Value = item.start;
                dataGridView1.Rows[num].Cells[6].Value = item.end;
                dataGridView1.Rows[num].Cells[7].Value = item.price;
            }
        }
    }
}
