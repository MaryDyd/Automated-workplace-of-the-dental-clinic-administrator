
namespace clinic
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.PtientRecordlabel = new System.Windows.Forms.Label();
            this.PRADDbutton = new System.Windows.Forms.Button();
            this.PRREDbutton1 = new System.Windows.Forms.Button();
            this.PRDELbutton = new System.Windows.Forms.Button();
            this.PRSERCHbutton = new System.Windows.Forms.Button();
            this.PRMainMenuExitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PtientRecordlabel
            // 
            this.PtientRecordlabel.AutoSize = true;
            this.PtientRecordlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PtientRecordlabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PtientRecordlabel.Location = new System.Drawing.Point(214, 44);
            this.PtientRecordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PtientRecordlabel.Name = "PtientRecordlabel";
            this.PtientRecordlabel.Size = new System.Drawing.Size(577, 51);
            this.PtientRecordlabel.TabIndex = 0;
            this.PtientRecordlabel.Text = "Запис пацієнта на прийом";
            // 
            // PRADDbutton
            // 
            this.PRADDbutton.Location = new System.Drawing.Point(73, 126);
            this.PRADDbutton.Name = "PRADDbutton";
            this.PRADDbutton.Size = new System.Drawing.Size(231, 44);
            this.PRADDbutton.TabIndex = 1;
            this.PRADDbutton.Text = "Додати";
            this.PRADDbutton.UseVisualStyleBackColor = true;
            this.PRADDbutton.Click += new System.EventHandler(this.PRADDbutton_Click);
            // 
            // PRREDbutton1
            // 
            this.PRREDbutton1.Location = new System.Drawing.Point(73, 186);
            this.PRREDbutton1.Name = "PRREDbutton1";
            this.PRREDbutton1.Size = new System.Drawing.Size(231, 44);
            this.PRREDbutton1.TabIndex = 2;
            this.PRREDbutton1.Text = "Редагувати";
            this.PRREDbutton1.UseVisualStyleBackColor = true;
            // 
            // PRDELbutton
            // 
            this.PRDELbutton.Location = new System.Drawing.Point(73, 246);
            this.PRDELbutton.Name = "PRDELbutton";
            this.PRDELbutton.Size = new System.Drawing.Size(231, 44);
            this.PRDELbutton.TabIndex = 3;
            this.PRDELbutton.Text = "Видалити";
            this.PRDELbutton.UseVisualStyleBackColor = true;
            // 
            // PRSERCHbutton
            // 
            this.PRSERCHbutton.Location = new System.Drawing.Point(73, 306);
            this.PRSERCHbutton.Name = "PRSERCHbutton";
            this.PRSERCHbutton.Size = new System.Drawing.Size(231, 44);
            this.PRSERCHbutton.TabIndex = 4;
            this.PRSERCHbutton.Text = "Пошук";
            this.PRSERCHbutton.UseVisualStyleBackColor = true;
            // 
            // PRMainMenuExitbutton
            // 
            this.PRMainMenuExitbutton.Location = new System.Drawing.Point(73, 366);
            this.PRMainMenuExitbutton.Name = "PRMainMenuExitbutton";
            this.PRMainMenuExitbutton.Size = new System.Drawing.Size(231, 44);
            this.PRMainMenuExitbutton.TabIndex = 5;
            this.PRMainMenuExitbutton.Text = "Головне меню";
            this.PRMainMenuExitbutton.UseVisualStyleBackColor = true;
            this.PRMainMenuExitbutton.Click += new System.EventHandler(this.PRMainMenuExitbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.PRMainMenuExitbutton);
            this.Controls.Add(this.PRSERCHbutton);
            this.Controls.Add(this.PRDELbutton);
            this.Controls.Add(this.PRREDbutton1);
            this.Controls.Add(this.PRADDbutton);
            this.Controls.Add(this.PtientRecordlabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APM адміністратора стоматологічної клініки";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PtientRecordlabel;
        private System.Windows.Forms.Button PRADDbutton;
        private System.Windows.Forms.Button PRREDbutton1;
        private System.Windows.Forms.Button PRDELbutton;
        private System.Windows.Forms.Button PRSERCHbutton;
        private System.Windows.Forms.Button PRMainMenuExitbutton;
    }
}