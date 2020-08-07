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
    public partial class FormIssuedBooks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public FormIssuedBooks()
        {
            InitializeComponent();
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
            DisplayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            studentName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            status.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //returnDate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
           // publisher.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            bookName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //author.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //bookname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT b.Book_ID,b.Book_Name,s.UserName, b.Status,b.Issue_Date, b.Return_Date FROM Borrower b, Student s where b.Student_ID = s.Student_ID and Status = 'Issued'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (studentName.Text != "" && bookName.Text != "" && status.Text != "")
            {
                cmd = new SqlCommand("update Borrower set  Book_Name = @Book_Name, Status = @status where Book_ID = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@Student_Name", studentName.Text);
                cmd.Parameters.AddWithValue("@Book_Name", bookName.Text);
                cmd.Parameters.AddWithValue("@status", status.Text);
                
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

        private void ClearData()
        {

            studentName.Text = "";
            bookName.Text = "";
            status.Text = "";
            ID = 0;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Borrower where Book_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
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

        private void FormIssuedBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
