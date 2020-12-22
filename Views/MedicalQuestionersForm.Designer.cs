namespace RadientHospital.Views
{
    partial class MedicalQuestionersForm
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
            this.lbl_medical_ques_1 = new System.Windows.Forms.Label();
            this.Medical_question_1_txt = new System.Windows.Forms.TextBox();
            this.RegisterPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_medical_ques_1
            // 
            this.lbl_medical_ques_1.AutoSize = true;
            this.lbl_medical_ques_1.Location = new System.Drawing.Point(210, 70);
            this.lbl_medical_ques_1.Name = "lbl_medical_ques_1";
            this.lbl_medical_ques_1.Size = new System.Drawing.Size(109, 13);
            this.lbl_medical_ques_1.TabIndex = 0;
            this.lbl_medical_ques_1.Text = "MedicalQuestioners 1";
            // 
            // Medical_question_1_txt
            // 
            this.Medical_question_1_txt.Location = new System.Drawing.Point(350, 63);
            this.Medical_question_1_txt.Name = "Medical_question_1_txt";
            this.Medical_question_1_txt.Size = new System.Drawing.Size(100, 20);
            this.Medical_question_1_txt.TabIndex = 1;
            // 
            // RegisterPatient
            // 
            this.RegisterPatient.Location = new System.Drawing.Point(291, 122);
            this.RegisterPatient.Name = "RegisterPatient";
            this.RegisterPatient.Size = new System.Drawing.Size(91, 23);
            this.RegisterPatient.TabIndex = 2;
            this.RegisterPatient.Text = "RegisterPatient";
            this.RegisterPatient.UseVisualStyleBackColor = true;
            // 
            // MedicalQuestionersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterPatient);
            this.Controls.Add(this.Medical_question_1_txt);
            this.Controls.Add(this.lbl_medical_ques_1);
            this.Name = "MedicalQuestionersForm";
            this.Text = "MedicalQuestionersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_medical_ques_1;
        private System.Windows.Forms.TextBox Medical_question_1_txt;
        private System.Windows.Forms.Button RegisterPatient;
    }
}