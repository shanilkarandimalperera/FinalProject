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

namespace FinalProject
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            string filePath = @"D:\Reserarch\Logs\AECTS1torintoncardcapture high\AECTS1\current.jrn";

            try
            {
                if (File.Exists(filePath))
                {
                    // Read all lines from the file
                    string[] lines = File.ReadAllLines(filePath);

                    // Initialize a count for transaction starts
                    int transactionStartCount = 0;
                    int cardeadererr = 0;
                    int cardnoerrrs = 0;
                    int receipt = 0;
                    int receiptno = 0;
                    int epp = 0;
                    int dispenseerr = 0;
                    int dispenseerr1 = 0;
                    int disno1A = 0;
                    int disno2A = 0;
                    int disno3A = 0;
                    int disno4A = 0;
                    int disno5A = 0;
                        int disno6A = 0;

                    // Define the pattern that indicates the start of a transaction
                    string transactionStartPattern = "TRANSACTION START"; // Replace this with the actual pattern you're looking for
                    string cardreadererrpatten = "CR01:";
                    string cr14Count = "CR01:00:00:00";

                    string receiptpattern = "PR01:";
                    string receiptpatternno = "PR01:00:00:00";
                    string epppattern = "EP01:";


                    string diserr = "DI01:";
                    string diserr1 = "D901:";
                    //noerrors
                   string disno1 = "DI01:00:00:00";
                   string disno2 = "D901:00:00:00";
                    string disno3 = "DI01:3E:02:02";
                    string disno4 = "D901:3E:02:02";
                    string disno5 = "DI01:3E:02:03";
                    string disno6 = "D901:3E:02:03";

                    // Search for lines that match the transaction start pattern
                    foreach (string line in lines)
                    {
                        if (line.Contains(transactionStartPattern))
                        {
                            // Increment the transaction start count
                            transactionStartCount++;
                        }
                    }
                    foreach (string line1 in lines)
                    {
                        if (line1.Contains(cardreadererrpatten))
                        {
                            // Increment the transaction start count
                            cardeadererr++;
                        }
                    }
                    foreach (string line2 in lines)
                    {
                        if (line2.Contains(cr14Count))
                        {
                            // Increment the transaction start count
                            cardnoerrrs++;
                        }
                    }
                    foreach (string line3 in lines)
                    {
                        if (line3.Contains(receiptpattern))
                        {
                            // Increment the transaction start count
                            receipt++;
                        }
                    }

                    foreach (string line4 in lines)
                    {
                        if (line4.Contains(receiptpatternno))
                        {
                            // Increment the transaction start count
                            receiptno++;
                        }
                    }
                    foreach (string line5 in lines)
                    {
                        if (line5.Contains(epppattern))
                        {
                            // Increment the transaction start count
                            epp++;
                        }
                    }

                    foreach (string line6 in lines)
                    {
                        if (line6.Contains(diserr))
                        {
                            // Increment the transaction start count
                            dispenseerr++;
                        }
                    }
                    foreach (string line7 in lines)
                    {
                        if (line7.Contains(diserr1))
                        {
                            // Increment the transaction start count
                            dispenseerr1++;
                        }
                    }

                    foreach (string line8 in lines)
                    {
                        if (line8.Contains(disno1))
                        {
                            // Increment the transaction start count
                            disno1A++;
                        }
                    }
                    foreach (string line9 in lines)
                    {
                        if (line9.Contains(disno2))
                        {
                            // Increment the transaction start count
                            disno2A++;
                        }
                    }

                    foreach (string line10 in lines)
                    {
                        if (line10.Contains(disno3))
                        {
                            // Increment the transaction start count
                            disno3A++;
                        }
                    }
                    foreach (string line11 in lines)
                    {
                        if (line11.Contains(disno4))
                        {
                            // Increment the transaction start count
                            disno4A++;
                        }
                    }
                    foreach (string line12 in lines)
                    {
                        if (line12.Contains(disno5))
                        {
                            // Increment the transaction start count
                            disno5A++;
                        }
                    }
                    foreach (string line13 in lines)
                    {
                        if (line13.Contains(disno6))
                        {
                            // Increment the transaction start count
                            disno6A++;
                        }
                    }


                    // Display the count in the lbltottran label
                    lbltottran.Text = transactionStartCount.ToString();
                   // lblcardreader.Text = (cardeadererr - cardnoerrrs).ToString();
                   // lblreceipt.Text = (receipt - receiptno).ToString();
                    //lblepp.Text = epp.ToString();

                    //lbldis.Text = ((dispenseerr + dispenseerr1) - (disno1A + disno2A + disno3A + disno4A + disno5A + disno6A)).ToString();

                    if ((cardeadererr - cardnoerrrs) > 5)
                    {
                        lblcardreader.ForeColor = Color.Red;
                        lblcardreader.Text = "Action Required";
                    }
                    else
                    {
                        lblcardreader.ForeColor = Color.Green;
                        lblcardreader.Text = "Device Normal Operation";
                    }

                    if ((receipt - receiptno) > 5)
                    {
                        lblreceipt.ForeColor = Color.Red;
                        lblreceipt.Text = "Action Required";
                    }
                    else
                    {
                        lblreceipt.ForeColor = Color.Green;
                        lblreceipt.Text = "Device Normal Operation";
                    }
                    if (epp > 5)
                    {
                        lblepp.ForeColor = Color.Red;
                        lblepp.Text = "Action Required";
                    }
                    else
                    {
                        lblepp.ForeColor = Color.Green;
                        lblepp.Text = "Device Normal Operation";
                    }
                    if (((dispenseerr + dispenseerr1) - (disno1A + disno2A + disno3A + disno4A + disno5A + disno6A)) > 5)
                    {
                        lbldis.ForeColor = Color.Red;
                        lbldis.Text = "Action Required";
                    }
                    else
                    {
                        lbldis.ForeColor = Color.Green;
                        lbldis.Text = "Device Normal Operation";
                    }
                }
                else
                {
                    // Handle the case where the file does not exist
                    lbltottran.Text = "File not found";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during file reading
                lbltottran.Text = "Error reading file: " + ex.Message;
            }

            lbldate.Text = "Today Analyzer :-" + DateTime.Now.ToString();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
        }
    }
}
