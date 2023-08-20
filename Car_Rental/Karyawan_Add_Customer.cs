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
    public partial class Karyawan_Add_Customer : Form
    {
        public int id { get; set; }
        AppDbContextDataContext context;
        private int sex=3;
        public Karyawan_Add_Customer(Form form)
        {
            context = new AppDbContextDataContext();
            this.MdiParent= form;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_pelanggan.Text==""||tb_noIdentitas.Text==""||text3.Text==""||tb_alamat.Text==""||tb_phone.Text==""||sex==3)
            {
                MessageBox.Show(null, "From Belum terisi semua", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (id==0)
            {
             customer customer=new customer();
            var identity=context.identity_types.Where(idn=>idn.name==cb_identitas.Text).FirstOrDefault();
            customer.nama_customer = tb_pelanggan.Text;
            customer.identity_type_id = identity.identity_type_id;
            customer.identity_number = tb_noIdentitas.Text;
            customer.address = tb_alamat.Text;
            customer.gender = sex;
            customer.phone_number = tb_phone.Text;
            context.customers.InsertOnSubmit(customer);
            context.SubmitChanges();
            clearData();
            MessageBox.Show(null, "Berhasil Menambah data customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            return;
            }
            else
            {
                var customer=context.customers.Where(c=>c.customer_id==id).FirstOrDefault();
                var identity = context.identity_types.Where(idn => idn.name == cb_identitas.Text).FirstOrDefault();
                customer.nama_customer = tb_pelanggan.Text;
                customer.identity_type_id = identity.identity_type_id;
                customer.identity_number = tb_noIdentitas.Text;
                customer.address = tb_alamat.Text;
                customer.gender = sex;
                customer.phone_number = tb_phone.Text;
                context.SubmitChanges();
                clearData();
                MessageBox.Show(null, "Berhasil Update data customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                return;
            }

        }

        private void clearData() {
            tb_pelanggan.Text = "";
            tb_noIdentitas.Text= "";
            tb_alamat.Text = "";
            tb_phone.Text = "";
            cb_identitas.Text = "";
            rd_lakilaki.Checked= false;
            rd_perempuan.Checked= false;
        }

        private void Karyawan_Add_Customer_Load(object sender, EventArgs e)
        {
            logicCb();
            loadRd();
            if (id!=0)
            {                
            loadTb();
            }
        }

        private void loadTb() { 
            var data=(from c in context.customers
                      join idn in context.identity_types
                      on c.identity_type_id equals idn.identity_type_id
                      where c.customer_id==id
                      select new {
                          name = c.nama_customer,
                          identityNum = c.identity_number,
                          nameIdentity = idn.name,
                          address = c.address,
                          gender = c.gender,
                          phone = c.phone_number
                      }).FirstOrDefault();
            tb_pelanggan.Text = data.name;
            tb_noIdentitas.Text=data.identityNum;
            cb_identitas.Text=data.nameIdentity;
            tb_alamat.Text=data.address;
            tb_phone.Text=data.phone;
            if (data.gender==0)
            {
                rd_lakilaki.Checked = true;
            }
            if (data.gender==1)
            {
                rd_perempuan.Checked = true;
            }
        }

        private void loadRd() { 
        
            var data=(from idn in context.identity_types
                      select idn).ToList();

            foreach (var idn in data)
            {
                cb_identitas.Items.Add(idn.name);
            }
        }

        private void logicCb() {
            if (rd_lakilaki.Checked == true)
            {
                rd_perempuan.Checked = false;
            }
            if (rd_perempuan.Checked == true)
            {
                rd_lakilaki.Checked = false;
            }
        }
        private void rd_lakilaki_CheckedChanged(object sender, EventArgs e)
        {
            sex = 0;
        }

        private void rd_phone_CheckedChanged(object sender, EventArgs e)
        {
            sex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
