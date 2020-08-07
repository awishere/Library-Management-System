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
    public class User
    {
        private String userName;

        public string UserName { get => userName; set => userName = value; }
    }


    public partial class formloginfac : Form
    {
        public formloginfac()
        {
            InitializeComponent();
        }
        public static string users = "";
        public static string userID = "";


        private void loginbtnfac_Click(object sender, EventArgs e)
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
                MessageBox.Show(users);
                openchildform(new Formmain());
            }
            else if (x == 2)
            {
                User u = new User();
                u.UserName = s;
                users = s;
                userID = usrID;
                // session["userName"] = u.UserName;
                MessageBox.Show(users);
                openchildform(new formmainstaff());
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void signuplabel2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void formloginfac_Load(object sender, EventArgs e)
        {
            
        }
    }
}
