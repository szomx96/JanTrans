namespace Projekt.Forms
{
    partial class EditVehicle
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
            this.groupBoxVehicle = new System.Windows.Forms.GroupBox();
            this.textBoxVolumeValue = new System.Windows.Forms.TextBox();
            this.textBoxCapacityValue = new System.Windows.Forms.TextBox();
            this.textBoxRegistrationNumerValue = new System.Windows.Forms.TextBox();
            this.labelVehicleVolume = new System.Windows.Forms.Label();
            this.labelVehicleCapacity = new System.Windows.Forms.Label();
            this.labelVehicleNumber = new System.Windows.Forms.Label();
            this.buttonVehicleEdit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVehicle
            // 
            this.groupBoxVehicle.Controls.Add(this.textBoxVolumeValue);
            this.groupBoxVehicle.Controls.Add(this.textBoxCapacityValue);
            this.groupBoxVehicle.Controls.Add(this.textBoxRegistrationNumerValue);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleVolume);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleCapacity);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleNumber);
            this.groupBoxVehicle.Location = new System.Drawing.Point(22, 117);
            this.groupBoxVehicle.Name = "groupBoxVehicle";
            this.groupBoxVehicle.Size = new System.Drawing.Size(367, 182);
            this.groupBoxVehicle.TabIndex = 1;
            this.groupBoxVehicle.TabStop = false;
            this.groupBoxVehicle.Text = "Pojazd";
            // 
            // textBoxVolumeValue
            // 
            this.textBoxVolumeValue.Location = new System.Drawing.Point(149, 128);
            this.textBoxVolumeValue.Name = "textBoxVolumeValue";
            this.textBoxVolumeValue.Size = new System.Drawing.Size(151, 22);
            this.textBoxVolumeValue.TabIndex = 5;
            // 
            // textBoxCapacityValue
            // 
            this.textBoxCapacityValue.Location = new System.Drawing.Point(149, 88);
            this.textBoxCapacityValue.Name = "textBoxCapacityValue";
            this.textBoxCapacityValue.Size = new System.Drawing.Size(151, 22);
            this.textBoxCapacityValue.TabIndex = 4;
            // 
            // textBoxRegistrationNumerValue
            // 
            this.textBoxRegistrationNumerValue.Location = new System.Drawing.Point(149, 50);
            this.textBoxRegistrationNumerValue.Name = "textBoxRegistrationNumerValue";
            this.textBoxRegistrationNumerValue.Size = new System.Drawing.Size(151, 22);
            this.textBoxRegistrationNumerValue.TabIndex = 3;
            // 
            // labelVehicleVolume
            // 
            this.labelVehicleVolume.AutoSize = true;
            this.labelVehicleVolume.Location = new System.Drawing.Point(16, 128);
            this.labelVehicleVolume.Name = "labelVehicleVolume";
            this.labelVehicleVolume.Size = new System.Drawing.Size(81, 17);
            this.labelVehicleVolume.TabIndex = 2;
            this.labelVehicleVolume.Text = "Pojemność:";
            // 
            // labelVehicleCapacity
            // 
            this.labelVehicleCapacity.AutoSize = true;
            this.labelVehicleCapacity.Location = new System.Drawing.Point(16, 88);
            this.labelVehicleCapacity.Name = "labelVehicleCapacity";
            this.labelVehicleCapacity.Size = new System.Drawing.Size(83, 17);
            this.labelVehicleCapacity.TabIndex = 1;
            this.labelVehicleCapacity.Text = "Ładowność:";
            // 
            // labelVehicleNumber
            // 
            this.labelVehicleNumber.AutoSize = true;
            this.labelVehicleNumber.Location = new System.Drawing.Point(16, 50);
            this.labelVehicleNumber.Name = "labelVehicleNumber";
            this.labelVehicleNumber.Size = new System.Drawing.Size(111, 17);
            this.labelVehicleNumber.TabIndex = 0;
            this.labelVehicleNumber.Text = "Nr rejestracyjny:";
            // 
            // buttonVehicleEdit
            // 
            this.buttonVehicleEdit.Location = new System.Drawing.Point(22, 315);
            this.buttonVehicleEdit.Name = "buttonVehicleEdit";
            this.buttonVehicleEdit.Size = new System.Drawing.Size(367, 41);
            this.buttonVehicleEdit.TabIndex = 2;
            this.buttonVehicleEdit.Text = "Zapisz";
            this.buttonVehicleEdit.UseVisualStyleBackColor = true;
            this.buttonVehicleEdit.Click += new System.EventHandler(this.buttonVehicleEdit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(22, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 31);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "<- Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(367, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // EditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonVehicleEdit);
            this.Controls.Add(this.groupBoxVehicle);
            this.Name = "EditVehicle";
            this.Size = new System.Drawing.Size(416, 384);
            this.groupBoxVehicle.ResumeLayout(false);
            this.groupBoxVehicle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVehicle;
        private System.Windows.Forms.TextBox textBoxVolumeValue;
        private System.Windows.Forms.TextBox textBoxCapacityValue;
        private System.Windows.Forms.TextBox textBoxRegistrationNumerValue;
        private System.Windows.Forms.Label labelVehicleVolume;
        private System.Windows.Forms.Label labelVehicleCapacity;
        private System.Windows.Forms.Label labelVehicleNumber;
        private System.Windows.Forms.Button buttonVehicleEdit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}
