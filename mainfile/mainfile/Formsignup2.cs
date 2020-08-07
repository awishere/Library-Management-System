using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainfile
{
    public partial class Formsignupfac : Form
    {
        public Formsignupfac()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            openchildform(new Formloginstd()) ;
        }
        private void openchildform(Form childform)
        {
            this.Hide();
            childform.Show();
        }

        private void gobacklab_Click(object sender, EventArgs e)
        {
            openchildform(new Formloginfac());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openchildform(new Formloginfac());
        }
    }
}
