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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonTryAgain = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButton3Q2 = new System.Windows.Forms.RadioButton();
            this.radioButton2Q2 = new System.Windows.Forms.RadioButton();
            this.radioButton1Q2 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Q2 = new System.Windows.Forms.Label();
            this.label1Q2 = new System.Windows.Forms.Label();
            this.label2Answer2Q2 = new System.Windows.Forms.Label();
            this.label1Answer1Q2 = new System.Windows.Forms.Label();
            this.label3Answer3Q2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3Q1 = new System.Windows.Forms.RadioButton();
            this.radioButton2Q1 = new System.Windows.Forms.RadioButton();
            this.radioButton1Q1 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Q1 = new System.Windows.Forms.Label();
            this.label1Q1 = new System.Windows.Forms.Label();
            this.label2Answer2Q1 = new System.Windows.Forms.Label();
            this.label1Answer1Q1 = new System.Windows.Forms.Label();
            this.label3Answer3Q1 = new System.Windows.Forms.Label();
            this.typeOfQuestion = new System.Windows.Forms.Label();
            this.TableOfQuizesLink = new System.Windows.Forms.LinkLabel();
            this.TableOfContentsLink = new System.Windows.Forms.LinkLabel();
            this.NameOfQuizLabel = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.Score = new System.Windows.Forms.Label();
            this.toolTipReturnToLecture = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.labelAttempted = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelAttempted);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.buttonTryAgain);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TableOfQuizesLink);
            this.panel1.Controls.Add(this.Return);
            this.panel1.Controls.Add(this.TableOfContentsLink);
            this.panel1.Controls.Add(this.NameOfQuizLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 741);
            this.panel1.TabIndex = 27;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(622, 640);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 32;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonTryAgain
            // 
            this.buttonTryAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTryAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTryAgain.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTryAgain.Location = new System.Drawing.Point(719, 640);
            this.buttonTryAgain.Name = "buttonTryAgain";
            this.buttonTryAgain.Size = new System.Drawing.Size(75, 23);
            this.buttonTryAgain.TabIndex = 31;
            this.buttonTryAgain.Text = "Try again";
            this.buttonTryAgain.UseVisualStyleBackColor = true;
            this.buttonTryAgain.Click += new System.EventHandler(this.buttonTryAgain_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.radioButton3Q2);
            this.panel6.Controls.Add(this.radioButton2Q2);
            this.panel6.Controls.Add(this.radioButton1Q2);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label1Q2);
            this.panel6.Controls.Add(this.label2Answer2Q2);
            this.panel6.Controls.Add(this.label1Answer1Q2);
            this.panel6.Controls.Add(this.label3Answer3Q2);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(38, 364);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(756, 258);
            this.panel6.TabIndex = 30;
            // 
            // radioButton3Q2
            // 
            this.radioButton3Q2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3Q2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3Q2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3Q2.Location = new System.Drawing.Point(52, 195);
            this.radioButton3Q2.Name = "radioButton3Q2";
            this.radioButton3Q2.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.radioButton3Q2.Size = new System.Drawing.Size(321, 33);
            this.radioButton3Q2.TabIndex = 14;
            this.radioButton3Q2.TabStop = true;
            this.radioButton3Q2.Text = "machine language";
            this.radioButton3Q2.UseVisualStyleBackColor = false;
            // 
            // radioButton2Q2
            // 
            this.radioButton2Q2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2Q2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2Q2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2Q2.Location = new System.Drawing.Point(53, 144);
            this.radioButton2Q2.Name = "radioButton2Q2";
            this.radioButton2Q2.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.radioButton2Q2.Size = new System.Drawing.Size(321, 33);
            this.radioButton2Q2.TabIndex = 13;
            this.radioButton2Q2.TabStop = true;
            this.radioButton2Q2.Text = "functional programming language";
            this.radioButton2Q2.UseVisualStyleBackColor = false;
            // 
            // radioButton1Q2
            // 
            this.radioButton1Q2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1Q2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1Q2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1Q2.Location = new System.Drawing.Point(53, 96);
            this.radioButton1Q2.Name = "radioButton1Q2";
            this.radioButton1Q2.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.radioButton1Q2.Size = new System.Drawing.Size(323, 33);
            this.radioButton1Q2.TabIndex = 12;
            this.radioButton1Q2.TabStop = true;
            this.radioButton1Q2.Text = "object-oriented programming language";
            this.radioButton1Q2.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Controls.Add(this.Q2);
            this.panel7.Location = new System.Drawing.Point(53, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(445, 52);
            this.panel7.TabIndex = 21;
            // 
            // Q2
            // 
            this.Q2.AutoSize = true;
            this.Q2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q2.Location = new System.Drawing.Point(16, 15);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(71, 26);
            this.Q2.TabIndex = 9;
            this.Q2.Text = "C#  is ?";
            // 
            // label1Q2
            // 
            this.label1Q2.AutoSize = true;
            this.label1Q2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Q2.Location = new System.Drawing.Point(19, 32);
            this.label1Q2.Name = "label1Q2";
            this.label1Q2.Size = new System.Drawing.Size(28, 26);
            this.label1Q2.TabIndex = 10;
            this.label1Q2.Text = "2.";
            // 
            // label2Answer2Q2
            // 
            this.label2Answer2Q2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2Answer2Q2.AutoSize = true;
            this.label2Answer2Q2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Answer2Q2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2Answer2Q2.Location = new System.Drawing.Point(400, 151);
            this.label2Answer2Q2.Name = "label2Answer2Q2";
            this.label2Answer2Q2.Size = new System.Drawing.Size(0, 19);
            this.label2Answer2Q2.TabIndex = 16;
            // 
            // label1Answer1Q2
            // 
            this.label1Answer1Q2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1Answer1Q2.AutoSize = true;
            this.label1Answer1Q2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Answer1Q2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1Answer1Q2.Location = new System.Drawing.Point(400, 103);
            this.label1Answer1Q2.Name = "label1Answer1Q2";
            this.label1Answer1Q2.Size = new System.Drawing.Size(0, 19);
            this.label1Answer1Q2.TabIndex = 15;
            // 
            // label3Answer3Q2
            // 
            this.label3Answer3Q2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3Answer3Q2.AutoSize = true;
            this.label3Answer3Q2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Answer3Q2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3Answer3Q2.Location = new System.Drawing.Point(400, 202);
            this.label3Answer3Q2.Name = "label3Answer3Q2";
            this.label3Answer3Q2.Size = new System.Drawing.Size(0, 19);
            this.label3Answer3Q2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "(Choose only one correct answer)";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.radioButton3Q1);
            this.panel2.Controls.Add(this.radioButton2Q1);
            this.panel2.Controls.Add(this.radioButton1Q1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label1Q1);
            this.panel2.Controls.Add(this.label2Answer2Q1);
            this.panel2.Controls.Add(this.label1Answer1Q1);
            this.panel2.Controls.Add(this.label3Answer3Q1);
            this.panel2.Controls.Add(this.typeOfQuestion);
            this.panel2.Location = new System.Drawing.Point(38, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 247);
            this.panel2.TabIndex = 29;
            // 
            // radioButton3Q1
            // 
            this.radioButton3Q1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3Q1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3Q1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3Q1.Location = new System.Drawing.Point(53, 196);
            this.radioButton3Q1.Name = "radioButton3Q1";
            this.radioButton3Q1.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.radioButton3Q1.Size = new System.Drawing.Size(312, 33);
            this.radioButton3Q1.TabIndex = 14;
            this.radioButton3Q1.Text = "System.ValueType";
            this.radioButton3Q1.UseVisualStyleBackColor = false;
            // 
            // radioButton2Q1
            // 
            this.radioButton2Q1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2Q1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2Q1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2Q1.Location = new System.Drawing.Point(53, 151);
            this.radioButton2Q1.Name = "radioButton2Q1";
            this.radioButton2Q1.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.radioButton2Q1.Size = new System.Drawing.Size(312, 33);
            this.radioButton2Q1.TabIndex = 13;
            this.radioButton2Q1.Text = "System.String";
            this.radioButton2Q1.UseVisualStyleBackColor = false;
            // 
            // radioButton1Q1
            // 
            this.radioButton1Q1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1Q1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1Q1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1Q1.Location = new System.Drawing.Point(52, 103);
            this.radioButton1Q1.Name = "radioButton1Q1";
            this.radioButton1Q1.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.radioButton1Q1.Size = new System.Drawing.Size(313, 33);
            this.radioButton1Q1.TabIndex = 12;
            this.radioButton1Q1.Text = "System.Object";
            this.radioButton1Q1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.Q1);
            this.panel5.Location = new System.Drawing.Point(53, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(445, 52);
            this.panel5.TabIndex = 21;
            // 
            // Q1
            // 
            this.Q1.AutoSize = true;
            this.Q1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1.Location = new System.Drawing.Point(16, 15);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(389, 26);
            this.Q1.TabIndex = 9;
            this.Q1.Text = "From which class did variables derive in C# ?";
            // 
            // label1Q1
            // 
            this.label1Q1.AutoSize = true;
            this.label1Q1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Q1.Location = new System.Drawing.Point(19, 32);
            this.label1Q1.Name = "label1Q1";
            this.label1Q1.Size = new System.Drawing.Size(28, 26);
            this.label1Q1.TabIndex = 10;
            this.label1Q1.Text = "1.";
            // 
            // label2Answer2Q1
            // 
            this.label2Answer2Q1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2Answer2Q1.AutoSize = true;
            this.label2Answer2Q1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Answer2Q1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2Answer2Q1.Location = new System.Drawing.Point(386, 158);
            this.label2Answer2Q1.Name = "label2Answer2Q1";
            this.label2Answer2Q1.Size = new System.Drawing.Size(0, 19);
            this.label2Answer2Q1.TabIndex = 16;
            // 
            // label1Answer1Q1
            // 
            this.label1Answer1Q1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1Answer1Q1.AutoSize = true;
            this.label1Answer1Q1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Answer1Q1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1Answer1Q1.Location = new System.Drawing.Point(386, 110);
            this.label1Answer1Q1.Name = "label1Answer1Q1";
            this.label1Answer1Q1.Size = new System.Drawing.Size(0, 19);
            this.label1Answer1Q1.TabIndex = 15;
            // 
            // label3Answer3Q1
            // 
            this.label3Answer3Q1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3Answer3Q1.AutoSize = true;
            this.label3Answer3Q1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Answer3Q1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3Answer3Q1.Location = new System.Drawing.Point(386, 203);
            this.label3Answer3Q1.Name = "label3Answer3Q1";
            this.label3Answer3Q1.Size = new System.Drawing.Size(0, 19);
            this.label3Answer3Q1.TabIndex = 17;
            // 
            // typeOfQuestion
            // 
            this.typeOfQuestion.AutoSize = true;
            this.typeOfQuestion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfQuestion.Location = new System.Drawing.Point(53, 72);
            this.typeOfQuestion.Name = "typeOfQuestion";
            this.typeOfQuestion.Size = new System.Drawing.Size(187, 14);
            this.typeOfQuestion.TabIndex = 11;
            this.typeOfQuestion.Text = "(Choose only one correct answer)";
            // 
            // TableOfQuizesLink
            // 
            this.TableOfQuizesLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TableOfQuizesLink.AutoSize = true;
            this.TableOfQuizesLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TableOfQuizesLink.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableOfQuizesLink.LinkColor = System.Drawing.Color.Black;
            this.TableOfQuizesLink.Location = new System.Drawing.Point(565, 24);
            this.TableOfQuizesLink.Name = "TableOfQuizesLink";
            this.TableOfQuizesLink.Size = new System.Drawing.Size(95, 18);
            this.TableOfQuizesLink.TabIndex = 28;
            this.TableOfQuizesLink.TabStop = true;
            this.TableOfQuizesLink.Text = "Table of quizes";
            this.TableOfQuizesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TableOfQuizesLink_LinkClicked);
            // 
            // TableOfContentsLink
            // 
            this.TableOfContentsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TableOfContentsLink.AutoSize = true;
            this.TableOfContentsLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TableOfContentsLink.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableOfContentsLink.LinkColor = System.Drawing.Color.Black;
            this.TableOfContentsLink.Location = new System.Drawing.Point(684, 24);
            this.TableOfContentsLink.Name = "TableOfContentsLink";
            this.TableOfContentsLink.Size = new System.Drawing.Size(110, 18);
            this.TableOfContentsLink.TabIndex = 26;
            this.TableOfContentsLink.TabStop = true;
            this.TableOfContentsLink.Text = "Table of contents";
            // 
            // NameOfQuizLabel
            // 
            this.NameOfQuizLabel.AutoSize = true;
            this.NameOfQuizLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfQuizLabel.Location = new System.Drawing.Point(32, 42);
            this.NameOfQuizLabel.Name = "NameOfQuizLabel";
            this.NameOfQuizLabel.Size = new System.Drawing.Size(124, 33);
            this.NameOfQuizLabel.TabIndex = 25;
            this.NameOfQuizLabel.Text = "Overview";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.button1);
            this.panel11.Controls.Add(this.linkLabel1);
            this.panel11.Controls.Add(this.textBoxScore);
            this.panel11.Controls.Add(this.Score);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 694);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(843, 47);
            this.panel11.TabIndex = 28;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(724, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 18);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Table of contents";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Enabled = false;
            this.textBoxScore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.Location = new System.Drawing.Point(64, 11);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(47, 27);
            this.textBoxScore.TabIndex = 1;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(11, 14);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(47, 19);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = global::CsharpBook.Properties.Resources._11539_200;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(678, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 24);
            this.button1.TabIndex = 27;
            this.toolTipReturnToLecture.SetToolTip(this.button1, "Return to the lecture");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Return
            // 
            this.Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Return.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Return.BackgroundImage = global::CsharpBook.Properties.Resources._11539_200;
            this.Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.Location = new System.Drawing.Point(507, 21);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(29, 24);
            this.Return.TabIndex = 27;
            this.toolTipReturnToLecture.SetToolTip(this.Return, "Return to the lecture");
            this.Return.UseVisualStyleBackColor = false;
            // 
            // labelAttempted
            // 
            this.labelAttempted.AutoSize = true;
            this.labelAttempted.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttempted.Location = new System.Drawing.Point(504, 644);
            this.labelAttempted.Name = "labelAttempted";
            this.labelAttempted.Size = new System.Drawing.Size(0, 15);
            this.labelAttempted.TabIndex = 33;
            // 
            // QuizeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(843, 741);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.Name = "QuizeForm1";
            this.Text = "Quize: Overview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonTryAgain;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioButton3Q2;
        private System.Windows.Forms.RadioButton radioButton2Q2;
        private System.Windows.Forms.RadioButton radioButton1Q2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Q2;
        private System.Windows.Forms.Label label1Q2;
        private System.Windows.Forms.Label label2Answer2Q2;
        private System.Windows.Forms.Label label1Answer1Q2;
        private System.Windows.Forms.Label label3Answer3Q2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton3Q1;
        private System.Windows.Forms.RadioButton radioButton2Q1;
        private System.Windows.Forms.RadioButton radioButton1Q1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Q1;
        private System.Windows.Forms.Label label1Q1;
        private System.Windows.Forms.Label label2Answer2Q1;
        private System.Windows.Forms.Label label1Answer1Q1;
        private System.Windows.Forms.Label label3Answer3Q1;
        private System.Windows.Forms.Label typeOfQuestion;
        private System.Windows.Forms.LinkLabel TableOfQuizesLink;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.ToolTip toolTipReturnToLecture;
        private System.Windows.Forms.LinkLabel TableOfContentsLink;
        private System.Windows.Forms.Label NameOfQuizLabel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label labelAttempted;
    }
}