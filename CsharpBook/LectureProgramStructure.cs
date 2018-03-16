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
    public partial class LectureProgramStructure : Form
    {
        public LectureProgramStructure()
        {
            InitializeComponent();
        }

        private void LectureProgramStructure_Load(object sender, EventArgs e)
        {

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
            //Opening Quiz Program Structure
            Form form = new QuizProgramStructure();
            form.Show();
            this.Hide();
        }
    }
}
