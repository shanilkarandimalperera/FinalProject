namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnldash = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.btndispenser = new System.Windows.Forms.Button();
            this.btnepp = new System.Windows.Forms.Button();
            this.btnreceipt = new System.Windows.Forms.Button();
            this.btncardreader = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlcardreader = new System.Windows.Forms.Panel();
            this.pnldash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnldash
            // 
            this.pnldash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(99)))));
            this.pnldash.Controls.Add(this.pnlNav);
            this.pnldash.Controls.Add(this.btnhome);
            this.pnldash.Controls.Add(this.btndispenser);
            this.pnldash.Controls.Add(this.btnepp);
            this.pnldash.Controls.Add(this.btnreceipt);
            this.pnldash.Controls.Add(this.btncardreader);
            this.pnldash.Controls.Add(this.pictureBox1);
            this.pnldash.Font = new System.Drawing.Font("Dubai", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnldash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnldash.Location = new System.Drawing.Point(-1, 0);
            this.pnldash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnldash.MaximumSize = new System.Drawing.Size(299, 625);
            this.pnldash.MinimumSize = new System.Drawing.Size(45, 625);
            this.pnldash.Name = "pnldash";
            this.pnldash.Size = new System.Drawing.Size(299, 625);
            this.pnldash.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.pnlNav.ForeColor = System.Drawing.Color.Black;
            this.pnlNav.Location = new System.Drawing.Point(0, 127);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(20);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Padding = new System.Windows.Forms.Padding(51, 50, 51, 50);
            this.pnlNav.Size = new System.Drawing.Size(8, 186);
            this.pnlNav.TabIndex = 1;
            this.pnlNav.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(41)))));
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(0, 581);
            this.btnhome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(299, 42);
            this.btnhome.TabIndex = 2;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            this.btnhome.Leave += new System.EventHandler(this.btnhome_Leave);
            // 
            // btndispenser
            // 
            this.btndispenser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(41)))));
            this.btndispenser.Cursor = System.Windows.Forms.Cursors.Default;
            this.btndispenser.FlatAppearance.BorderSize = 0;
            this.btndispenser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndispenser.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndispenser.Location = new System.Drawing.Point(-3, 272);
            this.btndispenser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndispenser.Name = "btndispenser";
            this.btndispenser.Size = new System.Drawing.Size(303, 42);
            this.btndispenser.TabIndex = 2;
            this.btndispenser.Text = "Dispenser";
            this.btndispenser.UseVisualStyleBackColor = false;
            this.btndispenser.Click += new System.EventHandler(this.btndispenser_Click);
            this.btndispenser.Leave += new System.EventHandler(this.btndispenser_leave);
            // 
            // btnepp
            // 
            this.btnepp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(41)))));
            this.btnepp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnepp.FlatAppearance.BorderSize = 0;
            this.btnepp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnepp.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnepp.Location = new System.Drawing.Point(0, 224);
            this.btnepp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnepp.Name = "btnepp";
            this.btnepp.Size = new System.Drawing.Size(300, 42);
            this.btnepp.TabIndex = 2;
            this.btnepp.Text = "Ecrypted Pin Pad";
            this.btnepp.UseVisualStyleBackColor = false;
            this.btnepp.Click += new System.EventHandler(this.btnepp_Click);
            this.btnepp.Leave += new System.EventHandler(this.btnepp_leave);
            // 
            // btnreceipt
            // 
            this.btnreceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(41)))));
            this.btnreceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnreceipt.FlatAppearance.BorderSize = 0;
            this.btnreceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreceipt.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreceipt.Location = new System.Drawing.Point(0, 176);
            this.btnreceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreceipt.Name = "btnreceipt";
            this.btnreceipt.Size = new System.Drawing.Size(300, 42);
            this.btnreceipt.TabIndex = 2;
            this.btnreceipt.Text = "Receipt Printer";
            this.btnreceipt.UseVisualStyleBackColor = false;
            this.btnreceipt.Click += new System.EventHandler(this.btnreceipt_Click);
            this.btnreceipt.Leave += new System.EventHandler(this.btnreceipt_Leave);
            // 
            // btncardreader
            // 
            this.btncardreader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(19)))), ((int)(((byte)(41)))));
            this.btncardreader.Cursor = System.Windows.Forms.Cursors.Default;
            this.btncardreader.FlatAppearance.BorderSize = 0;
            this.btncardreader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncardreader.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncardreader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncardreader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncardreader.Location = new System.Drawing.Point(0, 128);
            this.btncardreader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncardreader.Name = "btncardreader";
            this.btncardreader.Size = new System.Drawing.Size(300, 42);
            this.btncardreader.TabIndex = 1;
            this.btncardreader.Text = "Card Reader";
            this.btncardreader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncardreader.UseVisualStyleBackColor = false;
            this.btncardreader.Click += new System.EventHandler(this.button1_Click);
            this.btncardreader.Leave += new System.EventHandler(this.btncard_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.download_copy;
            this.pictureBox1.Location = new System.Drawing.Point(44, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pnlcardreader
            // 
            this.pnlcardreader.Location = new System.Drawing.Point(305, 0);
            this.pnlcardreader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlcardreader.Name = "pnlcardreader";
            this.pnlcardreader.Size = new System.Drawing.Size(704, 617);
            this.pnlcardreader.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 620);
            this.Controls.Add(this.pnlcardreader);
            this.Controls.Add(this.pnldash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ATM Fault Manangement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnldash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btncardreader;
        private System.Windows.Forms.Button btnreceipt;
        private System.Windows.Forms.Button btndispenser;
        private System.Windows.Forms.Button btnepp;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel pnlcardreader;
    }
}

