/*
 Name: Albelis Becea
   ID: 2110083
 Description: Project 30%
Lotto 649 Application
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
    
    public partial class Lotto649 : Form
    {
        string dir = @"..\PrjTxtFiles\";
        string path = @"..\PrjTxtFiles\LottoNbrs.txt";
        FileStream fs = null;
        LottoNumebers newnumbers;

        public Lotto649()
        {
            InitializeComponent();
        }

        private void Lotto649_Load(object sender, EventArgs e)
        {
            newnumbers = new LottoNumebers();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to quit this application?",
             "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)).ToString() == "Yes")
            {
                this.Close();
            }
        }
        

        private void btngenerate_Click(object sender, EventArgs e)
        {
            DateTime currDaTim = DateTime.Now;
            int index;
            int[] NbsArray = newnumbers.GenerateNbds649();
            String winnNB, winnNBtotex;
            winnNB = string.Join("\r\n", NbsArray);
            index = winnNB.LastIndexOf("\r\n");
            winnNB = winnNB.Insert(index, "\r\nBonus");
            textBox1.Text = winnNB;



            winnNBtotex = textBox1.Text.Trim().Replace("\r\n", ", ");
            index = winnNBtotex.LastIndexOf(",");
            //MessageBox.Show(index.ToString());
            winnNBtotex = winnNBtotex.Remove(index, 1);
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                // create the output stream for a text file that exists
                StreamWriter textOut = new StreamWriter(fs);
                // write the fields into text file

                textOut.WriteLine("649,\t" + currDaTim.ToString("MM/dd/yyyy  HH:mm:ss") + ",\t" + winnNBtotex);

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

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                // create the output stream for a text file that exists
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "\t\tTime\t\tWinning Numbers\n";
                // read the data from the file and store it in the list
                textToPrint += textIn.ReadToEnd();
                
                MessageBox.Show(textToPrint, "Winning Numbers  -  Lotto649 - Albelis");
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
    
}
