using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class Location_form : Form
    {
        public string fromwhere { get; set; }
        public Location_form()
        {
            InitializeComponent();
            fullScreenDisplay();

            txt_latitude.Mask = "#00.0000000";
            txt_latitude.Culture = CultureInfo.InvariantCulture;

            txt_latitude.MaskInputRejected += new MaskInputRejectedEventHandler(txt_latitude_MaskInputRejected);
            txt_latitude.KeyDown += new KeyEventHandler(txt_latitude_KeyDown);

            txt_longitude.Mask = "#00.0000000";
            txt_longitude.Culture = CultureInfo.InvariantCulture;

            txt_longitude.MaskInputRejected += new MaskInputRejectedEventHandler(txt_longitude_MaskInputRejected);
            txt_longitude.KeyDown += new KeyEventHandler(txt_longitude_KeyDown);
            populatefields();

        }
        public Location_form(string frmwhere)
        {
            InitializeComponent();
            fullScreenDisplay();

            this.fromwhere = frmwhere;

            txt_latitude.Mask = "#00.0000000";
            txt_latitude.Culture = CultureInfo.InvariantCulture;

            txt_latitude.MaskInputRejected += new MaskInputRejectedEventHandler(txt_latitude_MaskInputRejected);
            txt_latitude.KeyDown += new KeyEventHandler(txt_latitude_KeyDown);

            txt_longitude.Mask = "#00.0000000";
            txt_longitude.Culture = CultureInfo.InvariantCulture;

            txt_longitude.MaskInputRejected += new MaskInputRejectedEventHandler(txt_longitude_MaskInputRejected);
            txt_longitude.KeyDown += new KeyEventHandler(txt_longitude_KeyDown);
            populatefields();
        }

        private void txt_longitude_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip1.Hide(txt_longitude);
        }

        private void txt_longitude_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txt_longitude.Text.Contains(','))
            {
                toolTip1.ToolTipTitle = "Input Rejected - Use a point, not a comma";
                toolTip1.Show("You cannot use a comma. Use a '.' for entering data.", txt_longitude, 0, -20, 5000);
            }
            if (txt_longitude.MaskFull)
            {
                toolTip1.ToolTipTitle = "Input Rejected - Too Much Data";
                toolTip1.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", txt_longitude, 0, -20, 5000);
            }
            else if (e.Position == txt_longitude.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Input Rejected - End of Field";
                toolTip1.Show("You cannot add extra characters to the end of this date field.", txt_longitude, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Input Rejected";
                toolTip1.Show("You can only add numeric characters (0-9) into this date field.", txt_longitude, 0, -20, 5000);
            }
        }

        private void txt_latitude_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip1.Hide(txt_latitude);
        }

        private void txt_latitude_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txt_latitude.Text.Contains(','))
            {
                toolTip1.ToolTipTitle = "Input Rejected - Use a point, not a comma";
                toolTip1.Show("You cannot use a comma. Use a '.' for entering data.", txt_latitude, 0, -20, 5000);
            }

            if (txt_latitude.MaskFull)
            {
                toolTip1.ToolTipTitle = "Input Rejected - Too Much Data";
                toolTip1.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", txt_latitude, 0, -20, 5000);
            }
            else if (e.Position == txt_latitude.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Input Rejected - End of Field";
                toolTip1.Show("You cannot add extra characters to the end of this date field.", txt_latitude, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Input Rejected";
                toolTip1.Show("You can only add numeric characters (0-9) into this date field.", txt_latitude, 0, -20, 5000);
            }
        }



        private void btn_goback_Click(object sender, EventArgs e)
        {
            if (fromwhere == "ControlPanel")
            {
                Controlpanel_form ctrl_frm = new Controlpanel_form();
                ctrl_frm.Show();
                this.Hide();
            }
            else
            {
                Country_form country_frm = new Country_form();
                country_frm.Show();
                this.Hide();
            }
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {

            string lat = txt_latitude.Text;
            string lon = txt_longitude.Text;
            if (lat == "")
            {
                lbl_latitude.Text = "Please enter latitude";
                lbl_latitude.ForeColor = Color.Red;
                txt_latitude.Select();
                txt_latitude.Focus();
                txt_latitude.BackColor = Color.LightPink;


                

            }
            if(lon == "")
            {
                lbl_longitude.Text = "Please enter longitude";
                lbl_longitude.ForeColor = Color.Red;
                txt_longitude.Select();
                txt_longitude.Focus();
                txt_longitude.BackColor = Color.LightPink;
            }
            else
            {

                writeTofile(lat,lon);
                if (fromwhere == "ControlPanel")
                {
                    //Save the configuration
                    MessageBox.Show("Configuration saved!");
                }
                else
                {
                    Network_form network_frm = new Network_form();
                    network_frm.Show();
                    this.Hide();
                }
            }
        }



        private void writeTofile(string latitude, string longitude)
        {
            string line = null;
            List<string> lines = new List<string>();
            StreamReader reader = new StreamReader("configfiles/appsettings.txt");

            // read all the lines in the file and store them in the List
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            reader.Close();

        // change the second line long:28.200579
            
            if(longitude.Contains('+'))
            {
                string alteredlon = longitude.Remove(0, 1);
                lines[1] = "long:" + alteredlon;
            }
            else
            {
                lines[1] = "long:" + longitude;
            }


            if (latitude.Contains('+'))
            {
                string alteredlat = latitude.Remove(0, 1);
                lines[2] = "lat:" + alteredlat;
            }
            else
            {
                lines[2] = "lat:" + latitude;
            }






            StreamWriter writer = new StreamWriter("configfiles/appsettings.txt", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one
            for (int i = 0; i < lines.Count; i++)
            {
                if (i < lines.Count - 1)
                {
                    writer.WriteLine(lines[i]);
                    Console.WriteLine(lines[i]);
                }

                else
                {
                    writer.WriteLine(lines[i]);
                    Console.WriteLine(lines[i]);
                }

            }
            writer.Close();
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"home + "/Observer/configfiles/
            StreamWriter writer2 = new StreamWriter(home + "/configfiles/appsettings.txt", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one
            for (int i = 0; i < lines.Count; i++)
            {
                if (i < lines.Count - 1)
                {
                    writer2.WriteLine(lines[i]);
                    Console.WriteLine(lines[i]);
                }

                else
                {
                    writer2.WriteLine(lines[i]);
                    Console.WriteLine(lines[i]);
                }

            }
            writer2.Close();

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

        public void populatefields()
        {
            if(File.Exists("configfiles/appsettings.txt"))
            {
                string line = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader("configfiles/appsettings.txt");

                // read all the lines in the file and store them in the List
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                reader.Close();
                if(!lines[2].Contains('-'))
                {
                    txt_latitude.Text = "+"+lines[2];
                    txt_longitude.Text = lines[1];
                    return;
                }
                if(!lines[1].Contains('-'))
                {
                    txt_longitude.Text = "+" + lines[1];
                    txt_latitude.Text = lines[2];
                    return;
                }


            }

        }


    }
}
