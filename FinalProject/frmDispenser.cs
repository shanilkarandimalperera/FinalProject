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
    public partial class frmDispenser : Form
    {
        public frmDispenser()
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
            int cr10Count = 0; int cr10ACount = 0;
            int cr11Count = 0;
            int cr12Count = 0;
            int cr13Count = 0;
            int cr14Count = 0;
            int cr15Count = 0;
            int cr16Count = 0;
            int cr17Count = 0;
            int cr18Count = 0;
            int cr19Count = 0; int cr20Count = 0; int cr19ACount = 0;
            int cr21Count = 0;
            int cr22Count = 0;
            int cr23Count = 0;
            int cr24Count = 0;
            int cr25Count = 0;
            int cr26Count = 0;
            int cr13ACount = 0;





            // Feed failures variables
            int feed1 = 0; int feed2 = 0; int feed3 = 0; int feed4 = 0; int feed5 = 0; int feed6 = 0; int feed7 = 0;
            int feed8 = 0; int feed9 = 0; int feed10 = 0; int feed11 = 0; int feed12 = 0; int feed13 = 0; int feed14 = 0; int feed15 = 0;
            int feed16 = 0; int feed17 = 0; int feed18 = 0; int feed19 = 0; int feed20 = 0; int feed21 = 0;

            int feedA1 = 0; int feedA2 = 0; int feedA3 = 0; int feedA4 = 0; int feedA5 = 0; int feedA6 = 0; int feedA7 = 0;
            int feedA8 = 0; int feedA9 = 0; int feedA10 = 0; int feedA11 = 0; int feedA12 = 0; int feedA13 = 0; int feedA14 = 0; int feedA15 = 0;
            int feedA16 = 0; int feedA17 = 0; int feedA18 = 0; int feedA19 = 0; int feedA20 = 0; int feedA21 = 0;

            //dispenser timeout

            int tmout = 0;
            int tmout1 = 0;
            int tmout2 = 0;
            int tmout3 = 0;
            int tmout4 = 0;
            int tmout5 = 0;
            
            //divert
            int dt = 0;
            int dt1 = 0;
            int dt2 = 0;
                int dt3 = 0;
            int dt4 = 0;
            int dt5 = 0;
            int dt6 = 0;
            int dt7 = 0;
            int dt8 = 0;
            int dt9 = 0;

            // Cash jam
            int cjam = 0;
            int cjam2 = 0;
            int cjam3 = 0;
            int cjam4 = 0;
            int cjam5 = 0;
            int cjam6 = 0;
            int cjam7 = 0;
            int cjam8 = 0;
            int cjam9 = 0;
            int cjam10 = 0;
            int cjam11 = 0;
            int cjam12 = 0;
            int cjam13 = 0;
            int cjam14 = 0;
            int cjam15 = 0;
            int cjam16 = 0;
            int cjam17 = 0;
            int cjam18 = 0;
            int cjam19 = 0;
            int cjam20 = 0;
            int cjam21 = 0;
            int cjam22 = 0;
            int cjam23 = 0;
            int cjam24 = 0;
            int cjam25 = 0;
            int cjam26 = 0;




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

                        // Network Errors
                        cr01Count += CountWordOccurrences(fileContent, "DI01:22:00:00"); 
                        cr02Count += CountWordOccurrences(fileContent, "DI01:3E:00:00");
                        cr16Count += CountWordOccurrences(fileContent, "D901:22:00:00");
                        cr06Count += CountWordOccurrences(fileContent, "D901:3E:00:00");
                        
                        

                        // Cash Jams Jams
                        cr04Count += CountWordOccurrences(fileContent, "DI01:39:00:00");
                        cr05Count += CountWordOccurrences(fileContent, "D901:39:00:00");
                        cjam += CountWordOccurrences(fileContent, "DI01:3A:38:34");
                        cjam2 += CountWordOccurrences(fileContent, "D901:3A:38:34");
                        cjam3 += CountWordOccurrences(fileContent, "DI01:3B:33:33");
                        cjam4 += CountWordOccurrences(fileContent, "D901:3B:33:33");
                        cjam5 += CountWordOccurrences(fileContent, "DI01:3B:32:35");
                        cjam6 += CountWordOccurrences(fileContent, "D901:3B:32:35");
                        cjam7 += CountWordOccurrences(fileContent, "DI01:3B:32:36");
                        cjam8 += CountWordOccurrences(fileContent, "D901:3B:32:36");
                        cjam9 += CountWordOccurrences(fileContent, "DI01:3B:32:37");
                        cjam9 += CountWordOccurrences(fileContent, "D901:3B:32:37");
                        cjam10 += CountWordOccurrences(fileContent, "DI01:3B:32:38");
                        cjam11 += CountWordOccurrences(fileContent, "D901:3B:32:38");
                        cjam12 += CountWordOccurrences(fileContent, "DI01:3B:37:32");
                        cjam12 += CountWordOccurrences(fileContent, "D901:3B:37:32");
                        cjam13 += CountWordOccurrences(fileContent, "DI01:3E:32:35");
                        cjam14 += CountWordOccurrences(fileContent, "D901:3E:32:35");
                        cjam15 += CountWordOccurrences(fileContent, "DI01:3E:32:36");
                        cjam16 += CountWordOccurrences(fileContent, "D901:3E:32:36");
                        cjam17 += CountWordOccurrences(fileContent, "DI01:3E:32:37");
                        cjam18 += CountWordOccurrences(fileContent, "D901:3E:32:37");
                        cjam19 += CountWordOccurrences(fileContent, "DI01:3E:32:38");
                        cjam20 += CountWordOccurrences(fileContent, "D901:3E:32:38");
                        cjam21 += CountWordOccurrences(fileContent, "DI01:3E:33:33");
                        cjam22 += CountWordOccurrences(fileContent, "D901:3E:33:33");
                        cjam23 += CountWordOccurrences(fileContent, "DI01:3E:33:34");
                        cjam24 += CountWordOccurrences(fileContent, "D901:3E:33:34");
                        cjam25 += CountWordOccurrences(fileContent, "DI01:3F:33:34");
                        cjam26 += CountWordOccurrences(fileContent, "D901:3F:33:34");

                        


                        // Communication Failures
                        cr10Count += CountWordOccurrences(fileContent, "DI01:38:00:00");
                        cr19Count += CountWordOccurrences(fileContent, "D901:38:00:00"); 
                        cr10ACount += CountWordOccurrences(fileContent, "DI01:38:39:31");
                        cr19ACount += CountWordOccurrences(fileContent, "D901:38:39:31");

                        


                        //Sensor Blocks
                        cr11Count += CountWordOccurrences(fileContent, "DI01:39:00:01");
                        cr20Count += CountWordOccurrences(fileContent, "DI01:39:00:03");
                        cr21Count += CountWordOccurrences(fileContent, "DI01:39:00:05");
                        cr22Count += CountWordOccurrences(fileContent, "DI01:39:00:07"); 
                        cr23Count += CountWordOccurrences(fileContent, "DI01:3A:36:30");
                        cr24Count += CountWordOccurrences(fileContent, "DI01:3E:36:30");

                        



                        //Dispense Command reject
                        cr12Count += CountWordOccurrences(fileContent, "DI01:30:");
                        cr15Count += CountWordOccurrences(fileContent, "D901:30:");
                        cr18Count += CountWordOccurrences(fileContent, "DI01:3D:33:35");
                        cr17Count += CountWordOccurrences(fileContent, "D901:3D:33:35");

                        



                        // Divert / Retracs
                        dt += CountWordOccurrences(fileContent, "DI01:3A:36:37");
                        dt1 += CountWordOccurrences(fileContent, "DI01:3B:33:37");
                        dt2 += CountWordOccurrences(fileContent, "DI01:3B:36:37");
                        dt3 += CountWordOccurrences(fileContent, "DI01:3D:37:38");
                        dt4 += CountWordOccurrences(fileContent, "DI01:3E:03:03");

                        dt5 += CountWordOccurrences(fileContent, "D901:3A:36:37");
                        dt6 += CountWordOccurrences(fileContent, "D901:3B:33:37");
                        dt7 += CountWordOccurrences(fileContent, "D901:3B:36:37");
                        dt8 += CountWordOccurrences(fileContent, "D901:3D:37:38");
                        dt9 += CountWordOccurrences(fileContent, "D901:3E:03:03");

                        



                        // Dispense timeout
                        tmout += CountWordOccurrences(fileContent, "DI01:3B:38:31");
                        tmout1 += CountWordOccurrences(fileContent, "DI01:3A:38:31");
                        tmout2 += CountWordOccurrences(fileContent, "DI01:3C:38:31");

                        tmout3 += CountWordOccurrences(fileContent, "D901:3C:38:31");
                        tmout4 += CountWordOccurrences(fileContent, "D901:3B:38:31");
                        tmout5 += CountWordOccurrences(fileContent, "D901:3A:38:31");

                        


                        // feed failures
                        feed1 += CountWordOccurrences(fileContent, "DI01:3D:31:37");
                        feed2 += CountWordOccurrences(fileContent, "DI01:3D:31:38");
                        feed3 += CountWordOccurrences(fileContent, "DI01:3D:31:39");
                        feed4 += CountWordOccurrences(fileContent, "DI01:3D:32:30");
                        feed5 += CountWordOccurrences(fileContent, "DI01:3A:30:31");
                        feed6 += CountWordOccurrences(fileContent, "DI01:3A:30:32");
                        feed7 += CountWordOccurrences(fileContent, "DI01:3A:30:33");
                        feed8 += CountWordOccurrences(fileContent, "DI01:3A:30:34");
                        feed9 += CountWordOccurrences(fileContent, "DI01:3D:33:42");
                        feed10 += CountWordOccurrences(fileContent, "DI01:3D:33:44");
                        feed11 += CountWordOccurrences(fileContent, "DI01:3D:35:41");
                        feed12 += CountWordOccurrences(fileContent, "DI01:3D:35:42");
                        feed13 += CountWordOccurrences(fileContent, "DI01:3D:35:43");
                        feed14 += CountWordOccurrences(fileContent, "DI01:3D:35:44");
                        feed15 += CountWordOccurrences(fileContent, "DI01:3F:31:37");
                        feed15 += CountWordOccurrences(fileContent, "DI01:3F:31:38");
                        feed16 += CountWordOccurrences(fileContent, "DI01:3F:31:39");
                        feed17 += CountWordOccurrences(fileContent, "DI01:3F:32:30"); 
                        feed18 += CountWordOccurrences(fileContent, "DI01:3F:39:34");
                        feed19 += CountWordOccurrences(fileContent, "DI01:3F:39:35");
                        feed20 += CountWordOccurrences(fileContent, "DI01:3F:39:36");
                        feed21 += CountWordOccurrences(fileContent, "DI01:3F:39:37");


                        feedA1 += CountWordOccurrences(fileContent, "D901:3D:31:37");
                        feedA2 += CountWordOccurrences(fileContent, "D901:3D:31:38");
                        feedA3 += CountWordOccurrences(fileContent, "D901:3D:31:39");
                        feedA4 += CountWordOccurrences(fileContent, "D901:3D:32:30");
                        feedA5 += CountWordOccurrences(fileContent, "D901:3A:30:31");
                        feedA6 += CountWordOccurrences(fileContent, "D901:3A:30:32");
                        feedA7 += CountWordOccurrences(fileContent, "D901:3A:30:33");
                        feedA8 += CountWordOccurrences(fileContent, "D901:3A:30:34");
                        feedA9 += CountWordOccurrences(fileContent, "D901:3D:33:42");
                        feedA10 += CountWordOccurrences(fileContent, "D901:3D:33:44");
                        feedA11 += CountWordOccurrences(fileContent, "D901:3D:35:41");
                        feedA12 += CountWordOccurrences(fileContent, "D901:3D:35:42");
                        feedA13 += CountWordOccurrences(fileContent, "D901:3D:35:43");
                        feedA14 += CountWordOccurrences(fileContent, "D901:3D:35:44");
                        feedA15 += CountWordOccurrences(fileContent, "D901:3F:31:37");
                        feedA15 += CountWordOccurrences(fileContent, "D901:3F:31:38");
                        feedA16 += CountWordOccurrences(fileContent, "D901:3F:31:39");
                        feedA17 += CountWordOccurrences(fileContent, "D901:3F:32:30");
                        feedA18 += CountWordOccurrences(fileContent, "D901:3F:39:34");
                        feedA19 += CountWordOccurrences(fileContent, "D901:3F:39:35");
                        feedA20 += CountWordOccurrences(fileContent, "D901:3F:39:36");
                        feedA21 += CountWordOccurrences(fileContent, "D901:3F:39:37");

                        
                        //Other device errors
                        cr13Count += CountWordOccurrences(fileContent, "DI01:");
                        cr13ACount += CountWordOccurrences(fileContent, "D901:");

                        // No errors
                        cr14Count += CountWordOccurrences(fileContent, "DI01:00:00:00");
                        cr26Count += CountWordOccurrences(fileContent, "D901:00:00:00");
                        cr08Count += CountWordOccurrences(fileContent, "DI01:3E:02:02");
                        cr09Count += CountWordOccurrences(fileContent, "D901:3E:02:02");
                        cr07Count += CountWordOccurrences(fileContent, "DI01:3E:02:03");
                        cr25Count += CountWordOccurrences(fileContent, "D901:3E:02:03");                   
                    }
                }


                int chjamcal = cr04Count + cr05Count + cjam + cjam2 + cjam3 + cjam4 + cjam5 + cjam7 + cjam8 + cjam9 + cjam10 + cjam11 + cjam12 + cjam13 + cjam14 + cjam15 + cjam16 + cjam17 + cjam18 + cjam19 + cjam20 + cjam21 + cjam22 + cjam23 + cjam24 + cjam25 + cjam26;
                lblcashjam.Text = chjamcal.ToString();

                int comcal = cr10Count + cr19Count + cr10ACount + cr19ACount;
                communication.Text = comcal.ToString();

                int networkerr = cr01Count + cr02Count + cr16Count + cr06Count;
                lblnetwork.Text = networkerr.ToString();

                int cmdreject = cr12Count + cr15Count + cr18Count + cr17Count;
                lblreject.Text = cmdreject.ToString();

                int sensorer = cr11Count + cr20Count + cr21Count + cr22Count + cr23Count + cr24Count;
                lblsensor.Text = sensorer.ToString();

                int divert = dt + dt1 + dt2 + dt3 + dt4 + dt5 + dt6 + dt7 + dt8 + dt9;
                lbldvt.Text = divert.ToString();

                int distimeout = tmout + tmout1 + tmout2 + tmout3 + tmout4 + tmout5;
                lbltimeout.Text = distimeout.ToString();

                int feedfail = feed1 + feed2 + feed3 + feed4 + feed5 + feed6 + feed7 + feed8 + feed9 + feed10 + feed11 + feed12 + feed13 + feed14 + feed15 + feed16 + feed17 + feed18 + feed19 + feed20 + feed21 + feedA1 + feedA2 + feedA3 + feedA4 + feedA5 + feedA6 + feedA7 + feedA8 + feedA9 + feedA10 + feedA11 + feedA12 + feedA13 + feedA14 + feedA15 + feedA16 + feedA17 + feedA18 + feedA19 + feedA20 + feedA21;
                lblfeed.Text = feedfail.ToString();


                int noerrors = cr14Count + cr26Count + cr08Count + cr09Count + cr07Count + cr25Count;
                int othererr = cr13Count + cr13ACount;

                int othererrcal = othererr - (noerrors + chjamcal + comcal + networkerr + cmdreject + sensorer + divert + distimeout + feedfail);

                lblother.Text = othererrcal.ToString();

                lbltotalfail.Text = (othererr - noerrors).ToString();

                // Error Condition Checking
               if (sensorer <= 4 & chjamcal <= 4 & comcal <= 4 & cmdreject <= 15 & distimeout <= 5 & othererrcal <= 20 & feedfail <= 5 & divert <= 20)
                {
                    lblstatus.Text = "Devie Normal Operation";
                    lblstatus.ForeColor = Color.Green;
                }
                else
                {
                    lblstatus.Text = "High Number Of Dispenser Errors Service Required";
                    lblstatus.ForeColor = Color.Red;
                }





                /*if ((cr13Count - cr14Count) > 15)
                {
                    label2.ForeColor = Color.Red;
                    lbltotalfail.ForeColor = Color.Red;
                }*/
                if (sensorer > 4 || chjamcal > 4 || comcal > 4 || cmdreject > 15 || distimeout > 5 || othererrcal > 20 || feedfail > 5 || divert > 20)
                {
                    label2.ForeColor = Color.Red;
                    lbltotalfail.ForeColor = Color.Red;
                }
                else
                {
                    label2.ForeColor = SystemColors.ControlText;
                    lbltotalfail.ForeColor = SystemColors.ControlText;
                }

                if (chjamcal > 4)
                {

                    lblcashjam.ForeColor = Color.Red;

                }
                else
                {
                    lblcashjam.ForeColor = SystemColors.ControlText;
                }

                if (cmdreject > 15)
                {
                    lblreject.ForeColor = Color.Red;

                }
                else
                {
                    lblreject.ForeColor = SystemColors.ControlText;
                }

                if (sensorer > 4)
                {
                    lblsensor.ForeColor = Color.Red;
                }
                else
                {

                    lblsensor.ForeColor = SystemColors.ControlText;
                }
                if (comcal > 4)
                {
                    communication.ForeColor = Color.Red;
                }
                else
                {
                    communication.ForeColor = SystemColors.ControlText;
                }
                if (divert > 20)
                {
                    lbldvt.ForeColor = Color.Red;
                }
                else
                {
                    lbldvt.ForeColor = SystemColors.ControlText;
                }

                if (distimeout > 5)
                {
                    lbltimeout.ForeColor = Color.Red;
                }
                else
                {
                    lbltimeout.ForeColor = SystemColors.ControlText;
                }
                if (feedfail > 5)
                {
                    lblfeed.ForeColor = Color.Red;
                }
                else
                {
                    lblfeed.ForeColor = SystemColors.ControlText;
                }
                if (othererrcal > 20)
                {
                    lblother.ForeColor = Color.Red;
                }
                else
                {
                    lblother.ForeColor = SystemColors.ControlText;
                }


                chart1.Series["CashJam"].Points.AddXY("", chjamcal);
                chart1.Series["Network Failures"].Points.AddXY("", networkerr);
                chart1.Series["ComFail"].Points.AddXY("", comcal);
                chart1.Series["Sensor Block"].Points.AddXY("", sensorer);
                chart1.Series["Command Reject"].Points.AddXY("", cmdreject);
                chart1.Series["Divert / Retracks"].Points.AddXY("", divert);
                chart1.Series["Dispense Timeout"].Points.AddXY("", distimeout);
                chart1.Series["Feed Failure"].Points.AddXY("", feedfail);
                chart1.Series["Other"].Points.AddXY("", othererrcal);


            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the process
                MessageBox.Show("Error reading files: " + ex.Message);
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MaxDate = DateTime.Now;

            dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-1);
        }

        private void communication_Click(object sender, EventArgs e)
        {

        }
    }
}
