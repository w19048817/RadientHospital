using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadientHospital.Views
{
    public partial class PatientGridView : Form
    {
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
                editbutton.Text = "edit";
                editbutton.Width = 60;
                dataGridView1.Columns.Add(editbutton);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                AddAppoinntmentForm aaf = new AddAppoinntmentForm();
                aaf.patientid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                aaf.patientname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                aaf.sai();
                aaf.Show();
            }
        }
    }
}
