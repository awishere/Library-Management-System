namespace mainfile
{
    partial class FormStudentmain
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
            this.panelheader = new System.Windows.Forms.Panel();
            this.issuedBooks = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnbooks = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.X = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelchildform = new System.Windows.Forms.Panel();
            this.panelheader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelheader.Controls.Add(this.issuedBooks);
            this.panelheader.Controls.Add(this.btnhome);
            this.panelheader.Controls.Add(this.btnbooks);
            this.panelheader.Location = new System.Drawing.Point(0, 55);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1241, 53);
            this.panelheader.TabIndex = 1;
            // 
            // issuedBooks
            // 
            this.issuedBooks.FlatAppearance.BorderSize = 0;
            this.issuedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issuedBooks.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedBooks.ForeColor = System.Drawing.Color.White;
            this.issuedBooks.Location = new System.Drawing.Point(242, 12);
            this.issuedBooks.Name = "issuedBooks";
            this.issuedBooks.Size = new System.Drawing.Size(221, 30);
            this.issuedBooks.TabIndex = 6;
            this.issuedBooks.Text = "Total Books Issued";
            this.issuedBooks.UseVisualStyleBackColor = true;
            this.issuedBooks.Click += new System.EventHandler(this.issuedBooks_Click);
            // 
            // btnhome
            // 
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Location = new System.Drawing.Point(40, 10);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 32);
            this.btnhome.TabIndex = 2;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            this.btnhome.MouseLeave += new System.EventHandler(this.btnhome_MouseLeave);
            this.btnhome.MouseHover += new System.EventHandler(this.btnhome_MouseHover);
            // 
            // btnbooks
            // 
            this.btnbooks.FlatAppearance.BorderSize = 0;
            this.btnbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbooks.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooks.ForeColor = System.Drawing.Color.White;
            this.btnbooks.Location = new System.Drawing.Point(149, 11);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Size = new System.Drawing.Size(87, 31);
            this.btnbooks.TabIndex = 3;
            this.btnbooks.Text = "Books";
            this.btnbooks.UseVisualStyleBackColor = true;
            this.btnbooks.Click += new System.EventHandler(this.btnbooks_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 57);
            this.panel1.TabIndex = 38;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.Color.SteelBlue;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.Black;
            this.X.Location = new System.Drawing.Point(1221, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(17, 16);
            this.X.TabIndex = 2;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(1274, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "  X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // panelchildform
            // 
            this.panelchildform.AutoScroll = true;
            this.panelchildform.BackColor = System.Drawing.Color.White;
            this.panelchildform.Location = new System.Drawing.Point(0, 103);
            this.panelchildform.Name = "panelchildform";
            this.panelchildform.Size = new System.Drawing.Size(1241, 565);
            this.panelchildform.TabIndex = 3;
            this.panelchildform.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchildform_Paint);
            // 
            // FormStudentmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelchildform);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormStudentmain";
            this.Load += new System.EventHandler(this.FormStudentmain_Load);
            this.panelheader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnbooks;
        private System.Windows.Forms.Button issuedBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelchildform;
        private System.Windows.Forms.Label X;
    }
}