/*
 Name: Albelis Becea
   ID: 2110083
 Description: Project 30%
IPV4 VALIDATOR Application
 Version 4.0  July 22, 2021
 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project_2110083
{
    public partial class IPvalidator : Form
    {
        DateTime currDate = DateTime.Now;
        Ipvalid validation;
        public IPvalidator()
        {
            InitializeComponent();
        }

        private void IPvalidator_Load(object sender, EventArgs e)
        {
            validation = new Ipvalid();
            lbDate.Text = "Today : " + currDate.ToLongDateString();
            txBxIp.Focus();
        }

        private void btnExittemp_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to quit the IP4 Validator App",
              "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)).ToString() == "Yes")
            {
                this.Close();
            }
            else { Reset(); }
        }
        void Reset() {
            txBxIp.ReadOnly = false;
            txBxIp.Focus();
            txBxIp.Text = "";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            try
            {
                validation.Ipaddress = txBxIp.Text;
                validation.ValidateIP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                txBxIp.Focus();
                txBxIp.Text = "0";
            }
        }
    }
    class Ipvalid {
        string ipaddress;
        public Ipvalid() { }

        public string Ipaddress
        {
            get { return ipaddress; }
            set { ipaddress = value; }
        }

        public void ValidateIP() {
                Ipaddress = Ipaddress.Trim();
                Regex IPRegex = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");

                if (IPRegex.IsMatch(Ipaddress) == true)
                {
                    MessageBox.Show(Ipaddress + "\nThe IP is correct", "Valid IP");
                }
                else
                {
                    MessageBox.Show(Ipaddress+ "\nThe IP must have 4 bytes\ninteger number between 0 to 255\nseparated by a dot (255.255.255.255)", "Error");
                }
        }

    }
}
