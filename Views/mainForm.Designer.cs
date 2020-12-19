namespace RadientHospital.Views
{
    partial class mainForm
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
            this.receptionistbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // receptionistbtn
            // 
            this.receptionistbtn.Location = new System.Drawing.Point(299, 97);
            this.receptionistbtn.Name = "receptionistbtn";
            this.receptionistbtn.Size = new System.Drawing.Size(107, 30);
            this.receptionistbtn.TabIndex = 0;
            this.receptionistbtn.Text = "Receptionist";
            this.receptionistbtn.UseVisualStyleBackColor = true;
            this.receptionistbtn.Click += new System.EventHandler(this.receptionistbtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receptionistbtn);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button receptionistbtn;
    }
}