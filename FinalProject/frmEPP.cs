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
    public partial class frmEPP : Form
    {
        public frmEPP()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(-1);
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
           // string folderPath = @"D:\Reserarch\Logs\AECTS1torintoncardcapture high\AECTS1";
            string folderPath = @"C:\FTPHOME\FTPOUT";
            int cr01Count = 0;
            int cr02Count = 0;
            int cr04Count = 0;
            int cr07Count = 0;
            int cr09Count = 0;
            int cr10Count = 0;
            int cr11Count = 0;
            int cr12Count = 0;
            int cr13Count = 0;


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

                        // Temperature out of limit
                        cr01Count += CountWordOccurrences(fileContent, "EP01:3C:00:03");
                        cr02Count += CountWordOccurrences(fileContent, "EP01:3C:00:02");

                        //Grid Errors
                        cr07Count += CountWordOccurrences(fileContent, "EP01:3C:00:04");
                        cr09Count += CountWordOccurrences(fileContent, "EP01:3C:00:05");


                        // Battery Low
                        cr04Count += CountWordOccurrences(fileContent, "EP01:3C:00:01");


                        // Communication Failures
                        cr10Count += CountWordOccurrences(fileContent, "EP01:38:00:0F");


                        //NVRAM loss of integrity
                        cr11Count += CountWordOccurrences(fileContent, "EP01:3C:00:06");


                        //Other device errors
                        cr13Count += CountWordOccurrences(fileContent, "EP01:");


                    }
                }

                int temp = cr01Count + cr02Count;
                lblheadder.Text = temp.ToString();

                int com = cr10Count;
                communication.Text = com.ToString();

                int grider = cr07Count + cr09Count;
                jam.Text = grider.ToString();

                int batterylow = cr04Count;
                lblbattery.Text = batterylow.ToString();

                int nvrm = cr11Count;
                lblcutter.Text = nvrm.ToString();

                int cal = temp + com + grider + batterylow + nvrm;

                int othercal = cr13Count - cal;
                lblother.Text = othercal.ToString();


                lbltotalfail.Text = cr13Count.ToString();

                // Error Condition Checking
                if ((temp > 15 & grider > 15 & com > 4 & nvrm > 15 & othercal > 20 & batterylow >= 1) ||
                    (temp > 15 & grider > 15 & com > 4 & nvrm > 15 & batterylow >= 1) ||
                    (temp > 15 & grider > 15 & com > 4 & othercal > 20) || com > 4 & nvrm > 15 & othercal > 20 ||
                    (temp > 15 & grider > 15 & othercal > 20) || (temp > 15 & grider > 4 & nvrm > 15) )
                {
                    lblstatus.Text = "High Number Of Errors Service Required";
                    lblstatus.ForeColor = Color.Red;
                }
                else if (batterylow >= 1)
                {
                    lblstatus.Text = "Battery Low In Pin Pad Service Required"+Environment.NewLine+"Please Don't Turn Off The Machine";
                    lblstatus.ForeColor = Color.Red;

                    label2.ForeColor = Color.Red;
                    lbltotalfail.ForeColor = Color.Red;
                }
                else if (temp <= 15 & grider <= 15 & com <= 4 & nvrm <= 15 & othercal <= 20 & batterylow < 1)
                {
                    lblstatus.Text = "Devie Normal Operation";
                    lblstatus.ForeColor = Color.Green;
                }
                else
                {
                    lblstatus.Text = "High Number Of Errors Service Required";
                    lblstatus.ForeColor = Color.Red;
                }





                if (temp > 15 || grider > 15 || nvrm > 15 || batterylow >= 1 || com > 4 || othercal > 20)
                {
                    label2.ForeColor = Color.Red;
                    lbltotalfail.ForeColor = Color.Red;
                }
                else
                {
                    label2.ForeColor = SystemColors.ControlText;
                    lbltotalfail.ForeColor = SystemColors.ControlText;
                }

                if (temp > 15)
                {

                    lblheadder.ForeColor = Color.Red;

                }
                else
                {
                    lblheadder.ForeColor = SystemColors.ControlText;
                }

                if (grider > 15)
                {
                    jam.ForeColor = Color.Red;

                }
                else
                {
                    jam.ForeColor = SystemColors.ControlText;
                }

                if (nvrm > 15)
                {
                    lblcutter.ForeColor = Color.Red;
                }
                else
                {
                    lblcutter.ForeColor = SystemColors.ControlText;
                }

                if (batterylow >= 1)
                {
                    lblbattery.ForeColor = Color.Red;

                }
                else
                {
                    lblbattery.ForeColor = SystemColors.ControlText;
                }

                if (com > 4)
                {
                    communication.ForeColor = Color.Red;
                }
                else
                {
                    communication.ForeColor = SystemColors.ControlText;
                }
                if (othercal > 20)
                {
                    lblother.ForeColor = Color.Red;
                }
                else
                {
                    lblother.ForeColor = SystemColors.ControlText;
                }


                chart1.Series["Temp"].Points.AddXY("", temp);
                chart1.Series["Battery Low"].Points.AddXY("", batterylow);
                chart1.Series["ComFail"].Points.AddXY("", com);
                chart1.Series["NVRM"].Points.AddXY("", nvrm);
                chart1.Series["Grider"].Points.AddXY("", grider);
                chart1.Series["Other"].Points.AddXY("", othercal);


            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the process
                MessageBox.Show("Error reading files: " + ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

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
    }
}
