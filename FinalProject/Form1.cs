using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlNav.Height = btnhome.Height;
            pnlNav.Top = btnhome.Top;
            pnlNav.Left = btnhome.Left;
            btnhome.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pnlNav.Height = btncardreader.Height;
            pnlNav.Top = btncardreader.Top;
            pnlNav.Left = btncardreader.Left;
            btncardreader.BackColor = Color.FromArgb(46, 51, 73);


            this.pnlcardreader.Controls.Clear();
            frmCardreader Frmcardreader = new frmCardreader() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmcardreader.FormBorderStyle = FormBorderStyle.None;
            this.pnlcardreader.Controls.Add(Frmcardreader);
            Frmcardreader.Show();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnhome.Height;
            pnlNav.Top = btnhome.Top;
            pnlNav.Left = btnhome.Left;
            btnhome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnhome_Leave(object sender, EventArgs e)
        {
            btnhome.BackColor = Color.FromArgb(6, 19, 41);
        }

        private void btnreceipt_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnreceipt.Height;
            pnlNav.Top = btnreceipt.Top;
            pnlNav.Left = btnreceipt.Left;
            btnreceipt.BackColor = Color.FromArgb(46, 51, 73);


            this.pnlcardreader.Controls.Clear();
            frmReceipt Frmcardreader = new frmReceipt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmcardreader.FormBorderStyle = FormBorderStyle.None;
            this.pnlcardreader.Controls.Add(Frmcardreader);
            Frmcardreader.Show();
        }

        private void btnepp_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnepp.Height;
            pnlNav.Top = btnepp.Top;
            pnlNav.Left = btnepp.Left;
            btnepp.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btndispenser_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btndispenser.Height;
            pnlNav.Top = btndispenser.Top;
            pnlNav.Left = btndispenser.Left;
            btndispenser.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnreceipt_Leave(object sender, EventArgs e)
        {
            btnreceipt.BackColor = Color.FromArgb(6, 19, 41);
        }

        private void btnepp_leave(object sender, EventArgs e)
        {
            btnepp.BackColor = Color.FromArgb(6, 19, 41);
        }

        private void btndispenser_leave(object sender, EventArgs e)
        {
            btndispenser.BackColor = Color.FromArgb(6, 19, 41);
        }

        private void btncard_Leave(object sender, EventArgs e)
        {
            btncardreader.BackColor = Color.FromArgb(6, 19, 41);
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
