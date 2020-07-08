using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class Country_form : Form
    {
        public string fromwhere { get; set; }
        public List<string> countries = new List<string>();
        public string cuntry;


        public Country_form( string frmwhere)
        {
            InitializeComponent();
            fullScreenDisplay();
            this.fromwhere = frmwhere;
            btn_proceed.Text = "Save";
            LoadCountries();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = countries;
            comboBox1.DataSource = bindingSource1.DataSource;
            populatefields();
        }


        public Country_form()
        {
            InitializeComponent();
            fullScreenDisplay();
            LoadCountries();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = countries;
            comboBox1.DataSource = bindingSource1.DataSource;
            populatefields();
        }


        private void LoadCountries()
        {
            DatabaseContext operatorcountries = new DatabaseContext();
            try
            {
                var countrylist = operatorcountries.Operators
                .Select(p => p.Country)
                .Distinct();

                foreach (var item in countrylist)
                {
                    countries.Add(item.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message:" + ex.Message);
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
                Choice_form choice_frm = new Choice_form();
                choice_frm.Show();
                this.Hide();
            }
        }



        private void btn_proceed_Click(object sender, EventArgs e)
        {
            string country = comboBox1.Text;
            if(country=="")
            {
                if (fromwhere == "ControlPanel")
                {
                    //Save the configuration
                    MessageBox.Show("Please choose a country before saving!");
                    comboBox1.BackColor = Color.LightPink;
                }
                else
                {
                    MessageBox.Show("Please choose a country before proceeding!");
                    comboBox1.BackColor = Color.LightPink;
                }
               
            }
            else
            {

                writeTofile(country);
                if (fromwhere == "ControlPanel")
                {
                    //Save the configuration
                    MessageBox.Show("Configuration saved!");
                }
                else
                {
                    Location_form loc_frm = new Location_form();
                    loc_frm.Show();
                    this.Hide();
                }
            }

             
        }

        /* private void ReadFile()
         {
             string path = "configfiles/mtnenb.conf";
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

                 foreach (string item in lines)
                 {
                     Console.WriteLine(item);
                 }
             }
         }*/
        List<string> networks = new List<string>();
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

        private void writeTofile(string country)
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

            string filecountry = lines[3].Split(':')[1];

            //var envHome = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "HOMEPATH" : "HOME";
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"

            string remoteDirectory = "/home/Pepla/Desktop/Opaque/";
            string localDirectory = home;
            if (filecountry != country)
            {
                int networkcount = DoNetworkCount(filecountry);
                if(networkcount > 0)
                {
                    foreach (string networkname in networks)
                    {
                        //~/Observer/Observer/bin/Debug/configfiles/
                        if (File.Exists("configfiles/" + networkname + "mme.conf"))
                        {
                            File.Delete("configfiles/" + networkname + "mme.conf");
                        }
                        if (File.Exists(home+"/configfiles/" + networkname + "mme.conf"))
                        {
                            File.Delete(home+"/configfiles/" + networkname + "mme.conf");
                        }


                        if (File.Exists("configfiles/" + networkname + "enb.conf"))
                        {
                            File.Delete("configfiles/" + networkname + "enb.conf");
                        }
                        if (File.Exists(home + "/configfiles/" + networkname + "enb.conf"))
                        {
                            File.Delete(home + "/configfiles/" + networkname + "enb.conf");
                        }


                        if (File.Exists("configfiles//" + networkname + ".txt"))
                        {
                            File.Delete("configfiles//" + networkname + ".txt");
                        }
                        if (File.Exists(home + "/configfiles//" + networkname + ".txt"))
                        {
                            File.Delete(home + "/configfiles//" + networkname + ".txt");
                        }


                        if (File.Exists("configfiles//" + networkname + "_earfcn.txt"))
                        {
                            File.Delete("configfiles//" + networkname + "_earfcn.txt");
                        }
                        if (File.Exists(home + "/configfiles//" + networkname + "_earfcn.txt"))
                        {
                            File.Delete(home + "/configfiles//" + networkname + "_earfcn.txt");
                        }


                        if (File.Exists("configfiles/countrymcc.txt"))
                        {
                            File.Delete("configfiles/countrymcc.txt");
                        }
                        if (File.Exists(home + "/configfiles/countrymcc.txt"))
                        {
                            File.Delete(home + "/configfiles/countrymcc.txt");
                        }


                        if (File.Exists("configfiles/networkoperators.txt"))
                        {
                            File.Delete("configfiles/networkoperators.txt");
                        }
                        if (File.Exists(home + "/configfiles/networkoperators.txt"))
                        {
                            File.Delete(home + "/configfiles/networkoperators.txt");
                        }


                        if (File.Exists("configfiles/mmenetworkfilelist.txt"))
                        {
                            File.Delete("configfiles/mmenetworkfilelist.txt");
                        }
                        if (File.Exists(home + "/configfiles/mmenetworkfilelist.txt"))
                        {
                            File.Delete(home + "/configfiles/mmenetworkfilelist.txt");
                        }


                        if (File.Exists("configfiles/enbnetworkfilelist.txt"))
                        {
                            File.Delete("configfiles/enbnetworkfilelist.txt");
                        }
                        if (File.Exists(home + "/configfiles/enbnetworkfilelist.txt"))
                        {
                            File.Delete(home + "/configfiles/enbnetworkfilelist.txt");
                        }


                        if (File.Exists("configfiles/towernetworkfilelist.txt"))
                        {
                            File.Delete("configfiles/towernetworkfilelist.txt");
                        }
                        if (File.Exists(home + "/configfiles/towernetworkfilelist.txt"))
                        {
                            File.Delete(home + "/configfiles/towernetworkfilelist.txt");
                        }


                        if (File.Exists("configfiles/"+ networkname + "celltowerinfo.txt"))
                        {
                            File.Delete("configfiles/" + networkname + "celltowerinfo.txt");
                        }
                        if (File.Exists(home + "/configfiles/" + networkname + "celltowerinfo.txt"))
                        {
                            File.Delete(home + "/configfiles/" + networkname + "celltowerinfo.txt");
                        }
                    }
                }
            }

            // change the second line
            lines[3] = "country:"+country;



            StreamWriter writer = new StreamWriter("configfiles/appsettings.txt",false);
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

            //Observer
            StreamWriter writer2 = new StreamWriter(home+"/configfiles/appsettings.txt", false);
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
            if (File.Exists("configfiles/appsettings.txt"))
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

                comboBox1.SelectedItem = lines[3].Split(':')[1];


            }

        }
    }


}
