namespace CsharpBook
{
    partial class QuizeForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameOfQuizLabel = new System.Windows.Forms.Label();
            this.groupBoxForQuestion1 = new System.Windows.Forms.GroupBox();
            this.FirstQuestion = new System.Windows.Forms.Label();
            this.NumberOfFirstQuestion = new System.Windows.Forms.Label();
            this.TypeOfQuestion = new System.Windows.Forms.Label();
            this.TableOfContentsLink = new System.Windows.Forms.LinkLabel();
            this.Return = new System.Windows.Forms.Button();
            this.TableOfQuizesLink = new System.Windows.Forms.LinkLabel();
            this.Q1radioButton1 = new System.Windows.Forms.RadioButton();
            this.Q1radioButton2 = new System.Windows.Forms.RadioButton();
            this.Q1radioButton3 = new System.Windows.Forms.RadioButton();
            this.Q1TypeOfAnswerLabel1 = new System.Windows.Forms.Label();
            this.Q1TypeOfAnswerLabel2 = new System.Windows.Forms.Label();
            this.Q1TypeOfAnswerLabel3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxForQuestion1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameOfQuizLabel
            // 
            this.NameOfQuizLabel.AutoSize = true;
            this.NameOfQuizLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfQuizLabel.Location = new System.Drawing.Point(38, 43);
            this.NameOfQuizLabel.Name = "NameOfQuizLabel";
            this.NameOfQuizLabel.Size = new System.Drawing.Size(137, 33);
            this.NameOfQuizLabel.TabIndex = 0;
            this.NameOfQuizLabel.Text = "Data Types";
            this.NameOfQuizLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxForQuestion1
            // 
            this.groupBoxForQuestion1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBoxForQuestion1.Controls.Add(this.Q1TypeOfAnswerLabel3);
            this.groupBoxForQuestion1.Controls.Add(this.Q1TypeOfAnswerLabel2);
            this.groupBoxForQuestion1.Controls.Add(this.Q1TypeOfAnswerLabel1);
            this.groupBoxForQuestion1.Controls.Add(this.Q1radioButton3);
            this.groupBoxForQuestion1.Controls.Add(this.Q1radioButton2);
            this.groupBoxForQuestion1.Controls.Add(this.Q1radioButton1);
            this.groupBoxForQuestion1.Controls.Add(this.TypeOfQuestion);
            this.groupBoxForQuestion1.Controls.Add(this.NumberOfFirstQuestion);
            this.groupBoxForQuestion1.Controls.Add(this.FirstQuestion);
            this.groupBoxForQuestion1.Location = new System.Drawing.Point(44, 103);
            this.groupBoxForQuestion1.Name = "groupBoxForQuestion1";
            this.groupBoxForQuestion1.Size = new System.Drawing.Size(758, 244);
            this.groupBoxForQuestion1.TabIndex = 1;
            this.groupBoxForQuestion1.TabStop = false;
            // 
            // FirstQuestion
            // 
            this.FirstQuestion.AutoSize = true;
            this.FirstQuestion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstQuestion.Location = new System.Drawing.Point(60, 33);
            this.FirstQuestion.Name = "FirstQuestion";
            this.FirstQuestion.Size = new System.Drawing.Size(389, 26);
            this.FirstQuestion.TabIndex = 0;
            this.FirstQuestion.Text = "From which class did variables derive in C# ?";
            this.FirstQuestion.Click += new System.EventHandler(this.FirstQuestion_Click);
            // 
            // NumberOfFirstQuestion
            // 
            this.NumberOfFirstQuestion.AutoSize = true;
            this.NumberOfFirstQuestion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfFirstQuestion.Location = new System.Drawing.Point(20, 33);
            this.NumberOfFirstQuestion.Name = "NumberOfFirstQuestion";
            this.NumberOfFirstQuestion.Size = new System.Drawing.Size(28, 26);
            this.NumberOfFirstQuestion.TabIndex = 1;
            this.NumberOfFirstQuestion.Text = "1.";
            // 
            // TypeOfQuestion
            // 
            this.TypeOfQuestion.AutoSize = true;
            this.TypeOfQuestion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfQuestion.Location = new System.Drawing.Point(61, 68);
            this.TypeOfQuestion.Name = "TypeOfQuestion";
            this.TypeOfQuestion.Size = new System.Drawing.Size(161, 14);
            this.TypeOfQuestion.TabIndex = 2;
            this.TypeOfQuestion.Text = "(Choose all correct answers)";
            // 
            // TableOfContentsLink
            // 
            this.TableOfContentsLink.AutoSize = true;
            this.TableOfContentsLink.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableOfContentsLink.LinkColor = System.Drawing.Color.Black;
            this.TableOfContentsLink.Location = new System.Drawing.Point(692, 25);
            this.TableOfContentsLink.Name = "TableOfContentsLink";
            this.TableOfContentsLink.Size = new System.Drawing.Size(110, 18);
            this.TableOfContentsLink.TabIndex = 2;
            this.TableOfContentsLink.TabStop = true;
            this.TableOfContentsLink.Text = "Table of contents";
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Return.BackgroundImage = global::CsharpBook.Properties.Resources._11539_200;
            this.Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Return.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.Location = new System.Drawing.Point(515, 22);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(29, 24);
            this.Return.TabIndex = 3;
            this.Return.UseVisualStyleBackColor = false;
            // 
            // TableOfQuizesLink
            // 
            this.TableOfQuizesLink.AutoSize = true;
            this.TableOfQuizesLink.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableOfQuizesLink.LinkColor = System.Drawing.Color.Black;
            this.TableOfQuizesLink.Location = new System.Drawing.Point(573, 25);
            this.TableOfQuizesLink.Name = "TableOfQuizesLink";
            this.TableOfQuizesLink.Size = new System.Drawing.Size(95, 18);
            this.TableOfQuizesLink.TabIndex = 4;
            this.TableOfQuizesLink.TabStop = true;
            this.TableOfQuizesLink.Text = "Table of quizes";
            this.TableOfQuizesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Q1radioButton1
            // 
            this.Q1radioButton1.AutoSize = true;
            this.Q1radioButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1radioButton1.Location = new System.Drawing.Point(64, 104);
            this.Q1radioButton1.Name = "Q1radioButton1";
            this.Q1radioButton1.Size = new System.Drawing.Size(120, 23);
            this.Q1radioButton1.TabIndex = 3;
            this.Q1radioButton1.TabStop = true;
            this.Q1radioButton1.Text = "System.Object";
            this.Q1radioButton1.UseVisualStyleBackColor = true;
            // 
            // Q1radioButton2
            // 
            this.Q1radioButton2.AutoSize = true;
            this.Q1radioButton2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1radioButton2.Location = new System.Drawing.Point(64, 143);
            this.Q1radioButton2.Name = "Q1radioButton2";
            this.Q1radioButton2.Size = new System.Drawing.Size(114, 23);
            this.Q1radioButton2.TabIndex = 4;
            this.Q1radioButton2.TabStop = true;
            this.Q1radioButton2.Text = "System.String";
            this.Q1radioButton2.UseVisualStyleBackColor = true;
            // 
            // Q1radioButton3
            // 
            this.Q1radioButton3.AutoSize = true;
            this.Q1radioButton3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1radioButton3.Location = new System.Drawing.Point(64, 183);
            this.Q1radioButton3.Name = "Q1radioButton3";
            this.Q1radioButton3.Size = new System.Drawing.Size(142, 23);
            this.Q1radioButton3.TabIndex = 5;
            this.Q1radioButton3.TabStop = true;
            this.Q1radioButton3.Text = "System.ValueType";
            this.Q1radioButton3.UseVisualStyleBackColor = true;
            // 
            // Q1TypeOfAnswerLabel1
            // 
            this.Q1TypeOfAnswerLabel1.AutoSize = true;
            this.Q1TypeOfAnswerLabel1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1TypeOfAnswerLabel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.Q1TypeOfAnswerLabel1.Location = new System.Drawing.Point(239, 104);
            this.Q1TypeOfAnswerLabel1.Name = "Q1TypeOfAnswerLabel1";
            this.Q1TypeOfAnswerLabel1.Size = new System.Drawing.Size(110, 19);
            this.Q1TypeOfAnswerLabel1.TabIndex = 6;
            this.Q1TypeOfAnswerLabel1.Text = " Wrong answer";
            this.Q1TypeOfAnswerLabel1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Q1TypeOfAnswerLabel2
            // 
            this.Q1TypeOfAnswerLabel2.AutoSize = true;
            this.Q1TypeOfAnswerLabel2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1TypeOfAnswerLabel2.ForeColor = System.Drawing.Color.OrangeRed;
            this.Q1TypeOfAnswerLabel2.Location = new System.Drawing.Point(239, 143);
            this.Q1TypeOfAnswerLabel2.Name = "Q1TypeOfAnswerLabel2";
            this.Q1TypeOfAnswerLabel2.Size = new System.Drawing.Size(106, 19);
            this.Q1TypeOfAnswerLabel2.TabIndex = 7;
            this.Q1TypeOfAnswerLabel2.Text = "Wrong answer";
            // 
            // Q1TypeOfAnswerLabel3
            // 
            this.Q1TypeOfAnswerLabel3.AutoSize = true;
            this.Q1TypeOfAnswerLabel3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1TypeOfAnswerLabel3.ForeColor = System.Drawing.Color.LimeGreen;
            this.Q1TypeOfAnswerLabel3.Location = new System.Drawing.Point(239, 185);
            this.Q1TypeOfAnswerLabel3.Name = "Q1TypeOfAnswerLabel3";
            this.Q1TypeOfAnswerLabel3.Size = new System.Drawing.Size(110, 19);
            this.Q1TypeOfAnswerLabel3.TabIndex = 8;
            this.Q1TypeOfAnswerLabel3.Text = "Correct answer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(44, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 242);
            this.panel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(380, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Correct answer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(380, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Wrong answer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(380, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Wrong answer";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(3, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(142, 23);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "System.ValueType";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(3, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(114, 23);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "System.String";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(3, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(120, 23);
            this.radioButton6.TabIndex = 12;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "System.Object";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "(Choose all correct answers)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "1.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(389, 26);
            this.label12.TabIndex = 9;
            this.label12.Text = "From which class did variables derive in C# ?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Location = new System.Drawing.Point(81, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 34);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Location = new System.Drawing.Point(81, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 33);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.radioButton4);
            this.panel4.Location = new System.Drawing.Point(81, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 32);
            this.panel4.TabIndex = 20;
            // 
            // QuizeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(843, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TableOfQuizesLink);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.TableOfContentsLink);
            this.Controls.Add(this.groupBoxForQuestion1);
            this.Controls.Add(this.NameOfQuizLabel);
            this.Name = "QuizeForm1";
            this.Text = "Quize: Data Types";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxForQuestion1.ResumeLayout(false);
            this.groupBoxForQuestion1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfQuizLabel;
        private System.Windows.Forms.GroupBox groupBoxForQuestion1;
        private System.Windows.Forms.Label TypeOfQuestion;
        private System.Windows.Forms.Label NumberOfFirstQuestion;
        private System.Windows.Forms.Label FirstQuestion;
        private System.Windows.Forms.LinkLabel TableOfContentsLink;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.LinkLabel TableOfQuizesLink;
        private System.Windows.Forms.Label Q1TypeOfAnswerLabel1;
        private System.Windows.Forms.RadioButton Q1radioButton3;
        private System.Windows.Forms.RadioButton Q1radioButton2;
        private System.Windows.Forms.RadioButton Q1radioButton1;
        private System.Windows.Forms.Label Q1TypeOfAnswerLabel3;
        private System.Windows.Forms.Label Q1TypeOfAnswerLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}