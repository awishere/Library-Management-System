using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mainfile
{
    public partial class Formaddbook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmds;
        SqlDataAdapter adapt;
        int ID = 0;

        public Formaddbook()
        {
            InitializeComponent();
            User u = new User();
            user.Text = u.UserName;
            DisplayData();
            days.Hide();
            user.Hide();
            quantity.Hide();
            user.Text = formloginfac.users;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formaddbook_Load(object sender, EventArgs e)
        {

        }

        private void addbtnsearch_Click(object sender, EventArgs e)
        {
            opanchildform(new Formaddmain());
        }
        private Form activeForm = null;
        private void openchildform(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelthis.Controls.Add(childform);
            panelthis.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void opanchildform(Form childform)
        {

            childform.BringToFront();
            childform.Show();
        }

        private void panelthis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            deptname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            categoryname.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            isbn.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            publisher.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            title.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            author.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            bookname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Book WHERE Book_Name = '" + search.Text + "' or Category_Name = '"+searchcategory.Text+"'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ClearData()
        {
            deptname.Text = "";
            categoryname.Text = "";
            isbn.Text = "";
            title.Text = "";
            author.Text = "";
            publisher.Text = "";
            ID = 0;
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Book", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (deptname.Text != "" && categoryname.Text != "" && isbn.Text != "" && title.Text != "" && author.Text != "" && publisher.Text != "" && quantity.Text != "")
            {
                cmd = new SqlCommand("update Book set Category_Name=@categoryname, Dept_Name = @deptname, ISBN = @isbn, Title = @title, Author = @author, Publisher = @publisher, Is_Issued = @isIssued where Book_ID = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@deptname", deptname.Text);
                cmd.Parameters.AddWithValue("@categoryname", categoryname.Text);
                cmd.Parameters.AddWithValue("@isbn", isbn.Text);
                cmd.Parameters.AddWithValue("@title", title.Text);
                cmd.Parameters.AddWithValue("@author", author.Text);
                cmd.Parameters.AddWithValue("@isIssued", quantity.Text);
                cmd.Parameters.AddWithValue("@publisher", publisher.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmds = new SqlCommand("delete Borrower where Book_ID=@id", con);
                cmd = new SqlCommand("delete Book where Book_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmds.Parameters.AddWithValue("@id", ID);
                cmds.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void Issue_Click(object sender, EventArgs e)
        {
            SqlCommand cm;
            SqlDataReader cmReader;
            cm = con.CreateCommand();
            cm.CommandText = "SELECT Book_ID ,Quantity from Book where Book_ID = @ID";
            con.Open();
            cm.Parameters.AddWithValue("@ID",
            ID);
            cmReader = cm.ExecuteReader();
            cmReader.Read();
            quantity.Text = cmReader["Quantity"].ToString();
            String bookID = cmReader["Book_ID"].ToString();
            con.Close();
            // SqlCommand MyCommands;
            // SqlDataReader MyDataReader;
            // MyCommands = con.CreateCommand();
            // MyCommands.CommandText = "SELECT b.Quantity,bo.Book_ID, s.Student_ID FROM Book b, Borrower bo, Student s where b.Book_ID = bo.Book_ID and s.Student_ID = bo.Student_ID";
            // con.Open();
            // MyDataReader = MyCommands.ExecuteReader();
            // MyDataReader.Read();
            // quantity.Text = MyDataReader["Quantity"].ToString();
            //String studentID = MyDataReader["Student_ID"].ToString();
            //con.Close();
            SqlCommand MyCommand;
            SqlDataReader MyDataReader;
            MyCommand = con.CreateCommand();
            MyCommand.CommandText = "SELECT Student_ID from Student where Name = @username";
            con.Open();
            MyCommand.Parameters.AddWithValue("@username",
            studentName.Text);
            MyDataReader = MyCommand.ExecuteReader();
            MyDataReader.Read();
            String studentID = MyDataReader["Student_ID"].ToString();
            con.Close();

            SqlCommand cmd;
            SqlCommand cmds;
            cmd = new SqlCommand("INSERT INTO Borrower (Book_Name,Student_ID,Days,Issue_Date,Return_Date,Status,Book_ID) VALUES (@Book_Name,@Student_ID,@Days,@Issued_Date,@Return_Date,@Status,@Book_ID)", con);
            con.Open();
            DateTime today = DateTime.Today;
            DateTime today7 = DateTime.Today;
            cmd.Parameters.AddWithValue("@Book_Name",
            bookname.Text);
            cmd.Parameters.AddWithValue("@Book_ID",
            bookID);
            cmd.Parameters.AddWithValue("@Student_ID",
            studentID);
            cmd.Parameters.AddWithValue("@Days",
            days.Text);
            cmd.Parameters.AddWithValue("@Issued_Date",
            today);
            cmd.Parameters.AddWithValue("@Return_Date",
            today7.AddDays(7));
            cmd.Parameters.AddWithValue("@Status",
            status.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            
            MessageBox.Show(i + " Row(s) Inserted ");

            int y = Int32.Parse(quantity.Text);
            int y1 = y - 1;
             cmds = new SqlCommand( "Update Book SET Quantity=@Quantity where Book_ID= @Book_ID",con);
            cmds.Parameters.AddWithValue("@Quantity",
            y1);
            cmds.Parameters.AddWithValue("@Book_ID",
            bookID);
            int j = cmds.ExecuteNonQuery();
            con.Close();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
        {
        }

        private void SearchEnter(object sender, EventArgs e)
        {
            if (search.Text == "Search By Name")
            {
                search.Text = "";

                search.ForeColor = Color.Black;
            }
        }

        private void SearchLeave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search By Name";
                search.ForeColor = Color.Silver;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchCategory(object sender, EventArgs e)
        {
            if (searchcategory.Text == "Search By Category")
            {
                searchcategory.Text = "";

                searchcategory.ForeColor = Color.Black;
            }
        }

        private void SearchCategoryLeave(object sender, EventArgs e)
        {
            if (searchcategory.Text == "")
            {
                searchcategory.Text = "Search By Category";
                searchcategory.ForeColor = Color.Silver;
            }
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            if (deptname.Text != "" && categoryname.Text != "" && isbn.Text != "" && title.Text != "" && author.Text != "" && publisher.Text != "" && quantity.Text != "")
            {
                cmd = new SqlCommand("update Book set Category_Name=@categoryname, Dept_Name = @deptname, ISBN = @isbn, Title = @title, Author = @author, Publisher = @publisher, Is_Issued = @isIssued where Book_ID = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@deptname", deptname.Text);
                cmd.Parameters.AddWithValue("@categoryname", categoryname.Text);
                cmd.Parameters.AddWithValue("@isbn", isbn.Text);
                cmd.Parameters.AddWithValue("@title", title.Text);
                cmd.Parameters.AddWithValue("@author", author.Text);
                cmd.Parameters.AddWithValue("@isIssued", quantity.Text);
                cmd.Parameters.AddWithValue("@publisher", publisher.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmds = new SqlCommand("delete Borrower where Book_ID=@id", con);
                cmd = new SqlCommand("delete Book where Book_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmds.Parameters.AddWithValue("@id", ID);
                cmds.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void Issue_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cm;
                SqlDataReader cmReader;
                cm = con.CreateCommand();
                cm.CommandText = "SELECT Book_ID ,Quantity from Book where Book_ID = @ID";
                con.Open();
                cm.Parameters.AddWithValue("@ID",
                ID);
                cmReader = cm.ExecuteReader();
                cmReader.Read();
                quantity.Text = cmReader["Quantity"].ToString();
                String bookID = cmReader["Book_ID"].ToString();
                con.Close();
                // SqlCommand MyCommands;
                // SqlDataReader MyDataReader;
                // MyCommands = con.CreateCommand();
                // MyCommands.CommandText = "SELECT b.Quantity,bo.Book_ID, s.Student_ID FROM Book b, Borrower bo, Student s where b.Book_ID = bo.Book_ID and s.Student_ID = bo.Student_ID";
                // con.Open();
                // MyDataReader = MyCommands.ExecuteReader();
                // MyDataReader.Read();
                // quantity.Text = MyDataReader["Quantity"].ToString();
                //String studentID = MyDataReader["Student_ID"].ToString();
                //con.Close();
                SqlCommand MyCommand;
                SqlDataReader MyDataReader;
                MyCommand = con.CreateCommand();
                MyCommand.CommandText = "SELECT Student_ID from Student where UserName = @username";
                con.Open();
                MyCommand.Parameters.AddWithValue("@username",
                studentName.Text);
                MyDataReader = MyCommand.ExecuteReader();
                MyDataReader.Read();
                String studentID = MyDataReader["Student_ID"].ToString();
                con.Close();

                SqlCommand cmd;
                SqlCommand cmds;
                cmd = new SqlCommand("INSERT INTO Borrower (Book_Name,Student_ID,Days,Issue_Date,Return_Date,Status,Book_ID) VALUES (@Book_Name,@Student_ID,@Days,@Issued_Date,@Return_Date,@Status,@Book_ID)", con);
                con.Open();
                DateTime today = DateTime.Today;
                DateTime today7 = DateTime.Today;
                cmd.Parameters.AddWithValue("@Book_Name",
                bookname.Text);
                cmd.Parameters.AddWithValue("@Book_ID",
                bookID);
                cmd.Parameters.AddWithValue("@Student_ID",
                studentID);
                cmd.Parameters.AddWithValue("@Days",
                days.Text);
                cmd.Parameters.AddWithValue("@Issued_Date",
                today);
                cmd.Parameters.AddWithValue("@Return_Date",
                today7.AddDays(7));
                cmd.Parameters.AddWithValue("@Status",
                status.Text);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();

                MessageBox.Show(i + " Row(s) Inserted ");

                int y = Int32.Parse(quantity.Text);
                int y1 = y - 1;
                cmds = new SqlCommand("Update Book SET Quantity=@Quantity where Book_ID= @Book_ID", con);
                cmds.Parameters.AddWithValue("@Quantity",
                y1);
                cmds.Parameters.AddWithValue("@Book_ID",
                bookID);
                int j = cmds.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("User Doesnot Exist");
            }
        }

        private void image_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            quantity.Hide();
        }

        private void days_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
