
namespace Vplquiz.Views
{
    partial class InstructorDashboardView
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.rtbStudentEducation = new System.Windows.Forms.RichTextBox();
            this.tbStudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboStudentEmails = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveInstructor = new System.Windows.Forms.Button();
            this.rtbInstructorExperience = new System.Windows.Forms.RichTextBox();
            this.tbInstructorSpecialization = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbInstructorPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInstructorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(173, 35);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(130, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome - ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSaveStudent);
            this.groupBox1.Controls.Add(this.rtbStudentEducation);
            this.groupBox1.Controls.Add(this.tbStudentPhoneNumber);
            this.groupBox1.Controls.Add(this.tbStudentName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboStudentEmails);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(405, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 345);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select Student";
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.BackColor = System.Drawing.Color.White;
            this.btnSaveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStudent.ForeColor = System.Drawing.Color.Black;
            this.btnSaveStudent.Location = new System.Drawing.Point(121, 261);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(197, 48);
            this.btnSaveStudent.TabIndex = 14;
            this.btnSaveStudent.Text = "Save";
            this.btnSaveStudent.UseVisualStyleBackColor = false;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // rtbStudentEducation
            // 
            this.rtbStudentEducation.Location = new System.Drawing.Point(121, 159);
            this.rtbStudentEducation.Name = "rtbStudentEducation";
            this.rtbStudentEducation.Size = new System.Drawing.Size(197, 96);
            this.rtbStudentEducation.TabIndex = 13;
            this.rtbStudentEducation.Text = "";
            // 
            // tbStudentPhoneNumber
            // 
            this.tbStudentPhoneNumber.Location = new System.Drawing.Point(120, 122);
            this.tbStudentPhoneNumber.Name = "tbStudentPhoneNumber";
            this.tbStudentPhoneNumber.Size = new System.Drawing.Size(197, 20);
            this.tbStudentPhoneNumber.TabIndex = 12;
            this.tbStudentPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(120, 86);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(197, 20);
            this.tbStudentName.TabIndex = 11;
            this.tbStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Education";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // comboStudentEmails
            // 
            this.comboStudentEmails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStudentEmails.FormattingEnabled = true;
            this.comboStudentEmails.Location = new System.Drawing.Point(138, 42);
            this.comboStudentEmails.Name = "comboStudentEmails";
            this.comboStudentEmails.Size = new System.Drawing.Size(180, 21);
            this.comboStudentEmails.TabIndex = 1;
            this.comboStudentEmails.SelectedIndexChanged += new System.EventHandler(this.comboStudentEmails_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveInstructor);
            this.groupBox2.Controls.Add(this.rtbInstructorExperience);
            this.groupBox2.Controls.Add(this.tbInstructorSpecialization);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbInstructorPhone);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbInstructorName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 345);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instructor Section";
            // 
            // btnSaveInstructor
            // 
            this.btnSaveInstructor.BackColor = System.Drawing.Color.White;
            this.btnSaveInstructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInstructor.ForeColor = System.Drawing.Color.Black;
            this.btnSaveInstructor.Location = new System.Drawing.Point(130, 261);
            this.btnSaveInstructor.Name = "btnSaveInstructor";
            this.btnSaveInstructor.Size = new System.Drawing.Size(197, 48);
            this.btnSaveInstructor.TabIndex = 16;
            this.btnSaveInstructor.Text = "Save";
            this.btnSaveInstructor.UseVisualStyleBackColor = false;
            this.btnSaveInstructor.Click += new System.EventHandler(this.btnSaveInstructor_Click);
            // 
            // rtbInstructorExperience
            // 
            this.rtbInstructorExperience.Location = new System.Drawing.Point(130, 159);
            this.rtbInstructorExperience.Name = "rtbInstructorExperience";
            this.rtbInstructorExperience.Size = new System.Drawing.Size(197, 96);
            this.rtbInstructorExperience.TabIndex = 17;
            this.rtbInstructorExperience.Text = "";
            // 
            // tbInstructorSpecialization
            // 
            this.tbInstructorSpecialization.Location = new System.Drawing.Point(129, 123);
            this.tbInstructorSpecialization.Name = "tbInstructorSpecialization";
            this.tbInstructorSpecialization.Size = new System.Drawing.Size(197, 20);
            this.tbInstructorSpecialization.TabIndex = 21;
            this.tbInstructorSpecialization.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Experience";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Specialization";
            // 
            // tbInstructorPhone
            // 
            this.tbInstructorPhone.Location = new System.Drawing.Point(129, 87);
            this.tbInstructorPhone.Name = "tbInstructorPhone";
            this.tbInstructorPhone.Size = new System.Drawing.Size(197, 20);
            this.tbInstructorPhone.TabIndex = 19;
            this.tbInstructorPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phone Num";
            // 
            // tbInstructorName
            // 
            this.tbInstructorName.Location = new System.Drawing.Point(129, 51);
            this.tbInstructorName.Name = "tbInstructorName";
            this.tbInstructorName.Size = new System.Drawing.Size(197, 20);
            this.tbInstructorName.TabIndex = 18;
            this.tbInstructorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(688, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 37);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // InstructorDashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InstructorDashboardView";
            this.Text = "InstructorDashboardView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboStudentEmails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.RichTextBox rtbStudentEducation;
        private System.Windows.Forms.TextBox tbStudentPhoneNumber;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveInstructor;
        private System.Windows.Forms.RichTextBox rtbInstructorExperience;
        private System.Windows.Forms.TextBox tbInstructorSpecialization;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbInstructorPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInstructorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogout;
    }
}