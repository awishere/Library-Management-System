using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace mainfile
{
    public partial class Formsignup : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Formsignup()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            try
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
                SqlCommand cmd;
                
                String s = "INSERT INTO Student (UserName,Name,Email,Password,Address,Semester) VALUES (@UserName,@Name,@Email,@Password,@Address,@Semester)";
                cmd = new SqlCommand(s, MyConnection);
                cmd.Parameters.AddWithValue("@UserName",
                username.Text);
                
                cmd.Parameters.AddWithValue("@Name",
                name.Text);
                cmd.Parameters.AddWithValue("@Email",
                email.Text);
                cmd.Parameters.AddWithValue("@Password",
                password.Text);
                cmd.Parameters.AddWithValue("@Address",
                address.Text);           
                cmd.Parameters.AddWithValue("@Semester",
                semester.Text);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                MyConnection.Close();
                MessageBox.Show("You have been registered! ");
                openchildform(new Formloginstd());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username already registered!");
            }
            String s1 = "student";
            SqlConnection MyConnections = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
            MyConnections.Open();
            SqlCommand cmds;
           
            String ss = "INSERT INTO [dbo].[User] (UserName,Name,Password,Type) VALUES (@UserName,@Name,@Password,@Type)";
            cmds = new SqlCommand(ss, MyConnections);
            cmds.Parameters.AddWithValue("@UserName",
            username.Text);
            cmds.Parameters.AddWithValue("@Type",
            s1);
            cmds.Parameters.AddWithValue("@Name",
            name.Text);
            
            cmds.Parameters.AddWithValue("@Password",
            password.Text);
            
            cmds.CommandType = CommandType.Text;
            int j = cmds.ExecuteNonQuery();
            MyConnections.Close();
            

        }
        private void openchildform(Form childform)
        {
            this.Hide();
            childform.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gobacklab_Click(object sender, EventArgs e)
        {
            openchildform(new Formloginstd());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Formsignup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openchildform(new Formloginstd());
        }
    }
}
