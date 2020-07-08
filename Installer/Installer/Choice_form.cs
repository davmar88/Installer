using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class Choice_form : Form
    {
        public Choice_form()
        {
            InitializeComponent();
            fullScreenDisplay();
        }

        private void btn_controlpanel_Click(object sender, EventArgs e)
        {
            Controlpanel_form ctrlpanel_frm = new Controlpanel_form();
            ctrlpanel_frm.Show();
            this.Hide();

        }

        private void btn_createnew_Click(object sender, EventArgs e)
        {
            Country_form country_frm = new Country_form("Choice");
            country_frm.Show();
            this.Hide();
        }

        public void fullScreenDisplay()
        {
            // This is required if the form reaches this code in maximized state
            // otherwise the TaskBar remains on top of the form
            this.WindowState = FormWindowState.Normal;

            //this.FormBorderStyle = FormBorderStyle.;
            this.WindowState = FormWindowState.Maximized;
            //this.mainPanel.Dock = DockStyle.Fill;
            //this.BringToFront();
        }
    }
}
