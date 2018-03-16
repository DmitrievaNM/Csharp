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

namespace CsharpBook
{
    public partial class Firstpage : Form
    {
        public Firstpage()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new TableOfQuizesForm().Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            new Contents().Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
