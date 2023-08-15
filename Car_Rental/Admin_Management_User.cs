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
    public partial class Admin_Management_User : Form
    {
        AppDbContextDataContext context;
        public Admin_Management_User()
        {
            context = new AppDbContextDataContext();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Admin_Add_User(this.MdiParent);
            form.StartPosition = FormStartPosition.CenterScreen;

            form.FormClosing += (object closesender, FormClosingEventArgs ea) =>
            {
                if (form.DialogResult == DialogResult.OK)
                    LoadData();             
            };

            form.Show();
        }

        private void LoadData()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            int i = 0;
            var data=(from u in context.users
                      orderby u.name ascending 
                      select new { 
                        name=u.name,
                        id=u.user_id,
                        username=u.username,
                        level=u.level==0?"Admin":"Karyawan",
                      }).ToList();
            foreach (var item in data)
            {
                i++;
                var num=dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value= i;
                dataGridView1.Rows[num].Cells[1].Value= item.id;
                dataGridView1.Rows[num].Cells[2].Value= item.name;
                dataGridView1.Rows[num].Cells[3].Value= item.username;
                dataGridView1.Rows[num].Cells[4].Value= item.level;
            }
        }

        private void Admin_Management_User_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (e.ColumnIndex==5)
            {
                var form1=new Admin_Add_User(this.MdiParent);
                form1.StartPosition = FormStartPosition.CenterParent;
                form1.id = id;
                form1.FormClosing += (object closeseder1, FormClosingEventArgs aw) =>
                {
                    if (form1.DialogResult == DialogResult.OK)                    
                        LoadData();
                    
                };
                form1.Show();
            }
            if (e.ColumnIndex==6)
            {
                DialogResult dialog = MessageBox.Show(null, "Pakah anda yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    var data=context.users.Where(u=>u.user_id==int.Parse(id)).FirstOrDefault();
                    context.users.DeleteOnSubmit(data);
                    context.SubmitChanges();
                    MessageBox.Show(null, "berhasil menghapus data ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            int i = 0;
            var data = (from u in context.users
                        orderby u.name ascending
                        select new
                        {
                            name = u.name,
                            id = u.user_id,
                            username = u.username,
                            level = u.level == 0 ? "Admin" : "Karyawan",
                        }).ToList();

            if (tb_search.Text!="")
            {
                data = data.Where(u => u.name.Contains(tb_search.Text)|u.username.Contains(tb_search.Text)|u.level.Contains(tb_search.Text)).ToList();
            }
            foreach (var item in data)
            {
                i++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = i;
                dataGridView1.Rows[num].Cells[1].Value = item.id;
                dataGridView1.Rows[num].Cells[2].Value = item.name;
                dataGridView1.Rows[num].Cells[3].Value = item.username;
                dataGridView1.Rows[num].Cells[4].Value = item.level;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_orderList.Text== "Descending")
            {                
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            int i = 0;
            var data = (from u in context.users
                        orderby u.name descending
                        select new
                        {
                            name = u.name,
                            id = u.user_id,
                            username = u.username,
                            level = u.level == 0 ? "Admin" : "Karyawan",
                        }).ToList();
         
            foreach (var item in data)
            {
                i++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = i;
                dataGridView1.Rows[num].Cells[1].Value = item.id;
                dataGridView1.Rows[num].Cells[2].Value = item.name;
                dataGridView1.Rows[num].Cells[3].Value = item.username;
                dataGridView1.Rows[num].Cells[4].Value = item.level;
            }
            }
            else
            {
                LoadData();
            }
        }

        private void cb_orderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
