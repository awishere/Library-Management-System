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
    public partial class Formloginfac : Form
    {
        public Formloginfac()
        {
            InitializeComponent();
        }
        public static string users = "";
        public static string userID = "";
        private void lgnbtn_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
            MyConnection.Open();
            SqlCommand cmd;
            cmd = MyConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT User_ID,Username,Password,Type from [dbo].[User]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int x = 0;
            String s = "";
            String usrID = "";
            foreach (DataRow dr in dt.Rows)
            {
                s = dr["Username"].ToString();
                String t = dr["Password"].ToString();
                String us = dr["Type"].ToString();
                usrID = dr["User_ID"].ToString();
                if (s == username.Text && t == password.Text && us == "admin")
                {
                    x = 1;
                    break;
                }
                else if (s == username.Text && t == password.Text && us == "staff")
                {
                    x = 2;
                    break;
                }

            }
            if (x == 1)
            {
                User u = new User();
                u.UserName = s;
                users = s;
                userID = usrID;
                // session["userName"] = u.UserName;
                MessageBox.Show("Welcome " + users);
                openchildform(new Formmain());
            }
            else if (x == 2)
            {
                User u = new User();
                u.UserName = s;
                users = s;
                userID = usrID;
                // session["userName"] = u.UserName;
                MessageBox.Show("Welcome " + users);
                openchildform(new Formstf());
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }
        private void openchildform(Form childform)
        {
            this.Hide();
            childform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            openchildform( new Formlogin());
        }

        private void signuplabel_Click(object sender, EventArgs e)
        {
            openchildform(new Formsignupfac());
        }
    }
}
