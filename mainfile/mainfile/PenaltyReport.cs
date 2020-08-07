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
    public partial class PenaltyReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmds;
        SqlDataAdapter adapt;
        int ID = 0;
        public PenaltyReport()
        {
            InitializeComponent();
            DisplayData();
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

        private void generate_Click(object sender, EventArgs e)
        {
            SqlCommand cm;
            SqlDataReader cmReader;
            cm = con.CreateCommand();
            cm.CommandText = "SELECT Book_ID,Student_ID,Book_Name from Borrower where Borrow_ID = @ID";
            con.Open();
            cm.Parameters.AddWithValue("@ID",
            ID);
            cmReader = cm.ExecuteReader();
            cmReader.Read();
            
            String bookID = cmReader["Book_ID"].ToString();
            String studentID = cmReader["Student_ID"].ToString();
            String bookName = cmReader["Book_Name"].ToString();
            con.Close();

            int count = Convert.ToInt32(penalty.Value);

            int val = Int32.Parse(fine.Text) * count;
            DateTime today = DateTime.Now;
            SqlCommand cmd;
            SqlCommand cmds;
            cmd = new SqlCommand("INSERT INTO Penalty (Student_ID,Book_Name,Penalty,Borrow_ID,Entry_Date) VALUES (@Student_ID,@Book_Name,@Penalty,@Borrow_ID,@today)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@today",
              today);
            cmd.Parameters.AddWithValue("@Book_Name",
            bookName);
            cmd.Parameters.AddWithValue("@Student_ID",
            studentID);
            cmd.Parameters.AddWithValue("@Borrow_ID",
            ID);
            cmd.Parameters.AddWithValue("@Penalty",
            val.ToString());
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();

            MessageBox.Show(i + " Row(s) Inserted ");



        }
        private void DisplayData()
        {
            DateTime dob = DateTime.Now;
            
            con.Open();
            DataTable dt = new DataTable();
            String s = "Issued";
            adapt = new SqlDataAdapter("SELECT * from Borrower where Return_Date <= GetDate() and Status = '"+s+"'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            bookid.Text = ID.ToString();
        }

        private void PenaltyReport_Load(object sender, EventArgs e)
        {

        }
    }
}
