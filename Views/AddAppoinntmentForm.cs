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
    public partial class AddAppoinntmentForm : Form
    {
        public AddAppoinntmentForm()
        {
            InitializeComponent();
        }
        public int patientid { get; set; }
        public string patientname { get; set; }

        //private void Form2_Load(object sender, EventArgs e)
        public void addAppointment()
        {
            text_app_patient_id.Text = patientid.ToString();
            text_app_patient_name.Text = patientname.ToString();
        }
    }
}
