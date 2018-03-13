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
    public partial class QuizeForm1 : Form
    {
        public QuizeForm1()
        {
            InitializeComponent();
        }

        //private SqlConnection conn;
        //private SqlCommand cmd;
        //string connstr = Properties.Settings.Default.MyConnection;

        //Get all elements of one type
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //Counter for quiz score
            int score = 0;

            //Cheking answer for Question1
            if (radioButton1Q1.Checked) label1Answer1Q1.Text = "Wrong answer!";
            else
            {
                if (radioButton2Q1.Checked) label2Answer2Q1.Text = "Wrong answer!";
                else
                {
                    if (radioButton3Q1.Checked)
                    {
                        label3Answer3Q1.Text = "Correct answer!";

                        //Counting rieght answers;
                        score++;
                    }

                }
            }

            //Cheking answer for Question2
            if (radioButton1Q2.Checked)
            {
                label1Answer1Q2.Text = "Correct answer!";
                //Counting rieght answers;
                score++;
            }

            else
            {
                if (radioButton2Q2.Checked) label2Answer2Q2.Text = "Wrong answer!";
                else
                {
                    if (radioButton3Q2.Checked) label3Answer3Q2.Text = "Wrong answer!";
                }
            }

            //Cheking answer for Question3
            if (radioButton1Q3.Checked)
            {
                label1Answer1Q2.Text = "Correct answer!";
                //Counting rieght answers;
                score++;
            }

            else
            {
                if (radioButton2Q3.Checked) label2Answer2Q2.Text = "Wrong answer!";
                else
                {
                    if (radioButton3Q3.Checked) label3Answer3Q2.Text = "Wrong answer!";
                }
            }

            //Show user score
            textBoxScore.Text = "  " + score + "/5";

            //Write douwn information about user, date and score of quiz to database

            /*
            DateTime currentDate = new DateTime();

            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("INSERT INTO score (Name, Date, Score) VALUES (@Name, @Date, @Score) ", conn);

            cmd.Parameters.AddWithValue("@Name", textBoxUserName.Text);
            cmd.Parameters.AddWithValue("@Date", currentDate);
            cmd.Parameters.AddWithValue("@Score", textBoxScore.Text);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                labelAttempted.Text = "Attempted!";
            }
            conn.Close();

            */

        }

        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            //Clearing All radioButtons on the page
            var cntls = GetAll(this, typeof(RadioButton));
            var lblls = GetAll(this, typeof(Label));
            foreach (Control cntrl in cntls)
            {
                RadioButton _rb = (RadioButton)cntrl;
                if (_rb.Checked)
                {
                    _rb.Checked = false;

                }
            }

            foreach (Control lbll in lblls)
            {
                Label lb = (Label)lbll;
                if (lb.Text == "Wrong answer!" || lb.Text == "Correct answer!")
                {
                    lb.Text = "";
                }
            }

            //Clear score
            textBoxScore.Text = "";
        }

        private void TableOfQuizesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Opening form with table of quizes
            Form form = new TableOfQuizesForm();
            form.Show();
            this.Hide();
        }
    }
}
