namespace mainfile
{
    partial class Formbookissuestd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.author = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.issue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.searchbook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(135, 445);
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Size = new System.Drawing.Size(215, 20);
            this.author.TabIndex = 2;
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(135, 395);
            this.bookname.Name = "bookname";
            this.bookname.ReadOnly = true;
            this.bookname.Size = new System.Drawing.Size(215, 20);
            this.bookname.TabIndex = 3;
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(487, 395);
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            this.publisher.Size = new System.Drawing.Size(215, 20);
            this.publisher.TabIndex = 4;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(746, 402);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 5;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "status";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Issued"});
            this.status.Location = new System.Drawing.Point(495, 506);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(207, 21);
            this.status.TabIndex = 9;
            // 
            // issue
            // 
            this.issue.Location = new System.Drawing.Point(552, 570);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(75, 23);
            this.issue.TabIndex = 12;
            this.issue.Text = "Issue";
            this.issue.UseVisualStyleBackColor = true;
            this.issue.Click += new System.EventHandler(this.issue_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Publisher";
            // 
            // bookPicture
            // 
            this.bookPicture.Location = new System.Drawing.Point(878, 52);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(313, 236);
            this.bookPicture.TabIndex = 17;
            this.bookPicture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantiity";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(140, 502);
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 11;
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.search.Location = new System.Drawing.Point(243, 52);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(156, 20);
            this.search.TabIndex = 18;
            this.search.Text = "Search By Name";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.Enter += new System.EventHandler(this.SearchEnter);
            this.search.Leave += new System.EventHandler(this.SearchLeave);
            // 
            // searchbook
            // 
            this.searchbook.Location = new System.Drawing.Point(487, 48);
            this.searchbook.Name = "searchbook";
            this.searchbook.Size = new System.Drawing.Size(75, 23);
            this.searchbook.TabIndex = 19;
            this.searchbook.Text = "Search";
            this.searchbook.UseVisualStyleBackColor = true;
            this.searchbook.Click += new System.EventHandler(this.searchbook_Click);
            // 
            // Formbookissuestd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 676);
            this.Controls.Add(this.searchbook);
            this.Controls.Add(this.search);
            this.Controls.Add(this.bookPicture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.author);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formbookissuestd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Formbookissuestd";
            this.Load += new System.EventHandler(this.Formbookissuestd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox bookPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button searchbook;
    }
}