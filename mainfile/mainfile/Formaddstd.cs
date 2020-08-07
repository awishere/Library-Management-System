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
using System.Text.RegularExpressions;
namespace mainfile
{
    public partial class Formaddstd : Form
    {
        public Formaddstd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || email.Text == "" || address.Text == "" || password.Text == "" || semester.Text == "")
            {

                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name.Focus();
                return;
            }

            if (!Regex.Match(name.Text, "^[A-Z][a-zA-Z]*$").Success)
            {

                MessageBox.Show("Invalid name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name.Focus();
                return;
            }

            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(email.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.Focus();
                return;
            }

            if (!Regex.Match(address.Text, @"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$").Success)
            {

                MessageBox.Show("Invalid address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                address.Focus();
                return;
            }

            //if (!Regex.Match(password.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$").Success)
            //{

            //    MessageBox.Show("Invalid Password, Password must contain an upper case letter, number and a special character", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    password.Focus();
            //    return;
            //}

            if (!Regex.Match(semester.Text, @"^([1-8])$").Success)
            {

                MessageBox.Show("Invalid Semester", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                semester.Focus();
                return;
            }


            SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
                MyConnection.Open();
                SqlCommand command = new SqlCommand("[dbo].[AddStuds]", MyConnection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@uname", SqlDbType.VarChar).Value = username.Text.Trim();

                command.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email.Text.Trim();
                command.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = password.Text.Trim();
                command.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = address.Text.Trim();
                command.Parameters.AddWithValue("@semester", SqlDbType.SmallInt).Value = semester.Text.Trim();
                command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = name.Text.Trim();
                int i = command.ExecuteNonQuery();
                MyConnection.Close();
                MessageBox.Show(i + " Row(s) Inserted ");
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
