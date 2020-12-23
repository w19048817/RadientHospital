using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RadientHospital.Presenter;

namespace RadientHospital.Views
{
    public partial class ExestingPatientsAppt : Form, IPatientAppointment
    {
        public ExestingPatientsAppt()
        {
            InitializeComponent();
        }
        string IPatientAppointment.patient_appt_type
        {
            get
            {
                return txt_exist_appt_type.Text;
            }
            set
            {
                txt_exist_appt_type.Text = value;
            }
        }
        DateTime IPatientAppointment.patient_appt_time
        {
            get
            {
                return txt_exist_appt_date.Value.Date;
            }
            set
            {
                txt_exist_appt_date.Text = txt_exist_appt_date.ToString();
            }
        }
        private void btn_exist_patientid_Click(object sender, EventArgs e)
        {
            var patientid = Int32.Parse(txt_exist_patientid.Text);
            //Console.WriteLine(patientid);
            PatientRegisterPresenter prp = new PatientRegisterPresenter();
            var patientobj = prp.getPatientByID(patientid);
            if (patientobj == null)
            {
                MessageBox.Show("no records found");
            }
            else
            {
                btn_exist_patientid.Hide();
                txt_exist_patientid.ReadOnly = true;
                txt_exist_patientname.Text = patientobj.patientName;
                txt_exist_patientname.ReadOnly = true;
            }
                
        }

    }
}
