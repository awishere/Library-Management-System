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
    public partial class Formloginstd : Form
    {
        public Formloginstd()
        {
            InitializeComponent();
        }
        public static string users = "";
        public static string userid = "";
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void signuplabel_Click(object sender, EventArgs e)
        {
            openchildform(new Formsignup());
            
        }
        private void openchildform(Form childform)
        {
            this.Hide();
            childform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
            MyConnection.Open();
            SqlCommand cmd;
            SqlCommand cmds;
            cmd = MyConnection.CreateCommand();
            
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "SELECT u.Username,u.Password,u.Type,s.Student_ID from [dbo].[User] u, Student s where u.Username = S.UserName";
            
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int x = 0;
            String s = "";
            String ids = "";
            foreach (DataRow dr in dt.Rows)
            {
                s = dr["Username"].ToString();
                ids = dr["Student_ID"].ToString();
                String t = dr["Password"].ToString();
                String u = dr["Type"].ToString();
                if (s == username.Text && t == password.Text && u == "student")
                {
                    x = 1;
                    break;
                }
            }
            if (x == 1)
            {
                users = s;
                userid = ids;
                MessageBox.Show("Welcome "+users);
                openchildform(new FormStudentmain());
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void Formloginstd_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            openchildform(new Formlogin());
        }
    }
}
