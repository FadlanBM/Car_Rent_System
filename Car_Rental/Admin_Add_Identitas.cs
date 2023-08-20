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
    public partial class Admin_Add_Identitas : Form
    {
        AppDbContextDataContext context;
        public int? id { get; set; }
        public Admin_Add_Identitas(Form mdi)
        {
            context = new AppDbContextDataContext();
            InitializeComponent();
            this.MdiParent = mdi;
        }

        private void showLb() { 
            tb_identitas.Text = identityClass(id).name;
            
        }

        private void Admin_Add_Identitas_Load(object sender, EventArgs e)
        {
            if (id!=null)
            {
                showLb();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_identitas.Text=="")
            {
                MessageBox.Show(null,"Identitas Belum di isi","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (id==null)
            {
                identity_type identity = new identity_type();
                identity.name = tb_identitas.Text;
                context.identity_types.InsertOnSubmit(identity);
                context.SubmitChanges();
                MessageBox.Show(null, "Berhasil menambahkan tipe idnetitas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                clear();
                return;
            }
            else
            {
                var data=identityClass(id);
                data.name=tb_identitas.Text;
                context.SubmitChanges();
                MessageBox.Show(null, "Berhasil menambahkan tipe idnetitas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult=DialogResult.OK;
                clear();
                this.Close();
                return;
            }

        }

        private identity_type identityClass(int? idn) {
            var data = context.identity_types.Where(i => i.identity_type_id == idn).FirstOrDefault();
            return data;
        }
        private void clear() {
            tb_identitas.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
