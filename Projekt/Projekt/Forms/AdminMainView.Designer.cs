
namespace Projekt.Forms
{
    partial class AdminMainView
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
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noweZlecenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kierowcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pojazdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujKierowcówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujPojazdyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujZleceniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojeKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxUser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCurrentDate.Location = new System.Drawing.Point(12, 43);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(82, 17);
            this.labelCurrentDate.TabIndex = 6;
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
            this.groupBoxUser.Location = new System.Drawing.Point(12, 73);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(264, 232);
            this.groupBoxUser.TabIndex = 5;
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ustawieniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noweZlecenieToolStripMenuItem,
            this.kierowcaToolStripMenuItem,
            this.pojazdToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // noweZlecenieToolStripMenuItem
            // 
            this.noweZlecenieToolStripMenuItem.Name = "noweZlecenieToolStripMenuItem";
            this.noweZlecenieToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.noweZlecenieToolStripMenuItem.Text = "Nowe zlecenie";
            this.noweZlecenieToolStripMenuItem.Click += new System.EventHandler(this.noweZlecenieToolStripMenuItem_Click);
            // 
            // kierowcaToolStripMenuItem
            // 
            this.kierowcaToolStripMenuItem.Name = "kierowcaToolStripMenuItem";
            this.kierowcaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.kierowcaToolStripMenuItem.Text = "Kierowca";
            this.kierowcaToolStripMenuItem.Click += new System.EventHandler(this.kierowcaToolStripMenuItem_Click);
            // 
            // pojazdToolStripMenuItem
            // 
            this.pojazdToolStripMenuItem.Name = "pojazdToolStripMenuItem";
            this.pojazdToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pojazdToolStripMenuItem.Text = "Pojazd";
            this.pojazdToolStripMenuItem.Click += new System.EventHandler(this.pojazdToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytujKierowcówToolStripMenuItem,
            this.edytujPojazdyToolStripMenuItem,
            this.edytujZleceniaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.toolStripMenuItem1.Text = "Edytuj";
            // 
            // edytujKierowcówToolStripMenuItem
            // 
            this.edytujKierowcówToolStripMenuItem.Name = "edytujKierowcówToolStripMenuItem";
            this.edytujKierowcówToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.edytujKierowcówToolStripMenuItem.Text = "Edytuj kierowców";
            // 
            // edytujPojazdyToolStripMenuItem
            // 
            this.edytujPojazdyToolStripMenuItem.Name = "edytujPojazdyToolStripMenuItem";
            this.edytujPojazdyToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.edytujPojazdyToolStripMenuItem.Text = "Edytuj pojazdy";
            // 
            // edytujZleceniaToolStripMenuItem
            // 
            this.edytujZleceniaToolStripMenuItem.Name = "edytujZleceniaToolStripMenuItem";
            this.edytujZleceniaToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.edytujZleceniaToolStripMenuItem.Text = "Edytuj zlecenia";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojeKontoToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // mojeKontoToolStripMenuItem
            // 
            this.mojeKontoToolStripMenuItem.Name = "mojeKontoToolStripMenuItem";
            this.mojeKontoToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.mojeKontoToolStripMenuItem.Text = "Moje konto";
            // 
            // AdminMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdminMainView";
            this.Size = new System.Drawing.Size(954, 549);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noweZlecenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kierowcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pojazdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem edytujKierowcówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujPojazdyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujZleceniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojeKontoToolStripMenuItem;
    }
}
