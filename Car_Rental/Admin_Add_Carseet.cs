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
    public partial class Admin_Add_Carseet : Form
    {
        AppDbContextDataContext context;
        public int? id { get; set; }
        public Admin_Add_Carseet(Form form)
        {
            context = new AppDbContextDataContext();
           this.MdiParent= form;    
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id==null)
            {
            carseat carseat = new carseat();
            carseat.name = tb_carseet.Text;
            context.carseats.InsertOnSubmit(carseat);
            context.SubmitChanges();
            tbclear();
            MessageBox.Show(null, "Berhasil input data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
                return ;
            }
            else
            {
                var data=context.carseats.Where(c=>c.car_seat_id==id).FirstOrDefault();
                data.name=tb_carseet.Text;
                context.SubmitChanges();
                DialogResult= DialogResult.OK;
                MessageBox.Show(null, "Berhasil Mengupdate data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult= DialogResult.OK;
                this.Close();
                return;
            }

        }

        private void showTb() {
            var data = context.carseats.Where(c => c.car_seat_id == id).FirstOrDefault();
            tb_carseet.Text=data.name;
        }
        private void tbclear() {
            tb_carseet.Text = "";
        }

        private void Admin_Add_Carseet_Load(object sender, EventArgs e)
        {
            if (id!=null)
            {
            showTb();                   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
