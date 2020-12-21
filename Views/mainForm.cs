using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadientHospital.Views
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void receptionistbtn_Click(object sender, EventArgs e)
        {
            Receptionist rep = new Receptionist();
            rep.Show();
            Visible = false;
        }
    }
}
