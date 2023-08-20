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
    public partial class Login : Form
    {
        AppDbContextDataContext context;
        public Login()
        {
            context = new AppDbContextDataContext();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_username.Text==""||tb_password.Text==""||tb_chapta.Text=="")
            {
                MessageBox.Show(null, "Form Belum terisi semua", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lb_chapta.Text!=tb_chapta.Text)
            {
                MessageBox.Show(null, "Chapta yang anda masukkan tidak sama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadChapta();
                return;
            }

            var user=context.users.Where(c=>c.username==tb_username.Text).FirstOrDefault();
            if (user!=null)
            {
                if (user.password==createSHA(tb_password.Text))
                 {
                if (user.level==0)
                {
                    new Admin_dashboard().Show();
                    this.Hide();
                    
                }
                if (user.level==1)
                {
                    new Karyawan_dashboard().Show();
                    this.Hide();
                }
                Helper.Helper.user=user;
                return;
                }
                MessageBox.Show(null, "Password yang anda masukkan salah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
            MessageBox.Show(null, "Akun tidak di temukan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            

        }

        private string createSHA(string p) { 
            StringBuilder sb = new StringBuilder();
            using (var sha=SHA256.Create())
            {
                var token=sha.ComputeHash(Encoding.UTF8.GetBytes(p));
                for (int i = 0; i < token.Length; i++) {
                    sb.Append(token[i].ToString("x2"));
                }
            }
            return sb.ToString();
        }
        private void loadChapta() { 
            Random random = new Random();   
            int num=random.Next(4,8);
            string cahpta = string.Empty;
            int i = 0;
            do
            {
                int chr = random.Next(48, 123);
                if ((chr>=48&&chr<=57)||(chr>=60&&chr<=90)||(chr>=92&&chr<=123))
                {
                    i++;
                    cahpta = cahpta + (char)chr;
                    if (num == i)
                        break;
                    {
                        
                    }
                }
            } while (true);
            lb_chapta.Text = cahpta;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            loadChapta();
        }
    }
}
