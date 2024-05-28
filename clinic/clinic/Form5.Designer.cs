
namespace clinic
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.Appointmentlabel = new System.Windows.Forms.Label();
            this.ASearchbutton = new System.Windows.Forms.Button();
            this.AADDbutton = new System.Windows.Forms.Button();
            this.ADelbutton = new System.Windows.Forms.Button();
            this.AMainMenuExitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Appointmentlabel
            // 
            this.Appointmentlabel.AutoSize = true;
            this.Appointmentlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Appointmentlabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appointmentlabel.Location = new System.Drawing.Point(334, 44);
            this.Appointmentlabel.Name = "Appointmentlabel";
            this.Appointmentlabel.Size = new System.Drawing.Size(370, 51);
            this.Appointmentlabel.TabIndex = 1;
            this.Appointmentlabel.Text = "Прийом у лікаря";
            // 
            // ASearchbutton
            // 
            this.ASearchbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ASearchbutton.Location = new System.Drawing.Point(73, 126);
            this.ASearchbutton.Name = "ASearchbutton";
            this.ASearchbutton.Size = new System.Drawing.Size(231, 44);
            this.ASearchbutton.TabIndex = 2;
            this.ASearchbutton.Text = "Пошук";
            this.ASearchbutton.UseVisualStyleBackColor = true;
            // 
            // AADDbutton
            // 
            this.AADDbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AADDbutton.Location = new System.Drawing.Point(73, 186);
            this.AADDbutton.Name = "AADDbutton";
            this.AADDbutton.Size = new System.Drawing.Size(231, 44);
            this.AADDbutton.TabIndex = 3;
            this.AADDbutton.Text = "Додати";
            this.AADDbutton.UseVisualStyleBackColor = true;
            // 
            // ADelbutton
            // 
            this.ADelbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADelbutton.Location = new System.Drawing.Point(73, 246);
            this.ADelbutton.Name = "ADelbutton";
            this.ADelbutton.Size = new System.Drawing.Size(231, 44);
            this.ADelbutton.TabIndex = 4;
            this.ADelbutton.Text = "Видалити";
            this.ADelbutton.UseVisualStyleBackColor = true;
            // 
            // AMainMenuExitbutton
            // 
            this.AMainMenuExitbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AMainMenuExitbutton.Location = new System.Drawing.Point(73, 306);
            this.AMainMenuExitbutton.Name = "AMainMenuExitbutton";
            this.AMainMenuExitbutton.Size = new System.Drawing.Size(231, 44);
            this.AMainMenuExitbutton.TabIndex = 5;
            this.AMainMenuExitbutton.Text = "Головне меню";
            this.AMainMenuExitbutton.UseVisualStyleBackColor = true;
            this.AMainMenuExitbutton.Click += new System.EventHandler(this.AMainMenuExitbutton_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 733);
            this.Controls.Add(this.AMainMenuExitbutton);
            this.Controls.Add(this.ADelbutton);
            this.Controls.Add(this.AADDbutton);
            this.Controls.Add(this.ASearchbutton);
            this.Controls.Add(this.Appointmentlabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APM адміністратора стоматологічної клініки";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Appointmentlabel;
        private System.Windows.Forms.Button ASearchbutton;
        private System.Windows.Forms.Button AADDbutton;
        private System.Windows.Forms.Button ADelbutton;
        private System.Windows.Forms.Button AMainMenuExitbutton;
    }
}