using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadientHospital.Models
{
    public class PatientDbAccess
    {
        public void addPatient(Models.Patient patient)
        {
            using (var db = new HospitalModel())
            {
                db.patient.Add(patient);
                db.SaveChanges();
            }
        }

        public List<Patient> getPatientsDb()
        {
            using (var db = new HospitalModel())
            {
                var patientList = from patient in  db.patient
                                  select patient;
                return patientList.ToList();
            }
        }

        public void addConsentForm()
        {

        }
        public Patient getPatientByIDDB(int patientid)
        {
            using (var db = new HospitalModel())
            {
                var getpatient = from patient in db.patient
                              where patient.patiendID == patientid
                              select patient;
                return getpatient.First();
            }
        }
    }
}
