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
using Vplquiz.Models;

namespace Vplquiz.Views
{
    public partial class InstructorDashboardView : Form
    {
        private Instructor entity;
        private List<Student> _students;
        public InstructorDashboardView(Instructor instructor,List<Student> students)
        {
            InitializeComponent();
            entity = instructor;
            _students = students;
            if (entity is null)
            {
                MessageBox.Show("Instructor Dashboard View was created with a null Instructor");
                this.Close();
                EntryView.Instance.Show();
            }
            
            var studentEmails = students.Select(x => x.EmailAddress).ToArray();
            comboStudentEmails.Items.AddRange(studentEmails);
            
            //if(studentEmails.Length>0)
            //    comboStudentEmails.SelectedIndex=1;

            tbInstructorName.Text = entity.Name;
            tbInstructorPhone.Text = entity.PhoneNum;
            tbInstructorSpecialization.Text = entity.Specialization;
            rtbInstructorExperience.Text = entity.Experience;
            

        }

        private void comboStudentEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var studentEmail = (string)comboStudentEmails.SelectedItem;

            var student = _students.FirstOrDefault(x => x.EmailAddress.ToLower().Trim().Equals(studentEmail));

            tbStudentName.Text = student.Name;
            tbStudentPhoneNumber.Text = student.PhoneNum;
            rtbStudentEducation.Text = student.Education;

        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            var studentEmail = (string)comboStudentEmails.SelectedItem;
            var student = _students.FirstOrDefault(x => x.EmailAddress.ToLower().Trim().Equals(studentEmail));

            if (student != null)
            {
                StudentController.Instance.Update(student.Id, student.Name, student.PhoneNum, student.Education);
            }

            MessageBox.Show("Success", "Record updated for the student:"+studentEmail,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSaveInstructor_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbInstructorName.Text)
                || string.IsNullOrWhiteSpace(tbInstructorPhone.Text)
                || string.IsNullOrWhiteSpace(tbInstructorSpecialization.Text)
                || string.IsNullOrWhiteSpace(rtbInstructorExperience.Text)
                )
            {
                MessageBox.Show("Error", "Please fill all feilds");
                return;
            }

            entity.Name = tbInstructorName.Text;
            entity.PhoneNum = tbInstructorPhone.Text;
            entity.Specialization = tbInstructorSpecialization.Text;
            entity.Experience = rtbInstructorExperience.Text;

            InsctructorController.Instance.Update(entity.Id,entity.Name, entity.PhoneNum, entity.Specialization, entity.Experience);

            MessageBox.Show("Success", "Record updated for the Instructor:" + entity.EmailAddress, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuthController.Instance.RemoveCookie();
            this.Close();
            EntryView.Instance.Show();
        }
    }
}
