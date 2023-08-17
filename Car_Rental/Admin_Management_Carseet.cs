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
    public partial class Admin_Management_Carseet : Form
    {
        AppDbContextDataContext context;
        public Admin_Management_Carseet()
        {            
            context = new AppDbContextDataContext();
            InitializeComponent();
        }

        private void Admin_Management_Carseet_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData() { 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            int i = 0;
            var data = (from ct in context.carseats
                        orderby ct.name ascending
                        select new
                        {
                            id=ct.car_seat_id,
                            name=ct.name,
                        }).ToList();
            foreach ( var item in data)
            {
                i++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = i;
                dataGridView1.Rows[num].Cells[1].Value = item.id;
                dataGridView1.Rows[num].Cells[2].Value= item.name;  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fCarSeet=new Admin_Add_Carseet(this.MdiParent);
            fCarSeet.StartPosition = FormStartPosition.CenterParent;
            fCarSeet.FormClosing += (object sd, FormClosingEventArgs sf) =>
            {
                if (DialogResult.OK == fCarSeet.DialogResult)
                
                    loadData();
                
            };
            fCarSeet.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==3)
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var fCarSeet= new Admin_Add_Carseet(this.MdiParent);
                fCarSeet.id = int.Parse(id);
                fCarSeet.StartPosition=FormStartPosition.CenterParent;
                fCarSeet.FormClosing += (object ls, FormClosingEventArgs fs) =>
                {
                    if (DialogResult.OK == fCarSeet.DialogResult)
                    
                        loadData();
                    
                };
                fCarSeet.Show();                
            }
            if (e.ColumnIndex==4)
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                DialogResult dialog = MessageBox.Show(null, "Apakah anda yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    var data=context.carseats.Where(c=>c.car_seat_id==int.Parse(id)).FirstOrDefault();
                    var car=context.cars.Where(c=>c.car_seat_id==data.car_seat_id).FirstOrDefault();
                    
                    if (data!=null)
                    {
                        if (car!=null)
                        {
                            MessageBox.Show(null, "Data Tidak bisa di hapus karena masih di gunakan","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        context.carseats.DeleteOnSubmit(data);
                        context.SubmitChanges();
                        loadData();
                        MessageBox.Show(null, "Berhasil menghapus data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            int i = 0;
            var data = (from ct in context.carseats
                        orderby ct.name ascending
                        select new
                        {
                            id = ct.car_seat_id,
                            name = ct.name,
                        }).ToList();
            if (tb_search.Text!=null)
            {
                data = data.Where(cs => cs.name.ToLower().Contains(tb_search.Text.ToLower())).ToList();
            }
            foreach (var item in data)
            {
                i++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = i;
                dataGridView1.Rows[num].Cells[1].Value = item.id;
                dataGridView1.Rows[num].Cells[2].Value = item.name;
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
                var data = (from ct in context.carseats
                            orderby ct.name descending
                            select new
                            {
                                id = ct.car_seat_id,
                                name = ct.name,
                            }).ToList();
                foreach (var item in data)
                {
                    i++;
                    var num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = i;
                    dataGridView1.Rows[num].Cells[1].Value = item.id;
                    dataGridView1.Rows[num].Cells[2].Value = item.name;
                }
            }
            else
            {
                loadData(); 
            }
        }
    }
}
