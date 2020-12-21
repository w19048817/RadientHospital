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
    public partial class ParientRegisterForm : Form, IRegisterPatient
    {
        public ParientRegisterForm()
        {
            InitializeComponent();
        }

        
        string IRegisterPatient.patientName_txt 
        {
            get
            {
                return patientName_txt.Text;
            }
            set
            {
                patientName_txt.Text = value;
            }
        }
        string IRegisterPatient.patientGender_txt 
        {
            get
            {
                return patientGender_txt.Text;
            }
            set
            {
                patientGender_txt.Text = value;
            }
        }
        DateTime IRegisterPatient.patientdob_txt 
        {
            get
            {
                return patientdob_txt.Value.Date;
            }
            set
            {
                patientdob_txt.Text = patientdob_txt.ToString();
            }
        }
        string IRegisterPatient.patientEmail_txt 
        {
            get
            {
                return patientEmail_txt.Text;
            }
            set
            {
                patientEmail_txt.Text = value;
            }
        }
        string IRegisterPatient.patientPostcode_txt 
        {
            get
            {
                return patientPostcode_txt.Text;
            }
            set
            {
                patientPostcode_txt.Text = value;
            }
        }
        string IRegisterPatient.patientAddress_txt
        {
            get
            {
                return patientAddress_txt.Text;
            }
            set
            {
                patientAddress_txt.Text = value;
            }
        }
        string IRegisterPatient.patientNHSnumber_txt 
        {
            get
            {
                return patientNHSnumber_txt.Text;
            }
            set
            {
                patientNHSnumber_txt.Text = value;
            }
        }
        string IRegisterPatient.patientGPname_txt 
        {
            get
            {
                return patientGPname_txt.Text;
            }
            set
            {
                patientGPname_txt.Text = value;
            }
        }
        string IRegisterPatient.patientGPaddress_txt
        {
            get
            {
                return patientGPaddress_txt.Text;
            }
            set
            {
                patientGPaddress_txt.Text = value;
            }
        }

        

        private void registerPatientbtn_Click(object sender, EventArgs e)
        {
            PatientRegisterPresenter prp = new PatientRegisterPresenter(this);
            prp.addPatient();
            MessageBox.Show("inserted sucessfully");
            Visible = false;
        }
    }
}
