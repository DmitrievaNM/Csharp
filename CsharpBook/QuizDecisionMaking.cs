﻿using System;
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
    public partial class QuizDecisionMaking : Form
    {
        public QuizDecisionMaking()
        {
            InitializeComponent();
        }
        //This code is written by : Natalia
        //Method for finding all elements of one type
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrls => GetAll(ctrls, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void TableOfQuizesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //This code is written by : Natalia
            //Opening form with table of quizes
            Form form = new TableOfQuizesForm();
            form.Show();
            this.Hide();
        }

        private void TableOfContentsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //This code is written by : Natalia
            //Opening form with table of contents
            Form form = new Contents();
            form.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //This code is written by : Natalia
            //Opening form with table of contents
            Form form = new Contents();
            form.Show();
            this.Hide();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //This code is written by : Natalia
            //Counter for quiz score
            int score = 0;

            //Cheking answer for Question1
            if (radioButton1Q1.Checked) Q1label1Answer1.Text = "Wrong answer!";
            else
            {
                if (radioButton2Q1.Checked) Q1label2Answer2.Text = "Wrong answer!";
                else
                {
                    if (radioButton3Q1.Checked)
                    {
                        Q1label3Answer3.Text = "Correct answer!";

                        //Counting right answers;
                        score++;
                    }

                }
            }

            //Cheking answer for Question2
            if (radioButton1Q2.Checked)
            {
                Q2label1Answer1.Text = "Correct answer!";
                //Counting right answers;
                score++;
            }

            else
            {
                if (radioButton2Q2.Checked) Q2label2Answer2.Text = "Wrong answer!";
                else
                {
                    if (radioButton3Q2.Checked) Q2label3Answer3.Text = "Wrong answer!";
                }
            }

            //Cheking answer for Question3
            if (radioButton1Q3.Checked)
            {
                Q3label1Answer1.Text = "Correct answer!";
                //Counting right answers;
                score++;
            }

            else
            {
                if (radioButton2Q3.Checked) Q3label2Answer2.Text = "Wrong answer!";
                else
                {
                    if (radioButton3Q3.Checked) Q3label3Answer3.Text = "Wrong answer!";
                }
            }

            // Cheking answer for Question4
            if (radioButton1Q4.Checked)
            {
                Q4label1Answer1.Text = "Wrong answer!";
            }
            else
            {
                if (radioButton2Q4.Checked)
                {
                    Q4label2Answer2.Text = "Correct answer!";
                    //Counting right answers;
                    score++;
                }
            }

            //Cheking answer for Question5
            if (radioButton1Q5.Checked) Q5label1Answer1.Text = "Wrong answer!";
            else if (radioButton2Q5.Checked) Q5label2Answer2.Text = "Wrong answer!";
            else if (radioButton3Q5.Checked)
            {
                Q5label3Answer3.Text = "Correct answer!";
                //Counting right answers;
                score++;
            }
            else if (radioButton4Q5.Checked) Q5label4Answer4.Text = "Wrong answer!";




            //Show user score
            textBoxScore.Text = "  " + score + "/5";

            String dbString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Cssharpdatabase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(dbString);



            con.Open();


            SqlCommand cmd = new SqlCommand("INSERT INTO score (Name, Score, QuizName) VALUES (@Name, @Score, @QuizName) ", con);

            cmd.Parameters.AddWithValue("@Name", Program.username);

            cmd.Parameters.AddWithValue("@Score", score);
            cmd.Parameters.AddWithValue("@QuizName", NameOfQuizLabel.Text);


            if (cmd.ExecuteNonQuery() == 1)
            {
                labelAttempted.Text = "Attempted!";
            }
            con.Close();
        }

        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            //This code is written by : Natalia
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

        private void radioButton1Q1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2Q1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Return_Click(object sender, EventArgs e)
        {
            //This code is written by : Natalia
            //Opening Lecture Decision Making
            Form form = new LectureDecisionMaking();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This code is written by : Natalia
            //Opening Lecture Decision Making
            Form form = new LectureDecisionMaking();
            form.Show();
            this.Hide();
        }
    }
}
