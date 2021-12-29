/*
 Name: Albelis Becea
   ID: 2110083
 Description: Project 30%
CALCULATOR Application
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
using System.IO;

namespace Project_2110083
{
    public partial class Calculator : Form
    {
        
        //Writing File
        string dir = @"..\PrjTxtFiles\";
        string path = @"..\PrjTxtFiles\Calculator.txt";
        FileStream fs = null;

        
        CalculatorOperator operations;
        double result;
      
        public Calculator()
        {
            InitializeComponent();
        }
        void Reset()
        {
            texBxCalc.ReadOnly = false;
            texBxCalc.Focus();
            texBxCalc.Text = "0";

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            operations = new CalculatorOperator();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to quit the Calculator Application?",
              "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)).ToString() == "Yes")
            {
                this.Close();
            }
            else { Reset(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null){texBxCalc.Text = "1";}
            else { texBxCalc.Text = texBxCalc.Text + "1";}
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null) { texBxCalc.Text = "2"; }
            else { texBxCalc.Text = texBxCalc.Text + "2"; }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null) { texBxCalc.Text = "3"; }
            else { texBxCalc.Text = texBxCalc.Text + "3"; }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null) { texBxCalc.Text = "4"; }
            else { texBxCalc.Text = texBxCalc.Text + "4"; }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null) { texBxCalc.Text = "5"; }
            else { texBxCalc.Text = texBxCalc.Text + "5"; }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null) { texBxCalc.Text = "6"; }
            else { texBxCalc.Text = texBxCalc.Text + "6"; }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null) { texBxCalc.Text = "7"; }
            else { texBxCalc.Text = texBxCalc.Text + "7"; }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null) { texBxCalc.Text = "8"; }
            else { texBxCalc.Text = texBxCalc.Text + "8"; }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null) { texBxCalc.Text = "9"; }
            else { texBxCalc.Text = texBxCalc.Text + "9"; }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null) { texBxCalc.Text = "0"; }
            else { texBxCalc.Text = texBxCalc.Text + "0"; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (texBxCalc.Text == "0" && texBxCalc.Text != null) { texBxCalc.Text = "0."; }
            else if (texBxCalc.Text.Contains(".")) { texBxCalc.Text = texBxCalc.Text; }
            else { texBxCalc.Text = texBxCalc.Text + "."; }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operations.Val1 = Convert.ToDouble(texBxCalc.Text);
            texBxCalc.Text = "0";
            operations.Operation = "add";
        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            operations.Val1 = Convert.ToDouble(texBxCalc.Text);
            texBxCalc.Text = "0";
            operations.Operation = "subs";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operations.Val1 = Convert.ToDouble(texBxCalc.Text);
            texBxCalc.Text = "0";
            operations.Operation = "mult";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operations.Val1 = Convert.ToDouble(texBxCalc.Text);
            texBxCalc.Text = "0";
            operations.Operation = "div";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            
            string resultstr="";
            operations.Val2 = Convert.ToDouble(texBxCalc.Text);

            result = operations.CalculatorResults();
            texBxCalc.Text = Convert.ToString(result);
            resultstr = operations.StringResults() + " = " + Convert.ToString(result);
           
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
               StreamWriter textOut = new StreamWriter(fs);
               
                textOut.WriteLine(resultstr);

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
            //operations.Val2  = 0;
        }
    }
    class CalculatorOperator
    {
        double val1, val2;
        string operation;

        public CalculatorOperator() { }

        public double Val1
        {
            get { return val1; }
            set { val1 = value; }
        }
        public double Val2
        {
            get { return val2; }
            set { val2 = value; }             
        }
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }
        
        public double CalculatorResults()
        {
            double result=0;
            switch (Operation)
            {
                case "add":

                    result = Val1 + Val2;
                    break;

                case "subs":
                    result = Val1 - Val2;
                    break;

                case "mult":
                    result = Val1 * Val2;
                   break;

                case "div":

                    if (Val2 == 0)
                    {
                        MessageBox.Show("Error Division by Zero not allowed", "Error");
                        
                    }
                    else
                    { result = Val1 / Val2;}
                    break;
                
                   
            }
            
            return result;
        }
        public string StringResults()
        {
            string resultstr = "";
            switch (Operation)
            {
                case "add":
                    resultstr = Val1.ToString() + " + " + Val2.ToString();
                    break;

                case "subs":
                   resultstr = Val1.ToString() + " - " +Val2.ToString();
                    break;

                case "mult":
                    resultstr = Val1.ToString() + " * " +Val2.ToString();
                    break;

                case "div":

                    if (Val2 == 0)
                    {
                        resultstr = "Division by zero attend";

                    }
                    else
                    {resultstr =Val1.ToString() + " / " + Val2.ToString();}
                    break;

            }
            return resultstr;


        }
    }
}
