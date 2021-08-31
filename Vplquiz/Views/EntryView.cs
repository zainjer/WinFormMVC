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

namespace Vplquiz.Views
{
    public partial class EntryView : Form
    {
        private static EntryView _instance;
        public static EntryView Instance => _instance ?? (_instance = new EntryView());

        public EntryView()
        {
            InitializeComponent();
            _instance = this;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            EntryController.Instance.Startup();
            this.Hide();
            
        }
    }
}
