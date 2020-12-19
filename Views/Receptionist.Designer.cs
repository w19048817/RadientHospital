namespace RadientHospital.Views
{
    partial class Receptionist
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
            this.regiterpatientbtn = new System.Windows.Forms.Button();
            this.newpatientsgridbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regiterpatientbtn
            // 
            this.regiterpatientbtn.Location = new System.Drawing.Point(300, 39);
            this.regiterpatientbtn.Name = "regiterpatientbtn";
            this.regiterpatientbtn.Size = new System.Drawing.Size(119, 37);
            this.regiterpatientbtn.TabIndex = 0;
            this.regiterpatientbtn.Text = "RegisterPatient";
            this.regiterpatientbtn.UseVisualStyleBackColor = true;
            this.regiterpatientbtn.Click += new System.EventHandler(this.regiterpatientbtn_Click);
            // 
            // newpatientsgridbtn
            // 
            this.newpatientsgridbtn.Location = new System.Drawing.Point(300, 108);
            this.newpatientsgridbtn.Name = "newpatientsgridbtn";
            this.newpatientsgridbtn.Size = new System.Drawing.Size(119, 35);
            this.newpatientsgridbtn.TabIndex = 1;
            this.newpatientsgridbtn.Text = "NewPatientsGrid";
            this.newpatientsgridbtn.UseVisualStyleBackColor = true;
            this.newpatientsgridbtn.Click += new System.EventHandler(this.newpatientsgridbtn_Click);
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newpatientsgridbtn);
            this.Controls.Add(this.regiterpatientbtn);
            this.Name = "Receptionist";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button regiterpatientbtn;
        private System.Windows.Forms.Button newpatientsgridbtn;
    }
}