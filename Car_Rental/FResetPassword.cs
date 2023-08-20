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
    public partial class FResetPassword : Form
    {
        AppDbContextDataContext context;
        public FResetPassword()
        {
            context = new AppDbContextDataContext();
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_passold.Text==""||tb_passnew.Text==""||tb_comfimPas.Text=="")
            {
                MessageBox.Show(null, "Form belum terisi semua", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tb_comfimPas.Text!=tb_passnew.Text)
            {
                MessageBox.Show(null, "Form comfim password tidak sama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user=context.users.Where(u=>u.user_id==Helper.Helper.user.user_id).FirstOrDefault();
            if (user!=null)
            {
                if (user.password==getSha(tb_passold.Text))
                {
                    if (user.password==getSha(tb_passnew.Text))
                    {
                        MessageBox.Show(null, "Password tidak boleh sama saya yang lama", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                    user.password=getSha(tb_passnew.Text);
                    context.SubmitChanges();
                    MessageBox.Show(null, "Password Berhasil di Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(null, "Password id ubah anda harus login lagi", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Login().Show();
                    DialogResult= DialogResult.OK;
                    this.Close();
                    return;
                }else
                {
                    MessageBox.Show(null, "Password Lama Salah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private string getSha(string p) { 
            StringBuilder stringBuilder = new StringBuilder();
            using (var sha=SHA256.Create())
            {
                var baytes=sha.ComputeHash(Encoding.UTF8.GetBytes(p));
                for (int i = 0; i < baytes.Length; i++)
                {
                    stringBuilder.Append(baytes[i].ToString("x2"));
                }
            }
            return stringBuilder.ToString();    
        }

        private void FResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
