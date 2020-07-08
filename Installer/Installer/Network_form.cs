using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class Network_form : Form
    {

        List<string> networks = new List<string>();
        public string fromwhere { get; set; }
        public int totalnetworks { get; set; }
        static int countformreload = 0;



        public Network_form(string frmwhere)
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

        public Network_form()
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
            int networkcount = DoNetworkCount(ReadCountryFile());
            MessageBox.Show("total networks: " + networkcount + " counting form load: " + countformreload.ToString());

            if(String.IsNullOrEmpty(txt_lac.Text))
            {
                lbl_lac.Text = "Please enter lac";
                lbl_lac.ForeColor = Color.Red;
                txt_lac.Select();
                txt_lac.Focus();
                txt_lac.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txt_pcellid.Text))
            {
                lbl_pcellid.Text = "Please enter physical cellid";
                lbl_pcellid.ForeColor = Color.Red;
                txt_pcellid.Select();
                txt_pcellid.Focus();
                txt_pcellid.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txt_dlearfcn.Text))
            {
                lbl_dlearfcn.Text = "Please enter downlink earcfn";
                lbl_dlearfcn.ForeColor = Color.Red;
                txt_dlearfcn.Select();
                txt_dlearfcn.Focus();
                txt_dlearfcn.BackColor = Color.LightPink;
            }
            if (String.IsNullOrEmpty(txt_ulearfcn.Text))
            {
                lbl_ulearfcn.Text = "Please enter uplink earcfn";
                lbl_ulearfcn.ForeColor = Color.Red;
                txt_ulearfcn.Select();
                txt_ulearfcn.Focus();
                txt_ulearfcn.BackColor = Color.LightPink;
            }
            else
            {
                string mcc = getMCC(lbl_networkname.Text, ReadCountryFile());
                string mnc = getMNC(lbl_networkname.Text, ReadCountryFile());
                int tac = Int32.Parse(txt_lac.Text);
                string notchangedtac = txt_lac.Text;
                string notchangedphcid = txt_pcellid.Text;
                int pcid = Int32.Parse(txt_pcellid.Text);
                double ddl = Double.Parse(txt_dlearfcn.Text, CultureInfo.InvariantCulture);
                double dul = Double.Parse(txt_ulearfcn.Text, CultureInfo.InvariantCulture);
                double tddl = ddl * 1000000;
                double tdul = dul * 1000000;

                string dlearfcn = tddl.ToString();
                string ulearfcn = tdul.ToString();
                double diff = tddl - tdul;
                string diffearfcn = diff.ToString();
                createtowerlistfile(lbl_networkname.Text);
                createenblistfile(lbl_networkname.Text);
                createmmelistfile(lbl_networkname.Text);

                if (cb_LAC.Text != "")
                {
                    int addlac = Int32.Parse(cb_LAC.Text);
                    tac = tac + addlac;
                }
                else
                {
                    tac = tac + 1;
                }

                string lac = tac.ToString();

                if (cb_pcellid.Text != "")
                {
                    int addpci = Int32.Parse(cb_pcellid.Text);
                    pcid = pcid + addpci;
                }
                else
                {
                    pcid = pcid + 1;
                }

                string phcellid = pcid.ToString();
                CreateENBfile(lbl_networkname.Text, mcc, mnc, lac, "3", phcellid, dlearfcn, diffearfcn);
                CreateMMEfile(lbl_networkname.Text, mcc, mnc, lac);
                createcountrymccfile(mcc);
                createnetworkoperatorfilelist(lbl_networkname.Text);
                createearfcnfilelist(lbl_networkname.Text);
                createeachnetworkoperatorfile(lbl_networkname.Text, mcc, mnc, notchangedtac, notchangedphcid);
                createeachnetworkearfcnfile(dlearfcn, ulearfcn, lbl_networkname.Text);

                if (fromwhere == "ControlPanel")
                {

                    if (networkcount > countformreload)
                    {

                        Network_form network_frm = new Network_form("ControlPanel");
                        network_frm.Show();
                        this.Hide();
                        MessageBox.Show("Configuration saved!");
                    }
                    else
                    {
                        Tower_form tower_frm = new Tower_form();
                        tower_frm.Show();
                        this.Hide();
                    }
                    //Save the configuration
                    //

                }
                else
                {

                    if (networkcount > countformreload)
                    {
                        Network_form network_frm = new Network_form("ControlPanel");
                        network_frm.Show();
                        this.Hide();
                        MessageBox.Show("Configuration saved!");
                    }
                    else
                    {
                        Tower_form tower_frm = new Tower_form();
                        tower_frm.Show();
                        this.Hide();
                    }
                }
            }

            
        }
        //gets used
        private void CreateMMEfile(string networkname, string mcc, string mnc, string lac)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            string path = "configfiles/temp_mme.conf";
            StreamReader reader = new StreamReader(path);
            String s = "";
            List<string> lines = new List<string>();
            while ((s = reader.ReadLine()) != null)
            {
                lines.Add(s);
            }
            reader.Close();

            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }
            //         {MCC="655" ; MNC="10"; MME_GID="4" ; MME_CODE="1"; }                   # YOUR GUMMEI CONFIG HERE
            //         {MCC="655" ; MNC="10";  TAC = "27001"; }                                   # YOUR TAI CONFIG HERE


            Console.WriteLine(lines[77]);
            Console.WriteLine(lines[86]);

            string newmnc = "";
            if (mnc.Count() == 1)
            {
                newmnc = "0" + mnc;
                lines[77] = "         {MCC=\"" + mcc + "\" ; MNC=\"" + newmnc + "\"; MME_GID=\"4\" ; MME_CODE=\"1\"; }                   # YOUR GUMMEI CONFIG HERE";
                lines[86] = "         {MCC=\"" + mcc + "\" ; MNC=\"" + newmnc + "\";  TAC = \"" + lac + "\"; }                                   # YOUR TAI CONFIG HERE";
            }
            else
            {
                lines[77] = "         {MCC=\"" + mcc + "\" ; MNC=\"" + mnc + "\"; MME_GID=\"4\" ; MME_CODE=\"1\"; }                   # YOUR GUMMEI CONFIG HERE";
                lines[86] = "         {MCC=\"" + mcc + "\" ; MNC=\"" + mnc + "\";  TAC = \"" + lac + "\"; }                                   # YOUR TAI CONFIG HERE";
            }





            //installer self
            StreamWriter writer = new StreamWriter("configfiles/" + networkname + "mme.conf", false);
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
            //home+"
            //observer
            StreamWriter writer2 = new StreamWriter(home + "/Observer/configfiles/" + networkname + "mme.conf", false);
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

            StreamWriter writer3 = new StreamWriter(home + "/configfiles/" + networkname + "mme.conf", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one
            for (int i = 0; i < lines.Count; i++)
            {
                if (i < lines.Count - 1)
                {
                    writer3.WriteLine(lines[i]);
                    Console.WriteLine(lines[i]);
                }

                else
                {
                    writer3.WriteLine(lines[i]);
                    Console.WriteLine(lines[i]);
                }

            }
            writer3.Close();

        }

        private void CreateENBfile(string networkname, string mcc, string mnc, string lac, string band,string phcellid, string dlearfcn, string diffearfcn)
       {
            networkname = Regex.Replace(networkname, @"\s+", "");
            string path = "configfiles/temp_enb.conf";
           StreamReader reader = new StreamReader(path);
           String s = "";
           List<string> lines = new List<string>();
           while ((s = reader.ReadLine()) != null)
           {
              lines.Add(s);
           }
           reader.Close();

           foreach (string item in lines)
           {
                Console.WriteLine(item);
           }
            //17    tracking_area_code = 27001;
            //19      { mcc = 655; mnc = 10; mnc_length = 2; }
            //37               eutra_band                             = 3;
            //38                           downlink_frequency = 1822700000L;
            //39                           uplink_frequency_offset = -95000000;
            //41               Nid_cell                       = 302;

            Console.WriteLine(lines[17]);
            Console.WriteLine(lines[19]);
            Console.WriteLine(lines[37]);
            Console.WriteLine(lines[38]);
            Console.WriteLine(lines[39]);
            Console.WriteLine(lines[41]);
            string newmnc = "";
            if(mnc.Count()==1)
            {
                newmnc = "0" + mnc;
                lines[19] = "      { mcc = " + mcc + "; mnc = " + newmnc + "; mnc_length = " + newmnc.Count().ToString() + "; }";
            }
            else
            {
                lines[19] = "      { mcc = " + mcc + "; mnc = " + mnc + "; mnc_length = " + mnc.Count().ToString() + "; }";
            }

            lines[17] = "    tracking_area_code  = " + lac + ";";

            lines[37] = "  \t\t\t   eutra_band              \t\t\t      = " + band + ";";
            lines[38] = "                           downlink_frequency      \t\t\t      = " + dlearfcn + "L;";
            lines[39] = "                           uplink_frequency_offset \t\t\t      = -" + diffearfcn + ";";
            lines[41] = "                           Nid_cell                \t\t\t      = " + phcellid + ";";



           StreamWriter writer = new StreamWriter("configfiles/"+networkname+"enb.conf", false);
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
            //home+"
            //for observer
            StreamWriter writer2 = new StreamWriter(home + "/Observer/configfiles/" + networkname + "enb.conf", false);
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

            StreamWriter writer3 = new StreamWriter(home + "/configfiles/" + networkname + "enb.conf", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one
            for (int i = 0; i < lines.Count; i++)
            {
                if (i < lines.Count - 1)
                {
                    writer3.WriteLine(lines[i]);
                    Console.WriteLine(lines[i]);
                }

                else
                {
                    writer3.WriteLine(lines[i]);
                    Console.WriteLine(lines[i]);
                }

            }
            writer3.Close();


        }
        //gets used
        private void createeachnetworkoperatorfile(string networkname, string mcc, string mnc, string lac, string phcellid)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            //~/Observer/Observer/bin/Debug/configfiles/
            StreamWriter writer = new StreamWriter("configfiles//"+networkname+".txt", false);
            Console.WriteLine("Writing lines back to the file");
        // write the lines back to the file, overwriting the original one

            writer.WriteLine("cellid:"+phcellid);
            writer.WriteLine("mcc:" + mcc);
            writer.WriteLine("mnc:" + mnc);
            writer.WriteLine("lac:" + lac);
            writer.WriteLine("brand:" + networkname);
            writer.WriteLine("imsioperator:" + networkname);

            writer.Close();

            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"
            //for observer
            StreamWriter writer2 = new StreamWriter(home + "/Observer/configfiles//" + networkname + ".txt", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one

            writer2.WriteLine("cellid:" + phcellid);
            writer2.WriteLine("mcc:" + mcc);
            writer2.WriteLine("mnc:" + mnc);
            writer2.WriteLine("lac:" + lac);
            writer2.WriteLine("brand:" + networkname);
            writer2.WriteLine("imsioperator:" + networkname);

            writer2.Close();

            StreamWriter writer3 = new StreamWriter(home + "/configfiles//" + networkname + ".txt", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one

            writer3.WriteLine("cellid:" + phcellid);
            writer3.WriteLine("mcc:" + mcc);
            writer3.WriteLine("mnc:" + mnc);
            writer3.WriteLine("lac:" + lac);
            writer3.WriteLine("brand:" + networkname);
            writer3.WriteLine("imsioperator:" + networkname);

            writer3.Close();
        }



        private void createeachnetworkearfcnfile(string dlearfcn, string ulearfcn, string networkname)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"
            //~/Observer/Observer/bin/Debug/configfiles/
            StreamWriter writer = new StreamWriter("configfiles//" + networkname + "_earfcn.txt", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one

            writer.WriteLine(dlearfcn);
            writer.WriteLine(ulearfcn);


            writer.Close();

            //for observer
            StreamWriter writer2 = new StreamWriter(home + "/configfiles//" + networkname + "_earfcn.txt", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one

            writer2.WriteLine(dlearfcn);
            writer2.WriteLine(ulearfcn);


            writer2.Close();
        }

        public void populatefields(string networkname)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            if (File.Exists("configfiles//" + networkname + "_earfcn.txt"))
            {
                string line = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader("configfiles//" + networkname + "_earfcn.txt");

                // read all the lines in the file and store them in the List
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                reader.Close();

                double ddl = Double.Parse(lines[0], CultureInfo.InvariantCulture);
                double dul = Double.Parse(lines[1], CultureInfo.InvariantCulture);
                double tddl = ddl / 1000000;
                double tdul = dul / 1000000;

                string dlearfcn = tddl.ToString().Replace(',','.');
                string ulearfcn = tdul.ToString().Replace(',', '.');

                txt_dlearfcn.Text = dlearfcn;
                txt_ulearfcn.Text = ulearfcn;



            }
            if (File.Exists("configfiles//" + networkname + ".txt"))
            {
                string line = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader("configfiles//" + networkname + ".txt");

                // read all the lines in the file and store them in the List
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                reader.Close();

                txt_pcellid.Text = lines[0].Split(':')[1];
                txt_lac.Text = lines[3].Split(':')[1];



            }

        }
        //gets used
        private void createcountrymccfile(string mcc)
        {
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"
            //~/Observer/Observer/bin/Debug/configfiles/
            StreamWriter writer = new StreamWriter("configfiles/countrymcc.txt", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one

            writer.WriteLine(mcc);

            writer.Close();

            //oberver
            StreamWriter writer2 = new StreamWriter(home + "/configfiles/countrymcc.txt", false);
            Console.WriteLine("Writing lines back to the file");
            // write the lines back to the file, overwriting the original one

            writer2.WriteLine(mcc);

            writer2.Close();
        }
        //gets used
        private void createnetworkoperatorfilelist(string networkname)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"
            if (!File.Exists(home + "/configfiles/networkoperators.txt"))
            {
                //for Observer
                StreamWriter writer2 = new StreamWriter(home + "/configfiles/networkoperators.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer2.WriteLine(networkname + ".txt");

                writer2.Close();
            }
            //~/Observer/Observer/bin/Debug/configfiles/
            if (File.Exists("configfiles/networkoperators.txt"))
            {
                string line = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader("configfiles/networkoperators.txt");

                // read all the lines in the file and store them in the List
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                reader.Close();


                if (!lines.Contains(networkname + ".txt"))
                {
                    StreamWriter writer = new StreamWriter("configfiles/networkoperators.txt", true);
                    Console.WriteLine("Writing lines back to the file");
                    // write the lines back to the file, overwriting the original one

                    writer.WriteLine(networkname + ".txt");

                    writer.Close();

                    //for Observer
                    StreamWriter writer2 = new StreamWriter(home + "/configfiles/networkoperators.txt", true);
                    Console.WriteLine("Writing lines back to the file");
                    // write the lines back to the file, overwriting the original one

                    writer2.WriteLine(networkname + ".txt");

                    writer2.Close();
                }

            }
            else
            {
                StreamWriter writer = new StreamWriter("configfiles/networkoperators.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer.WriteLine(networkname + ".txt");

                writer.Close();


                //for Observer
                StreamWriter writer2 = new StreamWriter(home + "/configfiles/networkoperators.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer2.WriteLine(networkname + ".txt");

                writer2.Close();
            }



        }

        private void createearfcnfilelist(string networkname)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"
            if (!File.Exists(home + "/configfiles/earfcnlist.txt"))
            {
                StreamWriter writer2 = new StreamWriter(home + "/configfiles/earfcnlist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer2.WriteLine(networkname + "_earfcn.txt");

                writer2.Close();
            }
            //~/Observer/Observer/bin/Debug/configfiles/
            if (File.Exists("configfiles/earfcnlist.txt"))
            {
                string line = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader("configfiles/earfcnlist.txt");

                // read all the lines in the file and store them in the List
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                reader.Close();


                if (!lines.Contains(networkname + "_earfcn.txt"))
                {
                    StreamWriter writer = new StreamWriter("configfiles/earfcnlist.txt", true);
                    Console.WriteLine("Writing lines back to the file");
                    // write the lines back to the file, overwriting the original one

                    writer.WriteLine(networkname + "_earfcn.txt");

                    writer.Close();

                    //for Observer
                    StreamWriter writer2 = new StreamWriter(home + "/configfiles/earfcnlist.txt", true);
                    Console.WriteLine("Writing lines back to the file");
                    // write the lines back to the file, overwriting the original one

                    writer2.WriteLine(networkname + "_earfcn.txt");

                    writer2.Close();
                }

            }
            else
            {
                StreamWriter writer = new StreamWriter("configfiles/earfcnlist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer.WriteLine(networkname + "_earfcn.txt");

                writer.Close();


                //for Observer
                StreamWriter writer2 = new StreamWriter(home + "/configfiles/earfcnlist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer2.WriteLine(networkname + "_earfcn.txt");

                writer2.Close();
            }



        }




        //gets used
        private void createmmelistfile(string networkname)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            var home = Environment.GetEnvironmentVariable("HOME");
            if (!File.Exists(home + "/configfiles/mmenetworkfilelist.txt"))
            {
                StreamWriter writer2 = new StreamWriter(home + "/configfiles/mmenetworkfilelist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer2.WriteLine(networkname + "mme.conf");

                writer2.Close();
            }
            //~/Observer/Observer/bin/Debug/configfiles/

            //home+"
            if (File.Exists("configfiles/mmenetworkfilelist.txt"))
            {
                string line = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader("configfiles/mmenetworkfilelist.txt");

                // read all the lines in the file and store them in the List
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                reader.Close();


                if (!lines.Contains(networkname + "mme.conf"))
                {
                    StreamWriter writer = new StreamWriter("configfiles/mmenetworkfilelist.txt", true);
                    Console.WriteLine("Writing lines back to the file");
                    // write the lines back to the file, overwriting the original one

                    writer.WriteLine(networkname + "mme.conf");

                    writer.Close();

                    //Observer
                    StreamWriter writer2 = new StreamWriter(home + "/configfiles/mmenetworkfilelist.txt", true);
                    Console.WriteLine("Writing lines back to the file");
                    // write the lines back to the file, overwriting the original one

                    writer2.WriteLine(networkname + "mme.conf");

                    writer2.Close();
                }

            }
            else
            {
                StreamWriter writer = new StreamWriter("configfiles/mmenetworkfilelist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer.WriteLine(networkname + "mme.conf");

                writer.Close();

                //Observer
                StreamWriter writer2 = new StreamWriter(home + "/configfiles/mmenetworkfilelist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer2.WriteLine(networkname + "mme.conf");

                writer2.Close();
            }



        }




        //gets used
        private void createenblistfile(string networkname)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"
            if (!File.Exists(home + "/configfiles/enbnetworkfilelist.txt"))
            {
                StreamWriter writer2 = new StreamWriter(home + "/configfiles/enbnetworkfilelist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer2.WriteLine(networkname + "enb.conf");

                writer2.Close();
            }
            //~/Observer/Observer/bin/Debug/configfiles/
            if (File.Exists("configfiles/enbnetworkfilelist.txt"))
            {
                string line = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader("configfiles/enbnetworkfilelist.txt");

                // read all the lines in the file and store them in the List
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                reader.Close();



                if (!lines.Contains(networkname + "enb.conf"))
                {
                    StreamWriter writer = new StreamWriter("configfiles/enbnetworkfilelist.txt", true);
                    Console.WriteLine("Writing lines back to the file");
                    // write the lines back to the file, overwriting the original one

                    writer.WriteLine(networkname + "enb.conf");

                    writer.Close();

                    //Observer
                    StreamWriter writer2 = new StreamWriter(home + "/configfiles/enbnetworkfilelist.txt", true);
                    Console.WriteLine("Writing lines back to the file");
                    // write the lines back to the file, overwriting the original one

                    writer2.WriteLine(networkname + "enb.conf");

                    writer2.Close();
                }

            }
            else
            {
                StreamWriter writer = new StreamWriter("configfiles/enbnetworkfilelist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer.WriteLine(networkname + "enb.conf");

                writer.Close();

                //Observer
                StreamWriter writer2 = new StreamWriter(home + "/configfiles/enbnetworkfilelist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer2.WriteLine(networkname + "enb.conf");

                writer2.Close();
            }



        }
        //gets used
        private void createtowerlistfile(string networkname)
        {
            networkname = Regex.Replace(networkname, @"\s+", "");
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"
            //~/Observer/Observer/bin/Debug/configfiles
            if (!File.Exists(home + "/configfiles/towernetworkfilelist.txt"))
            {
                StreamWriter writer2 = new StreamWriter(home + "/configfiles/towernetworkfilelist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer2.WriteLine(networkname + "celltowerinfo.txt");

                writer2.Close();
            }
            if (File.Exists("configfiles/towernetworkfilelist.txt"))
            {
                string line = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader("configfiles/towernetworkfilelist.txt");

                // read all the lines in the file and store them in the List
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                reader.Close();


                if (!lines.Contains(networkname + "celltowerinfo.txt"))
                {
                    StreamWriter writer = new StreamWriter("configfiles/towernetworkfilelist.txt", true);
                    Console.WriteLine("Writing lines back to the file");
                    // write the lines back to the file, overwriting the original one

                    writer.WriteLine(networkname + "celltowerinfo.txt");

                    writer.Close();

                    //Observer
                    StreamWriter writer2 = new StreamWriter(home + "/configfiles/towernetworkfilelist.txt", true);
                    Console.WriteLine("Writing lines back to the file");
                    // write the lines back to the file, overwriting the original one

                    writer2.WriteLine(networkname + "celltowerinfo.txt");

                    writer2.Close();
                }

            }
            else
            {
                StreamWriter writer = new StreamWriter("configfiles/towernetworkfilelist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer.WriteLine(networkname + "celltowerinfo.txt");

                writer.Close();

                //Observer
                StreamWriter writer2 = new StreamWriter(home + "/configfiles/towernetworkfilelist.txt", true);
                Console.WriteLine("Writing lines back to the file");
                // write the lines back to the file, overwriting the original one

                writer2.WriteLine(networkname + "celltowerinfo.txt");

                writer2.Close();
            }



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
        //gets used
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

        //gets used
        private void frm_load(object sender, EventArgs e)
        {
            countformreload++;
        }
        //gets used
        private string getMCC(string networkname, string country)
        {
            string mcc = "";
            DatabaseContext operatorcountries = new DatabaseContext();
            try
            {
                var mcclist = operatorcountries.Operators
                .Where(x => x.Network == networkname && x.Country ==country)
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

                    Network_form network_frm = new Network_form("ControlPanel");
                    network_frm.Show();
                    this.Hide();

                }
                else
                {
                    Tower_form tower_frm = new Tower_form();
                    tower_frm.Show();
                    this.Hide();
                }
                //Save the configuration
                //

            }
            else
            {

                if (networkcount > countformreload)
                {
                    Network_form network_frm = new Network_form("ControlPanel");
                    network_frm.Show();
                    this.Hide();

                }
                else
                {
                    Tower_form tower_frm = new Tower_form();
                    tower_frm.Show();
                    this.Hide();
                }
            }
        }
    }
}
