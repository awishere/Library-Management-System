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
using System.IO;
using System.Web;
using System.Net.Mail;

namespace mainfile
{
    public partial class Formbookissuestd : Form
    {
        public Formbookissuestd()
        {
            InitializeComponent();
            DisplayData();
            username.Text = Formloginstd.users;
            bookPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        private void Formbookissuestd_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            publisher.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           // title.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            author.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            bookname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            byte[] img = (byte[])dataGridView1.Rows[e.RowIndex].Cells[6].Value;

            MemoryStream ms = new MemoryStream(img);

            bookPicture.Image = Image.FromStream(ms);
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT Book_ID,Book_Name,Author,Publisher,Quantity,Category_Name,Image FROM Book", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        

        private void issue_Click_1(object sender, EventArgs e)
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
            username.Text);
            MyDataReader = MyCommand.ExecuteReader();
            MyDataReader.Read();
            String studentID = MyDataReader["Student_ID"].ToString();
            con.Close();
            if (Int32.Parse(quantity.Text) > 0)
            {
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
                7);
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
                MailMessage mail = new MailMessage();

                con.Close();
            }
            else
            {
                MessageBox.Show("Book Not Available Right Now!");
            }


        }

        private void username_TextChanged(object sender, EventArgs e)
        {
           // username.Hide();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchbook_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Book WHERE Book_Name = '"+search.Text+"'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void SearchEnter(object sender, EventArgs e)
        {
            if(search.Text == "Search By Name")
            {
                search.Text = "";

                search.ForeColor = Color.Black;
            }
        }

        private void SearchLeave(object sender, EventArgs e)
        {
            if(search.Text == "")
            {
                search.Text = "Search By Name";
                search.ForeColor = Color.Silver;
            }
        }
    }
}
