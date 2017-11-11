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
    public partial class frm_CustomerUpdate : Form
    {
        public frm_CustomerUpdate()
        {
            InitializeComponent();
        }

        CustomerDAL customerDAL = new CustomerDAL();
        CRM.Entity.Customers c = new Entity.Customers();
        private void frm_CustomerUpdate_Load(object sender, EventArgs e)
        {
            FillCustomerInformation();
        }

        private void FillCustomerInformation()
        {
            lblID.Text = "ID : " + Form1.Id.ToString();

            //id ye göre sorgu yapıp ilgili kaydı döndürür.
            c = customerDAL.getCustomer(Form1.Id);

            txtName.Text = c.Name;
            txtSurname.Text = c.SurName;
            txtAdress.Text = c.Address;
            txtPhone.Text = c.Phone;
            txtCity.Text = c.City;
            txtMail.Text = c.Mail;
            txtCountry.Text = c.Country;

            if (c.Gender == true)
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCustomer();

            UpdateDataGridView();

            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirilmiş.");

            this.Close();

        }

        private void UpdateDataGridView()
        {
            var result = customerDAL.ListOfCustomer();

            if (result.IsSucceedded == true)
            {
                Form1.DGV.DataSource = result.TransactionResult;
            }
        }

        private void UpdateCustomer()
        {
            CRM.Entity.Customers uptCustomer = new Entity.Customers();
            uptCustomer.Id = Form1.Id;

            uptCustomer.Name = txtName.Text;
            uptCustomer.SurName = txtSurname.Text;
            uptCustomer.Address = txtAdress.Text;
            uptCustomer.Phone = txtPhone.Text;
            uptCustomer.Mail = txtMail.Text;
            uptCustomer.Country = txtCountry.Text;
            uptCustomer.City = txtCity.Text;
            uptCustomer.Gender = SelectGender();
            uptCustomer.CreateDate = DateTime.Now;
            uptCustomer.PhotoPath = "";

            customerDAL.Update(uptCustomer);
        }
    }
}
