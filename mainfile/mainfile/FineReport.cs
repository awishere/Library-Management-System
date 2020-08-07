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
    public partial class FineReport : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmds;
        SqlDataAdapter adapt;
        int ID = 0;
        public FineReport()
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

        private void FineReport_Load(object sender, EventArgs e)
        {

        }
        private void DisplayData()
        {
            DateTime dob = DateTime.Now;

            con.Open();
            DataTable dt = new DataTable();
            String s = "Issued";
            adapt = new SqlDataAdapter("SELECT p.Penalty_ID,b.Student_ID,b.Book_Name,p.Detail,p.Penalty,b.Status,b.Borrow_ID from Penalty p, Borrower b where p.Student_ID = b.Student_ID and b.Book_Name = p.Book_Name and b.Status = '"+s+"'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            penaltyid.Text = ID.ToString();
            status.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            borrowid.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (penaltyid.Text != "" && status.Text != "")
            {
                int borrow = Int32.Parse(borrowid.Text);
                cmd = new SqlCommand("update Borrower set Status = @Status where Borrow_ID = @Borrow_ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                
                cmd.Parameters.AddWithValue("@Borrow_ID", borrow.ToString());
                cmd.Parameters.AddWithValue("@status", status.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                //ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void borrowid_TextChanged(object sender, EventArgs e)
        {
            borrowid.Hide();
        }
    }
}
