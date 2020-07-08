using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class Tower_form : Form
    {
        List<string> networks = new List<string>();
        public string fromwhere { get; set; }
        public int totalnetworks { get; set; }
        static int countformreload = 0;


        public Tower_form(string frmwhere)
        {
            InitializeComponent();
            fullScreenDisplay();
            this.fromwhere = frmwhere;
            int networkcount = DoNetworkCount(ReadCountryFile());
            if (countformreload == networkcount)
            {
                countformreload = 0;
            }
            lbl_totalnetworks.Text = (networkcount - countformreload).ToString();
            lbl_networkname.Text = networks[countformreload].ToString();
            populatefields(lbl_networkname.Text);

        }

        public Tower_form()
        {
            InitializeComponent();
            fullScreenDisplay();
            int networkcount = DoNetworkCount(ReadCountryFile());
            if (countformreload == networkcount)
            {
                countformreload = 0;
            }
            lbl_totalnetworks.Text = (networkcount - countformreload).ToString();
            lbl_networkname.Text = networks[countformreload].ToString();
            populatefields(lbl_networkname.Text);
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
                Location_form loc_frm = new Location_form();
                loc_frm.Show();
                this.Hide();
            }
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            //Start the service.
            int networkcount = DoNetworkCount(ReadCountryFile());
            MessageBox.Show("total networks: " + networkcount + " counting form load: " + countformreload.ToString());

            if (String.IsNullOrEmpty(txtone_tac.Text))
            {
                lbl_lacone.Text = "Please enter lac";
                lbl_lacone.ForeColor = Color.Red;
                txtone_tac.Select();
                txtone_tac.Focus();
                txtone_tac.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txttwo_tac.Text))
            {
                lbl_lactwo.Text = "Please enter lac";
                lbl_lactwo.ForeColor = Color.Red;
                txttwo_tac.Select();
                txttwo_tac.Focus();
                txttwo_tac.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txtone_phcellid.Text))
            {
                lbl_pcione.Text = "Please enter pci";
                lbl_pcione.ForeColor = Color.Red;
                txtone_phcellid.Select();
                txtone_phcellid.Focus();
                txtone_phcellid.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txttwo_phcellid.Text))
            {
                lbl_pcitwo.Text = "Please enter pci";
                lbl_pcitwo.ForeColor = Color.Red;
                txttwo_phcellid.Select();
                txttwo_phcellid.Focus();
                txttwo_phcellid.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txtone_latitude.Text))
            {
                lbl_latone.Text = "Please enter latitude";
                lbl_latone.ForeColor = Color.Red;
                txtone_latitude.Select();
                txtone_latitude.Focus();
                txtone_latitude.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txttwo_latitude.Text))
            {
                lbl_lattwo.Text = "Please enter latitude";
                lbl_lattwo.ForeColor = Color.Red;
                txttwo_latitude.Select();
                txttwo_latitude.Focus();
                txttwo_latitude.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txtone_longitude.Text))
            {
                lbl_lonone.Text = "Please enter longitude";
                lbl_lonone.ForeColor = Color.Red;
                txtone_longitude.Select();
                txtone_longitude.Focus();
                txtone_longitude.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txttwo_longitude.Text))
            {
                lbl_lontwo.Text = "Please enter longitude";
                lbl_lontwo.ForeColor = Color.Red;
                txttwo_longitude.Select();
                txttwo_longitude.Focus();
                txttwo_longitude.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txtone_range.Text))
            {
                lbl_rangeone.Text = "Please enter range";
                lbl_rangeone.ForeColor = Color.Red;
                txtone_longitude.Select();
                txtone_longitude.Focus();
                txtone_longitude.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txttwo_range.Text))
            {
                lbl_rangetwo.Text = "Please enter range";
                lbl_rangetwo.ForeColor = Color.Red;
                txttwo_range.Select();
                txttwo_range.Focus();
                txttwo_range.BackColor = Color.LightPink;
            }
            else
            {
                string tacone = txtone_tac.Text;
                string tactwo = txttwo_tac.Text;

                string pcione = txtone_phcellid.Text;
                string pcitwo = txttwo_phcellid.Text;

                string latone = txtone_latitude.Text;
                string lattwo = txttwo_latitude.Text;

                string lonone = txtone_longitude.Text;
                string lontwo = txttwo_longitude.Text;

                string rangeone = txtone_range.Text;
                string rangetwo = txttwo_range.Text;

                createeachtowerinfofile(lbl_networkname.Text, tacone, pcione, latone, lonone, rangeone, tactwo, pcitwo, lattwo, lontwo, rangetwo);

                if (fromwhere == "ControlPanel")
                {

                    if (networkcount > countformreload)
                    {

                        Tower_form tower_frm = new Tower_form("ControlPanel");
                        tower_frm.Show();
                        this.Hide();
                        MessageBox.Show("Configuration saved!");
                    }
                    else
                    {
                        MessageBox.Show("Configuration saved!, Starting the service!");
                        StartObserver();
                        this.Close();

                    }
                    //Save the configuration
                    //
                }
                else
                {
                    if (networkcount > countformreload)
                    {

                        Tower_form tower_frm = new Tower_form();
                        tower_frm.Show();
                        this.Hide();
                        MessageBox.Show("Configuration saved!");
                    }
                    else
                    {
                        MessageBox.Show("Configuration saved!, Starting the service!");
                        StartObserver();
                        StartUpdater();
                        this.Close();
                    }

                }
            }
            
        }

        public static void StartObserver()
        {
            RunCommands("sudo chown -R marietjie:marietjie /home/marietjie/configfiles");
            string command = string.Format("{0}", "./configfiles/start_observer.sh");
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "gnome-terminal";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.RedirectStandardInput = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.Arguments = " -e  \" " + command + " \"";

            proc.Start();



        }

        public static void StartUpdater()
        {


            string command = string.Format("{0}", "./configfiles/start_updater.sh");
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "gnome-terminal";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.RedirectStandardInput = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.Arguments = " -e  \" " + command + " \"";

            proc.Start();
        }



        public static void RunCommands(string command)
        {


            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;

            proc.Start();

            proc.StandardInput.WriteLine(command);

            proc.StandardInput.WriteLine("exit");
            string line = "";

            while (!proc.StandardOutput.EndOfStream)
            {
                line = proc.StandardOutput.ReadLine();
                Console.WriteLine(line);
            }

            proc.WaitForExit();
        }

        //gets used
        private void createeachtowerinfofile(string networkname, string tacone, string pcione, string latone, string lonone, string rangeone, string tactwo, string pcitwo, string lattwo, string lontwo, string rangetwo)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"
            StreamWriter writer = new StreamWriter("configfiles//"+ networkname + "celltowerinfo.txt", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one
            /*TAC:0
                PCI:0
                LAT:0
                LON:0
                ACCURACY:457.2
                AGED:0
                TAC:201
                PCI:28
                LAT:-25.73076
                LON:28.205321
                ACCURACY:1260
                AGED:0
                TAC:201
                PCI:27
                LAT:-25.721311
                LON:28.207827
                ACCURACY:738
                AGED:0
            */

            //our tower
            writer.WriteLine("TAC:0");
            writer.WriteLine("PCI:0");
            writer.WriteLine("LAT:0");
            writer.WriteLine("LON:0");
            writer.WriteLine("ACCURACY:457.2");
            writer.WriteLine("AGED:0");

            //tower one
            writer.WriteLine("TAC:"+tacone);
            writer.WriteLine("PCI:"+pcione);
            writer.WriteLine("LAT:"+latone);
            writer.WriteLine("LON:"+lonone);
            writer.WriteLine("ACCURACY:"+rangeone);
            writer.WriteLine("AGED:0");

            //tower two
            writer.WriteLine("TAC:" + tactwo);
            writer.WriteLine("PCI:" + pcitwo);
            writer.WriteLine("LAT:" + lattwo);
            writer.WriteLine("LON:" + lontwo);
            writer.WriteLine("ACCURACY:" + rangetwo);
            writer.WriteLine("AGED:0");



            writer.Close();



            //for observer
            StreamWriter writer2 = new StreamWriter(home + "/configfiles//" + networkname + "celltowerinfo.txt", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one
            /*TAC:0
                PCI:0
                LAT:0
                LON:0
                ACCURACY:457.2
                AGED:0
                TAC:201
                PCI:28
                LAT:-25.73076
                LON:28.205321
                ACCURACY:1260
                AGED:0
                TAC:201
                PCI:27
                LAT:-25.721311
                LON:28.207827
                ACCURACY:738
                AGED:0
            */

            //our tower
            writer2.WriteLine("TAC:0");
            writer2.WriteLine("PCI:0");
            writer2.WriteLine("LAT:0");
            writer2.WriteLine("LON:0");
            writer2.WriteLine("ACCURACY:457.2");
            writer2.WriteLine("AGED:0");

            //tower one
            writer2.WriteLine("TAC:" + tacone);
            writer2.WriteLine("PCI:" + pcione);
            writer2.WriteLine("LAT:" + latone);
            writer2.WriteLine("LON:" + lonone);
            writer2.WriteLine("ACCURACY:" + rangeone);
            writer2.WriteLine("AGED:0");

            //tower two
            writer2.WriteLine("TAC:" + tactwo);
            writer2.WriteLine("PCI:" + pcitwo);
            writer2.WriteLine("LAT:" + lattwo);
            writer2.WriteLine("LON:" + lontwo);
            writer2.WriteLine("ACCURACY:" + rangetwo);
            writer2.WriteLine("AGED:0");



            writer2.Close();


            //Insert this to database Towerdetails:
            string mcc = getMCC(lbl_networkname.Text, ReadCountryFile());
            string mnc = getMNC(lbl_networkname.Text, ReadCountryFile());

            try
            {
                using (var context = new DatabaseContext())
                {
                    var addnetworks = new TowerDetail();
                    addnetworks.Mcc = int.Parse(mcc);
                    addnetworks.Mnc = int.Parse(mnc);
                    addnetworks.Tac = int.Parse(tacone);
                    addnetworks.Pci = int.Parse(pcione);
                    addnetworks.Lon = float.Parse(lonone);
                    addnetworks.Lat = float.Parse(latone);
                    addnetworks.Range_meter = float.Parse(rangeone);
                    addnetworks.Aged = 0;
                    addnetworks.Rsrp_per_meter = -120 / float.Parse(rangeone);
                    context.TowerDetails.Add(addnetworks);
                    context.SaveChanges();
                }

                using (var context = new DatabaseContext())
                {
                    var addnetworks = new TowerDetail();
                    addnetworks.Mcc = int.Parse(mcc);
                    addnetworks.Mnc = int.Parse(mnc);
                    addnetworks.Tac = int.Parse(tactwo);
                    addnetworks.Pci = int.Parse(pcitwo);
                    addnetworks.Lon = float.Parse(lontwo);
                    addnetworks.Lat = float.Parse(lattwo);
                    addnetworks.Range_meter = float.Parse(rangetwo);
                    addnetworks.Aged = 0;
                    addnetworks.Rsrp_per_meter = -120 / float.Parse(rangetwo);
                    context.TowerDetails.Add(addnetworks);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured while inserting data to database:");
            }


        }

        private string getMCC(string networkname, string country)
        {
            string mcc = "";
            DatabaseContext operatorcountries = new DatabaseContext();
            try
            {
                var mcclist = operatorcountries.Operators
                .Where(x => x.Network == networkname && x.Country == country)
                .Select(x => x.MCC).Distinct();


                foreach (var item in mcclist)
                {
                    mcc = item.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message:" + ex.Message);
            }

            return mcc;
        }
        //gets used
        private string getMNC(string networkname, string country)
        {
            string mnc = "";
            DatabaseContext operatorcountries = new DatabaseContext();
            try
            {
                var mcclist = operatorcountries.Operators
                .Where(x => x.Network == networkname && x.Country == country)
                .Select(x => x.MNC).Distinct();


                foreach (var item in mcclist)
                {
                    mnc = item.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message:" + ex.Message);
            }

            return mnc;
        }

        //gets used
        private string ReadCountryFile()
        {
            string path = "configfiles/appsettings.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                List<string> lines = new List<string>();
                while ((s = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(s);
                    lines.Add(s);
                }

                sr.Close();

                return lines[3].Split(':')[1].ToString();
            }
        }

        public void populatefields(string networkname)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            if (File.Exists("configfiles//" + networkname + "celltowerinfo.txt"))
            {
                string line = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader("configfiles//" + networkname + "celltowerinfo.txt");

                // read all the lines in the file and store them in the List
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                reader.Close();

               

                txtone_tac.Text = lines[6].Split(':')[1];
                txtone_phcellid.Text = lines[7].Split(':')[1];
                txtone_latitude.Text = lines[8].Split(':')[1];
                txtone_longitude.Text = lines[9].Split(':')[1];
                txtone_range.Text = lines[10].Split(':')[1];

                txttwo_tac.Text = lines[12].Split(':')[1];
                txttwo_phcellid.Text = lines[13].Split(':')[1];
                txttwo_latitude.Text = lines[14].Split(':')[1];
                txttwo_longitude.Text = lines[15].Split(':')[1];
                txttwo_range.Text = lines[16].Split(':')[1];



            }

        }





        private int DoNetworkCount(string country)
        {
            networks.Clear();
            DatabaseContext operatorcountries = new DatabaseContext();
            try
            {
                var countrylist = operatorcountries.Operators
                .Where(x => x.Country == country)
                .Select(x => x.Network).Distinct();


                foreach (var item in countrylist)
                {
                    networks.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message:" + ex.Message);
            }

            return networks.Count;
        }


        private void frm_load(object sender, EventArgs e)
        {
            countformreload++;
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

        private void btn_skip_Click(object sender, EventArgs e)
        {
            int networkcount = DoNetworkCount(ReadCountryFile());
            if (fromwhere == "ControlPanel")
            {

                if (networkcount > countformreload)
                {

                    Tower_form tower_frm = new Tower_form("ControlPanel");
                    tower_frm.Show();
                    this.Hide();

                }
                else
                {

                }
                //Save the configuration
                //
            }
            else
            {
                if (networkcount > countformreload)
                {

                    Tower_form tower_frm = new Tower_form();
                    tower_frm.Show();
                    this.Hide();

                }
                else
                {

                }

            }
        }
    }
}
