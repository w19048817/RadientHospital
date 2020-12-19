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
            this.label_patientid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_patientid
            // 
            this.label_patientid.AutoSize = true;
            this.label_patientid.Location = new System.Drawing.Point(276, 70);
            this.label_patientid.Name = "label_patientid";
            this.label_patientid.Size = new System.Drawing.Size(35, 13);
            this.label_patientid.TabIndex = 0;
            this.label_patientid.Text = "label1";
            // 
            // AddAppoinntmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_patientid);
            this.Name = "AddAppoinntmentForm";
            this.Text = "AddAppoinntmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_patientid;
    }
}