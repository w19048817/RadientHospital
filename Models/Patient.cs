using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadientHospital.Models
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int patiendID { get; set; }
        public string patientName { get; set; }
        public DateTime patientDoB { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string postcode { get; set; }
        public string address { get; set; }
        public virtual PatientGpDetails patientGpDetails { get; set; }
        
    }

    public class PatientGpDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PatientGpDetailsId { get; set; }
        public string gpname { get; set; }
        public string gpaddress { get; set; }
    }
    
}
