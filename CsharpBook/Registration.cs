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
using System.Text.RegularExpressions;



namespace CsharpBook
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            passstxtbx.PasswordChar = '*';
            confirmpwtxtbx.PasswordChar = '*';

        }
        

        
        string Gender;
        public static object ConfiguratioManager { get; private set; }
        public object ID { get; private set; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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



        private void registerbttn_Click(object sender, EventArgs e)
        {

            
        }

        private void femaleradiobtn_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Maleradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void confirmpwtxtbx_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void Usernametxtbx_TextChanged_1(object sender, EventArgs e)
        {
            String dbString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Cssharpdatabase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(dbString);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM [Csharpusers] WHERE Username=@Username";
            cmd.Parameters.AddWithValue("@Username", this.Usernametxtbx.Text);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Username Already exist";
                }

                else
                {
                    label6.ForeColor = Color.Green;
                    label6.Text = "Username available";


                }
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emailaddresstxtbx_TextChanged(object sender, EventArgs e)
        {

        }



        private void femaleradiobtn_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void emailaddresstxtbx_TextChanged_1(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(emailaddresstxtbx.Text, pattern))
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Email Address is correct";

            }

            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Please enter a valid Email Address";

            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void confirmpwtxtbx_TextChanged_1(object sender, EventArgs e)
        {
            if (passstxtbx.Text == confirmpwtxtbx.Text)
            {
                label2.ForeColor = Color.Green;
                label2.Text = "Both Passwords are same";
            }
            else

            {
                label2.ForeColor = Color.Red;
                label2.Text = "Both passwords should be same";

            }
        }

        private void registerbttn_Click_1(object sender, EventArgs e)
        {
            String dbString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Cssharpdatabase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(dbString);

            con.Open();
            String sqlQuery = "INSERT INTO Csharpusers VALUES('" + firstnametxtbx.Text + "', '" + lastnametxtbx.Text + "', '" + Usernametxtbx.Text + "', '" + Gender + "', '" + emailaddresstxtbx.Text + "', '" + passstxtbx.Text + "', '" + confirmpwtxtbx.Text + "')";

            SqlCommand com = new SqlCommand(sqlQuery, con);
            if (com.ExecuteNonQuery() == 1)



                MessageBox.Show("User Registerd Successfully");

            con.Close();
        }

        private void updatebttn_Click(object sender, EventArgs e)
        {

            {
                String dbString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Cssharpdatabase.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(dbString);
                con.Open();

                SqlCommand cmd = new SqlCommand("Update Csharpusers Set First Name=@First Name, Last Name=@Last Name, Username=@Username, Gender=@Gender, Email Address=@Email Address, Password=@Password, Confirm Password=@Confirm Password", con);


                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Parameters.AddWithValue("@Last name", lastnametxtbx.Text);
                cmd.Parameters.AddWithValue("@Username", Usernametxtbx.Text);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Email Address", emailaddresstxtbx.Text);
                cmd.Parameters.AddWithValue("@Password", passstxtbx.Text);
                cmd.Parameters.AddWithValue("@Confirm Password", confirmpwtxtbx.Text);


                if (cmd.ExecuteNonQuery() == 1)

                {
                    label14.ForeColor = Color.Green;
                    label14.Text = "Successfully Updated";

                }

                else
                {
                    label14.ForeColor = Color.Red;
                    label14.Text = "Invalid username";
                }
                con.Close();



            }
        

        }

        private void Maleradiobtn_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Male";
        }
    }

}









