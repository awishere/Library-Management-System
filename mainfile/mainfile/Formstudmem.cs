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
    public partial class Formstudmem : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public Formstudmem()
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
            openchildform(new Formaddstd());
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
            panelstd.Controls.Add(childform);
            panelstd.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void ClearData()
        {
            name.Text = "";
            email.Text = "";
            password.Text = "";
            address.Text = "";
            semester.Text = "";
            ID = 0;
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Student", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void panelstd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            name.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            username.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            email.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            password.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            address.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            semester.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && email.Text != "" && password.Text != "" && address.Text != "" && semester.Text != "")
            {
                cmd = new SqlCommand("update Student set UserName = @Username,Name=@name, Email = @email, Password = @password, Address = @address, Semester = @semester where Student_ID = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@Username", username.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@semester", semester.Text);
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SqlCommand command = new SqlCommand("DelStud", con);
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", ID);
                command.Parameters.AddWithValue("@name", name.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.Parameters.AddWithValue("@password", password.Text);
                command.Parameters.AddWithValue("@address", address.Text);
                command.Parameters.AddWithValue("@semester", semester.Text);
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

        private void Formstudmem_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openchildform(new Formaddstd());
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            name.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            username.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            email.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            password.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            address.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            semester.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            if (name.Text != "" && email.Text != "" && password.Text != "" && address.Text != "" && semester.Text != "")
            {
                cmd = new SqlCommand("update Student set UserName = @Username,Name=@name, Email = @email, Password = @password, Address = @address, Semester = @semester where Student_ID = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@Username", username.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@semester", semester.Text);
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

        private void delete_Click_1(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SqlCommand command = new SqlCommand("DelStud", con);
                con.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", ID);
                command.Parameters.AddWithValue("@name", name.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.Parameters.AddWithValue("@password", password.Text);
                command.Parameters.AddWithValue("@address", address.Text);
                command.Parameters.AddWithValue("@semester", semester.Text);
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelstd_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
