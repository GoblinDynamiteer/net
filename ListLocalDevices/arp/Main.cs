using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace arp
{
    public partial class Main : Form
    {
        string regexIp = @"\d+\.\d+\.\d+\.\d+";
        // string regexMac = @"([0 - 9a - f]{2}\-){5}[0-9a-f]{2}";
        string regexMac = @".{2}\-.{2}\-.{2}\-.{2}\-.{2}\-.{2}";

        public Main()
        {
            InitializeComponent();
        }

        private void btnGetDevices_Click(object sender, EventArgs e)
        {
            listBoxDevices.Items.Clear();

            string[] result = GetARPResult();

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = result[i].Trim();
            }

            listBoxDevices.Items.AddRange(result);
        }

        private static string[] GetARPResult()
        {
            Process p = null;
            string output = string.Empty;

            try
            {
                p = Process.Start(new ProcessStartInfo(
                    @"C:\Windows\SysWOW64\ARP.EXE", "-a")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                });

                output = p.StandardOutput.ReadToEnd();

                p.Close();
            }
            catch
            {
                
            }

            finally
            {
                if (p != null)
                {
                    p.Close();
                }
            }
            string[] stringSeparators = new string[] { "\n" };

            return output.Split(
                stringSeparators, StringSplitOptions.None); ;
        }

        private void listBoxDevices_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            try
            {
                string ip = Regex.Match(
                    listBoxDevices.Text, regexIp).Value;
                string mac = Regex.Match(
                    listBoxDevices.Text, regexMac).Value;

                tbIp.Text = ip;
                tbMac.Text = mac;
            }

            catch
            {
                tbIp.Text = "NONE";
                tbMac.Text = "NONE";
            }
        }
    }
}
