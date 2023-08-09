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
    public partial class frmReceipt : Form
    {
        public frmReceipt()
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
            string folderPath = @"D:\Reserarch\Logs\AECTS1torintoncardcapture high\AECTS1";
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
            int cr17Count = 0;
            int cr18Count = 0;
            int cr19Count = 0; int cr20Count = 0;
            int cr21Count = 0;
            int cr22Count = 0;
            int cr23Count = 0;
            int cr24Count = 0;
            int cr25Count = 0;



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

                        // Head Home possition errors
                        cr01Count += CountWordOccurrences(fileContent, "PR01:39:44:");
                        cr02Count += CountWordOccurrences(fileContent, "PR01:39:45:");
                        cr16Count += CountWordOccurrences(fileContent, "PR01:39:46:");
                        cr06Count += CountWordOccurrences(fileContent, "PR01:39:54:");
                        cr07Count += CountWordOccurrences(fileContent, "PR01:39:55:");
                        cr09Count += CountWordOccurrences(fileContent, "PR01:39:64:");
                        cr08Count += CountWordOccurrences(fileContent, "PR01:39:56:");
                        cr17Count += CountWordOccurrences(fileContent, "PR01:39:65:");
                        cr18Count += CountWordOccurrences(fileContent, "PR01:39:66:");

                        // Receipt Jams Jams
                        cr04Count += CountWordOccurrences(fileContent, "PR01:3E:02:07");
                        cr05Count += CountWordOccurrences(fileContent, "PR01:3E:02:0A");
                        
                        
                        // Communication Failures
                        cr10Count += CountWordOccurrences(fileContent, "PR01:38:60:00");
                        cr19Count += CountWordOccurrences(fileContent, "PR01: 38:62:");
                    

                        //Cutter errors / tof
                        cr11Count += CountWordOccurrences(fileContent, "PR01:3E:02:0E");
                        cr20Count += CountWordOccurrences(fileContent, "PR01:3F:00:0B");
                        cr21Count += CountWordOccurrences(fileContent, "PR01:3E:41:");
                        cr22Count += CountWordOccurrences(fileContent, "PR01:3E:42:");
                        cr23Count += CountWordOccurrences(fileContent, "PR01:3E:51");
                        cr24Count += CountWordOccurrences(fileContent, "PR01:3E:52");
                        cr25Count += CountWordOccurrences(fileContent, "PR01:3E:61");
                        cr20Count += CountWordOccurrences(fileContent, "PR01: 3E:62:");



                        //Supply Low
                        cr12Count += CountWordOccurrences(fileContent, "PR01:2D:50:00"); 
                        cr15Count += CountWordOccurrences(fileContent, "PR01:3D:60:00");

                        

                        //Other device errors
                        cr13Count += CountWordOccurrences(fileContent, "PR01:");


                        // No errors
                        cr14Count += CountWordOccurrences(fileContent, "PR01:00:00:00");


                    }
                }

                int headder = cr01Count + cr02Count + cr16Count + cr06Count + cr07Count + cr09Count + cr08Count + cr17Count + cr18Count;
                lblheadder.Text = headder.ToString();

                int com = cr10Count + cr19Count;
                communication.Text = com.ToString();

                int jamcal = cr04Count + cr05Count;
                jam.Text =jamcal.ToString();

                int supplycal = cr12Count + cr15Count;
                lblsupply.Text = supplycal.ToString();

                int cuttercal = cr11Count + cr20Count+ cr21Count+ cr22Count+ cr23Count+ cr24Count+ cr25Count;
                lblcutter.Text = cuttercal.ToString();

                int cal = headder + com + jamcal + supplycal + cuttercal;

                int othercal = cr13Count - cal - cr14Count;
                lblother.Text = othercal.ToString();
                

                lbltotalfail.Text = (cr13Count - cr14Count).ToString();

                // Error Condition Checking
               /* /// 
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

                *//* else if (teasescal > 15)
                 {
                     lblstatus.Text = "High Number Of Shutter / Rollers" + Environment.NewLine + "Service Require";
                     lblstatus.ForeColor = Color.Red;
                 }
                 else if (jamcal > 4)
                 {
                     lblstatus.Text = "High Number Of Card Jams" + Environment.NewLine + "Service Require";
                     lblstatus.ForeColor = Color.Red;
                 }*//*
                else if (teasescal <= 15 & jamcal <= 4 & cr10Count <= 4 & cr12Count <= 4 & othercal <= 20)
                {
                    lblstatus.Text = "Devie Normal Operation";
                    lblstatus.ForeColor = Color.Green;
                }
                else
                {
                    lblstatus.Text = "High Number Of Errors Service Required";
                    lblstatus.ForeColor = Color.Red;
                }*/





                if ((cr13Count - cr14Count) > 15)
                {
                    label2.ForeColor = Color.Red;
                    lbltotalfail.ForeColor = Color.Red;
                }
                else
                {
                    label2.ForeColor = SystemColors.ControlText;
                    lbltotalfail.ForeColor = SystemColors.ControlText;
                }
                
                if (headder > 15)
                {

                    lblheadder.ForeColor = Color.Red;

                }
                else
                {
                    lblheadder.ForeColor = SystemColors.ControlText;
                }

                if (jamcal > 4)
                {
                    jam.ForeColor = Color.Red;

                }
                else
                {
                    jam.ForeColor = SystemColors.ControlText;
                }

                if (cuttercal > 4)
                {
                    lblcutter.ForeColor = Color.Red;
                }
                else
                {

                    lblcutter.ForeColor = SystemColors.ControlText;
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


              /*  chart1.Series["ShutterFail"].Points.AddXY("", teasescal);
                chart1.Series["CardJam"].Points.AddXY("", jamcal);
                chart1.Series["ComFail"].Points.AddXY("", cr10Count);
                chart1.Series["CusForget"].Points.AddXY("", forgetcal);
                chart1.Series["STFail"].Points.AddXY("", cr12Count);
                chart1.Series["Other"].Points.AddXY("", othercal);*/


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
            dateTimePicker2.MaxDate = DateTime.Now;

            dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
