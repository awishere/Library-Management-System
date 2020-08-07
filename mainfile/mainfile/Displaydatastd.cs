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
using System.IO;

namespace mainfile
{
    public partial class Displaydatastd : Form
    {
        public Displaydatastd()
        {
            InitializeComponent();
            DisplayData();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;

        }
    
        public static string bookID = "";
        public static string bookName = "";
        public static string bookAuthor = "";
        public static string bookTitle = "";
        public static string bookQuantity = "";
        public static string publisher = "";
        public static string category = "";
        public static string image = "";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        private void opanchildform(Form childform)
        {

            childform.BringToFront();
            childform.Show();
        }
     

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        

        private void panelchildform_Paint(object sender, PaintEventArgs e)
        {

        }



        void DisplayData()
        {
            String query = "SELECT * FROM Book";

            cmd = new SqlCommand(query, con);

            adapt = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapt.Fill(table);
            byte[] img = (byte[])table.Rows[0][9];

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            //bookName = table.Rows[0][1].ToString();
            //bookAuthor = table.Rows[0][2].ToString();
            //bookQuantity = table.Rows[0][5].ToString();
            //publisher = table.Rows[0][4].ToString();



            adapt.Dispose();

            adapt = new SqlDataAdapter(cmd);

            DataTable tables = new DataTable();

            adapt.Fill(tables);

            byte[] imgs = (byte[])table.Rows[1][9];

            MemoryStream msi = new MemoryStream(imgs);

            pictureBox2.Image = Image.FromStream(msi);
            bookID = tables.Rows[1][0].ToString();
            bookName = tables.Rows[1][1].ToString();
            bookAuthor = tables.Rows[1][2].ToString();
            bookQuantity = tables.Rows[1][5].ToString();
            publisher = tables.Rows[1][4].ToString();


            adapt.Dispose();

            adapt = new SqlDataAdapter(cmd);

            DataTable table3 = new DataTable();

            adapt.Fill(table);

            byte[] imgs3 = (byte[])table.Rows[2][9];

            MemoryStream ms3 = new MemoryStream(imgs3);

            pictureBox3.Image = Image.FromStream(ms3);

            //bookName = table.Rows[2][1].ToString();
            //bookAuthor = table.Rows[2][2].ToString();
            //bookQuantity = table.Rows[2][5].ToString();
            //publisher = table.Rows[2][4].ToString();

            adapt.Dispose();

            adapt = new SqlDataAdapter(cmd);

            DataTable table4 = new DataTable();

            adapt.Fill(table);

            byte[] imgs4 = (byte[])table.Rows[3][9];

            MemoryStream ms4 = new MemoryStream(imgs4);

            pictureBox4.Image = Image.FromStream(ms4);

            //bookName = table.Rows[3][1].ToString();
            //bookAuthor = table.Rows[3][2].ToString();
            //bookQuantity = table.Rows[4][5].ToString();
            //publisher = table.Rows[4][4].ToString();

            adapt.Dispose();

            adapt = new SqlDataAdapter(cmd);

            DataTable table5 = new DataTable();

            adapt.Fill(table);

            byte[] imgs5 = (byte[])table.Rows[4][9];

            MemoryStream ms5 = new MemoryStream(imgs5);

            pictureBox5.Image = Image.FromStream(ms5);
            //bookName = table.Rows[5][1].ToString();
            //bookAuthor = table.Rows[5][2].ToString();
            //bookQuantity = table.Rows[5][5].ToString();
            //publisher = table.Rows[5][4].ToString();

            adapt.Dispose();

            adapt = new SqlDataAdapter(cmd);

            DataTable table6 = new DataTable();

            adapt.Fill(table);

            byte[] imgs6 = (byte[])table.Rows[5][9];

            MemoryStream ms6 = new MemoryStream(imgs6);

            pictureBox6.Image = Image.FromStream(ms6);
            //bookName = table.Rows[6][1].ToString();
            //bookAuthor = table.Rows[6][2].ToString();
            //bookQuantity = table.Rows[6][5].ToString();
            //publisher = table.Rows[6][4].ToString();

            adapt.Dispose();
            adapt = new SqlDataAdapter(cmd);

            DataTable table7 = new DataTable();

            adapt.Fill(table);

            //byte[] imgs7 = (byte[])table.Rows[7][9];

            //MemoryStream ms7= new MemoryStream(imgs7);

            // pictureBox7.Image = Image.FromStream(ms7);
            //bookName = table.Rows[7][1].ToString();
            //bookAuthor = table.Rows[7][2].ToString();
            //bookQuantity = table.Rows[7][5].ToString();
            //publisher = table.Rows[7][4].ToString();

            adapt.Dispose();
            con.Close();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());

        }

     

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            opanchildform(new FormStudentmain());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void Displaydatastd_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            opanchildform(new Formstdissue());
        }
    }

  
    }

