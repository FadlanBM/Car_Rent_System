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
        AppDbContextDataContext context;
        public Admin_Management_TipeIdentitas()
        {
            context = new AppDbContextDataContext();
            InitializeComponent();
        }
        private void loaddata() { 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var idn = 0;
            var data = (from i in context.identity_types
                        orderby i.name ascending
                        select new
                        {
                            id = i.identity_type_id,
                            name = i.name,
                        }).ToList();

           foreach ( var item in data )
            {
                idn++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value =idn ;
                dataGridView1.Rows[num].Cells[1].Value =item.id ;
                dataGridView1.Rows[num].Cells[2].Value =item.name ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FrAddIdentity = new Admin_Add_Identitas(this.MdiParent);
            FrAddIdentity.StartPosition = FormStartPosition.CenterScreen;
            FrAddIdentity.FormClosing += (object sd, FormClosingEventArgs ss) =>
            {
                if (DialogResult.OK==FrAddIdentity.DialogResult)
                
                    loaddata();
                
            };
            FrAddIdentity.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id=string.Empty;
            if (e.ColumnIndex==3)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var frAddiden= new Admin_Add_Identitas(this.MdiParent);
                frAddiden.id=int.Parse(id);
                frAddiden.StartPosition = FormStartPosition.CenterScreen;
                frAddiden.FormClosing += (object cc, FormClosingEventArgs ag) =>
                {
                    if (DialogResult.OK == frAddiden.DialogResult)
                                        loaddata();
                    
                };
                frAddiden.Show();
                return;
            }
            if (e.ColumnIndex==4) {
                id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                DialogResult dialog = MessageBox.Show(null, "Apakah anda yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    var data = context.identity_types.Where(i => i.identity_type_id == int.Parse(id)).FirstOrDefault();
                    context.identity_types.DeleteOnSubmit(data);
                    context.SubmitChanges();
                    MessageBox.Show(null, "Apakah anda yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loaddata();
                    return;
                }
            }
        }

        private void Admin_Management_TipeIdentitas_Load(object sender, EventArgs e)
        {
            loaddata();

        }
    }
}
