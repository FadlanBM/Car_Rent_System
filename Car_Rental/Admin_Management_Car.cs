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
    public partial class Admin_Management_Car : Form
    {
        AppDbContextDataContext context;
        public Admin_Management_Car()
        {
            context = new AppDbContextDataContext();
            InitializeComponent();
        }

        private void loadData() {
            int i = 0;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data = (from c in context.cars
                        join s in context.carseats
                        on c.car_seat_id equals s.car_seat_id
                        orderby c.brand descending
                        select new
                        {
                            car_id = c.car_id,
                            brand = c.brand,
                            plate = c.plate,
                            color = c.color,
                            year = c.year,
                            status = c.status == 0 ? "Sewa" : "Kembali",
                            price = c.rental_price,
                            carseet = s.name
                        }).ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    i++;
                    var num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = i;
                    dataGridView1.Rows[num].Cells[1].Value = item.car_id;
                    dataGridView1.Rows[num].Cells[2].Value = item.brand;
                    dataGridView1.Rows[num].Cells[3].Value = item.plate;
                    dataGridView1.Rows[num].Cells[4].Value = item.color;
                    dataGridView1.Rows[num].Cells[5].Value = item.year;
                    dataGridView1.Rows[num].Cells[6].Value = item.status;
                    dataGridView1.Rows[num].Cells[7].Value = item.price;
                    dataGridView1.Rows[num].Cells[8].Value = item.carseet;
                }
            }
        }

        private void Admin_Management_Car_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formAdd = new Admin_Add_Car(this.MdiParent);
            formAdd.StartPosition = FormStartPosition.CenterScreen;
            formAdd.FormClosing += (object seed, FormClosingEventArgs ag) =>
            {
                if (DialogResult.OK == formAdd.DialogResult) {
                    loadData();
                }
                
            };
            formAdd.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (e.ColumnIndex==8)
            {
               var fromadd = new Admin_Add_Car(this.MdiParent);
                fromadd.id=int.Parse(id);
                fromadd.StartPosition= FormStartPosition.CenterScreen;

                fromadd.FormClosing += (object ac, FormClosingEventArgs r) => {
                    if (fromadd.DialogResult == DialogResult.OK)
                        loadData();
                };
                fromadd.Show();
            }
            if (e.ColumnIndex==9)
            {
                DialogResult dialog = MessageBox.Show(null, "Apakah anda yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    var data=context.cars.Where(cs=>cs.car_id==int.Parse(id)).FirstOrDefault();
                    context.cars.DeleteOnSubmit(data);
                    context.SubmitChanges();
                    MessageBox.Show(null, "Berhasil Hapus data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data = (from c in context.cars
                        join s in context.carseats
                        on c.car_seat_id equals s.car_seat_id
                        orderby c.brand ascending
                        select new
                        {
                            car_id = c.car_id,
                            brand = c.brand,
                            plate = c.plate,
                            color = c.color,
                            year = c.year,
                            status = c.status == 0 ? "Sewa" : "Kembali",
                            price = c.rental_price,
                            carseet = s.name
                        }).ToList();
            if (data != null)
            {
                if (tb_search.Text!=null)
                {
                    data = data.Where(c => c.brand.ToLower().Contains(tb_search.Text.ToLower()) | c.plate.ToLower().Contains(tb_search.Text.ToLower())).ToList();
                }
                foreach (var item in data)
                {
                    i++;
                    var num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = i;
                    dataGridView1.Rows[num].Cells[1].Value = item.car_id;
                    dataGridView1.Rows[num].Cells[2].Value = item.brand;
                    dataGridView1.Rows[num].Cells[3].Value = item.plate;
                    dataGridView1.Rows[num].Cells[4].Value = item.color;
                    dataGridView1.Rows[num].Cells[5].Value = item.year;
                    dataGridView1.Rows[num].Cells[6].Value = item.status;
                    dataGridView1.Rows[num].Cells[7].Value = item.price;
                    dataGridView1.Rows[num].Cells[8].Value = item.carseet;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (cb_orderList.Text == "Descending")
            {

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Rows.Clear();
                var datad = (from c in context.cars
                             join s in context.carseats
                             on c.car_seat_id equals s.car_seat_id
                             orderby c.brand
                             select new
                             {
                                 car_id = c.car_id,
                                 brand = c.brand,
                                 plate = c.plate,
                                 color = c.color,
                                 year = c.year,
                                 status = c.status == 0 ? "Sewa" : "Kembali",
                                 price = c.rental_price,
                                 carseet = s.name
                             }).ToList();
                if (datad != null)
                {
                    foreach (var item in datad)
                    {
                        i++;
                        var num = dataGridView1.Rows.Add();
                        dataGridView1.Rows[num].Cells[0].Value = i;
                        dataGridView1.Rows[num].Cells[1].Value = item.car_id;
                        dataGridView1.Rows[num].Cells[2].Value = item.brand;
                        dataGridView1.Rows[num].Cells[3].Value = item.plate;
                        dataGridView1.Rows[num].Cells[4].Value = item.color;
                        dataGridView1.Rows[num].Cells[5].Value = item.year;
                        dataGridView1.Rows[num].Cells[6].Value = item.status;
                        dataGridView1.Rows[num].Cells[7].Value = item.price;
                        dataGridView1.Rows[num].Cells[8].Value = item.carseet;
                    }
                }
                return;
            }
            loadData();

        }
    }
}
