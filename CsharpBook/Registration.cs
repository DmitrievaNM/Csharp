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

namespace CsharpBook
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("INSERT INTO Csharpusers (First Name, Last Name, Email Address, Gender, Country, Contact Number, Subscriptions, Terms And Conditions) Values (@First Name, @Last Name, @Email Address, @Gender, @Country, @Contact Number, @Subscriptions, @Terms And Conditions  )", conn);
           
            cmd.Parameters.AddWithValue("@First Name", firstnametxtbx.Text);
            cmd.Parameters.AddWithValue("@Last Name", lastnametxtbx.Text);
            cmd.Parameters.AddWithValue("@Email Address", emailaddresstxtbx.Text);
            cmd.Parameters.AddWithValue("@Country", countrytxtbx.Text);
            cmd.Parameters.AddWithValue("@Contact Number", contactnumbertxtbx.Text);
       

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                label6.ForeColor = System.Drawing.Color.Red;
                label6.Text = "successfully added!";
            }
            conn.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            new QuizeForm1();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void contactnumberstarlbl_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void firstnametxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new QuizeForm1();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
