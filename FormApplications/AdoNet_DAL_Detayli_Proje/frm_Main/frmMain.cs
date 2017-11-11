using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 1.
            // Ana formun (IsMdiContainer) arkaPlan rengini (Gri olan) değiştirelim ...
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient) // veya == true
                {
                    c.BackColor = Color.LightSkyBlue; // arkaPlan istedğim renk olur ...
                }
            }

            // -> Products içindeki yavru formları ekleyip -> Entity klasöründeki -> "IEntity" içindeyim ...
        }
    }
}
