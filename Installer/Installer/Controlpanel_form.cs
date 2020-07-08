using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class Controlpanel_form : Form
    {

        public const string Ctrlpanel = "ControlPanel";
        public Controlpanel_form()
        {
            InitializeComponent();
            fullScreenDisplay();
        }

        private void btn_changecountry_Click(object sender, EventArgs e)
        {
            Country_form country_frm = new Country_form(Ctrlpanel);
            country_frm.Show();
            this.Hide();
        }

        private void btn_goback_Click(object sender, EventArgs e)
        {
            Choice_form choice_frm = new Choice_form();
            choice_frm.Show();
            this.Hide();
        }

        private void btn_changelocation_Click(object sender, EventArgs e)
        {
            Location_form loc_frm = new Location_form(Ctrlpanel);
            loc_frm.Show();
            this.Hide();
        }

        private void btn_changeLAC_Click(object sender, EventArgs e)
        {
            Network_form network_frm = new Network_form(Ctrlpanel);
            network_frm.Show();
            this.Hide();

        }

        private void btn_changetowerinfo_Click(object sender, EventArgs e)
        {
            Tower_form tower_frm = new Tower_form(Ctrlpanel);
            tower_frm.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting and starting Observer.");
            StartObserver();
            StartUpdater();
            this.Close();
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

        public static void StartObserver()
        {
            RunCommands("sudo chmod +x /configfiles/start_observer");
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
            RunCommands("sudo chmod +x /configfiles/start_updater");

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
    }
}
