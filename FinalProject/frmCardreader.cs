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
            string folderPath = @"D:\Reserarch\Logs\AECTS1torintoncardcapture high\AECTS1";
            int cr01Count = 0;
            int cr02Count = 0;

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
                        cr01Count += CountWordOccurrences(fileContent, "CR01:");
                        cr02Count += CountWordOccurrences(fileContent, "Transaction");
                    }
                }

                // Set the count value to label2
                label2.Text = cr01Count.ToString();
                label5.Text = cr02Count.ToString();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
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
                    label2.Text = "File Modified Date: " + creationDate.ToString("yyyy-MM-dd HH:mm:ss");
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

            label5.Text = "Date picker time" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }

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
            label5.Text = "";

            // Loop through the dates and construct the result string
            DateTime currentDate = startDate;
            while (currentDate <= endDate)
            {
                label5.Text += currentDate.ToString("yyyy-MM-dd") + Environment.NewLine;
                currentDate = currentDate.AddDays(1); // Increment to the next date
            }
        }

    }
}
