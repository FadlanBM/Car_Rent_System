using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Admin_Add_User : Form
    {
        public string id { get; set; }
        AppDbContextDataContext context;
        private int level;
        public Admin_Add_User()
        {
            context = new AppDbContextDataContext();
            InitializeComponent();
        }
        private void clearForm() {
            tb_nama.Text = "";
            tb_password.Text = "";
            tb_username.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_nama.Text==""||tb_username.Text=="")
            {
                MessageBox.Show(null, "Form Belum", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id==null)
            {
 user user= new user();
            user.name = tb_nama.Text;
            user.username = tb_username.Text;
            user.password = getSha(tb_password.Text);
            user.level= level;
            context.users.InsertOnSubmit(user);
            context.SubmitChanges();
            MessageBox.Show(null, "Berhasil Save data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearForm();
             new Admin_Management_User().Show();
                this.Close();
            }
            else
            {
                var data = context.users.Where(u => u.user_id == int.Parse(id)).FirstOrDefault();
                data.name= tb_nama.Text;    
                data.username = tb_username.Text;
                data.password= getSha(tb_password.Text);
                data.level= level;
                context.SubmitChanges();
                MessageBox.Show(null, "Berhasil Update data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
                new Admin_Management_User().Show();
                this.Close();
            }
        }
       
        private string getSha(string p)
        {
            StringBuilder sb= new StringBuilder();
            using (var sha=SHA256.Create())
            {
               var bytes=sha.ComputeHash(Encoding.UTF8.GetBytes(p));
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rd_admin_CheckedChanged(object sender, EventArgs e)
        {
            level = 0;
        }

        private void rd_karyawan_CheckedChanged(object sender, EventArgs e)
        {
            level = 1;
        }

        private void Admin_Add_User_Load(object sender, EventArgs e)
        {
            logicRd();
            showtable();
        }

        private void showtable() {
            if (id!=null)
            {
            var data=context.users.Where(u=>u.user_id==int.Parse(id)).FirstOrDefault();
            if (data!=null)
            {
            tb_nama.Text = data.name;
            tb_username.Text= data.username;
            if (data.level==0)
            {
                rd_admin.Checked = true;
            }
            if (data.level==1)
            {
                rd_karyawan.Checked = true;
            }
            }
            }
           
            
        }

        private void logicRd()
        {
            if (rd_admin.Checked == true)
            {
                rd_karyawan.Checked = false;
            }
            if (rd_karyawan.Checked == true)
            {
                rd_admin.Checked = false;
            }
        }
    }
}
