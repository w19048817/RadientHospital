namespace RadientHospital.Views
{
    partial class ExestingPatientsAppt
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
            this.lbl_exest_patientid = new System.Windows.Forms.Label();
            this.txt_exist_patientid = new System.Windows.Forms.TextBox();
            this.btn_exist_patientid = new System.Windows.Forms.Button();
            this.lbl_exist_patientname = new System.Windows.Forms.Label();
            this.txt_exist_patientname = new System.Windows.Forms.TextBox();
            this.lbl_exist_appt_type = new System.Windows.Forms.Label();
            this.lbl_exist_appt_date = new System.Windows.Forms.Label();
            this.txt_exist_appt_type = new System.Windows.Forms.ComboBox();
            this.txt_exist_appt_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_exest_patientid
            // 
            this.lbl_exest_patientid.AutoSize = true;
            this.lbl_exest_patientid.Location = new System.Drawing.Point(223, 77);
            this.lbl_exest_patientid.Name = "lbl_exest_patientid";
            this.lbl_exest_patientid.Size = new System.Drawing.Size(54, 13);
            this.lbl_exest_patientid.TabIndex = 0;
            this.lbl_exest_patientid.Text = "Patient ID";
            // 
            // txt_exist_patientid
            // 
            this.txt_exist_patientid.Location = new System.Drawing.Point(292, 74);
            this.txt_exist_patientid.Name = "txt_exist_patientid";
            this.txt_exist_patientid.Size = new System.Drawing.Size(100, 20);
            this.txt_exist_patientid.TabIndex = 1;
            // 
            // btn_exist_patientid
            // 
            this.btn_exist_patientid.Location = new System.Drawing.Point(428, 72);
            this.btn_exist_patientid.Name = "btn_exist_patientid";
            this.btn_exist_patientid.Size = new System.Drawing.Size(75, 23);
            this.btn_exist_patientid.TabIndex = 2;
            this.btn_exist_patientid.Text = "Search";
            this.btn_exist_patientid.UseVisualStyleBackColor = true;
            this.btn_exist_patientid.Click += new System.EventHandler(this.btn_exist_patientid_Click);
            // 
            // lbl_exist_patientname
            // 
            this.lbl_exist_patientname.AutoSize = true;
            this.lbl_exist_patientname.Location = new System.Drawing.Point(215, 131);
            this.lbl_exist_patientname.Name = "lbl_exist_patientname";
            this.lbl_exist_patientname.Size = new System.Drawing.Size(71, 13);
            this.lbl_exist_patientname.TabIndex = 3;
            this.lbl_exist_patientname.Text = "Patient Name";
            // 
            // txt_exist_patientname
            // 
            this.txt_exist_patientname.Location = new System.Drawing.Point(292, 128);
            this.txt_exist_patientname.Name = "txt_exist_patientname";
            this.txt_exist_patientname.Size = new System.Drawing.Size(100, 20);
            this.txt_exist_patientname.TabIndex = 4;
            // 
            // lbl_exist_appt_type
            // 
            this.lbl_exist_appt_type.AutoSize = true;
            this.lbl_exist_appt_type.Location = new System.Drawing.Point(184, 173);
            this.lbl_exist_appt_type.Name = "lbl_exist_appt_type";
            this.lbl_exist_appt_type.Size = new System.Drawing.Size(93, 13);
            this.lbl_exist_appt_type.TabIndex = 5;
            this.lbl_exist_appt_type.Text = "Appointment Type";
            // 
            // lbl_exist_appt_date
            // 
            this.lbl_exist_appt_date.AutoSize = true;
            this.lbl_exist_appt_date.Location = new System.Drawing.Point(184, 224);
            this.lbl_exist_appt_date.Name = "lbl_exist_appt_date";
            this.lbl_exist_appt_date.Size = new System.Drawing.Size(92, 13);
            this.lbl_exist_appt_date.TabIndex = 6;
            this.lbl_exist_appt_date.Text = "Appointment Date";
            // 
            // txt_exist_appt_type
            // 
            this.txt_exist_appt_type.FormattingEnabled = true;
            this.txt_exist_appt_type.Items.AddRange(new object[] {
            "General",
            "Emergency"});
            this.txt_exist_appt_type.Location = new System.Drawing.Point(292, 170);
            this.txt_exist_appt_type.Name = "txt_exist_appt_type";
            this.txt_exist_appt_type.Size = new System.Drawing.Size(121, 21);
            this.txt_exist_appt_type.TabIndex = 7;
            // 
            // txt_exist_appt_date
            // 
            this.txt_exist_appt_date.Location = new System.Drawing.Point(292, 217);
            this.txt_exist_appt_date.Name = "txt_exist_appt_date";
            this.txt_exist_appt_date.Size = new System.Drawing.Size(200, 20);
            this.txt_exist_appt_date.TabIndex = 8;
            // 
            // ExestingPatientsAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_exist_appt_date);
            this.Controls.Add(this.txt_exist_appt_type);
            this.Controls.Add(this.lbl_exist_appt_date);
            this.Controls.Add(this.lbl_exist_appt_type);
            this.Controls.Add(this.txt_exist_patientname);
            this.Controls.Add(this.lbl_exist_patientname);
            this.Controls.Add(this.btn_exist_patientid);
            this.Controls.Add(this.txt_exist_patientid);
            this.Controls.Add(this.lbl_exest_patientid);
            this.Name = "ExestingPatientsAppt";
            this.Text = "ExestingPatientsAppt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_exest_patientid;
        private System.Windows.Forms.TextBox txt_exist_patientid;
        private System.Windows.Forms.Button btn_exist_patientid;
        private System.Windows.Forms.Label lbl_exist_patientname;
        private System.Windows.Forms.TextBox txt_exist_patientname;
        private System.Windows.Forms.Label lbl_exist_appt_type;
        private System.Windows.Forms.Label lbl_exist_appt_date;
        private System.Windows.Forms.ComboBox txt_exist_appt_type;
        private System.Windows.Forms.DateTimePicker txt_exist_appt_date;
    }
}