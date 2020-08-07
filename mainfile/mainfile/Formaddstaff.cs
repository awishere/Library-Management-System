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
    public partial class Formaddstaff : Form
    {
        public Formaddstaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (name.Text == "" || username.Text == "" || password.Text == "")
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
            SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");

            MyConnection.Open();
            String type = "staff";
            SqlCommand cmd;

            String s = "INSERT INTO [dbo].[User] (UserName,Name,Password,Type) VALUES (@UserName,@Name,@Password,@Type)";
            cmd = new SqlCommand(s, MyConnection);
            cmd.Parameters.AddWithValue("@Name",
            name.Text);
            cmd.Parameters.AddWithValue("@UserName",
            username.Text);
            cmd.Parameters.AddWithValue("@Password",
            passwords.Text);
            cmd.Parameters.AddWithValue("@Type",
            type);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            MyConnection.Close();
            MessageBox.Show(i + " Row(s) Inserted ");
        }
    }
}
