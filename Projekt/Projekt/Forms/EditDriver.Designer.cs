namespace Projekt.Forms
{
    partial class EditDriver
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
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.labelDriverName = new System.Windows.Forms.Label();
            this.labelDriverSurname = new System.Windows.Forms.Label();
            this.textBoxDriverSurname = new System.Windows.Forms.TextBox();
            this.textBoxDriverName = new System.Windows.Forms.TextBox();
            this.buttonDriverEdit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDriver
            // 
            this.groupBoxDriver.Controls.Add(this.labelDriverName);
            this.groupBoxDriver.Controls.Add(this.labelDriverSurname);
            this.groupBoxDriver.Controls.Add(this.textBoxDriverSurname);
            this.groupBoxDriver.Controls.Add(this.textBoxDriverName);
            this.groupBoxDriver.Location = new System.Drawing.Point(22, 105);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(288, 123);
            this.groupBoxDriver.TabIndex = 6;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Kierowca";
            // 
            // labelDriverName
            // 
            this.labelDriverName.AutoSize = true;
            this.labelDriverName.Location = new System.Drawing.Point(6, 36);
            this.labelDriverName.Name = "labelDriverName";
            this.labelDriverName.Size = new System.Drawing.Size(37, 17);
            this.labelDriverName.TabIndex = 0;
            this.labelDriverName.Text = "Imię:";
            // 
            // labelDriverSurname
            // 
            this.labelDriverSurname.AutoSize = true;
            this.labelDriverSurname.Location = new System.Drawing.Point(6, 75);
            this.labelDriverSurname.Name = "labelDriverSurname";
            this.labelDriverSurname.Size = new System.Drawing.Size(71, 17);
            this.labelDriverSurname.TabIndex = 1;
            this.labelDriverSurname.Text = "Nazwisko:";
            // 
            // textBoxDriverSurname
            // 
            this.textBoxDriverSurname.Location = new System.Drawing.Point(83, 75);
            this.textBoxDriverSurname.Name = "textBoxDriverSurname";
            this.textBoxDriverSurname.Size = new System.Drawing.Size(154, 22);
            this.textBoxDriverSurname.TabIndex = 3;
            // 
            // textBoxDriverName
            // 
            this.textBoxDriverName.Location = new System.Drawing.Point(83, 36);
            this.textBoxDriverName.Name = "textBoxDriverName";
            this.textBoxDriverName.Size = new System.Drawing.Size(154, 22);
            this.textBoxDriverName.TabIndex = 2;
            // 
            // buttonDriverEdit
            // 
            this.buttonDriverEdit.Location = new System.Drawing.Point(22, 245);
            this.buttonDriverEdit.Name = "buttonDriverEdit";
            this.buttonDriverEdit.Size = new System.Drawing.Size(288, 34);
            this.buttonDriverEdit.TabIndex = 7;
            this.buttonDriverEdit.Text = "Zapisz";
            this.buttonDriverEdit.UseVisualStyleBackColor = true;
            this.buttonDriverEdit.Click += new System.EventHandler(this.buttonDriverEdit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(22, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 31);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "<- Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // EditDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDriverEdit);
            this.Controls.Add(this.groupBoxDriver);
            this.Name = "EditDriver";
            this.Size = new System.Drawing.Size(323, 304);
            this.groupBoxDriver.ResumeLayout(false);
            this.groupBoxDriver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.Label labelDriverName;
        private System.Windows.Forms.Label labelDriverSurname;
        private System.Windows.Forms.TextBox textBoxDriverSurname;
        private System.Windows.Forms.TextBox textBoxDriverName;
        private System.Windows.Forms.Button buttonDriverEdit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
