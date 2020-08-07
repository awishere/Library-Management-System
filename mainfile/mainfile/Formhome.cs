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
using System.Configuration;

namespace mainfile
{
    public partial class Formhome : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmds;
        SqlDataAdapter adapt;
        int ID = 0;
        public Formhome()
        {

            InitializeComponent();
            //DisplayData();
            
            //this.chart1.Series["MostIssuedBooks"].Points.AddXY("Science", 23);
            //this.chart2.Series["MostRecentBooks"].Points.AddXY("Oliver Twist", 33);
            //this.chart2.Series["MostRecentBooks"].Points.AddXY("Harry Potter", 23);
            //this.chart2.Series["MostRecentBooks"].Points.AddXY("Science", 23);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Formhome_Load(object sender, EventArgs e)
        {
            LoadData();
            chart2.Series["MostRecentBooks"].XValueMember = "Book_Name";
            chart2.Series["MostRecentBooks"].YValueMembers = "Quantity";
            chart1.Series["MostIssuedBooks"].XValueMember = "Book_Name";
            chart1.Series["MostIssuedBooks"].YValueMembers = "Total";
            
            //chart2.Series["MostRecentBooks"].Points.AddXY("Quantity","Book_Name");
            //chart2.Series["MostRecentBooks"]
            //  this.chart1.Series["MostIssuedBooks"].Points.AddXY("Harry Potter", 23);
        }

        private void LoadData()
        {
            chart1.DataSource = GetData();
            chart2.DataSource = GetsData();
        }
        private DataTable GetData()
        {
            DataTable dtChartData = new DataTable();

            using(SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True"))
            {
                using(SqlCommand cmd = new SqlCommand("pieChart", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtChartData.Load(reader);
                }
            }

            return dtChartData;
        }

        private DataTable GetsData()
        {
            DataTable dtChartData = new DataTable();

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("pieChart3", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtChartData.Load(reader);
                }
            }

            return dtChartData;
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Book", con);
            adapt.Fill(dt);
            chart1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chart1.Series.Add("Most Issued Books");
            //chart1.Series.Add("Most Read Books");
            //chart1.Series.Add("Most Viewed Books");
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
