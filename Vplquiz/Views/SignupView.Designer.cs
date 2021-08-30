
namespace Vplquiz.Views
{
    partial class SignupView
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
            this.lblFirstTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInstructor = new System.Windows.Forms.RadioButton();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbRePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblSignIn = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstTime
            // 
            this.lblFirstTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstTime.AutoSize = true;
            this.lblFirstTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFirstTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstTime.ForeColor = System.Drawing.Color.White;
            this.lblFirstTime.Location = new System.Drawing.Point(118, 119);
            this.lblFirstTime.Name = "lblFirstTime";
            this.lblFirstTime.Size = new System.Drawing.Size(533, 21);
            this.lblFirstTime.TabIndex = 0;
            this.lblFirstTime.Text = "Hi! This is your first time using this application, so Lets get you started!";
            this.lblFirstTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 78);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alpha Institute";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.DimGray;
            this.tbEmail.Location = new System.Drawing.Point(284, 161);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 27);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Text = "Your Email";
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEmail.Click += new System.EventHandler(this.tbEmail_Click);
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Click);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.ForeColor = System.Drawing.Color.White;
            this.rbStudent.Location = new System.Drawing.Point(6, 19);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(62, 17);
            this.rbStudent.TabIndex = 5;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbInstructor);
            this.groupBox1.Controls.Add(this.rbStudent);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(284, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select User Role";
            // 
            // rbInstructor
            // 
            this.rbInstructor.AutoSize = true;
            this.rbInstructor.ForeColor = System.Drawing.Color.White;
            this.rbInstructor.Location = new System.Drawing.Point(125, 19);
            this.rbInstructor.Name = "rbInstructor";
            this.rbInstructor.Size = new System.Drawing.Size(69, 17);
            this.rbInstructor.TabIndex = 6;
            this.rbInstructor.TabStop = true;
            this.rbInstructor.Text = "Instructor";
            this.rbInstructor.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbPassword.Location = new System.Drawing.Point(284, 194);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(200, 27);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.Text = "Your Password";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbRePassword
            // 
            this.tbRePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRePassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbRePassword.Location = new System.Drawing.Point(284, 226);
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.Size = new System.Drawing.Size(200, 27);
            this.tbRePassword.TabIndex = 8;
            this.tbRePassword.Text = "Re-Type Password";
            this.tbRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRePassword.Click += new System.EventHandler(this.tbRePassword_Click);
            this.tbRePassword.Enter += new System.EventHandler(this.tbRePassword_Click);
            this.tbRePassword.Leave += new System.EventHandler(this.tbRePassword_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(173, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password Requirments: [Length 8] [1 Capital] [1 Small] [1 Number][1 Special Chara" +
    "cter]";
            // 
            // btnSignup
            // 
            this.btnSignup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignup.BackColor = System.Drawing.Color.White;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(284, 346);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(200, 56);
            this.btnSignup.TabIndex = 10;
            this.btnSignup.Text = " Sign Me Up!";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.ActiveLinkColor = System.Drawing.Color.LightSeaGreen;
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.LinkColor = System.Drawing.Color.Silver;
            this.lblSignIn.Location = new System.Drawing.Point(303, 406);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(161, 13);
            this.lblSignIn.TabIndex = 16;
            this.lblSignIn.TabStop = true;
            this.lblSignIn.Text = "Already have an account? Login";
            this.lblSignIn.VisitedLinkColor = System.Drawing.Color.Silver;
            this.lblSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSignIn_LinkClicked);
            // 
            // SignupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRePassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFirstTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignupView";
            this.Text = "SignupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInstructor;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbRePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.LinkLabel lblSignIn;
    }
}