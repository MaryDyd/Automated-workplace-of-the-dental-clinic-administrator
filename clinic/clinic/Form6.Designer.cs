
namespace clinic
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.Dentistlabel = new System.Windows.Forms.Label();
            this.DSearchbutton = new System.Windows.Forms.Button();
            this.DRedbutton = new System.Windows.Forms.Button();
            this.DMainMenuExitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dentistlabel
            // 
            this.Dentistlabel.AutoSize = true;
            this.Dentistlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dentistlabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dentistlabel.Location = new System.Drawing.Point(450, 44);
            this.Dentistlabel.Name = "Dentistlabel";
            this.Dentistlabel.Size = new System.Drawing.Size(136, 51);
            this.Dentistlabel.TabIndex = 1;
            this.Dentistlabel.Text = "Лікар";
            // 
            // DSearchbutton
            // 
            this.DSearchbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DSearchbutton.Location = new System.Drawing.Point(73, 126);
            this.DSearchbutton.Name = "DSearchbutton";
            this.DSearchbutton.Size = new System.Drawing.Size(231, 44);
            this.DSearchbutton.TabIndex = 5;
            this.DSearchbutton.Text = "Пошук";
            this.DSearchbutton.UseVisualStyleBackColor = true;
            // 
            // DRedbutton
            // 
            this.DRedbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DRedbutton.Location = new System.Drawing.Point(73, 186);
            this.DRedbutton.Name = "DRedbutton";
            this.DRedbutton.Size = new System.Drawing.Size(231, 44);
            this.DRedbutton.TabIndex = 7;
            this.DRedbutton.Text = "Редагувати";
            this.DRedbutton.UseVisualStyleBackColor = true;
            // 
            // DMainMenuExitbutton
            // 
            this.DMainMenuExitbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DMainMenuExitbutton.Location = new System.Drawing.Point(73, 246);
            this.DMainMenuExitbutton.Name = "DMainMenuExitbutton";
            this.DMainMenuExitbutton.Size = new System.Drawing.Size(231, 44);
            this.DMainMenuExitbutton.TabIndex = 9;
            this.DMainMenuExitbutton.Text = "Головне меню";
            this.DMainMenuExitbutton.UseVisualStyleBackColor = true;
            this.DMainMenuExitbutton.Click += new System.EventHandler(this.DMainMenuExitbutton_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 733);
            this.Controls.Add(this.DMainMenuExitbutton);
            this.Controls.Add(this.DRedbutton);
            this.Controls.Add(this.DSearchbutton);
            this.Controls.Add(this.Dentistlabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APM адміністратора стоматологічної клініки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dentistlabel;
        private System.Windows.Forms.Button DSearchbutton;
        private System.Windows.Forms.Button DRedbutton;
        private System.Windows.Forms.Button DMainMenuExitbutton;
    }
}