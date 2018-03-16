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
    public partial class LectureBasicSyntax : Form
    {
        public LectureBasicSyntax()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //This code is written by : Piumi
            //Opening Table of contents
            Form form = new Contents();
            form.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //This code is written by : Piumi
            //Opening Quiz Basic Syntax
            Form form = new QuizBasicSyntax();
            form.Show();
            this.Hide();
        }
    }
}
