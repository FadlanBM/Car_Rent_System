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
    public partial class Admin_Add_Car : Form
    {
        AppDbContextDataContext context;
        public int? id { get; set; }
        OpenFileDialog openFileDialog;
        private string path=Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName+@"\image\";
        private string imageold = string.Empty;
        public Admin_Add_Car(Form mdi)
        {
           openFileDialog = new OpenFileDialog();
            context=new AppDbContextDataContext();
            InitializeComponent();
            this.MdiParent = mdi;
            loadData();
        }

        private void loadData() {
            var data = (from cs in context.carseats
                        select cs).ToList();
            foreach (var item in data)
            {
                cb_kursi.Items.Add(item.name);
            }
        }

        private void cleartb() { 
                tb_brand.Text= string.Empty;
                tb_color.Text= string.Empty;    
            tb_plate.Text= string.Empty;    
            tb_price.Text= string.Empty;
           cb_kursi.Text= string.Empty;
            cb_status.Text= string.Empty;
            dt_date.Text= DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int status=1;
            if (tb_brand.Text==""||tb_color.Text==""||tb_plate.Text==""||tb_price.Text==""||cb_kursi.Text==""||cb_status.Text==""||dt_date.Text=="")
            {
                MessageBox.Show("Form Belum terisi semua");
                return;
            }
            if (cb_status.Text=="Sewa")
            {
                status = 0;
            }
            if (cb_status.Text=="Kembali")
            {
                status = 1;
            }
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var imagename = DateTime.Now.Ticks.ToString() + Path.GetFileName(openFileDialog.FileName);
            if (id==null)
            {
            var seetValid = context.carseats.Where(cs => cs.name == cb_kursi.Text).FirstOrDefault();          
            car car=new car();          
            car.brand= tb_brand.Text;                
            car.plate=tb_plate.Text;
            car.color=tb_color.Text;
            car.color = tb_color.Text;
            car.year = dt_date.Value;
            car.status = status;
            car.rental_price=tb_price.Text;
            car.car_seat_id = seetValid.car_seat_id;
                File.Copy(openFileDialog.FileName, path + imagename);
                car.image_name=imagename;
            context.cars.InsertOnSubmit(car);   
            context.SubmitChanges();
            MessageBox.Show(null, "Berhasil Input data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cleartb();
                DialogResult = DialogResult.OK;
                this.Close();
            return;
            }
            else
            {
                var seetValid = context.carseats.Where(cs => cs.name == cb_kursi.Text).FirstOrDefault();
                var car =context.cars.Where(c=>c.car_id==id).FirstOrDefault();
                car.brand = tb_brand.Text;
                car.plate = tb_plate.Text;
                car.color = tb_color.Text;
                car.color = tb_color.Text;
                car.year = dt_date.Value;
                car.status = status;
                car.rental_price = tb_price.Text;
                car.car_seat_id = seetValid.car_seat_id;
                if (File.Exists(path+imageold))
                {
                    File.Delete(path+imageold);
                }
                File.Copy(openFileDialog.FileName, path + imagename);
                car.image_name=imagename ;
                context.SubmitChanges();
                MessageBox.Show(null, "Berhasil Update data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleartb();
                DialogResult=DialogResult.OK;
                this.Close();
                return;
            }

        }

        private void Admin_Add_Car_Load(object sender, EventArgs e)
        {
            loadDataForm();
        }

        private void loadDataForm() {
            string status = string.Empty;
            var data=(from c in context.cars
                      join cs in context.carseats
                      on c.car_seat_id equals cs.car_seat_id
                      where c.car_id==id
                      select new {
                          car_id = c.car_id,
                          brand = c.brand,
                          plate = c.plate,
                          color = c.color,
                          year = c.year,
                          status = c.status,
                          price = c.rental_price,
                          carseet = cs.name,
                          image=c.image_name
                      }).FirstOrDefault();
           
            if (data!=null) {
                if (data.status == 0)
                {
                    status = "Sewa";
                }
                if (data.status == 1)
                {
                    status = "Kembali";
                }
                tb_brand.Text = data.brand;
                tb_plate.Text = data.plate;
                tb_color.Text = data.color;
                dt_date.Text = data.year.ToString();
                cb_status.Text =status ;
                tb_price.Text = data.price;
                cb_kursi.Text = data.carseet;
                imageold = data.image;
                openFileDialog.FileName = data.image;
                bt_addImage.Text=openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "(Files|*jpg;*png;)";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                bt_addImage.Text=Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName!=null)
            {
                
                if (id!=0)
                {
                    var data = context.cars.Where(c => c.car_id == id).FirstOrDefault();
                    if (data.image_name==openFileDialog.FileName)
                    {
                        
                    }
                    else
                    {
                    openFileDialog.FileName = null;
                    bt_addImage.Text = "Add Image";
                    }                 
                }
                else
                {
                    openFileDialog.FileName = null;
                    bt_addImage.Text = "Add Image";
                }

            }
            
        }
    }
}
