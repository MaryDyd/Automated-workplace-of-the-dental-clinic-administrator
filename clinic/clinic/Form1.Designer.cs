
namespace clinic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.picture_login = new System.Windows.Forms.PictureBox();
            this.picture_password = new System.Windows.Forms.PictureBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.ExitProgrampictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitProgrampictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(387, 108);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(235, 23);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(387, 147);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(235, 23);
            this.textBox_password.TabIndex = 1;
            // 
            // picture_login
            // 
            this.picture_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_login.BackgroundImage")));
            this.picture_login.Location = new System.Drawing.Point(358, 108);
            this.picture_login.Name = "picture_login";
            this.picture_login.Size = new System.Drawing.Size(23, 23);
            this.picture_login.TabIndex = 2;
            this.picture_login.TabStop = false;
            // 
            // picture_password
            // 
            this.picture_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_password.BackgroundImage")));
            this.picture_password.Location = new System.Drawing.Point(358, 147);
            this.picture_password.Name = "picture_password";
            this.picture_password.Size = new System.Drawing.Size(23, 23);
            this.picture_password.TabIndex = 3;
            this.picture_password.TabStop = false;
            // 
            // button_enter
            // 
            this.button_enter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.Location = new System.Drawing.Point(421, 185);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(170, 39);
            this.button_enter.TabIndex = 4;
            this.button_enter.Text = "Вхід в систему";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // ExitProgrampictureBox
            // 
            this.ExitProgrampictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitProgrampictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitProgrampictureBox.Image")));
            this.ExitProgrampictureBox.Location = new System.Drawing.Point(2, 702);
            this.ExitProgrampictureBox.Name = "ExitProgrampictureBox";
            this.ExitProgrampictureBox.Size = new System.Drawing.Size(25, 25);
            this.ExitProgrampictureBox.TabIndex = 5;
            this.ExitProgrampictureBox.TabStop = false;
            this.ExitProgrampictureBox.Click += new System.EventHandler(this.ExitProgrampictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ExitProgrampictureBox);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.picture_password);
            this.Controls.Add(this.picture_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APM адміністратора стоматологічної клініки";
            ((System.ComponentModel.ISupportInitialize)(this.picture_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitProgrampictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.PictureBox picture_login;
        private System.Windows.Forms.PictureBox picture_password;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.PictureBox ExitProgrampictureBox;
    }
}

