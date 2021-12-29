/*
 Name: Albelis Becea
   ID: 2110083
 Description: Project 30%
Temperature Convertor Application
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
using System.IO;

namespace Project_2110083
{
    public partial class TempApp : Form
    {
        string dir = @"..\PrjTxtFiles\";
        string path = @"..\PrjTxtFiles\TempConversions.txt";
        FileStream fs = null;

        TempConvertor temperature;
        public TempApp()
        {
            InitializeComponent();
        }
        private void TempApp_Load(object sender, EventArgs e)
        {
            temperature = new TempConvertor();
           
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

        private void btnConvert_Click(object sender, EventArgs e)
        {
                   

            try
            {
                temperature.Temp = Convert.ToDouble(textBoxTemp1.Text);
                if (radioButtontmp.Checked == true)
                {

                    textBoxTemp1.Focus();
                    textBoxTemp2.Text = temperature.CelsiustoFahrenheit().ToString();
                   
                    celsiuslb1.Visible = true;
                    celsiuslb2.Visible = false;
                    fahrenheitlb1.Visible = false;
                    fahrenheitlb2.Visible = true;
                    if (temperature.Temp == 100) { txtboxMessage.Text = "Water boils"; }
                    else if (temperature.Temp == 40) { txtboxMessage.Text = "Hot Bath"; }
                    else if (temperature.Temp == 37) { txtboxMessage.Text = "Body Temperature"; }
                    else if (temperature.Temp == 30) { txtboxMessage.Text = "Beach Weather"; }
                    else if (temperature.Temp >= 20 && temperature.Temp <= 25) { txtboxMessage.Text = "Room temperature"; }
                    else if (temperature.Temp == 10) { txtboxMessage.Text = "Cool Day"; }
                    else if (temperature.Temp == 0) { txtboxMessage.Text = "Freezing point of water"; }
                    else if (temperature.Temp >= -18 && temperature.Temp <= 0) { txtboxMessage.Text = "Very Cool Day"; }
                    else if (temperature.Temp == -40) { txtboxMessage.Text = "Extremely Cold Day\r\n(and the same number!)"; } //Not sure what (and the same number!) means
                    else { txtboxMessage.Text = "\t"; }
                }
                else if (radioButtontemp2.Checked == true)
                {

                    radioButtontmp.Checked = false;
                    textBoxTemp1.Focus();
                    textBoxTemp2.Text = temperature.FahrenheittoCelsius().ToString("###,###.00");
                    celsiuslb1.Visible = false;
                    celsiuslb2.Visible = true;
                    fahrenheitlb1.Visible = true;
                    fahrenheitlb2.Visible = false;

                    if (temperature.Temp == 212) { txtboxMessage.Text = "Water boils"; }
                    else if (temperature.Temp == 104) { txtboxMessage.Text = "Hot Bath"; }
                    else if (temperature.Temp == 98.6) { txtboxMessage.Text = "Body Temperature"; }
                    else if (temperature.Temp == 86) { txtboxMessage.Text = "Beach Weather"; }
                    else if (temperature.Temp > 70 && temperature.Temp < 82) { txtboxMessage.Text = "Room temperature"; }
                    else if (temperature.Temp == 50) { txtboxMessage.Text = "Cool Day"; }
                    else if (temperature.Temp == 32) { txtboxMessage.Text = "Freezing point of water"; }
                    else if (temperature.Temp > 0 && temperature.Temp < 32) { txtboxMessage.Text = "Very Cool Day"; }
                    else if (temperature.Temp == -40) { txtboxMessage.Text = "Extremely Cold Day\r\n(and the same number!)"; }
                    else { txtboxMessage.Text = "\t"; }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                textBoxTemp1.Focus();
                textBoxTemp1.Text = "0";
            }

            //I was trying this approach simmilar to the money exchanger app but the conversion from C to F wasn't working so I remove the boxgroup
            /* string ConversType = this.CheckSelection(groupBox1).Text;
              try
            {
                temperature.Temp = Convert.ToDouble(textBoxTemp1.Text);
                switch (ConversType)
                { 
                    case "From C to F":

                    radioButtontemp2.Checked = false;
                    textBoxTemp1.Focus();
                    textBoxTemp2.Text = temperature.CelsiustoFahrenheit().ToString();
                    
                    celsiuslb1.Visible = true;
                    celsiuslb2.Visible = false;
                    fahrenheitlb1.Visible = false;
                    fahrenheitlb2.Visible = true;
                    if (temperature.Temp == 100) { txtboxMessage.Text = "Water boils"; }
                    else if (temperature.Temp == 40) { txtboxMessage.Text = "Hot Bath"; }
                    else if (temperature.Temp == 37) { txtboxMessage.Text = "Body Temperature"; }
                    else if (temperature.Temp == 30) { txtboxMessage.Text = "Beach Weather"; }
                    else if (temperature.Temp >= 20 && temperature.Temp <= 25) { txtboxMessage.Text = "Room temperature"; }
                    else if (temperature.Temp == 10) { txtboxMessage.Text = "Cool Day"; }
                    else if (temperature.Temp == 0) { txtboxMessage.Text = "Freezing point of water"; }
                    else if (temperature.Temp >= -18 && temperature.Temp <= 0) { txtboxMessage.Text = "Very Cool Day"; }
                    else if (temperature.Temp == -40) { txtboxMessage.Text = "Extremely Cold Day (and the same number!)"; } //Not sure what (and the same number!) means
                    else {  txtboxMessage.Text = ""; }
                        break;

                    case "From F to C":
                        radioButtontmp.Checked = false;
                        textBoxTemp2.Focus();
                        textBoxTemp2.Text = temperature.FahrenheittoCelsius().ToString();
                        celsiuslb1.Visible = false;
                        celsiuslb2.Visible = true;
                        fahrenheitlb1.Visible = true;
                        fahrenheitlb2.Visible = false;

                        if (temperature.Temp == 212) { txtboxMessage.Text = "Water boils"; }
                        else if (temperature.Temp == 104) { txtboxMessage.Text = "Hot Bath"; }
                        else if (temperature.Temp == 98.6) { txtboxMessage.Text = "Body Temperature"; }
                        else if (temperature.Temp == 86) { txtboxMessage.Text = "Beach Weather"; }
                        else if (temperature.Temp > 70 && temperature.Temp < 82) { txtboxMessage.Text = "Room temperature"; }
                        else if (temperature.Temp == 50) { txtboxMessage.Text = "Cool Day"; }
                        else if (temperature.Temp == 32) { txtboxMessage.Text = "Freezing point of water"; }
                        else if (temperature.Temp > 0 && temperature.Temp < 32) { txtboxMessage.Text = "Very Cool Day"; }
                        else if (temperature.Temp == -40) { txtboxMessage.Text = "Extremely Cold Day (and the same number!)"; } //Not sure what (and the same number!) means
                        else { txtboxMessage.Text = ""; }
                        break;
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error");
                textBoxTemp1.Focus();
                textBoxTemp1.Text = "0";
            }*/

            DateTime currDaTim = DateTime.Now;
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
               StreamWriter textOut = new StreamWriter(fs);
                
                if (radioButtontmp.Checked == true)
                {
                    textOut.WriteLine(textBoxTemp1.Text + " C  " +" = "+ textBoxTemp2.Text + " F \t" + txtboxMessage.Text + "\t\t" + currDaTim.ToString("MM/dd/yyyy  HH:mm:ss"));
                }
                else {
                    textOut.WriteLine(textBoxTemp1.Text + " F  " + " = " + textBoxTemp2.Text + " C \t" + txtboxMessage.Text + "\t\t" + currDaTim.ToString("MM/dd/yyyy  HH:mm:ss"));
                }

                // close the output stream for the text file
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

        private void btnExittemp_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to go back to the main window",
               "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)).ToString() == "Yes")
            {
                this.Close();
            }
            

        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            { //Read the text file
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "Temp 1\tTemp 2\t\tMessage\t\t\tDate & Time\t\t\n";
                textToPrint += textIn.ReadToEnd();

                MessageBox.Show(textToPrint, "Temperature Conversions  - Albelis");
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

    class TempConvertor
    {
        double temp;

        public TempConvertor(){}

        public double Temp
        {
            get { return temp; }
            set { temp = value; }
        }

        public TempConvertor(double temp)
        {
            this.temp = temp;
        }

        public double CelsiustoFahrenheit()
        {
          return temp*9/5+32;
        }

        public double FahrenheittoCelsius()
        {
          
            return (temp-32)*5/9;
        }

    }
}
