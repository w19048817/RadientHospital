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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void newpatientsgridbtn_Click(object sender, EventArgs e)
        {
            PatientGridView pgv = new PatientGridView();
            pgv.Show();
        }

        private void regiterpatientbtn_Click(object sender, EventArgs e)
        {
            ParientRegisterForm prp = new ParientRegisterForm();
            prp.Show();
        }

        private void exesting_patients_btn_Click(object sender, EventArgs e)
        {
            ExestingPatientsAppt epa = new ExestingPatientsAppt();
            epa.Show();
        }
    }
}
