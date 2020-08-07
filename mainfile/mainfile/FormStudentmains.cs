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
    public partial class FormStudentmain : Form
    {
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
        public FormStudentmain()
        {
            InitializeComponent();
          
      
            
        }
        private Form activeForm = null;
        private void openchildform(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(childform);
            panelchildform.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void opanchildform(Form childform)
        {
            
            childform.BringToFront();
            childform.Show();
        }
        private void btnhome_MouseHover(object sender, EventArgs e)
        {
            btnhome.FlatAppearance.BorderSize = 1;
            btnhome.FlatAppearance.BorderColor = Color.Aqua;
        }

        private void btnhome_MouseLeave(object sender, EventArgs e)
        {
            btnhome.FlatAppearance.BorderSize = 0;
            btnhome.FlatAppearance.BorderColor = DefaultBackColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            openchildform(new Formbookissuestd());
        }

        private void panelchildform_Paint(object sender, PaintEventArgs e)
        {

        }
        


        
        

        private void issuedBooks_Click(object sender, EventArgs e)
        {
            openchildform(new TotalBooksIssuedByStudent()); 
        }

        private void btnhome_Click(object sender, EventArgs e)
        {

            openchildform(new Displaydatastd());
        }

        private void FormStudentmain_Load(object sender, EventArgs e)
        {
            openchildform(new Displaydatastd());
        }

        private void X_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
    
}
