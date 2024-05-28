
namespace clinic
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.MainMenulabel = new System.Windows.Forms.Label();
            this.TPSearchbutton = new System.Windows.Forms.Button();
            this.TPDelbutton = new System.Windows.Forms.Button();
            this.TPMainMenuExitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenulabel
            // 
            this.MainMenulabel.AutoSize = true;
            this.MainMenulabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenulabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenulabel.Location = new System.Drawing.Point(270, 44);
            this.MainMenulabel.Name = "MainMenulabel";
            this.MainMenulabel.Size = new System.Drawing.Size(481, 51);
            this.MainMenulabel.TabIndex = 1;
            this.MainMenulabel.Text = "Процедури лікування";
            // 
            // TPSearchbutton
            // 
            this.TPSearchbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TPSearchbutton.Location = new System.Drawing.Point(73, 126);
            this.TPSearchbutton.Name = "TPSearchbutton";
            this.TPSearchbutton.Size = new System.Drawing.Size(231, 44);
            this.TPSearchbutton.TabIndex = 6;
            this.TPSearchbutton.Text = "Пошук";
            this.TPSearchbutton.UseVisualStyleBackColor = true;
            // 
            // TPDelbutton
            // 
            this.TPDelbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TPDelbutton.Location = new System.Drawing.Point(73, 186);
            this.TPDelbutton.Name = "TPDelbutton";
            this.TPDelbutton.Size = new System.Drawing.Size(231, 44);
            this.TPDelbutton.TabIndex = 9;
            this.TPDelbutton.Text = "Видалити";
            this.TPDelbutton.UseVisualStyleBackColor = true;
            // 
            // TPMainMenuExitbutton
            // 
            this.TPMainMenuExitbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TPMainMenuExitbutton.Location = new System.Drawing.Point(73, 246);
            this.TPMainMenuExitbutton.Name = "TPMainMenuExitbutton";
            this.TPMainMenuExitbutton.Size = new System.Drawing.Size(231, 44);
            this.TPMainMenuExitbutton.TabIndex = 10;
            this.TPMainMenuExitbutton.Text = "Головне меню";
            this.TPMainMenuExitbutton.UseVisualStyleBackColor = true;
            this.TPMainMenuExitbutton.Click += new System.EventHandler(this.TPMainMenuExitbutton_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.TPMainMenuExitbutton);
            this.Controls.Add(this.TPDelbutton);
            this.Controls.Add(this.TPSearchbutton);
            this.Controls.Add(this.MainMenulabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APM адміністратора стоматологічної клініки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenulabel;
        private System.Windows.Forms.Button TPSearchbutton;
        private System.Windows.Forms.Button TPDelbutton;
        private System.Windows.Forms.Button TPMainMenuExitbutton;
    }
}