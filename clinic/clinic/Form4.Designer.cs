
namespace clinic
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.PatientCardlabel = new System.Windows.Forms.Label();
            this.PCSearchbutton = new System.Windows.Forms.Button();
            this.PCADDbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PCMainMenuExitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatientCardlabel
            // 
            this.PatientCardlabel.AutoSize = true;
            this.PatientCardlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatientCardlabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientCardlabel.Location = new System.Drawing.Point(334, 44);
            this.PatientCardlabel.Name = "PatientCardlabel";
            this.PatientCardlabel.Size = new System.Drawing.Size(336, 51);
            this.PatientCardlabel.TabIndex = 1;
            this.PatientCardlabel.Text = "Карта пацієнта";
            // 
            // PCSearchbutton
            // 
            this.PCSearchbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCSearchbutton.Location = new System.Drawing.Point(73, 126);
            this.PCSearchbutton.Name = "PCSearchbutton";
            this.PCSearchbutton.Size = new System.Drawing.Size(231, 44);
            this.PCSearchbutton.TabIndex = 3;
            this.PCSearchbutton.Text = "Пошук";
            this.PCSearchbutton.UseVisualStyleBackColor = true;
            // 
            // PCADDbutton
            // 
            this.PCADDbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCADDbutton.Location = new System.Drawing.Point(73, 186);
            this.PCADDbutton.Name = "PCADDbutton";
            this.PCADDbutton.Size = new System.Drawing.Size(231, 44);
            this.PCADDbutton.TabIndex = 4;
            this.PCADDbutton.Text = "Додати нову карту";
            this.PCADDbutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(73, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Редагувати карту";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PCMainMenuExitbutton
            // 
            this.PCMainMenuExitbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCMainMenuExitbutton.Location = new System.Drawing.Point(73, 306);
            this.PCMainMenuExitbutton.Name = "PCMainMenuExitbutton";
            this.PCMainMenuExitbutton.Size = new System.Drawing.Size(231, 44);
            this.PCMainMenuExitbutton.TabIndex = 6;
            this.PCMainMenuExitbutton.Text = "Головне меню";
            this.PCMainMenuExitbutton.UseVisualStyleBackColor = true;
            this.PCMainMenuExitbutton.Click += new System.EventHandler(this.PCMainMenuExitbutton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.PCMainMenuExitbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PCADDbutton);
            this.Controls.Add(this.PCSearchbutton);
            this.Controls.Add(this.PatientCardlabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APM адміністратора стоматологічної клініки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientCardlabel;
        private System.Windows.Forms.Button PCSearchbutton;
        private System.Windows.Forms.Button PCADDbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PCMainMenuExitbutton;
    }
}