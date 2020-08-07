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
    public partial class formmainstaff : Form
    {
        public formmainstaff()
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

        private void Stdbtn_Click(object sender, EventArgs e)
        {
            openchildform(new Formstudmem());
        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            showdropdown(panelbook);
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

        private void panelchildform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new Formstudmem());
        }

        private void booksIssued_Click(object sender, EventArgs e)
        {
            openchildform(new FormIssuedBooks());
        }

        private void penalty_Click(object sender, EventArgs e)
        {
            openchildform(new PenaltyReport());
        }

        private void fineReport_Click(object sender, EventArgs e)
        {
            openchildform(new FineReport());
        }
    }
}
