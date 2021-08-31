using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vplquiz.Models;
using Vplquiz.Controllers;

namespace Vplquiz.Views
{
    public partial class StudentDashboardView : Form
    {
        private Student entity;
        public StudentDashboardView(Student student)
        {
            InitializeComponent();
            entity = student;
            if (entity is null)
            {
                MessageBox.Show("StudentDashboardView was created with a null student");
                this.Close();
                EntryView.Instance.Show();
            }

            lblWelcome.Text = "Welcome " + entity.EmailAddress;
            tbName.Text = entity.Name;
            tbPhoneNumber.Text = entity.PhoneNum;
            rtbEducation.Text = entity.Education;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text.Trim())
                || string.IsNullOrWhiteSpace(tbPhoneNumber.Text.Trim())
                || string.IsNullOrWhiteSpace(rtbEducation.Text.Trim())
                )
            {
                MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK);
                return;
            }

            foreach(var ch in tbPhoneNumber.Text)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Phone number can only contain Numbers");
                    return;
                }
            }

            var res = StudentController.Instance.Update(entity.Id, tbName.Text, tbPhoneNumber.Text, rtbEducation.Text);
            entity = res;
            MessageBox.Show("Record Updated!");

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuthController.Instance.RemoveCookie();
            this.Close();
            EntryView.Instance.Show();
        }
    }
}
