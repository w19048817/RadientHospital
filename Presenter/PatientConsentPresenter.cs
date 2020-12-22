using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadientHospital.Models;

namespace RadientHospital.Presenter
{
    public class PatientConsentPresenter
    {
        public string file { get; set; }
        public int patientid { get; set; }
        public string patientname { get; set; }

        public void addConsent(string file)
        {
             string[] f = file.Split('\\');
             string filename = f[(f.Length) - 1];
             string dest = @"E:\netprojects\RadientHospital\ConcentForms\" + filename;
             File.Copy(file, dest, true);

            PatientDbAccess pda = new PatientDbAccess();
            pda.addConsentForm();
            //Console.WriteLine(filename);

        }
    }
}
