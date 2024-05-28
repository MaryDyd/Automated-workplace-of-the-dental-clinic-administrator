
namespace clinic
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MainMenulabel = new System.Windows.Forms.Label();
            this.PatientRecordbutton = new System.Windows.Forms.Button();
            this.PatientCardbutton = new System.Windows.Forms.Button();
            this.Appointmentbutton = new System.Windows.Forms.Button();
            this.Dentistbutton = new System.Windows.Forms.Button();
            this.TreatmentProceduresbutton = new System.Windows.Forms.Button();
            this.ExitLogbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenulabel
            // 
            this.MainMenulabel.AutoSize = true;
            this.MainMenulabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenulabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenulabel.Location = new System.Drawing.Point(334, 44);
            this.MainMenulabel.Name = "MainMenulabel";
            this.MainMenulabel.Size = new System.Drawing.Size(327, 51);
            this.MainMenulabel.TabIndex = 0;
            this.MainMenulabel.Text = "Головне меню";
            // 
            // PatientRecordbutton
            // 
            this.PatientRecordbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientRecordbutton.Location = new System.Drawing.Point(73, 126);
            this.PatientRecordbutton.Name = "PatientRecordbutton";
            this.PatientRecordbutton.Size = new System.Drawing.Size(231, 44);
            this.PatientRecordbutton.TabIndex = 1;
            this.PatientRecordbutton.Text = "Запис пацієнта на прийом";
            this.PatientRecordbutton.UseVisualStyleBackColor = true;
            this.PatientRecordbutton.Click += new System.EventHandler(this.PatientRecordbutton_Click);
            // 
            // PatientCardbutton
            // 
            this.PatientCardbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientCardbutton.Location = new System.Drawing.Point(73, 186);
            this.PatientCardbutton.Name = "PatientCardbutton";
            this.PatientCardbutton.Size = new System.Drawing.Size(231, 44);
            this.PatientCardbutton.TabIndex = 2;
            this.PatientCardbutton.Text = "Карта пацієнта";
            this.PatientCardbutton.UseVisualStyleBackColor = true;
            this.PatientCardbutton.Click += new System.EventHandler(this.PatientCardbutton_Click);
            // 
            // Appointmentbutton
            // 
            this.Appointmentbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appointmentbutton.Location = new System.Drawing.Point(73, 246);
            this.Appointmentbutton.Name = "Appointmentbutton";
            this.Appointmentbutton.Size = new System.Drawing.Size(231, 44);
            this.Appointmentbutton.TabIndex = 3;
            this.Appointmentbutton.Text = "Прийом у лікаря";
            this.Appointmentbutton.UseVisualStyleBackColor = true;
            this.Appointmentbutton.Click += new System.EventHandler(this.Appointmentbutton_Click);
            // 
            // Dentistbutton
            // 
            this.Dentistbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dentistbutton.Location = new System.Drawing.Point(73, 306);
            this.Dentistbutton.Name = "Dentistbutton";
            this.Dentistbutton.Size = new System.Drawing.Size(231, 44);
            this.Dentistbutton.TabIndex = 4;
            this.Dentistbutton.Text = "Лікар";
            this.Dentistbutton.UseVisualStyleBackColor = true;
            this.Dentistbutton.Click += new System.EventHandler(this.Dentistbutton_Click);
            // 
            // TreatmentProceduresbutton
            // 
            this.TreatmentProceduresbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreatmentProceduresbutton.Location = new System.Drawing.Point(73, 366);
            this.TreatmentProceduresbutton.Name = "TreatmentProceduresbutton";
            this.TreatmentProceduresbutton.Size = new System.Drawing.Size(231, 44);
            this.TreatmentProceduresbutton.TabIndex = 5;
            this.TreatmentProceduresbutton.Text = "Процедури лікування";
            this.TreatmentProceduresbutton.UseVisualStyleBackColor = true;
            this.TreatmentProceduresbutton.Click += new System.EventHandler(this.TreatmentProceduresbutton_Click);
            // 
            // ExitLogbutton
            // 
            this.ExitLogbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitLogbutton.Location = new System.Drawing.Point(73, 427);
            this.ExitLogbutton.Name = "ExitLogbutton";
            this.ExitLogbutton.Size = new System.Drawing.Size(231, 44);
            this.ExitLogbutton.TabIndex = 6;
            this.ExitLogbutton.Text = "Закінчення сесії";
            this.ExitLogbutton.UseVisualStyleBackColor = true;
            this.ExitLogbutton.Click += new System.EventHandler(this.ExitLogbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ExitLogbutton);
            this.Controls.Add(this.TreatmentProceduresbutton);
            this.Controls.Add(this.Dentistbutton);
            this.Controls.Add(this.Appointmentbutton);
            this.Controls.Add(this.PatientCardbutton);
            this.Controls.Add(this.PatientRecordbutton);
            this.Controls.Add(this.MainMenulabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APM адміністратора стоматологічної клініки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenulabel;
        private System.Windows.Forms.Button PatientRecordbutton;
        private System.Windows.Forms.Button PatientCardbutton;
        private System.Windows.Forms.Button Appointmentbutton;
        private System.Windows.Forms.Button Dentistbutton;
        private System.Windows.Forms.Button TreatmentProceduresbutton;
        private System.Windows.Forms.Button ExitLogbutton;
    }
}