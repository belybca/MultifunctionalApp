/*
 Name: Albelis Becea
   ID: 2110083
 Description: Project 30%
DASHBOARD
 Version 3.0  July 7, 2021 
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

namespace Project_2110083
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIPvalidator_Click(object sender, EventArgs e)
        {
            IPvalidator ipvalid;

            ipvalid = new IPvalidator();

            ipvalid.Show();
        }

        private void exitapp_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure that you want to exit the application",
                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)).ToString() == "Yes") 
            {
                Application.Exit();
            }
            
            
        }

        private void btnTempconvert_Click(object sender, EventArgs e)
        {
            TempApp tempconvert;

            tempconvert = new TempApp();

            tempconvert.Show();
        }

        private void btnlottomx_Click(object sender, EventArgs e)
        {
            LottoMax lottoM;

            lottoM = new LottoMax();

            lottoM.ShowDialog();


        }

        private void btnlotto649_Click(object sender, EventArgs e)
        {
            Lotto649 lotto649;

            lotto649 = new Lotto649();

            lotto649.ShowDialog();
        }

        private void bntMoneyEx_Click(object sender, EventArgs e)
        {
            MoneyExchange Mexchange;

            Mexchange = new MoneyExchange();

            Mexchange.ShowDialog();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calculator calculate;

            calculate = new Calculator();

            calculate.ShowDialog();
        }
    }
}
