using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadientHospital.Views
{
    interface IPatientAppointment
    {
        
        string patient_appt_type { get; set; }
        DateTime patient_appt_time { get; set; }
    }
}
