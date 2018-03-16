using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpBook
{
    public partial class Contents : Form
    {
        public Contents()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //This code is written by : Piumi
            //Opening first page 
            Form form = new Firstpage();
            form.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //This code is written by : Piumi
            //Opening first page 
            Form form = new TableOfQuizesForm();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            //This code is written by : Piumi
            //Opening Lecture Overview 
        }
    }
}
