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
using System.IO;
namespace RadientHospital.Views
{
    public partial class PatientGridView : Form
    {
        //private object openFileDialog1;

        public PatientGridView()
        {
            InitializeComponent();
        }

        private void PatientGridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_RadientHospital_HospitalModelDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this._RadientHospital_HospitalModelDataSet.Patients);
            using (var db = new HospitalModel())
            {   
                var row = db.patient.ToList();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = row;
                DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();
                editbutton.FlatStyle = FlatStyle.Popup;
                editbutton.HeaderText = "Edit";
                editbutton.Name = "Edit";
                editbutton.UseColumnTextForButtonValue = true;
                editbutton.Text = "Add Appointment";
                editbutton.Width = 100;
                dataGridView1.Columns.Add(editbutton);

                DataGridViewButtonColumn consentform = new DataGridViewButtonColumn();
                consentform.FlatStyle = FlatStyle.Popup;
                consentform.HeaderText = "Upload consent";
                consentform.Name = "Upload consent";
                consentform.UseColumnTextForButtonValue = true;
                consentform.Text = "Upload consent";
                consentform.Width = 100;
                dataGridView1.Columns.Add(consentform);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.ColumnIndex == 5)
            {
                AddAppoinntmentForm aaf = new AddAppoinntmentForm();
                aaf.patientid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                aaf.patientname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                aaf.addAppointment();
                aaf.Show();
            }
            else if (e.ColumnIndex == 6)
            {
                PatientConsentPresenter pcp = new PatientConsentPresenter();
                DialogResult result = openFileDialog2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string file = openFileDialog2.FileName;
                    pcp.file = file;
                    pcp.patientid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    pcp.patientname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    pcp.addConsent(file);
                }
                
            }
        }
    }
}
