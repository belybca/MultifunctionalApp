/*
 Name: Albelis Becea
   ID: 2110083
 Description: Project 30%
Money Exchange Application
 Version 4.0  July 22, 2021
 */
/*
         1CAD -- 0.8 USD
              -- 0.67 EUR  
              -- 0.58 GBP
              -- 2244032 BS
        1US   -- 1.25 CAD
              -- 0.84 EUR
              -- 0.73 GBP
              -- 2839100 BS
        1EUR  -- 1.49 CAD
              -- 1.19 USD
              -- 0.86 GBP
              -- 3231532 BS
        1GBP  -- 1.73 CAD
              -- 1.38 USD
              -- 1.16 EUR
              -- 3772689 BS
        1BS   -- 4.45626e-7 CAD
              -- 3.522242e-7 USD
              -- 3.0945075e-7 EUR
              -- 2.650629e-7 GBP

         
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
using System.IO;

namespace Project_2110083
{
    public partial class MoneyExchange : Form
    {
        //Writing File
        string dir = @"..\PrjTxtFiles\";
        string path = @"..\PrjTxtFiles\MoneyConversions.txt";
        FileStream fs = null;
        
        MoneyConvertor valfrom;
        public MoneyExchange()
        {
            InitializeComponent();
        }
        private RadioButton CheckSelection(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton selection = control as RadioButton;
                if (selection != null && selection.Checked)
                {
                    return selection;
                }
            }
            return null;
        }
        
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want\nto quit the aplication\nMoney Exchange?",
              "Exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)).ToString() == "Yes")
            {
                this.Close();
            }

        }

        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            valfrom = new MoneyConvertor();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            string ExfromCurr = this.CheckSelection(groupBox1).Text;
            string ExtoCurr = this.CheckSelection(groupBox2).Text;
            
            valfrom.Convertion = ExfromCurr + ExtoCurr;
            
            try
            {
                valfrom.Val1 = Convert.ToDouble(TextBoxToChange.Text);
                txtBxResult.Text = (valfrom.ResultConversion()).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                TextBoxToChange.Focus();
                TextBoxToChange.Text = "";
            }

            DateTime currDaTim = DateTime.Now;

            try
            { //Writting into text file
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);

                textOut.WriteLine(ExfromCurr+" to "+ExtoCurr+"\t"+TextBoxToChange.Text +" "+ ExfromCurr+ " = " + txtBxResult.Text + " "+ExtoCurr + "\t"+currDaTim.ToString("MM/dd/yyyy  HH:mm:ss"));

                textOut.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dir + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally
            {
                if (fs != null) fs.Close();
            }


        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                //reading the text file
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "  From To\t\t\tResult\t\tDate Time\n";
                textToPrint += textIn.ReadToEnd();

                MessageBox.Show(textToPrint, "Money Exchage Results - Albelis");
                // close the input stream for the text file
                textIn.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dir + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }
    }

    class MoneyConvertor
    {
        double val1;
        string convertion;

        public MoneyConvertor() { }

        public double Val1
        {
            get { return val1; }
            set { val1 = value; }
        }
        public string Convertion
        {
            get { return convertion; }
            set { convertion = value; }
        }
        

       
        public double ResultConversion() {
            double result=0;
            switch (Convertion)
            {
                case "CADCAD":
                    result = Val1 * 1;
                    break;
                case "CADUSD":
                   result= Val1*0.8;
                    break;
                case "CADEUR":
                    result = Val1 * 0.67;
                     break;
                case "CADGBP":
                    result = Val1 * 0.58;
                    break;
                case "CADBS":
                    result = Val1 * 2244032;
                    break;
                //------------------------------------------------------
                case "USDCAD":
                    result = Val1 * 1.25;
                    break;
                case "USDUSD":
                    result = Val1*1;
                    break;
                case "USDEUR":
                    result = Val1 * 0.84;
                    break;
                case "USDGBP":
                    result = Val1 * 0.73;
                    break;
                case "USDBS":
                    result = Val1 * 2839100;
                    break;
                //-----------------------------------
                case "EURCAD":
                    result = Val1 * 1.49;
                    break;
                case "EURUSD":
                    result = Val1 * 1.19;
                    break;
                case "EUREUR":
                    result = Val1 * 1;
                    break;
                case "EURGBP":
                    result = Val1 * 0.86;
                    break;
                case "EURBS":
                    result = Val1 * 3231532;
                    break;
                //---------------------------------
                case "GBPCAD":
                    result = Val1 * 1.73;
                    break;
                case "GBPUSD":
                    result = Val1 * 1.38;
                    break;
                case "GBPEUR":
                    result = Val1 * 1.16;
                    break;
                case "GBPGBP":
                    result = Val1 * 1;
                    break;
                case "GBPBS":
                    result = Val1 * 3772689;
                    break;
                //----------------------------------------------
                case "BSCAD":
                    result = Val1 * 4.45626e-7;
                    break;
                case "BSUSD":
                    result = Val1 * 3.522242e-7;
                    break;
                case "BSEUR":
                    result = Val1 * 3.0945075e-7;
                    break;
                case "BSGBP":
                    result = Val1 * 2.650629e-7;
                    break;
                case "BSBS":
                    result = Val1 * 1;
                    break;
            }
            return result;

        }

    }
}
