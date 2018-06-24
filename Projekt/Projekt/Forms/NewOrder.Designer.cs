namespace Projekt.Forms
{
    partial class NewOrder
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
            this.buttonCustomerImport = new System.Windows.Forms.Button();
            this.buttonCustomerAdd = new System.Windows.Forms.Button();
            this.textBoxCustomerSurname = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerCompanyName = new System.Windows.Forms.TextBox();
            this.labelCustomerSurname = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerCompanyName = new System.Windows.Forms.Label();
            this.groupBoxCommodity = new System.Windows.Forms.GroupBox();
            this.textBoxCommodityVolume = new System.Windows.Forms.TextBox();
            this.textBoxCommodityWeight = new System.Windows.Forms.TextBox();
            this.labelCommodityVolume = new System.Windows.Forms.Label();
            this.labelCommodityWeight = new System.Windows.Forms.Label();
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.buttonDriverSelect = new System.Windows.Forms.Button();
            this.labelDriverSurnameValue = new System.Windows.Forms.Label();
            this.labelDriverNameValue = new System.Windows.Forms.Label();
            this.labelDriverSurname = new System.Windows.Forms.Label();
            this.labelDriverName = new System.Windows.Forms.Label();
            this.groupBoxRoute = new System.Windows.Forms.GroupBox();
            this.labelKm = new System.Windows.Forms.Label();
            this.textBoxRouteTo = new System.Windows.Forms.TextBox();
            this.textBoxRouteFrom = new System.Windows.Forms.TextBox();
            this.textBoxRouteLength = new System.Windows.Forms.TextBox();
            this.labelRouteTo = new System.Windows.Forms.Label();
            this.labelRouteFrom = new System.Windows.Forms.Label();
            this.labelRouteLength = new System.Windows.Forms.Label();
            this.groupBoxVehicle = new System.Windows.Forms.GroupBox();
            this.labelVehicleIDValue = new System.Windows.Forms.Label();
            this.buttonVehicleSelect = new System.Windows.Forms.Button();
            this.labelVehicleID = new System.Windows.Forms.Label();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxCustomer.SuspendLayout();
            this.groupBoxCommodity.SuspendLayout();
            this.groupBoxDriver.SuspendLayout();
            this.groupBoxRoute.SuspendLayout();
            this.groupBoxVehicle.SuspendLayout();
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
            this.groupBoxCustomer.Controls.Add(this.buttonCustomerImport);
            this.groupBoxCustomer.Controls.Add(this.buttonCustomerAdd);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerSurname);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerName);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerCompanyName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerSurname);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerCompanyName);
            this.groupBoxCustomer.Location = new System.Drawing.Point(21, 86);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(251, 304);
            this.groupBoxCustomer.TabIndex = 1;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Klient";
            // 
            // buttonCustomerImport
            // 
            this.buttonCustomerImport.Location = new System.Drawing.Point(131, 196);
            this.buttonCustomerImport.Name = "buttonCustomerImport";
            this.buttonCustomerImport.Size = new System.Drawing.Size(100, 35);
            this.buttonCustomerImport.TabIndex = 7;
            this.buttonCustomerImport.Text = "Importuj";
            this.buttonCustomerImport.UseVisualStyleBackColor = true;
            // 
            // buttonCustomerAdd
            // 
            this.buttonCustomerAdd.Location = new System.Drawing.Point(131, 155);
            this.buttonCustomerAdd.Name = "buttonCustomerAdd";
            this.buttonCustomerAdd.Size = new System.Drawing.Size(100, 35);
            this.buttonCustomerAdd.TabIndex = 6;
            this.buttonCustomerAdd.Text = "Dodaj";
            this.buttonCustomerAdd.UseVisualStyleBackColor = true;
            this.buttonCustomerAdd.Click += new System.EventHandler(this.buttonCustomerAdd_Click);
            // 
            // textBoxCustomerSurname
            // 
            this.textBoxCustomerSurname.Location = new System.Drawing.Point(83, 111);
            this.textBoxCustomerSurname.Name = "textBoxCustomerSurname";
            this.textBoxCustomerSurname.Size = new System.Drawing.Size(148, 22);
            this.textBoxCustomerSurname.TabIndex = 5;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(83, 74);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(148, 22);
            this.textBoxCustomerName.TabIndex = 4;
            // 
            // textBoxCustomerCompanyName
            // 
            this.textBoxCustomerCompanyName.Location = new System.Drawing.Point(83, 35);
            this.textBoxCustomerCompanyName.Name = "textBoxCustomerCompanyName";
            this.textBoxCustomerCompanyName.Size = new System.Drawing.Size(148, 22);
            this.textBoxCustomerCompanyName.TabIndex = 3;
            // 
            // labelCustomerSurname
            // 
            this.labelCustomerSurname.AutoSize = true;
            this.labelCustomerSurname.Location = new System.Drawing.Point(6, 111);
            this.labelCustomerSurname.Name = "labelCustomerSurname";
            this.labelCustomerSurname.Size = new System.Drawing.Size(71, 17);
            this.labelCustomerSurname.TabIndex = 2;
            this.labelCustomerSurname.Text = "Nazwisko:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(6, 74);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(37, 17);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Imię:";
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
            // groupBoxCommodity
            // 
            this.groupBoxCommodity.Controls.Add(this.textBoxCommodityVolume);
            this.groupBoxCommodity.Controls.Add(this.textBoxCommodityWeight);
            this.groupBoxCommodity.Controls.Add(this.labelCommodityVolume);
            this.groupBoxCommodity.Controls.Add(this.labelCommodityWeight);
            this.groupBoxCommodity.Location = new System.Drawing.Point(303, 266);
            this.groupBoxCommodity.Name = "groupBoxCommodity";
            this.groupBoxCommodity.Size = new System.Drawing.Size(285, 121);
            this.groupBoxCommodity.TabIndex = 2;
            this.groupBoxCommodity.TabStop = false;
            this.groupBoxCommodity.Text = "Towar";
            // 
            // textBoxCommodityVolume
            // 
            this.textBoxCommodityVolume.Location = new System.Drawing.Point(91, 73);
            this.textBoxCommodityVolume.Name = "textBoxCommodityVolume";
            this.textBoxCommodityVolume.Size = new System.Drawing.Size(148, 22);
            this.textBoxCommodityVolume.TabIndex = 7;
            // 
            // textBoxCommodityWeight
            // 
            this.textBoxCommodityWeight.Location = new System.Drawing.Point(91, 34);
            this.textBoxCommodityWeight.Name = "textBoxCommodityWeight";
            this.textBoxCommodityWeight.Size = new System.Drawing.Size(148, 22);
            this.textBoxCommodityWeight.TabIndex = 6;
            // 
            // labelCommodityVolume
            // 
            this.labelCommodityVolume.AutoSize = true;
            this.labelCommodityVolume.Location = new System.Drawing.Point(6, 73);
            this.labelCommodityVolume.Name = "labelCommodityVolume";
            this.labelCommodityVolume.Size = new System.Drawing.Size(68, 17);
            this.labelCommodityVolume.TabIndex = 5;
            this.labelCommodityVolume.Text = "Objętość:";
            // 
            // labelCommodityWeight
            // 
            this.labelCommodityWeight.AutoSize = true;
            this.labelCommodityWeight.Location = new System.Drawing.Point(6, 34);
            this.labelCommodityWeight.Name = "labelCommodityWeight";
            this.labelCommodityWeight.Size = new System.Drawing.Size(49, 17);
            this.labelCommodityWeight.TabIndex = 4;
            this.labelCommodityWeight.Text = "Waga:";
            // 
            // groupBoxDriver
            // 
            this.groupBoxDriver.Controls.Add(this.buttonDriverSelect);
            this.groupBoxDriver.Controls.Add(this.labelDriverSurnameValue);
            this.groupBoxDriver.Controls.Add(this.labelDriverNameValue);
            this.groupBoxDriver.Controls.Add(this.labelDriverSurname);
            this.groupBoxDriver.Controls.Add(this.labelDriverName);
            this.groupBoxDriver.Location = new System.Drawing.Point(303, 86);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(278, 174);
            this.groupBoxDriver.TabIndex = 3;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Kierowca";
            // 
            // buttonDriverSelect
            // 
            this.buttonDriverSelect.Location = new System.Drawing.Point(9, 113);
            this.buttonDriverSelect.Name = "buttonDriverSelect";
            this.buttonDriverSelect.Size = new System.Drawing.Size(222, 35);
            this.buttonDriverSelect.TabIndex = 11;
            this.buttonDriverSelect.Text = "Wybierz";
            this.buttonDriverSelect.UseVisualStyleBackColor = true;
            // 
            // labelDriverSurnameValue
            // 
            this.labelDriverSurnameValue.AutoSize = true;
            this.labelDriverSurnameValue.Location = new System.Drawing.Point(88, 77);
            this.labelDriverSurnameValue.Name = "labelDriverSurnameValue";
            this.labelDriverSurnameValue.Size = new System.Drawing.Size(67, 17);
            this.labelDriverSurnameValue.TabIndex = 3;
            this.labelDriverSurnameValue.Text = "Nazwisko";
            // 
            // labelDriverNameValue
            // 
            this.labelDriverNameValue.AutoSize = true;
            this.labelDriverNameValue.Location = new System.Drawing.Point(88, 38);
            this.labelDriverNameValue.Name = "labelDriverNameValue";
            this.labelDriverNameValue.Size = new System.Drawing.Size(33, 17);
            this.labelDriverNameValue.TabIndex = 2;
            this.labelDriverNameValue.Text = "Imię";
            // 
            // labelDriverSurname
            // 
            this.labelDriverSurname.AutoSize = true;
            this.labelDriverSurname.Location = new System.Drawing.Point(6, 77);
            this.labelDriverSurname.Name = "labelDriverSurname";
            this.labelDriverSurname.Size = new System.Drawing.Size(71, 17);
            this.labelDriverSurname.TabIndex = 1;
            this.labelDriverSurname.Text = "Nazwisko:";
            // 
            // labelDriverName
            // 
            this.labelDriverName.AutoSize = true;
            this.labelDriverName.Location = new System.Drawing.Point(6, 38);
            this.labelDriverName.Name = "labelDriverName";
            this.labelDriverName.Size = new System.Drawing.Size(37, 17);
            this.labelDriverName.TabIndex = 0;
            this.labelDriverName.Text = "Imię:";
            // 
            // groupBoxRoute
            // 
            this.groupBoxRoute.Controls.Add(this.labelKm);
            this.groupBoxRoute.Controls.Add(this.textBoxRouteTo);
            this.groupBoxRoute.Controls.Add(this.textBoxRouteFrom);
            this.groupBoxRoute.Controls.Add(this.textBoxRouteLength);
            this.groupBoxRoute.Controls.Add(this.labelRouteTo);
            this.groupBoxRoute.Controls.Add(this.labelRouteFrom);
            this.groupBoxRoute.Controls.Add(this.labelRouteLength);
            this.groupBoxRoute.Location = new System.Drawing.Point(303, 393);
            this.groupBoxRoute.Name = "groupBoxRoute";
            this.groupBoxRoute.Size = new System.Drawing.Size(285, 154);
            this.groupBoxRoute.TabIndex = 3;
            this.groupBoxRoute.TabStop = false;
            this.groupBoxRoute.Text = "Trasa";
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Location = new System.Drawing.Point(250, 35);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(26, 17);
            this.labelKm.TabIndex = 11;
            this.labelKm.Text = "km";
            // 
            // textBoxRouteTo
            // 
            this.textBoxRouteTo.Location = new System.Drawing.Point(91, 114);
            this.textBoxRouteTo.Name = "textBoxRouteTo";
            this.textBoxRouteTo.Size = new System.Drawing.Size(148, 22);
            this.textBoxRouteTo.TabIndex = 10;
            // 
            // textBoxRouteFrom
            // 
            this.textBoxRouteFrom.Location = new System.Drawing.Point(91, 75);
            this.textBoxRouteFrom.Name = "textBoxRouteFrom";
            this.textBoxRouteFrom.Size = new System.Drawing.Size(148, 22);
            this.textBoxRouteFrom.TabIndex = 9;
            // 
            // textBoxRouteLength
            // 
            this.textBoxRouteLength.Location = new System.Drawing.Point(91, 35);
            this.textBoxRouteLength.Name = "textBoxRouteLength";
            this.textBoxRouteLength.Size = new System.Drawing.Size(148, 22);
            this.textBoxRouteLength.TabIndex = 8;
            // 
            // labelRouteTo
            // 
            this.labelRouteTo.AutoSize = true;
            this.labelRouteTo.Location = new System.Drawing.Point(6, 114);
            this.labelRouteTo.Name = "labelRouteTo";
            this.labelRouteTo.Size = new System.Drawing.Size(53, 17);
            this.labelRouteTo.TabIndex = 8;
            this.labelRouteTo.Text = "Dokąd:";
            // 
            // labelRouteFrom
            // 
            this.labelRouteFrom.AutoSize = true;
            this.labelRouteFrom.Location = new System.Drawing.Point(6, 74);
            this.labelRouteFrom.Name = "labelRouteFrom";
            this.labelRouteFrom.Size = new System.Drawing.Size(44, 17);
            this.labelRouteFrom.TabIndex = 7;
            this.labelRouteFrom.Text = "Skąd:";
            // 
            // labelRouteLength
            // 
            this.labelRouteLength.AutoSize = true;
            this.labelRouteLength.Location = new System.Drawing.Point(6, 35);
            this.labelRouteLength.Name = "labelRouteLength";
            this.labelRouteLength.Size = new System.Drawing.Size(59, 17);
            this.labelRouteLength.TabIndex = 6;
            this.labelRouteLength.Text = "Długość";
            // 
            // groupBoxVehicle
            // 
            this.groupBoxVehicle.Controls.Add(this.labelVehicleIDValue);
            this.groupBoxVehicle.Controls.Add(this.buttonVehicleSelect);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleID);
            this.groupBoxVehicle.Location = new System.Drawing.Point(21, 396);
            this.groupBoxVehicle.Name = "groupBoxVehicle";
            this.groupBoxVehicle.Size = new System.Drawing.Size(251, 151);
            this.groupBoxVehicle.TabIndex = 4;
            this.groupBoxVehicle.TabStop = false;
            this.groupBoxVehicle.Text = "Pojazd";
            // 
            // labelVehicleIDValue
            // 
            this.labelVehicleIDValue.AutoSize = true;
            this.labelVehicleIDValue.Location = new System.Drawing.Point(80, 32);
            this.labelVehicleIDValue.Name = "labelVehicleIDValue";
            this.labelVehicleIDValue.Size = new System.Drawing.Size(21, 17);
            this.labelVehicleIDValue.TabIndex = 11;
            this.labelVehicleIDValue.Text = "ID";
            // 
            // buttonVehicleSelect
            // 
            this.buttonVehicleSelect.Location = new System.Drawing.Point(9, 67);
            this.buttonVehicleSelect.Name = "buttonVehicleSelect";
            this.buttonVehicleSelect.Size = new System.Drawing.Size(222, 35);
            this.buttonVehicleSelect.TabIndex = 10;
            this.buttonVehicleSelect.Text = "Wybierz";
            this.buttonVehicleSelect.UseVisualStyleBackColor = true;
            // 
            // labelVehicleID
            // 
            this.labelVehicleID.AutoSize = true;
            this.labelVehicleID.Location = new System.Drawing.Point(6, 32);
            this.labelVehicleID.Name = "labelVehicleID";
            this.labelVehicleID.Size = new System.Drawing.Size(25, 17);
            this.labelVehicleID.TabIndex = 9;
            this.labelVehicleID.Text = "ID:";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(303, 563);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(285, 37);
            this.buttonAddOrder.TabIndex = 5;
            this.buttonAddOrder.Text = "Dodaj";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(21, 20);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 31);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "<- Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.groupBoxVehicle);
            this.Controls.Add(this.groupBoxRoute);
            this.Controls.Add(this.groupBoxDriver);
            this.Controls.Add(this.groupBoxCommodity);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.label1);
            this.Name = "NewOrder";
            this.Size = new System.Drawing.Size(600, 613);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.groupBoxCommodity.ResumeLayout(false);
            this.groupBoxCommodity.PerformLayout();
            this.groupBoxDriver.ResumeLayout(false);
            this.groupBoxDriver.PerformLayout();
            this.groupBoxRoute.ResumeLayout(false);
            this.groupBoxRoute.PerformLayout();
            this.groupBoxVehicle.ResumeLayout(false);
            this.groupBoxVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.GroupBox groupBoxCommodity;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.GroupBox groupBoxRoute;
        private System.Windows.Forms.TextBox textBoxCustomerSurname;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerCompanyName;
        private System.Windows.Forms.Label labelCustomerSurname;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerCompanyName;
        private System.Windows.Forms.Button buttonCustomerImport;
        private System.Windows.Forms.Button buttonCustomerAdd;
        private System.Windows.Forms.GroupBox groupBoxVehicle;
        private System.Windows.Forms.TextBox textBoxCommodityVolume;
        private System.Windows.Forms.TextBox textBoxCommodityWeight;
        private System.Windows.Forms.Label labelCommodityVolume;
        private System.Windows.Forms.Label labelCommodityWeight;
        private System.Windows.Forms.Label labelDriverSurnameValue;
        private System.Windows.Forms.Label labelDriverNameValue;
        private System.Windows.Forms.Label labelDriverSurname;
        private System.Windows.Forms.Label labelDriverName;
        private System.Windows.Forms.TextBox textBoxRouteTo;
        private System.Windows.Forms.TextBox textBoxRouteFrom;
        private System.Windows.Forms.TextBox textBoxRouteLength;
        private System.Windows.Forms.Label labelRouteTo;
        private System.Windows.Forms.Label labelRouteFrom;
        private System.Windows.Forms.Label labelRouteLength;
        private System.Windows.Forms.Button buttonVehicleSelect;
        private System.Windows.Forms.Label labelVehicleID;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Label labelVehicleIDValue;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDriverSelect;
    }
}
