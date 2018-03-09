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




        public static object ConfiguratioManager { get; private set; }

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
            String dbString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Cssharpdatabase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(dbString);

            con.Open();
            String sqlQuery = "INSERT INTO Csharpusers VALUES('" + firstnametxtbx.Text + "','" + lastnametxtbx.Text + "', '" + emailaddresstxtbx.Text + "')";

            SqlCommand com = new SqlCommand(sqlQuery,con);
            if (com.ExecuteNonQuery()==1)

            

            MessageBox.Show("UserControl Added Successfully");

            con.Close();
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
            new Firstpage().Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            new Firstpage().Show();
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

        private void countrycombobx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
