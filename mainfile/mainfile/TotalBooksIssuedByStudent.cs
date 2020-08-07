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
    public partial class TotalBooksIssuedByStudent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        public TotalBooksIssuedByStudent()
        {
            InitializeComponent();
            idss.Text = Formloginstd.userid;
            DisplayData();
        }

        private void TotalBooksIssuedByStudent_Load(object sender, EventArgs e)
        {

        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            int y = Int32.Parse(idss.Text);
            adapt = new SqlDataAdapter("SELECT * FROM Borrower where Student_ID = '"+y+"'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void idss_TextChanged(object sender, EventArgs e)
        {
            idss.Hide();
        }
    }
}
