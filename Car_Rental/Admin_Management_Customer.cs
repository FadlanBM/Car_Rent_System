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
    public partial class Admin_Management_Customer : Form
    {
        AppDbContextDataContext context;
        public Admin_Management_Customer()
        {
            context = new AppDbContextDataContext();
            InitializeComponent();
        }

        private void Admin_Management_Customer_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData() {            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data = (from c in context.customers
                        join i in context.identity_types
                        on c.identity_type_id equals i.identity_type_id
                        orderby c.nama_customer ascending
                        select new { 
                            id=c.identity_type_id,
                            name=c.nama_customer,
                            noIden=c.identity_number,
                            tipeIden=i.name,
                            alamat=c.address,
                            phone=c.phone_number,
                            gender=c.gender==0?"Laki Laki":"Perempuan",
                        }).ToList();

            if (tb_search.Text!="")
            {
                data = data.Where(d => d.name.Contains(tb_search.Text)).ToList();
            }
            var idn = 0;
            foreach ( var c in data )
            {
                idn++;
                var num=dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = idn;
                dataGridView1.Rows[num].Cells[1].Value = c.id;
                dataGridView1.Rows[num].Cells[2].Value = c.name;
                dataGridView1.Rows[num].Cells[3].Value = c.noIden;
                dataGridView1.Rows[num].Cells[4].Value = c.tipeIden;
                dataGridView1.Rows[num].Cells[5].Value = c.alamat;
                dataGridView1.Rows[num].Cells[6].Value = c.phone;
                dataGridView1.Rows[num].Cells[7].Value = c.gender;                
            }
        } private void loadDataDes() {            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data = (from c in context.customers
                        join i in context.identity_types
                        on c.identity_type_id equals i.identity_type_id
                        orderby c.nama_customer descending
                        select new { 
                            id=c.identity_type_id,
                            name=c.nama_customer,
                            noIden=c.identity_number,
                            tipeIden=i.name,
                            alamat=c.address,
                            phone=c.phone_number,
                            gender=c.gender==0?"Laki Laki":"Perempuan",
                        }).ToList();

            if (tb_search.Text!="")
            {
                data = data.Where(d => d.name.Contains(tb_search.Text)).ToList();
            }
            var idn = 0;
            foreach ( var c in data )
            {
                idn++;
                var num=dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = idn;
                dataGridView1.Rows[num].Cells[1].Value = c.id;
                dataGridView1.Rows[num].Cells[2].Value = c.name;
                dataGridView1.Rows[num].Cells[3].Value = c.noIden;
                dataGridView1.Rows[num].Cells[4].Value = c.tipeIden;
                dataGridView1.Rows[num].Cells[5].Value = c.alamat;
                dataGridView1.Rows[num].Cells[6].Value = c.phone;
                dataGridView1.Rows[num].Cells[7].Value = c.gender;                
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data = (from c in context.customers
                        join i in context.identity_types
                        on c.identity_type_id equals i.identity_type_id
                        select new
                        {
                            id = c.identity_type_id,
                            name = c.nama_customer,
                            noIden = c.identity_number,
                            tipeIden = i.name,
                            alamat = c.address,
                            phone = c.phone_number,
                            gender = c.gender == 0 ? "Laki Laki" : "Perempuan",
                        }).ToList();

            if (tb_search.Text != "")
            {
                data = data.Where(d => d.name.Contains(tb_search.Text)).ToList();
            }
            var idn = 0;
            foreach (var c in data)
            {
                idn++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = idn;
                dataGridView1.Rows[num].Cells[1].Value = c.id;
                dataGridView1.Rows[num].Cells[2].Value = c.name;
                dataGridView1.Rows[num].Cells[3].Value = c.noIden;
                dataGridView1.Rows[num].Cells[4].Value = c.tipeIden;
                dataGridView1.Rows[num].Cells[5].Value = c.alamat;
                dataGridView1.Rows[num].Cells[6].Value = c.phone;
                dataGridView1.Rows[num].Cells[7].Value = c.gender;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_orderList.Text== "Descending")
            {
                loadDataDes();
            }
            else
            {
                loadData();
            }
        }
    }
}
