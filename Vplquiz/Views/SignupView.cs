using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vplquiz.Controllers;

namespace Vplquiz.Views
{
    public partial class SignupView : Form
    {
        public SignupView()
        {
            InitializeComponent();
            rbStudent.Checked = true;
            rbStudent.Focus();
        }
        
        public void FirstTime() => lblFirstTime.Show();
        
        //Events
        private void tbRePassword_Click(object sender, EventArgs e) => TbClickHandler(tbRePassword, true);
        private void tbRePassword_Leave(object sender, EventArgs e) => TbLeaveHandler(tbRePassword, "Re-Type Password");
        private void tbPassword_Leave(object sender, EventArgs e) => TbLeaveHandler(tbPassword, "Password");
        private void tbPassword_Click(object sender, EventArgs e) => TbClickHandler(tbPassword,true);
        private void tbEmail_Click(object sender, EventArgs e) => TbClickHandler(tbEmail);
        private void tbEmail_Leave(object sender, EventArgs e) => TbLeaveHandler(tbEmail,"Email");


        private void TbClickHandler(TextBox textBox,bool isPassword = false)
        {
            if (isPassword)
            {
                var status = textBox.Text.ToLower().Contains("password");
                if (!status) return;
            }
            else
            {
                var status = textBox.Text.ToLower().Contains("email");
                if (!status) return;
            }

            textBox.Text = "";
            textBox.ForeColor = Color.Black;
            textBox.UseSystemPasswordChar = isPassword;
        }

        private void TbLeaveHandler(TextBox textBox, string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = message;
                textBox.ForeColor = Color.DimGray;
                textBox.UseSystemPasswordChar = false;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                AuthController.Instance.SignUpNewUser(tbEmail.Text,tbPassword.Text,rbStudent.Checked);
            }
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(tbRePassword.Text)
                || string.IsNullOrWhiteSpace(tbPassword.Text)
                || string.IsNullOrWhiteSpace(tbEmail.Text)
                || tbEmail.Text.ToLower().Equals("email")
                || tbPassword.Text.ToLower().Equals("password")
                || tbEmail.Text.ToLower().Equals("re-type password")
            )

            {
                MessageBox.Show("Please fill out all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!tbPassword.Text.Equals(tbRePassword.Text))
            {
                MessageBox.Show("Password fields do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var emailRegex = AuthController.GetEmailRegex();
            var passwordRegex = AuthController.GetPasswordRegex();
          
            if (!emailRegex.IsMatch(tbEmail.Text))
            {
                MessageBox.Show("Invalid Email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!passwordRegex.IsMatch(tbPassword.Text))
            {
                MessageBox.Show("Password Requirements do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void lblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInView view = new SignInView();
            view.Show();
            this.Close();
        }
    }
}
