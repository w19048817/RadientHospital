namespace RadientHospital.Views
{
    partial class AddAppoinntmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_app_patientid = new System.Windows.Forms.Label();
            this.label_app_patientname = new System.Windows.Forms.Label();
            this.label_app_date = new System.Windows.Forms.Label();
            this.text_app_patient_id = new System.Windows.Forms.TextBox();
            this.text_app_patient_name = new System.Windows.Forms.TextBox();
            this.text_patient_appt_date = new System.Windows.Forms.DateTimePicker();
            this.Appointment_type = new System.Windows.Forms.ComboBox();
            this.lbl_appt_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_app_patientid
            // 
            this.label_app_patientid.AutoSize = true;
            this.label_app_patientid.Location = new System.Drawing.Point(194, 87);
            this.label_app_patientid.Name = "label_app_patientid";
            this.label_app_patientid.Size = new System.Drawing.Size(54, 13);
            this.label_app_patientid.TabIndex = 0;
            this.label_app_patientid.Text = "Patient ID";
            // 
            // label_app_patientname
            // 
            this.label_app_patientname.AutoSize = true;
            this.label_app_patientname.Location = new System.Drawing.Point(195, 122);
            this.label_app_patientname.Name = "label_app_patientname";
            this.label_app_patientname.Size = new System.Drawing.Size(71, 13);
            this.label_app_patientname.TabIndex = 1;
            this.label_app_patientname.Text = "Patient Name";
            // 
            // label_app_date
            // 
            this.label_app_date.AutoSize = true;
            this.label_app_date.Location = new System.Drawing.Point(173, 198);
            this.label_app_date.Name = "label_app_date";
            this.label_app_date.Size = new System.Drawing.Size(92, 13);
            this.label_app_date.TabIndex = 2;
            this.label_app_date.Text = "Appointment Date";
            // 
            // text_app_patient_id
            // 
            this.text_app_patient_id.Location = new System.Drawing.Point(294, 84);
            this.text_app_patient_id.Name = "text_app_patient_id";
            this.text_app_patient_id.ReadOnly = true;
            this.text_app_patient_id.Size = new System.Drawing.Size(100, 20);
            this.text_app_patient_id.TabIndex = 3;
            // 
            // text_app_patient_name
            // 
            this.text_app_patient_name.Location = new System.Drawing.Point(294, 122);
            this.text_app_patient_name.Name = "text_app_patient_name";
            this.text_app_patient_name.ReadOnly = true;
            this.text_app_patient_name.Size = new System.Drawing.Size(100, 20);
            this.text_app_patient_name.TabIndex = 4;
            // 
            // text_patient_appt_date
            // 
            this.text_patient_appt_date.Location = new System.Drawing.Point(294, 198);
            this.text_patient_appt_date.Name = "text_patient_appt_date";
            this.text_patient_appt_date.Size = new System.Drawing.Size(200, 20);
            this.text_patient_appt_date.TabIndex = 5;
            // 
            // Appointment_type
            // 
            this.Appointment_type.FormattingEnabled = true;
            this.Appointment_type.Items.AddRange(new object[] {
            "General",
            "Emergency"});
            this.Appointment_type.Location = new System.Drawing.Point(294, 159);
            this.Appointment_type.Name = "Appointment_type";
            this.Appointment_type.Size = new System.Drawing.Size(121, 21);
            this.Appointment_type.TabIndex = 6;
            // 
            // lbl_appt_type
            // 
            this.lbl_appt_type.AutoSize = true;
            this.lbl_appt_type.Location = new System.Drawing.Point(173, 159);
            this.lbl_appt_type.Name = "lbl_appt_type";
            this.lbl_appt_type.Size = new System.Drawing.Size(93, 13);
            this.lbl_appt_type.TabIndex = 7;
            this.lbl_appt_type.Text = "Appointment Type";
            // 
            // AddAppoinntmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_appt_type);
            this.Controls.Add(this.Appointment_type);
            this.Controls.Add(this.text_patient_appt_date);
            this.Controls.Add(this.text_app_patient_name);
            this.Controls.Add(this.text_app_patient_id);
            this.Controls.Add(this.label_app_date);
            this.Controls.Add(this.label_app_patientname);
            this.Controls.Add(this.label_app_patientid);
            this.Name = "AddAppoinntmentForm";
            this.Text = "AddAppoinntmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_app_patientid;
        private System.Windows.Forms.Label label_app_patientname;
        private System.Windows.Forms.Label label_app_date;
        private System.Windows.Forms.TextBox text_app_patient_id;
        private System.Windows.Forms.TextBox text_app_patient_name;
        private System.Windows.Forms.DateTimePicker text_patient_appt_date;
        private System.Windows.Forms.ComboBox Appointment_type;
        private System.Windows.Forms.Label lbl_appt_type;
    }
}