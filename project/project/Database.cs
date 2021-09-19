using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class Database : Form
    {
        private bool button1WasClicked = false;
        public Database()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(130, Color.White);
            panel3.BackColor = Color.FromArgb(130, Color.White);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Page adm_page = new Admin_Page();
            this.Hide();
            adm_page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Desktop\new\SystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            string passport_ID = IdTobeDeletetxt.Text;

            string del = "DELETE FROM personal_details where passport_ID='" + passport_ID + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            button1WasClicked = true;
            string message = "Do you need to delete this row from the table?";
            string title = "Verification window";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Desktop\new\SystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "select * from personal_details";

            SqlDataAdapter da = new SqlDataAdapter(qry,ConString);
            DataSet ds = new DataSet();

            da.Fill(ds, "personal_details");
            dataGridView1.DataSource = ds.Tables["personal_details"];

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Desktop\new\SystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
           
            string del = "DELETE FROM personal_details";
            SqlCommand cmd = new SqlCommand(del, con);


            button1WasClicked = true;
            string message = "Do you need to delete all data from the table?";
            string title = "Delete verification";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
             
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {

            }

           

        }
    }
}
