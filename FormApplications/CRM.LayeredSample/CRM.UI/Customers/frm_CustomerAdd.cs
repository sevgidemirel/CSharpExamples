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
using CRM.Entity;

namespace CRM.UI.Customers
{
    public partial class frm_CustomerAdd : Form
    {
        public frm_CustomerAdd()
        {
            InitializeComponent();
        }

        CustomerDAL customerDAL = new CustomerDAL();
        Entity.Customers newCustomer = new Entity.Customers();
        string emptyField;
        int emptyCount;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (TextBox txt in gbCustomer.Controls.OfType<TextBox>())
                {
                    if (txt.Text == "")
                    {
                        emptyCount++;
                        emptyField += txt.Tag + " , ";
                    }
                }

                if (emptyCount > 0)
                {
                    MessageBox.Show("Lütfen " + emptyField.Substring(0, emptyField.Length - 1) + " alanlarını boş bırakmayınız!!!");
                }
                else
                {
                    AddCustomer();

                    UpdateDataGridView();

                    MessageBox.Show("Yeni müşteri başarıyla eklenmiştir.");

                    this.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata sebebiyle yeni müşteri eklenememiştir.");
            }

            emptyField = "";
        }

        private void UpdateDataGridView()
        {
            var result = customerDAL.ListOfCustomer();

            if (result.IsSucceedded == true)
            {
                Form1.DGV.DataSource = result.TransactionResult;
            }
        }

        private void AddCustomer()
        {
            newCustomer.Name = txtName.Text;
            newCustomer.SurName = txtSurname.Text;
            newCustomer.Address = txtAdress.Text;
            newCustomer.Phone = txtPhone.Text;
            newCustomer.Mail = txtMail.Text;
            newCustomer.City = txtCity.Text;
            newCustomer.Country = txtCountry.Text;
            newCustomer.CreateDate = DateTime.Now;
            newCustomer.PhotoPath = "";
            newCustomer.Gender = SelectGender();

            customerDAL.Save(newCustomer);
        }

        private bool SelectGender()
        {
            if (rbFemale.Checked)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_CustomerAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
