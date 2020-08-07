namespace mainfile
{
    partial class Formaddbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formaddbook));
            this.addbtnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.textBoxAUTHOR = new System.Windows.Forms.TextBox();
            this.searchcategory = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelthis = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.deptname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.days = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.TextBox();
            this.categoryname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Issue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelthis.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbtnsearch
            // 
            this.addbtnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.addbtnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbtnsearch.BackgroundImage")));
            this.addbtnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addbtnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtnsearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtnsearch.ForeColor = System.Drawing.Color.White;
            this.addbtnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbtnsearch.Location = new System.Drawing.Point(12, 68);
            this.addbtnsearch.Name = "addbtnsearch";
            this.addbtnsearch.Size = new System.Drawing.Size(96, 28);
            this.addbtnsearch.TabIndex = 1;
            this.addbtnsearch.Text = "Add";
            this.addbtnsearch.UseVisualStyleBackColor = false;
            this.addbtnsearch.Click += new System.EventHandler(this.addbtnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 335);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Books";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Verdana", 12F);
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(506, 119);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(125, 27);
            this.searchbtn.TabIndex = 7;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // textBoxAUTHOR
            // 
            this.textBoxAUTHOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxAUTHOR.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxAUTHOR.Location = new System.Drawing.Point(387, 126);
            this.textBoxAUTHOR.Name = "textBoxAUTHOR";
            this.textBoxAUTHOR.Size = new System.Drawing.Size(100, 20);
            this.textBoxAUTHOR.TabIndex = 6;
            this.textBoxAUTHOR.Text = "Author";
            // 
            // searchcategory
            // 
            this.searchcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.searchcategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.searchcategory.Location = new System.Drawing.Point(144, 126);
            this.searchcategory.Name = "searchcategory";
            this.searchcategory.Size = new System.Drawing.Size(100, 20);
            this.searchcategory.TabIndex = 4;
            this.searchcategory.Text = "Search By Category";
            this.searchcategory.Enter += new System.EventHandler(this.SearchCategory);
            this.searchcategory.Leave += new System.EventHandler(this.SearchCategoryLeave);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.search.Location = new System.Drawing.Point(38, 126);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 3;
            this.search.Text = "Search By Name";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Enter += new System.EventHandler(this.SearchEnter);
            this.search.Leave += new System.EventHandler(this.SearchLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panelthis
            // 
            this.panelthis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panelthis.Controls.Add(this.label1);
            this.panelthis.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelthis.ForeColor = System.Drawing.Color.White;
            this.panelthis.Location = new System.Drawing.Point(0, 0);
            this.panelthis.Name = "panelthis";
            this.panelthis.Size = new System.Drawing.Size(1293, 54);
            this.panelthis.TabIndex = 3;
            this.panelthis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelthis_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.isbn);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.deptname);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.author);
            this.groupBox1.Controls.Add(this.days);
            this.groupBox1.Controls.Add(this.publisher);
            this.groupBox1.Controls.Add(this.bookname);
            this.groupBox1.Controls.Add(this.categoryname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Issue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(659, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 400);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(457, 125);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(138, 27);
            this.studentName.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "ISBN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label13.Location = new System.Drawing.Point(297, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 18);
            this.label13.TabIndex = 64;
            this.label13.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Dept Name";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(451, 323);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 27);
            this.user.TabIndex = 63;
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(121, 28);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(134, 27);
            this.isbn.TabIndex = 41;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Issued"});
            this.status.Location = new System.Drawing.Point(407, 79);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(162, 26);
            this.status.TabIndex = 62;
            // 
            // deptname
            // 
            this.deptname.Location = new System.Drawing.Point(121, 71);
            this.deptname.Name = "deptname";
            this.deptname.Size = new System.Drawing.Size(134, 27);
            this.deptname.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label12.Location = new System.Drawing.Point(297, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 18);
            this.label12.TabIndex = 61;
            this.label12.Text = "Status";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(121, 121);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(134, 27);
            this.title.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 60;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(124, 168);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(134, 27);
            this.author.TabIndex = 44;
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(451, 215);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(100, 27);
            this.days.TabIndex = 59;
            this.days.TextChanged += new System.EventHandler(this.days_TextChanged);
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(124, 206);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(134, 27);
            this.publisher.TabIndex = 45;
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(407, 31);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(162, 27);
            this.bookname.TabIndex = 58;
            // 
            // categoryname
            // 
            this.categoryname.Location = new System.Drawing.Point(172, 250);
            this.categoryname.Name = "categoryname";
            this.categoryname.Size = new System.Drawing.Size(112, 27);
            this.categoryname.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label9.Location = new System.Drawing.Point(291, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 18);
            this.label9.TabIndex = 56;
            this.label9.Text = "Book Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(19, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Author";
            // 
            // Issue
            // 
            this.Issue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Issue.Font = new System.Drawing.Font("Verdana", 12F);
            this.Issue.ForeColor = System.Drawing.Color.White;
            this.Issue.Location = new System.Drawing.Point(206, 350);
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(75, 31);
            this.Issue.TabIndex = 55;
            this.Issue.Text = "Issue";
            this.Issue.UseVisualStyleBackColor = false;
            this.Issue.Click += new System.EventHandler(this.Issue_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(19, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Publisher";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(300, 225);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(134, 27);
            this.quantity.TabIndex = 54;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.label7.Location = new System.Drawing.Point(19, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Category Name";
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Verdana", 12F);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(2, 350);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(85, 31);
            this.update.TabIndex = 51;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Verdana", 12F);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(107, 350);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 31);
            this.Delete.TabIndex = 52;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // Formaddbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxAUTHOR);
            this.Controls.Add(this.panelthis);
            this.Controls.Add(this.searchcategory);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.search);
            this.Controls.Add(this.addbtnsearch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formaddbook";
            this.Load += new System.EventHandler(this.Formaddbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelthis.ResumeLayout(false);
            this.panelthis.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox textBoxAUTHOR;
        private System.Windows.Forms.TextBox searchcategory;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelthis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.TextBox deptname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox categoryname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Issue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Delete;
    }
}