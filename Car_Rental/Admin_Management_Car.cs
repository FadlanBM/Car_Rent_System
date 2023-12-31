﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Admin_Management_Car : Form
    {
        AppDbContextDataContext context;
        private Image cusimage;
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
                        orderby c.brand ascending
                        select new
                        {
                            car_id = c.car_id,
                            brand = c.brand,
                            plate = c.plate,
                            color = c.color,
                            year = c.year,
                            status = c.status == 0 ? "Sewa" : "Kembali",
                            price = string.Format("{0:n}",c.rental_price),
                            carseet = s.name,
                            imagename=c.image_name
                        }).ToList();
            var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\image\";
            if (data != null)
            {
                foreach (var item in data)
                {
                    if (File.Exists(path+item.imagename))
                    {
                        using (var stram =File.OpenRead(path+item.imagename))
                    {
                        cusimage = new Bitmap(stram);
                    }
                    }                   
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
                    dataGridView1.Rows[num].Cells[11].Value = cusimage;
                }
            }

        }  private void loadDataDes() {
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
                            price = string.Format("{0:n}",c.rental_price),
                            carseet = s.name,
                            imagename=c.image_name
                        }).ToList();
            var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\image\";
            if (data != null)
            {
                foreach (var item in data)
                {
                    if (File.Exists(path+item.imagename))
                    {
                        using (var stram =File.OpenRead(path+item.imagename))
                    {
                        cusimage = new Bitmap(stram);
                    }
                    }                   
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
                    dataGridView1.Rows[num].Cells[11].Value = cusimage;
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
                    if (cb_orderList.Text == "Descending")
                        loadDataDes();
                    else
                        loadData();
                }
                
            };
            formAdd.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==9)
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var fromadd = new Admin_Add_Car(this.MdiParent);
                fromadd.id=int.Parse(id);
                fromadd.StartPosition= FormStartPosition.CenterScreen;
                fromadd.FormClosing += (object ac, FormClosingEventArgs r) => {
                    if (fromadd.DialogResult == DialogResult.OK)
                        if (cb_orderList.Text == "Descending")
                            loadDataDes();
                        else
                            loadData();
                };
                fromadd.Show();
            }
            if (e.ColumnIndex==10)
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                DialogResult dialog = MessageBox.Show(null, "Apakah anda yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    var data=context.cars.Where(cs=>cs.car_id==int.Parse(id)).FirstOrDefault();
                    var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\image\";
                    var nameImage = data.image_name;
                    if (File.Exists(path + nameImage))
                    {
                        File.Delete(path + nameImage);
                    }
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
                            carseet = s.name,
                            imagename = c.image_name
                        }).ToList();

            if (tb_search.Text!=null)
            {
                data = data.Where(d => d.brand.ToLower().Contains(tb_search.Text.ToLower()) | d.plate.ToLower().Contains(tb_search.Text.ToLower()) | d.color.ToLower().Contains(tb_search.Text.ToLower())).ToList();
            }
            var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\image\";
            if (data != null)
            {
                foreach (var item in data)
                {
                    if (File.Exists(path + item.imagename))
                    {
                        using (var stram = File.OpenRead(path + item.imagename))
                        {
                            cusimage = new Bitmap(stram);
                        }
                    }
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
                    dataGridView1.Rows[num].Cells[10].Value = cusimage;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_orderList.Text == "Ascending")
            {
                loadData();
            }
            if (cb_orderList.Text == "Descending")
            {
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
                                carseet = s.name,
                                imagename = c.image_name
                            }).ToList();
                var path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\image\";
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        if (File.Exists(path + item.imagename))
                        {
                            using (var stram = File.OpenRead(path + item.imagename))
                            {
                                cusimage = new Bitmap(stram);
                            }
                        }
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
                        dataGridView1.Rows[num].Cells[10].Value = cusimage;
                    }
                }
            }

        }

        private void cb_orderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
