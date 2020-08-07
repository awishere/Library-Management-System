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
    public partial class Formcatsearch : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public Formcatsearch()
        {
            InitializeComponent();
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DisplayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildform(new Formaddbookcat());
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
            panelcat.Controls.Add(childform);
            panelcat.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Category WHERE Category_Name = '" + search.Text + "'", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SqlCommand command = new SqlCommand("DelCat", con);
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id.Text);
                command.Parameters.AddWithValue("@name", name.Text);
                command.ExecuteNonQuery();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            id.Text = ID.ToString();
            name.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();               
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && name.Text != "")
            {
                cmd = new SqlCommand("update Category set Category_Name=@name where Category_ID = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", name.Text);
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
            id.Text = "";
            name.Text = "";
            ID = 0;
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Category", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
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

        private void panelcat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
