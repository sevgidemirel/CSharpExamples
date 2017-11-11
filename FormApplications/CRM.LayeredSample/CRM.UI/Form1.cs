using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Dal;
using CRM.UI.Customers;

namespace CRM.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static int Id;
        public static DataGridView DGV;

        CustomerDAL customerDAL = new CustomerDAL();
        private void Form1_Load(object sender, EventArgs e)
        {

            DGV = dataGridView1;

            FillCustomers();
        }

        private void FillCustomers()
        {
            var result = customerDAL.ListOfCustomer();

            if (result.IsSucceedded == true)
            {
                dataGridView1.DataSource = result.TransactionResult;
            }
        }


        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CustomerUpdate update = new frm_CustomerUpdate();
            Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            update.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CustomerAdd add = new frm_CustomerAdd();
            Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            add.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            DialogResult dr = MessageBox.Show("Kaydı silmek istediginizden emin misiniz?","Uyarı",MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edilmiştir.");
            }
            else
            {
                customerDAL.Delete(secilenId);
                MessageBox.Show("Seçilen kayıt basarıyla silinmiştir.");
                FillCustomers();
            }

        }
    }
}
