using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmCardreader : Form
    {
        public frmCardreader()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(-1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int CountWordOccurrences(string text, string word)
        {
            int count = 0;
            int index = 0;
            while ((index = text.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += word.Length;
            }
            return count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string folderPath = @"D:\Reserarch\Logs\AECTS1torintoncardcapture high\AECTS1"; 
                string folderPath = @"C:\FTPHOME\FTPOUT";
            int cr01Count = 0;
            int cr02Count = 0;
            int cr04Count = 0;
            int cr05Count = 0;
            int cr06Count = 0;
            int cr07Count = 0;
            int cr08Count = 0;
            int cr09Count = 0;
            int cr10Count = 0;
            int cr11Count = 0;
            int cr12Count = 0;
            int cr13Count = 0;
            int cr14Count = 0;
            int cr15Count = 0;
            int cr16Count = 0;

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value.Date.AddDays(1); // End date should include the entire day.

            try
            {
                // Get all .jrn files in the folder
                string[] jrnFiles = Directory.GetFiles(folderPath, "*.jrn");

                // Read and count the occurrences of "CR01" in each .jrn file within the date range
                foreach (string filePath in jrnFiles)
                {
                    DateTime fileModifiedDate = File.GetLastWriteTime(filePath);

                    if (fileModifiedDate >= startDate && fileModifiedDate < endDate)
                    {
                        string fileContent = File.ReadAllText(filePath);

                        // Device Front Failures 
                        cr01Count += CountWordOccurrences(fileContent, "CR01:3F:48:60");
                        cr02Count += CountWordOccurrences(fileContent, "CR01:3E:60:48");
                        cr16Count += CountWordOccurrences(fileContent, "CR01:3F:60:48");
                    

                        // Card Jams
                        cr04Count += CountWordOccurrences(fileContent, "CR01:3F:40:60");
                        cr05Count += CountWordOccurrences(fileContent, "CR01:3E:48:40");
                        cr06Count += CountWordOccurrences(fileContent, "CR01:3D:48:40");
                        cr07Count += CountWordOccurrences(fileContent, "CR01:3D:58:60");
                        cr08Count += CountWordOccurrences(fileContent, "CR01:3E:58:60");
                        cr09Count += CountWordOccurrences(fileContent, "CR01:3F:62:40");

                        // Communication Failures
                        cr10Count += CountWordOccurrences(fileContent, "CR01:38:00:00");

                        //customer card forgeten
                        cr11Count += CountWordOccurrences(fileContent, "CR01:23:00:00");
                        cr15Count += CountWordOccurrences(fileContent, "CR01:3F:40:41");

                        //self test failures
                        cr12Count += CountWordOccurrences(fileContent, "CR01:3F:00");

                        //Other device errors
                        cr13Count += CountWordOccurrences(fileContent, "CR01:");

                        cr14Count += CountWordOccurrences(fileContent, "CR01: 00:00:00"); 


                    }
                }

                // Set the count value to label2
                int teasescal = cr01Count + cr02Count + cr16Count;
                teases.Text = (cr01Count+ cr02Count + cr16Count).ToString();

                communication.Text = cr10Count.ToString();

                int jamcal = cr04Count + cr05Count + cr06Count + cr07Count + cr08Count + cr09Count;
                jam.Text= (cr04Count + cr05Count + cr06Count + cr07Count + cr08Count + cr09Count).ToString();

                lblfail.Text=cr12Count.ToString();

                int forgetcal = cr11Count + cr15Count;
                lblforgrt.Text= (cr11Count + cr15Count).ToString();

                int cal = cr01Count + cr02Count + cr04Count + cr05Count + cr06Count + cr07Count + cr08Count + cr09Count + cr10Count + cr11Count + cr12Count + cr14Count + cr15Count + cr16Count;
                lblother.Text = (cr13Count - cal - cr14Count).ToString();
                int othercal = cr13Count - cal - cr14Count;

                lbltotalfail.Text= (cr13Count - cr14Count).ToString();

                /// Error Condition Checking
                /// 
                if ((teasescal > 15 & jamcal > 4 & cr10Count > 4 & cr12Count > 4 & othercal > 20) || (teasescal > 15 & jamcal > 4 & cr10Count > 4 & cr12Count > 4) || (teasescal > 15 & jamcal > 4 & cr10Count > 4 & othercal > 20) || cr10Count > 4 & cr12Count > 4 & othercal > 20 || 
                    (teasescal > 15 & jamcal > 4 & othercal > 20) || teasescal > 15 & jamcal > 4 & cr12Count > 4)
                {
                    lblstatus.Text = "High Number Of Errors Service Required";
                    lblstatus.ForeColor = Color.Red;
                }
                else if (teasescal > 15 & jamcal > 4)
                {
                    lblstatus.Text = "High Number Of Shutter Errors & Card Jams Service Require";
                    lblstatus.ForeColor = Color.Red;
                }

               /* else if (teasescal > 15)
                {
                    lblstatus.Text = "High Number Of Shutter / Rollers" + Environment.NewLine + "Service Require";
                    lblstatus.ForeColor = Color.Red;
                }
                else if (jamcal > 4)
                {
                    lblstatus.Text = "High Number Of Card Jams" + Environment.NewLine + "Service Require";
                    lblstatus.ForeColor = Color.Red;
                }*/
                else if (teasescal <= 15 & jamcal <= 4 & cr10Count <= 4 & cr12Count <= 4 & othercal <= 20)
                {
                    lblstatus.Text = "Devie Normal Operation";
                    lblstatus.ForeColor = Color.Green;
                }
                else
                {
                    lblstatus.Text = "High Number Of Errors Service Required";
                    lblstatus.ForeColor = Color.Red;
                }





                /*if ((cr13Count - cr14Count) > 15)
                {
                    label2.ForeColor = Color.Red;
                    lbltotalfail.ForeColor = Color.Red;
                }*/
                if ((cr01Count + cr02Count) > 15 || (cr04Count + cr05Count + cr06Count + cr07Count + cr08Count + cr09Count) > 4 || cr12Count > 4 || cr10Count > 4 || (cr13Count - cal) > 20)
                {
                    label2.ForeColor = Color.Red;
                    lbltotalfail.ForeColor = Color.Red;
                }
                else
                {
                    label2.ForeColor = SystemColors.ControlText;
                    lbltotalfail.ForeColor = SystemColors.ControlText;
                }
                if ((cr01Count + cr02Count) > 15)
                {

                    teases.ForeColor = Color.Red;

                }
                else
                {
                    teases.ForeColor = SystemColors.ControlText;
                }

                if ((cr04Count + cr05Count + cr06Count + cr07Count + cr08Count + cr09Count) > 4)
                {
                    jam.ForeColor = Color.Red;

                }
                else
                {
                    jam.ForeColor = SystemColors.ControlText;
                }

                if (cr12Count > 4)
                {
                    lblfail.ForeColor = Color.Red;
                }
                else {

                    lblfail.ForeColor = SystemColors.ControlText;
                }
                if (cr10Count > 4)
                {
                    communication.ForeColor = Color.Red;
                }
                else
                {
                    communication.ForeColor = SystemColors.ControlText;
                }
                if ((cr13Count - cal) > 20)
                {
                    lblother.ForeColor = Color.Red;
                }
                else {
                    lblother.ForeColor = SystemColors.ControlText;
                }


                chart1.Series["ShutterFail"].Points.AddXY("", teasescal);
                chart1.Series["CardJam"].Points.AddXY("", jamcal);
                chart1.Series["ComFail"].Points.AddXY("", cr10Count);
                chart1.Series["CusForget"].Points.AddXY("", forgetcal);
                chart1.Series["STFail"].Points.AddXY("", cr12Count);
                chart1.Series["Other"].Points.AddXY("", othercal);
                

            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the process
                MessageBox.Show("Error reading files: " + ex.Message);
            }
        }


        /*private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = @"D:\Reserarch\Logs\AECTS1torintoncardcapture high\AECTS1";
            int cr01Count = 0;
            int otherCr01Count = 0; // Count of other words starting with "CR01:"
            string excludedWord = "CR01:3F:48:60";

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value.Date.AddDays(1); // End date should include the entire day.

            try
            {
                // Get all .jrn files in the folder
                string[] jrnFiles = Directory.GetFiles(folderPath, "*.jrn");

                // Read and count the occurrences of "CR01:3F:48:60" and other words starting with "CR01:" in each .jrn file within the date range
                foreach (string filePath in jrnFiles)
                {
                    DateTime fileModifiedDate = File.GetLastWriteTime(filePath);

                    if (fileModifiedDate >= startDate && fileModifiedDate < endDate)
                    {
                        string fileContent = File.ReadAllText(filePath);

                        // Count occurrences of "CR01:3F:48:60"
                        cr01Count += CountWordOccurrences(fileContent, excludedWord);

                        // Count occurrences of other words starting with "CR01:"
                        string cr01Prefix = "CR01:";
                        int index = 0;
                        while ((index = fileContent.IndexOf(cr01Prefix, index, StringComparison.OrdinalIgnoreCase)) != -1)
                        {
                            // Check if the word is not the excluded word
                            string word = fileContent.Substring(index, excludedWord.Length);
                            if (!string.Equals(word, excludedWord, StringComparison.OrdinalIgnoreCase))
                            {
                                otherCr01Count++;
                            }
                            index += cr01Prefix.Length;
                        }
                    }
                }

                // Set the count values to labels
                label2.Text = cr01Count.ToString();
                label5.Text = otherCr01Count.ToString();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the process
                MessageBox.Show("Error reading files: " + ex.Message);
            }
        }*/


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker2.MaxDate = DateTime.Now;

                dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Handle the exception here
                // You can display an error message, log the error, or perform any other necessary actions
                MessageBox.Show("Please Select The Correct Dates");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the process
                MessageBox.Show("Error Please Select Correct Dates " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }



        /*private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Reserarch\Logs\AECTS1torintoncardcapture high1\AECTS1\current.jrn";

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Get the file creation date
                    DateTime creationDate = File.GetLastWriteTime(filePath);

                    // Set the creation date value to label2
                    teases.Text = "File Modified Date: " + creationDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    MessageBox.Show("The file does not exist.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the process
                MessageBox.Show("Error: " + ex.Message);
            }

            lblother.Text = "Date picker time" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be greater than end date.");
                return;
            }

            // Clear the previous text in label5
            lblother.Text = "";

            // Loop through the dates and construct the result string
            DateTime currentDate = startDate;
            while (currentDate <= endDate)
            {
                lblother.Text += currentDate.ToString("yyyy-MM-dd") + Environment.NewLine;
                currentDate = currentDate.AddDays(1); // Increment to the next date
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
