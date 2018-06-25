namespace Projekt.Forms
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxChangePassword = new System.Windows.Forms.GroupBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewPassRepeat = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.labelNewPassword2 = new System.Windows.Forms.Label();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.groupBoxChangePassword);
            this.groupBoxSettings.Location = new System.Drawing.Point(8, 69);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(405, 292);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Moje konto";
            // 
            // groupBoxChangePassword
            // 
            this.groupBoxChangePassword.Controls.Add(this.buttonChangePassword);
            this.groupBoxChangePassword.Controls.Add(this.label1);
            this.groupBoxChangePassword.Controls.Add(this.textBoxNewPassRepeat);
            this.groupBoxChangePassword.Controls.Add(this.labelNewPassword);
            this.groupBoxChangePassword.Controls.Add(this.textBoxNewPass);
            this.groupBoxChangePassword.Controls.Add(this.labelNewPassword2);
            this.groupBoxChangePassword.Controls.Add(this.textBoxOldPass);
            this.groupBoxChangePassword.Location = new System.Drawing.Point(18, 42);
            this.groupBoxChangePassword.Name = "groupBoxChangePassword";
            this.groupBoxChangePassword.Size = new System.Drawing.Size(363, 218);
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
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
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
            // textBoxNewPassRepeat
            // 
            this.textBoxNewPassRepeat.Location = new System.Drawing.Point(159, 121);
            this.textBoxNewPassRepeat.Name = "textBoxNewPassRepeat";
            this.textBoxNewPassRepeat.PasswordChar = '*';
            this.textBoxNewPassRepeat.Size = new System.Drawing.Size(129, 22);
            this.textBoxNewPassRepeat.TabIndex = 5;
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
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(159, 80);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.PasswordChar = '*';
            this.textBoxNewPass.Size = new System.Drawing.Size(129, 22);
            this.textBoxNewPass.TabIndex = 4;
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
            // textBoxOldPass
            // 
            this.textBoxOldPass.Location = new System.Drawing.Point(159, 38);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.PasswordChar = '*';
            this.textBoxOldPass.Size = new System.Drawing.Size(129, 22);
            this.textBoxOldPass.TabIndex = 3;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(8, 14);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 31);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "<- Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(449, 400);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxChangePassword.ResumeLayout(false);
            this.groupBoxChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TextBox textBoxNewPassRepeat;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.Label labelNewPassword2;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxChangePassword;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
