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

namespace Vplquiz.Views
{
    public partial class InstructorDashboardView : Form
    {
        private Instructor entity;
        public InstructorDashboardView(Instructor instructor)
        {
            InitializeComponent();
            entity = instructor;
            if (entity is null)
            {
                MessageBox.Show("StudentDashboardView was created with a null student");
                this.Close();
                EntryView.Instance.Show();
            }
        }

    }
}
