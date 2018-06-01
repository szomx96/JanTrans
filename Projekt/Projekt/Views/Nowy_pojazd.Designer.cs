namespace Projekt.Views
{
    partial class Nowy_pojazd
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
            this.groupBoxVehicle = new System.Windows.Forms.GroupBox();
            this.labelVehicleNumber = new System.Windows.Forms.Label();
            this.labelVehicleCapacity = new System.Windows.Forms.Label();
            this.labelVehicleVolume = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonVehicleAdd = new System.Windows.Forms.Button();
            this.groupBoxVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVehicle
            // 
            this.groupBoxVehicle.Controls.Add(this.textBox3);
            this.groupBoxVehicle.Controls.Add(this.textBox2);
            this.groupBoxVehicle.Controls.Add(this.textBox1);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleVolume);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleCapacity);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleNumber);
            this.groupBoxVehicle.Location = new System.Drawing.Point(12, 13);
            this.groupBoxVehicle.Name = "groupBoxVehicle";
            this.groupBoxVehicle.Size = new System.Drawing.Size(318, 182);
            this.groupBoxVehicle.TabIndex = 0;
            this.groupBoxVehicle.TabStop = false;
            this.groupBoxVehicle.Text = "Pojazd";
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
            // labelVehicleCapacity
            // 
            this.labelVehicleCapacity.AutoSize = true;
            this.labelVehicleCapacity.Location = new System.Drawing.Point(16, 88);
            this.labelVehicleCapacity.Name = "labelVehicleCapacity";
            this.labelVehicleCapacity.Size = new System.Drawing.Size(83, 17);
            this.labelVehicleCapacity.TabIndex = 1;
            this.labelVehicleCapacity.Text = "Ładowność:";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 22);
            this.textBox3.TabIndex = 5;
            // 
            // buttonVehicleAdd
            // 
            this.buttonVehicleAdd.Location = new System.Drawing.Point(161, 202);
            this.buttonVehicleAdd.Name = "buttonVehicleAdd";
            this.buttonVehicleAdd.Size = new System.Drawing.Size(169, 31);
            this.buttonVehicleAdd.TabIndex = 1;
            this.buttonVehicleAdd.Text = "Dodaj";
            this.buttonVehicleAdd.UseVisualStyleBackColor = true;
            // 
            // Nowy_pojazd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonVehicleAdd);
            this.Controls.Add(this.groupBoxVehicle);
            this.Name = "Nowy_pojazd";
            this.Size = new System.Drawing.Size(362, 256);
            this.groupBoxVehicle.ResumeLayout(false);
            this.groupBoxVehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVehicle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelVehicleVolume;
        private System.Windows.Forms.Label labelVehicleCapacity;
        private System.Windows.Forms.Label labelVehicleNumber;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonVehicleAdd;
    }
}
