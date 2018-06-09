namespace Projekt.Views
{
    partial class Ustawienia
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelNewPassword2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBoxChangePassword = new System.Windows.Forms.GroupBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.groupBoxChangePassword);
            this.groupBoxSettings.Location = new System.Drawing.Point(4, 4);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(368, 293);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Moje konto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktualne hasło:";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(6, 80);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(85, 17);
            this.labelNewPassword.TabIndex = 1;
            this.labelNewPassword.Text = "Nowe hasło:";
            // 
            // labelNewPassword2
            // 
            this.labelNewPassword2.AutoSize = true;
            this.labelNewPassword2.Location = new System.Drawing.Point(6, 121);
            this.labelNewPassword2.Name = "labelNewPassword2";
            this.labelNewPassword2.Size = new System.Drawing.Size(137, 17);
            this.labelNewPassword2.TabIndex = 2;
            this.labelNewPassword2.Text = "Powtórz nowe hasło:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(129, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(129, 22);
            this.textBox3.TabIndex = 5;
            // 
            // groupBoxChangePassword
            // 
            this.groupBoxChangePassword.Controls.Add(this.buttonChangePassword);
            this.groupBoxChangePassword.Controls.Add(this.label1);
            this.groupBoxChangePassword.Controls.Add(this.textBox3);
            this.groupBoxChangePassword.Controls.Add(this.labelNewPassword);
            this.groupBoxChangePassword.Controls.Add(this.textBox2);
            this.groupBoxChangePassword.Controls.Add(this.labelNewPassword2);
            this.groupBoxChangePassword.Controls.Add(this.textBox1);
            this.groupBoxChangePassword.Location = new System.Drawing.Point(18, 42);
            this.groupBoxChangePassword.Name = "groupBoxChangePassword";
            this.groupBoxChangePassword.Size = new System.Drawing.Size(318, 218);
            this.groupBoxChangePassword.TabIndex = 6;
            this.groupBoxChangePassword.TabStop = false;
            this.groupBoxChangePassword.Text = "Zmień hasło";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(159, 164);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(129, 32);
            this.buttonChangePassword.TabIndex = 6;
            this.buttonChangePassword.Text = "Zmień";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            // 
            // Ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "Ustawienia";
            this.Size = new System.Drawing.Size(402, 321);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxChangePassword.ResumeLayout(false);
            this.groupBoxChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNewPassword2;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxChangePassword;
        private System.Windows.Forms.Button buttonChangePassword;
    }
}
