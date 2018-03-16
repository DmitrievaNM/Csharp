namespace CsharpBook
{
    partial class TableOfQuizesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOverview = new System.Windows.Forms.Label();
            this.labelDecisionMaking = new System.Windows.Forms.Label();
            this.labelEnvironment = new System.Windows.Forms.Label();
            this.labelBasicSyntax = new System.Windows.Forms.Label();
            this.labelProgramStructure = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.TableOfQuizesLabel = new System.Windows.Forms.Label();
            this.TableOfContentsLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.labelOverview);
            this.panel1.Controls.Add(this.labelDecisionMaking);
            this.panel1.Controls.Add(this.labelEnvironment);
            this.panel1.Controls.Add(this.labelBasicSyntax);
            this.panel1.Controls.Add(this.labelProgramStructure);
            this.panel1.Location = new System.Drawing.Point(35, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 248);
            this.panel1.TabIndex = 43;
            // 
            // labelOverview
            // 
            this.labelOverview.AutoSize = true;
            this.labelOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOverview.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverview.Location = new System.Drawing.Point(25, 19);
            this.labelOverview.Name = "labelOverview";
            this.labelOverview.Size = new System.Drawing.Size(91, 26);
            this.labelOverview.TabIndex = 33;
            this.labelOverview.Text = "Overview";
            this.labelOverview.Click += new System.EventHandler(this.labelOverview_Click);
            // 
            // labelDecisionMaking
            // 
            this.labelDecisionMaking.AutoSize = true;
            this.labelDecisionMaking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDecisionMaking.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecisionMaking.Location = new System.Drawing.Point(25, 195);
            this.labelDecisionMaking.Name = "labelDecisionMaking";
            this.labelDecisionMaking.Size = new System.Drawing.Size(152, 26);
            this.labelDecisionMaking.TabIndex = 37;
            this.labelDecisionMaking.Text = "Decision making";
            this.labelDecisionMaking.Click += new System.EventHandler(this.labelDecisionMaking_Click);
            // 
            // labelEnvironment
            // 
            this.labelEnvironment.AutoSize = true;
            this.labelEnvironment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnvironment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvironment.Location = new System.Drawing.Point(25, 62);
            this.labelEnvironment.Name = "labelEnvironment";
            this.labelEnvironment.Size = new System.Drawing.Size(121, 26);
            this.labelEnvironment.TabIndex = 34;
            this.labelEnvironment.Text = "Environment";
            this.labelEnvironment.Click += new System.EventHandler(this.labelEnvironment_Click);
            // 
            // labelBasicSyntax
            // 
            this.labelBasicSyntax.AutoSize = true;
            this.labelBasicSyntax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBasicSyntax.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasicSyntax.Location = new System.Drawing.Point(25, 152);
            this.labelBasicSyntax.Name = "labelBasicSyntax";
            this.labelBasicSyntax.Size = new System.Drawing.Size(115, 26);
            this.labelBasicSyntax.TabIndex = 36;
            this.labelBasicSyntax.Text = "Basic syntax";
            this.labelBasicSyntax.Click += new System.EventHandler(this.labelBasicSyntax_Click);
            // 
            // labelProgramStructure
            // 
            this.labelProgramStructure.AutoSize = true;
            this.labelProgramStructure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelProgramStructure.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramStructure.Location = new System.Drawing.Point(25, 105);
            this.labelProgramStructure.Name = "labelProgramStructure";
            this.labelProgramStructure.Size = new System.Drawing.Size(167, 26);
            this.labelProgramStructure.TabIndex = 35;
            this.labelProgramStructure.Text = "Program structure";
            this.labelProgramStructure.Click += new System.EventHandler(this.labelProgramStructure_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Enabled = false;
            this.textBoxUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(118, 20);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(130, 27);
            this.textBoxUserName.TabIndex = 42;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(31, 23);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(81, 19);
            this.UserName.TabIndex = 41;
            this.UserName.Text = "User name";
            // 
            // TableOfQuizesLabel
            // 
            this.TableOfQuizesLabel.AutoSize = true;
            this.TableOfQuizesLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableOfQuizesLabel.Location = new System.Drawing.Point(29, 89);
            this.TableOfQuizesLabel.Name = "TableOfQuizesLabel";
            this.TableOfQuizesLabel.Size = new System.Drawing.Size(180, 33);
            this.TableOfQuizesLabel.TabIndex = 40;
            this.TableOfQuizesLabel.Text = "Table of quizes";
            // 
            // TableOfContentsLink
            // 
            this.TableOfContentsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TableOfContentsLink.AutoSize = true;
            this.TableOfContentsLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TableOfContentsLink.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableOfContentsLink.LinkColor = System.Drawing.Color.Black;
            this.TableOfContentsLink.Location = new System.Drawing.Point(552, 24);
            this.TableOfContentsLink.Name = "TableOfContentsLink";
            this.TableOfContentsLink.Size = new System.Drawing.Size(110, 18);
            this.TableOfContentsLink.TabIndex = 39;
            this.TableOfContentsLink.TabStop = true;
            this.TableOfContentsLink.Text = "Table of contents";
            this.TableOfContentsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TableOfContentsLink_LinkClicked);
            // 
            // TableOfQuizesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(689, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.TableOfQuizesLabel);
            this.Controls.Add(this.TableOfContentsLink);
            this.Name = "TableOfQuizesForm";
            this.Text = "Table of Quizes";
            this.Load += new System.EventHandler(this.TableOfQuizesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelOverview;
        private System.Windows.Forms.Label labelDecisionMaking;
        private System.Windows.Forms.Label labelEnvironment;
        private System.Windows.Forms.Label labelBasicSyntax;
        private System.Windows.Forms.Label labelProgramStructure;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label TableOfQuizesLabel;
        private System.Windows.Forms.LinkLabel TableOfContentsLink;
    }
}