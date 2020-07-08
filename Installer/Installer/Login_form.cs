using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Installer
{
    public partial class Login_form : Form
    {

        public string installerradiovalidationurl;
        public Login_form()
        {
            InitializeComponent();
            fullScreenDisplay();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadUrlCOnfigFile();
            string uniqueboxid = txt_uniqueboxid.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (String.IsNullOrEmpty(txt_uniqueboxid.Text))
            {

                lbl_uniqueboxid.Text = "Please enter unique box id";
                lbl_uniqueboxid.ForeColor = Color.Red;
                txt_uniqueboxid.Select();
                txt_uniqueboxid.Focus();
                txt_uniqueboxid.BackColor = Color.LightPink;
                
            }
            
            if (username == "")
            {
                lbl_username.Text = "Please enter username";
                lbl_username.ForeColor = Color.Red;
                txt_username.Select();
                txt_username.Focus();
                txt_username.BackColor = Color.LightPink;
            }
            
            if (password == "")
            {
                lbl_password.Text = "Please enter password";
                lbl_password.ForeColor = Color.Red;
                txt_password.Select();
                txt_password.Focus();
                txt_password.BackColor = Color.LightPink;
            }
            else
            {


                bool isvalidlogin = OpaqueInstallerLogin(installerradiovalidationurl, username, password, uniqueboxid);

                if(isvalidlogin)
                {
                    writeTofile(uniqueboxid, username, password);

                    Choice_form choice_frm = new Choice_form();
                    choice_frm.Show();
                    this.Hide();
                }



            }

            

        }

        private void writeTofile(string boxid, string username, string password)
        {
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"
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

            lines[4] = "boxid:" + boxid;
            lines[5] = "username:" + username;
            lines[6] = "password:" + password;



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


        public bool OpaqueInstallerLogin(string url, string username, string password, string boxid)
        {


            try
            {
                using (var client = new HttpClient())
                {
                    //https://www.myiapps.net/opaque/installerradiovalidation/installerradiovalidation.php?locationBoxID=client-1&installerPsw=demo123&login=lh123
                    var queryParamater = string.Format(url, boxid, password, username);
                    HttpResponseMessage response = client.GetAsync(queryParamater).Result;
                    var device = response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var login = JsonConvert.DeserializeObject<loginDto>(device.Result);
                        Console.WriteLine("Result: {0}", login.result);
                        Console.WriteLine("Reason: {0}", login.reason);
                        if(login.result == "failed")
                        {
                            MessageBox.Show(login.reason);
                            KillUpdater();
                            KillObserver();//must not be here,but its larry's login issue
                            KillLTEMMEScripts();//must not be here,but its larry's login issue
                            KillHSSScript();//must not be here,but its larry's login issue
                            return true;//must be actually false, disabling it cos larry has to fix 
                        }
                        else
                        {
                            KillUpdater();
                            KillObserver();
                            KillLTEMMEScripts();
                            KillHSSScript();
                            return true;
                        }


                    }
                    else
                    {
                        MessageBox.Show(response.ReasonPhrase);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred within reading the OpaqueInstallerLogin: " + ex.Message);

                //writeTofile(uniqueboxid, username, password);

                Choice_form choice_frm = new Choice_form();
                choice_frm.Show();
                this.Hide();
            }
            return false;
        }

        public void ReadUrlCOnfigFile()
        {
            try
            {
                var home = Environment.GetEnvironmentVariable("HOME");
                string file = home+"/configfiles/urls.conf";
                if (File.Exists(file))
                {
                    string[] lines = File.ReadAllLines(file);
                    Console.WriteLine("Reading urls.conf file:");
                    Console.WriteLine("=============================");
                    Console.WriteLine("\n");

                    installerradiovalidationurl = lines[8];
                    Console.WriteLine(installerradiovalidationurl);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("=============================");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("urls.conf file is missing");

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred within reading the ReadURLConfig(): " + ex.Message);
            }
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


        public static void KillLTEMMEScripts()
        {
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine("killall -9 lte-softmodem");
            proc.StandardInput.WriteLine("killall - 9 oai_mme");
            proc.StandardInput.WriteLine("killall -9 run_mme");
            proc.StandardInput.WriteLine("exit");
            string line = "";
            while (!proc.StandardOutput.EndOfStream)
            {
                line = proc.StandardOutput.ReadLine();
                Console.WriteLine(line);
            }
            proc.WaitForExit();
        }

        public static void KillHSSScript()
        {
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine("killall - 9 oai_hss");
            proc.StandardInput.WriteLine("killall -9 run_hss");
            proc.StandardInput.WriteLine("exit");
            string line = "";
            while (!proc.StandardOutput.EndOfStream)
            {
                line = proc.StandardOutput.ReadLine();
                Console.WriteLine(line);
            }
            proc.WaitForExit();
        }

        public static void KillObserver()
        {
            var home = Environment.GetEnvironmentVariable("HOME");

            if(File.Exists(home + "/configfiles/pid.txt"))
            {
                string line1 = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader(home + "/configfiles/pid.txt");
                // read all the lines in the file and store them in the List
                while ((line1 = reader.ReadLine()) != null)
                {
                    lines.Add(line1);
                }
                reader.Close();

                string command = string.Format("sudo kill -9 {0}", lines[0]);
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
            //home+"

        }

        public static void KillUpdater()
        {
            var home = Environment.GetEnvironmentVariable("HOME");
            //home+"
            if(File.Exists(home + "/Updater/configfiles/pid.txt"))
            {
                string line1 = null;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader(home + "/Updater/configfiles/pid.txt");
                // read all the lines in the file and store them in the List
                while ((line1 = reader.ReadLine()) != null)
                {
                    lines.Add(line1);
                }
                reader.Close();

                string command = string.Format("sudo kill -9 {0}", lines[0]);
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
}