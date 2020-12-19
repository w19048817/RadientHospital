using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadientHospital.Views
{
    interface IRegisterPatient
    {
        string patientName_txt { get; set; }
        string patientGender_txt { get; set; }
        DateTime patientdob_txt { get; set; }
        string patientEmail_txt { get; set; }
        string patientPostcode_txt { get; set; }
        string patientAddress_txt { get; set; }
        string patientNHSnumber_txt { get; set; }
        string patientGPname_txt { get; set; }
        string patientGPaddress_txt { get; set; }
    }
}
