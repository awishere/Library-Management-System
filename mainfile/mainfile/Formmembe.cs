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
    public partial class Formmembe : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");

        SqlCommand cmd;
        SqlCommand cmds;
        SqlDataAdapter adapt;
        int ID = 0;
        public Formmembe()
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
            openchildform(new Formaddstaff());
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
            panelstaf.Controls.Add(childform);
            panelstaf.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            username.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            name.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }
        private void DisplayData()
        {
            con.Open();
            String type = "staff";
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT User_ID,Username,Name FROM [dbo].[User] where Type='"+type+"'", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && name.Text != "")
            {
                cmd = new SqlCommand("update [dbo].[User] set Username=@username,  Name = @name where User_ID = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete [dbo].[User] where User_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
               // cmds.Parameters.AddWithValue("@id", ID);
                //cmds.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
               // ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void panelstaf_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
