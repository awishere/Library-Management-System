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
using System.Text.RegularExpressions;
namespace mainfile
{
    public partial class Formaddmain : Form
    {
        public Formaddmain()
        {
            InitializeComponent();
            SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");

            category.Items.Clear();
            MyConnection.Open();
            SqlCommand cmd;
            cmd = MyConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Category_Name from Category";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                category.Items.Add(dr["Category_Name"].ToString());
            }

           // dept.Items.Clear();
            
            SqlCommand cmds;
            cmds = MyConnection.CreateCommand();
            cmds.CommandType = CommandType.Text;
            cmds.CommandText = "SELECT Dept_Name from Department";
            cmds.ExecuteNonQuery();
            DataTable dts = new DataTable();
            SqlDataAdapter das = new SqlDataAdapter(cmds);
            das.Fill(dts);

            foreach (DataRow drs in dts.Rows)
            {
               // dept.Items.Add(drs["Dept_Name"].ToString());
            }
            MyConnection.Close();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isbn.Text == "" || bookName.Text == "" || title.Text == "" || author.Text == "" || category.Text == "" || publisher.Text == "" || quantity.Text == "")
                {

                    MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isbn.Focus();
                    return;
                }

                if (!Regex.Match(isbn.Text, "^[0-9][0-9]*$").Success)
                {

                    MessageBox.Show("Invalid ISBN", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isbn.Focus();
                    return;
                }
                if (!Regex.Match(bookName.Text, "^[A-Za-z][a-zA-Z]*$").Success)
                {

                    MessageBox.Show("Invalid bookname", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bookName.Focus();
                    return;
                }

                if (!Regex.Match(title.Text, "^[A-Za-z][a-zA-Z]*$").Success)
                {

                    MessageBox.Show("Invalid title", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    title.Focus();
                    return;
                }
                if (!Regex.Match(author.Text, "^[A-Za-z][a-zA-Z]*$").Success)
                {

                    MessageBox.Show("Invalid author", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    author.Focus();
                    return;
                }
                if (!Regex.Match(publisher.Text, "^[A-Za-z][a-zA-Z]*$").Success)
                {

                    MessageBox.Show("Invalid publisher", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    publisher.Focus();
                    return;
                }
                //if (!Regex.Match(password.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$").Success)
                //{

                //    MessageBox.Show("Invalid Password, Password must contain an upper case letter, number and a special character", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    password.Focus();
                //    return;
                //}

                if (!Regex.Match(quantity.Text, @"^([1-8])$").Success)
                {

                    MessageBox.Show("Invalid Quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantity.Focus();
                    return;
                }

                SqlConnection MyConnection = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=LMS;Integrated Security=True");
                MyConnection.Open();

                SqlCommand command = new SqlCommand("AddBook", MyConnection);
                DateTime today = DateTime.Today;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@isbn", SqlDbType.VarChar).Value = isbn.Text.Trim();
                command.Parameters.AddWithValue("@author", SqlDbType.VarChar).Value = author.Text.Trim();
                command.Parameters.AddWithValue("@title", SqlDbType.VarChar).Value = title.Text.Trim();
                command.Parameters.AddWithValue("@publisher", SqlDbType.VarChar).Value = publisher.Text.Trim();
                command.Parameters.AddWithValue("@quantity", SqlDbType.VarChar).Value = quantity.Text.Trim();
                command.Parameters.AddWithValue("@entrydate", SqlDbType.VarChar).Value = DateTime.Now;
                command.Parameters.AddWithValue("@catname", SqlDbType.VarChar).Value = category.Text.Trim();
                command.Parameters.AddWithValue("@name", SqlDbType.NChar).Value = bookName.Text.Trim();
                command.Parameters.AddWithValue("@image", GetImageData());
                int i = command.ExecuteNonQuery();
                MyConnection.Close();
                MessageBox.Show(i + " Row(s) Inserted ");
                this.Close();
            }
            catch(Exception ex)
            {
                
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }
        public byte[] GetImageData()
        {
            FileStream fsImageStream = new FileStream(openFileDialog1.FileName,
            FileMode.Open, FileAccess.Read);
            byte[] bImageData = new byte[fsImageStream.Length];
            fsImageStream.Read(bImageData, 0,
            System.Convert.ToInt32(fsImageStream.Length));
            fsImageStream.Close();
            return bImageData;
        }
        public void BindData()
        {
            try
            {
                DataTable dtData = new System.Data.DataTable();

                using (SqlConnection dbCon = new SqlConnection(@"Data Source=DESKTOP-S9RU5TT\USMAN;Initial Catalog=Lab11;Integrated Security=True"))

                {
                    using (SqlCommand cmdGetData = new SqlCommand("SELECT TOP 4 * FROM Book", dbCon))
                    {
                        if (dbCon.State == ConnectionState.Closed)
                            dbCon.Open();
                        using (SqlDataReader drGetData = cmdGetData.ExecuteReader())
                        {
                            dtData.Load(drGetData);
                            for (int iCount = 0; iCount < dtData.Rows.Count; iCount++)
                            {
                                
                                byte[] storedImage = (byte[])dtData.Rows[iCount]["Image"];
                                Image newImage;
                                MemoryStream stream = new MemoryStream(storedImage);

                                newImage = Image.FromStream(stream);
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
