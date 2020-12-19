using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadientHospital.Models;
using RadientHospital.Views;

namespace RadientHospital.Presenter
{
     class PatientRegisterPresenter
    {
        private IRegisterPatient RegisterPatientView;
        public PatientRegisterPresenter(IRegisterPatient view)
        {
            RegisterPatientView = view;
        }
        public void addPatient()
        {
            Patient p = new Patient();
            p.patientName = RegisterPatientView.patientName_txt;
            p.gender = RegisterPatientView.patientGender_txt;
            p.patientDoB = RegisterPatientView.patientdob_txt;
            p.email = RegisterPatientView.patientEmail_txt;
            p.postcode = RegisterPatientView.patientPostcode_txt;
            p.address = RegisterPatientView.patientAddress_txt;

            PatientGpDetails pgpd = new PatientGpDetails();
            pgpd.gpname = RegisterPatientView.patientGPname_txt;
            pgpd.gpaddress = RegisterPatientView.patientGPaddress_txt;
            p.patientGpDetails = pgpd;

            PatientDbAccess pda = new PatientDbAccess();
            pda.addPatient(p);
        }
      }
}
