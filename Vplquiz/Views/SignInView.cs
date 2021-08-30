using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
