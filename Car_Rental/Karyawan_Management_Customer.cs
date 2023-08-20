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
    public partial class Karyawan_Management_Customer : Form
    {
        AppDbContextDataContext context;
        public Karyawan_Management_Customer()
        {
            context = new AppDbContextDataContext();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fAddCustomer = new Karyawan_Add_Customer(this.MdiParent);
            fAddCustomer.StartPosition = FormStartPosition.CenterScreen;
            fAddCustomer.FormClosing += (object sas, FormClosingEventArgs asd) =>
            {
                if (DialogResult.OK == fAddCustomer.DialogResult)
                {
                    if (cb_orderList.Text == "Descending")
                    {
                        loadDatades();
                    }
                    else
                    {
                        loadData();
                    }
                }
            };
            fAddCustomer.Show();
        }

        private void loadData()
        {
            int i = 0;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data = (from c in context.customers
                        join idn in context.identity_types
                        on c.identity_type_id equals idn.identity_type_id
                        orderby c.identity_number ascending
                        select new
                        {
                            idcus = c.customer_id,
                            name = c.nama_customer,
                            identityNum = c.identity_number,
                            nameIdentity = idn.name,
                            address = c.address,
                            gender = c.gender == 0 ? "Laki Laki" : "Perempuan",
                            phone = c.phone_number
                        }).ToList();

            foreach (var item in data)
            {
                i++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = i;
                dataGridView1.Rows[num].Cells[1].Value = item.idcus;
                dataGridView1.Rows[num].Cells[2].Value = item.name;
                dataGridView1.Rows[num].Cells[3].Value = item.identityNum;
                dataGridView1.Rows[num].Cells[4].Value = item.nameIdentity;
                dataGridView1.Rows[num].Cells[5].Value = item.address;
                dataGridView1.Rows[num].Cells[6].Value = item.phone;
                dataGridView1.Rows[num].Cells[7].Value = item.gender;

            }
        }  private void loadDatades()
        {
            int i = 0;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Rows.Clear();
            var data = (from c in context.customers
                        join idn in context.identity_types
                        on c.identity_type_id equals idn.identity_type_id
                        orderby c.identity_number descending
                        select new
                        {
                            idcus = c.customer_id,
                            name = c.nama_customer,
                            identityNum = c.identity_number,
                            nameIdentity = idn.name,
                            address = c.address,
                            gender = c.gender == 0 ? "Laki Laki" : "Perempuan",
                            phone = c.phone_number
                        }).ToList();

            foreach (var item in data)
            {
                i++;
                var num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = i;
                dataGridView1.Rows[num].Cells[1].Value = item.idcus;
                dataGridView1.Rows[num].Cells[2].Value = item.name;
                dataGridView1.Rows[num].Cells[3].Value = item.identityNum;
                dataGridView1.Rows[num].Cells[4].Value = item.nameIdentity;
                dataGridView1.Rows[num].Cells[5].Value = item.address;
                dataGridView1.Rows[num].Cells[6].Value = item.phone;
                dataGridView1.Rows[num].Cells[7].Value = item.gender;

            }
        }

        private void Karyawan_Management_Customer_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = string.Empty;
            if (e.ColumnIndex == 8)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var fAddCutomer = new Karyawan_Add_Customer(this.MdiParent);
                fAddCutomer.id = int.Parse(id);
                fAddCutomer.FormClosing += (object asd, FormClosingEventArgs assad) =>
                {
                    if (DialogResult.OK == fAddCutomer.DialogResult)
                    {
                        if (cb_orderList.Text== "Descending")
                        {
                            loadDatades();
                        }
                        else
                        {
                            loadData();
                        }
                    }
                };
                fAddCutomer.Show();
            }
            if (e.ColumnIndex == 9)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                DialogResult dialog = MessageBox.Show(null, "Pakah anda yakin ingin menghapus data ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    var data = context.customers.Where(c => c.customer_id == int.Parse(id)).FirstOrDefault();
                    if (data != null) { 
                    context.customers.DeleteOnSubmit(data);
                    context.SubmitChanges();
                    MessageBox.Show(null, "Data berhasil di hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    return;
                    }                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_orderList.Text == "Descending")
            {
                int i = 0;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Rows.Clear();
                var data = (from c in context.customers
                            join idn in context.identity_types
                            on c.identity_type_id equals idn.identity_type_id
                            orderby c.identity_number descending
                            select new
                            {
                                idcus = c.customer_id,
                                name = c.nama_customer,
                                identityNum = c.identity_number,
                                nameIdentity = idn.name,
                                address = c.address,
                                gender = c.gender == 0 ? "Laki Laki" : "Perempuan",
                                phone = c.phone_number
                            }).ToList();

                foreach (var item in data)
                {
                    i++;
                    var num = dataGridView1.Rows.Add();
                    dataGridView1.Rows[num].Cells[0].Value = i;
                    dataGridView1.Rows[num].Cells[1].Value = item.idcus;
                    dataGridView1.Rows[num].Cells[2].Value = item.name;
                    dataGridView1.Rows[num].Cells[3].Value = item.identityNum;
                    dataGridView1.Rows[num].Cells[4].Value = item.nameIdentity;
                    dataGridView1.Rows[num].Cells[5].Value = item.address;
                    dataGridView1.Rows[num].Cells[6].Value = item.phone;
                    dataGridView1.Rows[num].Cells[7].Value = item.gender;

                }
            }
            else
            {
                loadData();
            }
        }
    }
}

