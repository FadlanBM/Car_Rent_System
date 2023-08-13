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
            var form = new Admin_Add_User();
            form.StartPosition = FormStartPosition.CenterScreen;
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
                MessageBox.Show(id);
                var form=new Admin_Add_User();
                form.id = id;
                form.Show();
                this.Close();
            }
        }
    }
}
