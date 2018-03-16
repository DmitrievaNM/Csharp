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
    public partial class TableOfQuizesForm : Form
     
    {

        public TableOfQuizesForm()
        {
            InitializeComponent();
             
            
        }

        private void labelOverview_Click(object sender, EventArgs e)
        {
            Form form = new QuizOverview();
            form.Show();
            this.Hide();
        }


        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelEnvironment_Click(object sender, EventArgs e)
        {
            Form form = new QuizEnvironment();
            form.Show();
            this.Hide();
        }

        private void labelProgramStructure_Click(object sender, EventArgs e)
        {
            Form form = new QuizProgramStructure();
            form.Show();
            this.Hide();
        }

        private void labelBasicSyntax_Click(object sender, EventArgs e)
        {
            Form form = new QuizBasicSyntax();
            form.Show();
            this.Hide();
        }

        private void labelDecisionMaking_Click(object sender, EventArgs e)
        {
            Form form = new QuizDecisionMaking();
            form.Show();
            this.Hide();
        }

        private void TableOfContentsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new Contents();
            form.Show();
            this.Hide();
        }

        private void TableOfQuizesForm_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text = Program.username;
        }
    }
}
