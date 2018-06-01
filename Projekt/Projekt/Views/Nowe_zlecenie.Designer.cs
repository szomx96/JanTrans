namespace Projekt.Views
{
    partial class Nowe_zlecenie
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.groupBoxCommodity = new System.Windows.Forms.GroupBox();
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.groupBoxRoute = new System.Windows.Forms.GroupBox();
            this.labelCustomerCompanyName = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerSurname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.button2);
            this.groupBoxCustomer.Controls.Add(this.button1);
            this.groupBoxCustomer.Controls.Add(this.textBox3);
            this.groupBoxCustomer.Controls.Add(this.textBox2);
            this.groupBoxCustomer.Controls.Add(this.textBox1);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerSurname);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerCompanyName);
            this.groupBoxCustomer.Location = new System.Drawing.Point(25, 34);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(236, 215);
            this.groupBoxCustomer.TabIndex = 1;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Klient";
            // 
            // groupBoxCommodity
            // 
            this.groupBoxCommodity.Location = new System.Drawing.Point(21, 255);
            this.groupBoxCommodity.Name = "groupBoxCommodity";
            this.groupBoxCommodity.Size = new System.Drawing.Size(463, 112);
            this.groupBoxCommodity.TabIndex = 2;
            this.groupBoxCommodity.TabStop = false;
            this.groupBoxCommodity.Text = "Towar";
            // 
            // groupBoxDriver
            // 
            this.groupBoxDriver.Location = new System.Drawing.Point(21, 292);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(467, 121);
            this.groupBoxDriver.TabIndex = 3;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Kierowca";
            // 
            // groupBoxRoute
            // 
            this.groupBoxRoute.Location = new System.Drawing.Point(25, 434);
            this.groupBoxRoute.Name = "groupBoxRoute";
            this.groupBoxRoute.Size = new System.Drawing.Size(463, 110);
            this.groupBoxRoute.TabIndex = 3;
            this.groupBoxRoute.TabStop = false;
            this.groupBoxRoute.Text = "Trasa";
            // 
            // labelCustomerCompanyName
            // 
            this.labelCustomerCompanyName.AutoSize = true;
            this.labelCustomerCompanyName.Location = new System.Drawing.Point(6, 35);
            this.labelCustomerCompanyName.Name = "labelCustomerCompanyName";
            this.labelCustomerCompanyName.Size = new System.Drawing.Size(54, 17);
            this.labelCustomerCompanyName.TabIndex = 0;
            this.labelCustomerCompanyName.Text = "Nazwa:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(6, 68);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(37, 17);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Imię:";
            // 
            // labelCustomerSurname
            // 
            this.labelCustomerSurname.AutoSize = true;
            this.labelCustomerSurname.Location = new System.Drawing.Point(6, 102);
            this.labelCustomerSurname.Name = "labelCustomerSurname";
            this.labelCustomerSurname.Size = new System.Drawing.Size(71, 17);
            this.labelCustomerSurname.TabIndex = 2;
            this.labelCustomerSurname.Text = "Nazwisko:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Nowe_zlecenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxRoute);
            this.Controls.Add(this.groupBoxDriver);
            this.Controls.Add(this.groupBoxCommodity);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.label1);
            this.Name = "Nowe_zlecenie";
            this.Size = new System.Drawing.Size(545, 596);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.GroupBox groupBoxCommodity;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.GroupBox groupBoxRoute;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCustomerSurname;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerCompanyName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
