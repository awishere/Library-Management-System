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
    public partial class Formaddbookcat : Form
    {
        public Formaddbookcat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");

            
            MyConnection.Open();
            SqlCommand cmd;
            cmd = MyConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Category_Name from Category";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int x = 0;
            foreach (DataRow dr in dt.Rows)
            {
               String s =  dr["Category_Name"].ToString();
                if(s == category.Text)
                {
                    x = 1;
                    
                }
            }
            if (x == 1)
            {
                MessageBox.Show("Already Available in Table");
            }
            else if(x == 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");

                con.Open();

                SqlCommand command = new SqlCommand("InsertBookCat", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cat", SqlDbType.VarChar).Value = category.Text.Trim();
                int i = command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(i + " Row(s) Inserted ");

            }
        }
    }
}
