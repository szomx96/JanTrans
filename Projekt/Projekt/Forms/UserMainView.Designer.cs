namespace Projekt.Forms
{
    partial class UserMainView
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
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.labelUserIDValue = new System.Windows.Forms.Label();
            this.labelUserLoginValue = new System.Windows.Forms.Label();
            this.labelUserSurnameValue = new System.Windows.Forms.Label();
            this.labelUserNameValue = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelUserSurname = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonMyOrders = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCurrentDate.Location = new System.Drawing.Point(13, 21);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(82, 17);
            this.labelCurrentDate.TabIndex = 9;
            this.labelCurrentDate.Text = "0000-00-00";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.labelUserIDValue);
            this.groupBoxUser.Controls.Add(this.labelUserLoginValue);
            this.groupBoxUser.Controls.Add(this.labelUserSurnameValue);
            this.groupBoxUser.Controls.Add(this.labelUserNameValue);
            this.groupBoxUser.Controls.Add(this.labelUserLogin);
            this.groupBoxUser.Controls.Add(this.labelUserID);
            this.groupBoxUser.Controls.Add(this.labelUserSurname);
            this.groupBoxUser.Controls.Add(this.labelUserName);
            this.groupBoxUser.Location = new System.Drawing.Point(13, 51);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(264, 232);
            this.groupBoxUser.TabIndex = 8;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Użytkownik";
            // 
            // labelUserIDValue
            // 
            this.labelUserIDValue.AutoSize = true;
            this.labelUserIDValue.Location = new System.Drawing.Point(99, 187);
            this.labelUserIDValue.Name = "labelUserIDValue";
            this.labelUserIDValue.Size = new System.Drawing.Size(55, 17);
            this.labelUserIDValue.TabIndex = 7;
            this.labelUserIDValue.Text = "IdValue";
            // 
            // labelUserLoginValue
            // 
            this.labelUserLoginValue.AutoSize = true;
            this.labelUserLoginValue.Location = new System.Drawing.Point(99, 159);
            this.labelUserLoginValue.Name = "labelUserLoginValue";
            this.labelUserLoginValue.Size = new System.Drawing.Size(79, 17);
            this.labelUserLoginValue.TabIndex = 6;
            this.labelUserLoginValue.Text = "LoginValue";
            // 
            // labelUserSurnameValue
            // 
            this.labelUserSurnameValue.AutoSize = true;
            this.labelUserSurnameValue.Location = new System.Drawing.Point(99, 68);
            this.labelUserSurnameValue.Name = "labelUserSurnameValue";
            this.labelUserSurnameValue.Size = new System.Drawing.Size(103, 17);
            this.labelUserSurnameValue.TabIndex = 5;
            this.labelUserSurnameValue.Text = "NazwiskoValue";
            // 
            // labelUserNameValue
            // 
            this.labelUserNameValue.AutoSize = true;
            this.labelUserNameValue.Location = new System.Drawing.Point(99, 37);
            this.labelUserNameValue.Name = "labelUserNameValue";
            this.labelUserNameValue.Size = new System.Drawing.Size(69, 17);
            this.labelUserNameValue.TabIndex = 4;
            this.labelUserNameValue.Text = "ImieValue";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Location = new System.Drawing.Point(7, 159);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(47, 17);
            this.labelUserLogin.TabIndex = 3;
            this.labelUserLogin.Text = "Login:";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(7, 187);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(25, 17);
            this.labelUserID.TabIndex = 2;
            this.labelUserID.Text = "ID:";
            // 
            // labelUserSurname
            // 
            this.labelUserSurname.AutoSize = true;
            this.labelUserSurname.Location = new System.Drawing.Point(6, 68);
            this.labelUserSurname.Name = "labelUserSurname";
            this.labelUserSurname.Size = new System.Drawing.Size(71, 17);
            this.labelUserSurname.TabIndex = 1;
            this.labelUserSurname.Text = "Nazwisko:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(7, 37);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(37, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Imię:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonMyOrders
            // 
            this.buttonMyOrders.Location = new System.Drawing.Point(318, 57);
            this.buttonMyOrders.Name = "buttonMyOrders";
            this.buttonMyOrders.Size = new System.Drawing.Size(221, 56);
            this.buttonMyOrders.TabIndex = 10;
            this.buttonMyOrders.Text = "Moje zlecenia";
            this.buttonMyOrders.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(318, 142);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(221, 56);
            this.buttonSettings.TabIndex = 11;
            this.buttonSettings.Text = "Ustawienia";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(318, 227);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(221, 56);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // UserMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonMyOrders);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserMainView";
            this.Size = new System.Drawing.Size(582, 350);
            this.Load += new System.EventHandler(this.UserMainView_Load);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label labelUserIDValue;
        private System.Windows.Forms.Label labelUserLoginValue;
        private System.Windows.Forms.Label labelUserSurnameValue;
        private System.Windows.Forms.Label labelUserNameValue;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelUserSurname;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonMyOrders;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonLogout;
    }
}
