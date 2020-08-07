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
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
            customisedropdown();
        }
        private void customisedropdown()
        {
            panelmem.Visible = false;
            panelbook.Visible = false;
        }
        private void hidedropdown()
        {
            if (panelmem.Visible == true)
                panelmem.Visible = false;
            if (panelbook.Visible == true)
                panelbook.Visible = false;     
        }
        private void showdropdown(Panel dropdown)
        {
            if (dropdown.Visible == false)
            {
                hidedropdown();
                dropdown.Visible = true;
            }
            else
                dropdown.Visible = false;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Membtn_Click(object sender, EventArgs e)
        {
            showdropdown(panelmem);

        }

        private void Stdbtn_Click(object sender, EventArgs e)
        {
            openchildform(new Formstudmem());
            hidedropdown();
        }

        private void staffbtn_Click(object sender, EventArgs e)
        {
            openchildform(new Formmembe());
            hidedropdown();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            openchildform(new Formcatsearch());
            hidedropdown();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            openchildform(new Formaddbook());
            hidedropdown();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            hidedropdown();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            hidedropdown();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showdropdown(panelbook);
        }
        private Form activeForm = null;
        private void openchildform(Form childform)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childform);
            panelChildform.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void abtbtn_Click(object sender, EventArgs e)
        {
           // openchildform(new Formabout());
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {

            openchildform(new Formhome());
        }

        private void panelchildform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Formmain_Load(object sender, EventArgs e)
        {
            openchildform(new Formhome());
        }

        private void issuedBooks_Click(object sender, EventArgs e)
        {
            openchildform(new FormIssuedBooks());
        }

        private void Penalty_Click(object sender, EventArgs e)
        {
            openchildform(new PenaltyReport());
        }

        private void finereport_Click(object sender, EventArgs e)
        {
            openchildform(new FineReport());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            openchildform(new Formhome());
        }

        private void panellogo_Paint(object sender, PaintEventArgs e)
        {
            openchildform(new Formhome());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildform_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
