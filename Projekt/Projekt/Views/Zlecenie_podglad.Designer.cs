namespace Projekt.Views
{
    partial class Zlecenie_podglad
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
            this.labelDriver = new System.Windows.Forms.Label();
            this.labelDriverName = new System.Windows.Forms.Label();
            this.labelLicensePlate = new System.Windows.Forms.Label();
            this.labelLicensePlateNumber = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelDateFromNumber = new System.Windows.Forms.Label();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.labelDateToNumber = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFromName = new System.Windows.Forms.Label();
            this.labelToName = new System.Windows.Forms.Label();
            this.labelCommodity = new System.Windows.Forms.Label();
            this.listBoxCommodity = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelDriver
            // 
            this.labelDriver.AutoSize = true;
            this.labelDriver.Location = new System.Drawing.Point(25, 28);
            this.labelDriver.Name = "labelDriver";
            this.labelDriver.Size = new System.Drawing.Size(69, 17);
            this.labelDriver.TabIndex = 0;
            this.labelDriver.Text = "Kierowca:";
            // 
            // labelDriverName
            // 
            this.labelDriverName.AutoSize = true;
            this.labelDriverName.Location = new System.Drawing.Point(164, 28);
            this.labelDriverName.Name = "labelDriverName";
            this.labelDriverName.Size = new System.Drawing.Size(96, 17);
            this.labelDriverName.TabIndex = 1;
            this.labelDriverName.Text = "Imie Nazwisko";
            // 
            // labelLicensePlate
            // 
            this.labelLicensePlate.AutoSize = true;
            this.labelLicensePlate.Location = new System.Drawing.Point(25, 66);
            this.labelLicensePlate.Name = "labelLicensePlate";
            this.labelLicensePlate.Size = new System.Drawing.Size(111, 17);
            this.labelLicensePlate.TabIndex = 2;
            this.labelLicensePlate.Text = "Nr rejestracyjny:";
            // 
            // labelLicensePlateNumber
            // 
            this.labelLicensePlateNumber.AutoSize = true;
            this.labelLicensePlateNumber.Location = new System.Drawing.Point(164, 66);
            this.labelLicensePlateNumber.Name = "labelLicensePlateNumber";
            this.labelLicensePlateNumber.Size = new System.Drawing.Size(75, 17);
            this.labelLicensePlateNumber.TabIndex = 3;
            this.labelLicensePlateNumber.Text = "AAA 11 22";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(25, 107);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(122, 17);
            this.labelDateFrom.TabIndex = 4;
            this.labelDateFrom.Text = "Data rozpoczęcia:";
            // 
            // labelDateFromNumber
            // 
            this.labelDateFromNumber.AutoSize = true;
            this.labelDateFromNumber.Location = new System.Drawing.Point(164, 107);
            this.labelDateFromNumber.Name = "labelDateFromNumber";
            this.labelDateFromNumber.Size = new System.Drawing.Size(82, 17);
            this.labelDateFromNumber.TabIndex = 5;
            this.labelDateFromNumber.Text = "0000-00-00";
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(329, 107);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(125, 17);
            this.labelDateTo.TabIndex = 6;
            this.labelDateTo.Text = "Data zakończenia:";
            // 
            // labelDateToNumber
            // 
            this.labelDateToNumber.AutoSize = true;
            this.labelDateToNumber.Location = new System.Drawing.Point(473, 107);
            this.labelDateToNumber.Name = "labelDateToNumber";
            this.labelDateToNumber.Size = new System.Drawing.Size(82, 17);
            this.labelDateToNumber.TabIndex = 7;
            this.labelDateToNumber.Text = "0000-00-00";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(25, 148);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(60, 17);
            this.labelFrom.TabIndex = 8;
            this.labelFrom.Text = "Trasa z:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(329, 148);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(69, 17);
            this.labelTo.TabIndex = 9;
            this.labelTo.Text = "Trasa do:";
            // 
            // labelFromName
            // 
            this.labelFromName.AutoSize = true;
            this.labelFromName.Location = new System.Drawing.Point(164, 148);
            this.labelFromName.Name = "labelFromName";
            this.labelFromName.Size = new System.Drawing.Size(98, 17);
            this.labelFromName.TabIndex = 10;
            this.labelFromName.Text = "Miasto1, Kraj1";
            // 
            // labelToName
            // 
            this.labelToName.AutoSize = true;
            this.labelToName.Location = new System.Drawing.Point(473, 148);
            this.labelToName.Name = "labelToName";
            this.labelToName.Size = new System.Drawing.Size(102, 17);
            this.labelToName.TabIndex = 11;
            this.labelToName.Text = "Miasto 2, Kraj2";
            // 
            // labelCommodity
            // 
            this.labelCommodity.AutoSize = true;
            this.labelCommodity.Location = new System.Drawing.Point(25, 211);
            this.labelCommodity.Name = "labelCommodity";
            this.labelCommodity.Size = new System.Drawing.Size(51, 17);
            this.labelCommodity.TabIndex = 12;
            this.labelCommodity.Text = "Towar:";
            // 
            // listBoxCommodity
            // 
            this.listBoxCommodity.FormattingEnabled = true;
            this.listBoxCommodity.ItemHeight = 16;
            this.listBoxCommodity.Location = new System.Drawing.Point(28, 245);
            this.listBoxCommodity.MultiColumn = true;
            this.listBoxCommodity.Name = "listBoxCommodity";
            this.listBoxCommodity.Size = new System.Drawing.Size(586, 276);
            this.listBoxCommodity.TabIndex = 13;
            // 
            // Zlecenie_podglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 557);
            this.Controls.Add(this.listBoxCommodity);
            this.Controls.Add(this.labelCommodity);
            this.Controls.Add(this.labelToName);
            this.Controls.Add(this.labelFromName);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelDateToNumber);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.labelDateFromNumber);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.labelLicensePlateNumber);
            this.Controls.Add(this.labelLicensePlate);
            this.Controls.Add(this.labelDriverName);
            this.Controls.Add(this.labelDriver);
            this.Name = "Zlecenie_podglad";
            this.Text = "Podgląd zlecenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDriver;
        private System.Windows.Forms.Label labelDriverName;
        private System.Windows.Forms.Label labelLicensePlate;
        private System.Windows.Forms.Label labelLicensePlateNumber;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.Label labelDateFromNumber;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Label labelDateToNumber;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFromName;
        private System.Windows.Forms.Label labelToName;
        private System.Windows.Forms.Label labelCommodity;
        private System.Windows.Forms.ListBox listBoxCommodity;
    }
}