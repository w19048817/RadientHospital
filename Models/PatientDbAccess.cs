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
    }
}
