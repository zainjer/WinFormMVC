using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
