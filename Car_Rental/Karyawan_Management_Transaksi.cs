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
        AppDbContextDataContext context;
        public Karyawan_Management_Transaksi()
        {
            context = new AppDbContextDataContext();
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
                    loadData();
                }
            };
            fAddTransaksi.Show();
        }

        private void Karyawan_Management_Transaksi_Load(object sender, EventArgs e)
        {
            loadData();
        }

      

        private void loadData() {
            int i=0;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible= false;
            dataGridView1.Rows.Clear();
            var data=(from t in context.transactions
                      join c in context.customers
                      on t.customer_id equals c.customer_id
                      join car in context.cars
                      on t.car_id equals car.car_id
                      where t.user_id==Helper.Helper.user.user_id
                      select new { 
                        id=t.transaction_id,
                        cusname=c.nama_customer,
                        carName=car.brand,
                        daterent=t.rent_date,
                        dateretrun=t.rent_date,
                        price=t.total_price
                      }).ToList();
            if (tb_search.Text != null)
            {
                data = data.Where(w => w.cusname.ToLower().Contains(tb_search.Text.ToLower()) | w.carName.ToLower().Contains(tb_search.Text.ToLower())).ToList();
            }

            foreach ( var t in data ) {
                i++;               
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value =i;
                dataGridView1.Rows[num].Cells[1].Value =t.id;
                dataGridView1.Rows[num].Cells[2].Value =t.cusname;
                dataGridView1.Rows[num].Cells[3].Value =t.carName;
                dataGridView1.Rows[num].Cells[4].Value =t.daterent;
                dataGridView1.Rows[num].Cells[5].Value =t.dateretrun;
                dataGridView1.Rows[num].Cells[6].Value =string.Format("{0:n}",t.price);                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id=string.Empty;
            if (e.ColumnIndex == 7)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var fAddTransaksi = new Karyawan_Add_Transaksi(this.MdiParent);
                fAddTransaksi.StartPosition = FormStartPosition.CenterParent;
                fAddTransaksi.id=int.Parse(id);
                fAddTransaksi.FormClosing += (object ass, FormClosingEventArgs assa)=>{
                    if (DialogResult.OK==fAddTransaksi.DialogResult)
                    {
                        loadData();
                    }
                };
                fAddTransaksi.Show();
            }
            if (e.ColumnIndex==8)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show(null, "Apakah anda yakin ingin menhapus data ini ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult==DialogResult.Yes)
                {
                    var data = context.transactions.Where(t => t.transaction_id == int.Parse(id)).FirstOrDefault();
                    if (data!=null)
                    {
                        context.transactions.DeleteOnSubmit(data);
                        context.SubmitChanges();
                        loadData();
                        MessageBox.Show(null, "Berhasil hapus data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data = (from t in context.transactions
                        join c in context.customers
                        on t.customer_id equals c.customer_id
                        join car in context.cars
                        on t.car_id equals car.car_id
                        where t.user_id == Helper.Helper.user.user_id
                        select new
                        {
                            id = t.transaction_id,
                            cusname = c.nama_customer,
                            carName = car.brand,
                            daterent = t.rent_date,
                            dateretrun = t.rent_date,
                            price = t.total_price
                        }).ToList();
            if (tb_search.Text != null)
            {
                data = data.Where(w => w.cusname.ToLower().Contains(tb_search.Text.ToLower()) | w.carName.ToLower().Contains(tb_search.Text.ToLower())).ToList();
            }

            foreach (var t in data)
            {
                i++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = i;
                dataGridView1.Rows[num].Cells[1].Value = t.id;
                dataGridView1.Rows[num].Cells[2].Value = t.cusname;
                dataGridView1.Rows[num].Cells[3].Value = t.carName;
                dataGridView1.Rows[num].Cells[4].Value = t.daterent;
                dataGridView1.Rows[num].Cells[5].Value = t.dateretrun;
                dataGridView1.Rows[num].Cells[6].Value = string.Format("{0:n}", t.price);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
