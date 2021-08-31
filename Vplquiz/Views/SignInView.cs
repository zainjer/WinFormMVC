using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vplquiz.Controllers;
using Vplquiz.DAL;
using Vplquiz.Resources;

namespace Vplquiz.Views
{
    public partial class SignInView : Form
    {
        public SignInView()
        {
            InitializeComponent();
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupView view = new SignupView();
            view.Show();
            this.Close();
        }

        private void tbEmail_Click(object sender, EventArgs e) => Utils.TbClickHandler(tbEmail);
        private void tbEmail_Leave(object sender, EventArgs e) => Utils.TbLeaveHandler(tbEmail, "Your Email");
        private void tbPassword_Leave(object sender, EventArgs e) => Utils.TbLeaveHandler(tbPassword, "Your Password");
        private void tbPassword_Click(object sender, EventArgs e) => Utils.TbClickHandler(tbPassword,true);


        private void SignInView_Click(object sender, EventArgs e)
        {
            Utils.TbLeaveHandler(tbPassword, "Your Password");
            Utils.TbLeaveHandler(tbEmail, "Your Email");
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                var result = AuthController.Instance.SignIn(tbEmail.Text, tbPassword.Text, rbStudent.Checked);
                if (result.instructorEntity != null)
                {
                    new InstructorDashboardView(result.instructorEntity, AppDbContext.Instance.Students.ToList());
                    this.Close();
                    return;
                } else if (result.student != null)
                {
                    new StudentDashboardView(result.student);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Could not find a user with that email and password combination", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private bool Validate()
        {
            if ( string.IsNullOrWhiteSpace(tbPassword.Text)
                || string.IsNullOrWhiteSpace(tbEmail.Text)
                || tbEmail.Text.ToLower().Equals("email")
                || tbPassword.Text.ToLower().Equals("password")
                || tbEmail.Text.ToLower().Equals("re-type password")
            )

            {
                MessageBox.Show("Please fill out all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var emailRegex = AuthController.GetEmailRegex();
            var passwordRegex = AuthController.GetPasswordRegex();

            if (!emailRegex.IsMatch(tbEmail.Text))
            {
                MessageBox.Show("Invalid Email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
