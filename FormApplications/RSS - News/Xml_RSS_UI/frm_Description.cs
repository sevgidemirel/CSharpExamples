using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xml_RSS_UI
{
    public partial class frm_Description : Form
    {
        public frm_Description()
        {
            InitializeComponent();
        }

        private void frm_Description_Load(object sender, EventArgs e)
        {
            lblDescription.Text = Form1.description;

        }

        private void linkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Form1.link);
        }
    }
}
