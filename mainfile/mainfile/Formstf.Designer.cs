namespace mainfile
{
    partial class Formstf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formstf));
            this.panelChildform = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.finereport = new System.Windows.Forms.Button();
            this.Penalty = new System.Windows.Forms.Button();
            this.issuedBooks = new System.Windows.Forms.Button();
            this.panelbook = new System.Windows.Forms.Panel();
            this.addbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.btnbooks = new System.Windows.Forms.Button();
            this.panelleft = new System.Windows.Forms.Panel();
            this.panelmem = new System.Windows.Forms.Panel();
            this.Homebtn = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.Stdbtn = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelbook.SuspendLayout();
            this.panelleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildform
            // 
            this.panelChildform.BackColor = System.Drawing.Color.White;
            this.panelChildform.Location = new System.Drawing.Point(200, 75);
            this.panelChildform.Name = "panelChildform";
            this.panelChildform.Size = new System.Drawing.Size(1293, 701);
            this.panelChildform.TabIndex = 5;
            this.panelChildform.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildform_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Management System";
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Controls.Add(this.pictureBox4);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(200, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1293, 75);
            this.paneltop.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1266, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.Stdbtn);
            this.panel1.Controls.Add(this.finereport);
            this.panel1.Controls.Add(this.Penalty);
            this.panel1.Controls.Add(this.issuedBooks);
            this.panel1.Controls.Add(this.panelbook);
            this.panel1.Controls.Add(this.btnbooks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 654);
            this.panel1.TabIndex = 3;
            // 
            // finereport
            // 
            this.finereport.AutoSize = true;
            this.finereport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finereport.BackgroundImage")));
            this.finereport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.finereport.Dock = System.Windows.Forms.DockStyle.Top;
            this.finereport.FlatAppearance.BorderSize = 0;
            this.finereport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finereport.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.finereport.Location = new System.Drawing.Point(0, 204);
            this.finereport.Name = "finereport";
            this.finereport.Size = new System.Drawing.Size(200, 48);
            this.finereport.TabIndex = 5;
            this.finereport.Text = "Penalty Report";
            this.finereport.UseVisualStyleBackColor = true;
            this.finereport.Click += new System.EventHandler(this.finereport_Click);
            // 
            // Penalty
            // 
            this.Penalty.AutoSize = true;
            this.Penalty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Penalty.BackgroundImage")));
            this.Penalty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Penalty.Dock = System.Windows.Forms.DockStyle.Top;
            this.Penalty.FlatAppearance.BorderSize = 0;
            this.Penalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Penalty.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Penalty.ForeColor = System.Drawing.Color.White;
            this.Penalty.Location = new System.Drawing.Point(0, 156);
            this.Penalty.Name = "Penalty";
            this.Penalty.Size = new System.Drawing.Size(200, 48);
            this.Penalty.TabIndex = 4;
            this.Penalty.Text = "Penalty";
            this.Penalty.UseVisualStyleBackColor = true;
            this.Penalty.Click += new System.EventHandler(this.Penalty_Click);
            // 
            // issuedBooks
            // 
            this.issuedBooks.AutoSize = true;
            this.issuedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.issuedBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("issuedBooks.BackgroundImage")));
            this.issuedBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.issuedBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.issuedBooks.FlatAppearance.BorderSize = 0;
            this.issuedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issuedBooks.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.issuedBooks.ForeColor = System.Drawing.Color.White;
            this.issuedBooks.Location = new System.Drawing.Point(0, 108);
            this.issuedBooks.Name = "issuedBooks";
            this.issuedBooks.Size = new System.Drawing.Size(200, 48);
            this.issuedBooks.TabIndex = 3;
            this.issuedBooks.Text = "Books Issued";
            this.issuedBooks.UseVisualStyleBackColor = false;
            this.issuedBooks.Click += new System.EventHandler(this.issuedBooks_Click);
            // 
            // panelbook
            // 
            this.panelbook.AutoSize = true;
            this.panelbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panelbook.Controls.Add(this.addbtn);
            this.panelbook.Controls.Add(this.searchbtn);
            this.panelbook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbook.Location = new System.Drawing.Point(0, 48);
            this.panelbook.Name = "panelbook";
            this.panelbook.Size = new System.Drawing.Size(200, 60);
            this.panelbook.TabIndex = 2;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(0, 30);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(200, 30);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Search";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.searchbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(0, 0);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(200, 30);
            this.searchbtn.TabIndex = 0;
            this.searchbtn.Text = "Category";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // btnbooks
            // 
            this.btnbooks.AutoSize = true;
            this.btnbooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbooks.BackgroundImage")));
            this.btnbooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnbooks.FlatAppearance.BorderSize = 0;
            this.btnbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbooks.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnbooks.ForeColor = System.Drawing.Color.White;
            this.btnbooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbooks.Location = new System.Drawing.Point(0, 0);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Size = new System.Drawing.Size(200, 48);
            this.btnbooks.TabIndex = 1;
            this.btnbooks.Text = "Books";
            this.btnbooks.UseVisualStyleBackColor = true;
            this.btnbooks.Click += new System.EventHandler(this.btnbooks_Click);
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.Navy;
            this.panelleft.Controls.Add(this.panel1);
            this.panelleft.Controls.Add(this.panelmem);
            this.panelleft.Controls.Add(this.Homebtn);
            this.panelleft.Controls.Add(this.panellogo);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(200, 776);
            this.panelleft.TabIndex = 3;
            // 
            // panelmem
            // 
            this.panelmem.AutoSize = true;
            this.panelmem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panelmem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmem.Location = new System.Drawing.Point(0, 122);
            this.panelmem.Name = "panelmem";
            this.panelmem.Size = new System.Drawing.Size(200, 0);
            this.panelmem.TabIndex = 2;
            // 
            // Homebtn
            // 
            this.Homebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Homebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Homebtn.BackgroundImage")));
            this.Homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Homebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Homebtn.FlatAppearance.BorderSize = 0;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homebtn.ForeColor = System.Drawing.Color.White;
            this.Homebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Homebtn.Location = new System.Drawing.Point(0, 75);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(200, 47);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = false;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panellogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panellogo.BackgroundImage")));
            this.panellogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(200, 75);
            this.panellogo.TabIndex = 0;
            // 
            // Stdbtn
            // 
            this.Stdbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Stdbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stdbtn.FlatAppearance.BorderSize = 0;
            this.Stdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stdbtn.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Stdbtn.ForeColor = System.Drawing.Color.White;
            this.Stdbtn.Location = new System.Drawing.Point(0, 252);
            this.Stdbtn.Name = "Stdbtn";
            this.Stdbtn.Size = new System.Drawing.Size(200, 50);
            this.Stdbtn.TabIndex = 6;
            this.Stdbtn.Text = "Students";
            this.Stdbtn.UseVisualStyleBackColor = false;
            this.Stdbtn.Click += new System.EventHandler(this.Stdbtn_Click_1);
            // 
            // Formstf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 776);
            this.Controls.Add(this.panelChildform);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formstf";
            this.Text = "Formstf";
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelbook.ResumeLayout(false);
            this.panelleft.ResumeLayout(false);
            this.panelleft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnbooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button finereport;
        private System.Windows.Forms.Button Penalty;
        private System.Windows.Forms.Button issuedBooks;
        private System.Windows.Forms.Panel panelbook;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelmem;
        private System.Windows.Forms.Button Stdbtn;
    }
}