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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxForQuestion1.SuspendLayout();
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
            this.groupBoxForQuestion1.Controls.Add(this.label1);
            this.groupBoxForQuestion1.Controls.Add(this.NumberOfFirstQuestion);
            this.groupBoxForQuestion1.Controls.Add(this.FirstQuestion);
            this.groupBoxForQuestion1.Location = new System.Drawing.Point(44, 100);
            this.groupBoxForQuestion1.Name = "groupBoxForQuestion1";
            this.groupBoxForQuestion1.Size = new System.Drawing.Size(758, 248);
            this.groupBoxForQuestion1.TabIndex = 1;
            this.groupBoxForQuestion1.TabStop = false;
            // 
            // FirstQuestion
            // 
            this.FirstQuestion.AutoSize = true;
            this.FirstQuestion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstQuestion.Location = new System.Drawing.Point(60, 33);
            this.FirstQuestion.Name = "FirstQuestion";
            this.FirstQuestion.Size = new System.Drawing.Size(288, 23);
            this.FirstQuestion.TabIndex = 0;
            this.FirstQuestion.Text = "Choose right types of varables in C#:";
            // 
            // NumberOfFirstQuestion
            // 
            this.NumberOfFirstQuestion.AutoSize = true;
            this.NumberOfFirstQuestion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfFirstQuestion.Location = new System.Drawing.Point(20, 33);
            this.NumberOfFirstQuestion.Name = "NumberOfFirstQuestion";
            this.NumberOfFirstQuestion.Size = new System.Drawing.Size(25, 23);
            this.NumberOfFirstQuestion.TabIndex = 1;
            this.NumberOfFirstQuestion.Text = "1.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "(Choose all correct answers)";
            // 
            // QuizeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(843, 423);
            this.Controls.Add(this.groupBoxForQuestion1);
            this.Controls.Add(this.NameOfQuizLabel);
            this.Name = "QuizeForm1";
            this.Text = "QuizeForm1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxForQuestion1.ResumeLayout(false);
            this.groupBoxForQuestion1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfQuizLabel;
        private System.Windows.Forms.GroupBox groupBoxForQuestion1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumberOfFirstQuestion;
        private System.Windows.Forms.Label FirstQuestion;
    }
}