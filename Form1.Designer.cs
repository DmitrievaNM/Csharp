﻿namespace CsharpBook
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registrationlbl = new System.Windows.Forms.Label();
            this.loginlbl = new System.Windows.Forms.Label();
            this.contentslbl = new System.Windows.Forms.Label();
            this.quizzeslbl = new System.Windows.Forms.Label();
            this.aboutuslbl = new System.Windows.Forms.Label();
            this.contactuslbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CsharpBook.Properties.Resources.first_page;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // registrationlbl
            // 
            this.registrationlbl.AutoSize = true;
            this.registrationlbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationlbl.Location = new System.Drawing.Point(28, 9);
            this.registrationlbl.Name = "registrationlbl";
            this.registrationlbl.Size = new System.Drawing.Size(83, 18);
            this.registrationlbl.TabIndex = 1;
            this.registrationlbl.Text = "Registration";
            this.registrationlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlbl.Location = new System.Drawing.Point(133, 9);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(41, 18);
            this.loginlbl.TabIndex = 2;
            this.loginlbl.Text = "Login";
            // 
            // contentslbl
            // 
            this.contentslbl.AutoSize = true;
            this.contentslbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentslbl.Location = new System.Drawing.Point(196, 9);
            this.contentslbl.Name = "contentslbl";
            this.contentslbl.Size = new System.Drawing.Size(66, 18);
            this.contentslbl.TabIndex = 3;
            this.contentslbl.Text = "Contents";
            this.contentslbl.Click += new System.EventHandler(this.contentslbl_Click);
            // 
            // quizzeslbl
            // 
            this.quizzeslbl.AutoSize = true;
            this.quizzeslbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizzeslbl.Location = new System.Drawing.Point(285, 9);
            this.quizzeslbl.Name = "quizzeslbl";
            this.quizzeslbl.Size = new System.Drawing.Size(58, 18);
            this.quizzeslbl.TabIndex = 4;
            this.quizzeslbl.Text = "Quizzes";
            // 
            // aboutuslbl
            // 
            this.aboutuslbl.AutoSize = true;
            this.aboutuslbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutuslbl.Location = new System.Drawing.Point(363, 9);
            this.aboutuslbl.Name = "aboutuslbl";
            this.aboutuslbl.Size = new System.Drawing.Size(68, 18);
            this.aboutuslbl.TabIndex = 5;
            this.aboutuslbl.Text = "About Us";
            // 
            // contactuslbl
            // 
            this.contactuslbl.AutoSize = true;
            this.contactuslbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactuslbl.Location = new System.Drawing.Point(448, 9);
            this.contactuslbl.Name = "contactuslbl";
            this.contactuslbl.Size = new System.Drawing.Size(80, 18);
            this.contactuslbl.TabIndex = 6;
            this.contactuslbl.Text = "Contact Us";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 355);
            this.Controls.Add(this.contactuslbl);
            this.Controls.Add(this.aboutuslbl);
            this.Controls.Add(this.quizzeslbl);
            this.Controls.Add(this.contentslbl);
            this.Controls.Add(this.loginlbl);
            this.Controls.Add(this.registrationlbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label registrationlbl;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.Label contentslbl;
        private System.Windows.Forms.Label quizzeslbl;
        private System.Windows.Forms.Label aboutuslbl;
        private System.Windows.Forms.Label contactuslbl;
    }
}