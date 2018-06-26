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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.labelVolumeValue = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelCapacityValue = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelDriverIDValue = new System.Windows.Forms.Label();
            this.labelDriverID = new System.Windows.Forms.Label();
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
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
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.labelFreeVValue = new System.Windows.Forms.Label();
            this.labelFreeCValue = new System.Windows.Forms.Label();
            this.labelFreeV = new System.Windows.Forms.Label();
            this.labelFreeC = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelBeginDate = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDriver.SuspendLayout();
            this.groupBoxRoute.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            // groupBoxDriver
            // 
            this.groupBoxDriver.Controls.Add(this.labelVolumeValue);
            this.groupBoxDriver.Controls.Add(this.labelVolume);
            this.groupBoxDriver.Controls.Add(this.labelCapacityValue);
            this.groupBoxDriver.Controls.Add(this.labelCapacity);
            this.groupBoxDriver.Controls.Add(this.labelDriverIDValue);
            this.groupBoxDriver.Controls.Add(this.labelDriverID);
            this.groupBoxDriver.Controls.Add(this.comboBoxDrivers);
            this.groupBoxDriver.Controls.Add(this.labelDriverSurnameValue);
            this.groupBoxDriver.Controls.Add(this.labelDriverNameValue);
            this.groupBoxDriver.Controls.Add(this.labelDriverSurname);
            this.groupBoxDriver.Controls.Add(this.labelDriverName);
            this.groupBoxDriver.Location = new System.Drawing.Point(46, 211);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(285, 199);
            this.groupBoxDriver.TabIndex = 3;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Transport";
            // 
            // labelVolumeValue
            // 
            this.labelVolumeValue.AutoSize = true;
            this.labelVolumeValue.Location = new System.Drawing.Point(161, 117);
            this.labelVolumeValue.Name = "labelVolumeValue";
            this.labelVolumeValue.Size = new System.Drawing.Size(13, 17);
            this.labelVolumeValue.TabIndex = 10;
            this.labelVolumeValue.Text = "-";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(161, 96);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(113, 17);
            this.labelVolume.TabIndex = 9;
            this.labelVolume.Text = "Pojemność(m^2)";
            // 
            // labelCapacityValue
            // 
            this.labelCapacityValue.AutoSize = true;
            this.labelCapacityValue.Location = new System.Drawing.Point(161, 57);
            this.labelCapacityValue.Name = "labelCapacityValue";
            this.labelCapacityValue.Size = new System.Drawing.Size(13, 17);
            this.labelCapacityValue.TabIndex = 8;
            this.labelCapacityValue.Text = "-";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(161, 40);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(108, 17);
            this.labelCapacity.TabIndex = 7;
            this.labelCapacity.Text = "Ładowność (kg)";
            // 
            // labelDriverIDValue
            // 
            this.labelDriverIDValue.AutoSize = true;
            this.labelDriverIDValue.Location = new System.Drawing.Point(80, 114);
            this.labelDriverIDValue.Name = "labelDriverIDValue";
            this.labelDriverIDValue.Size = new System.Drawing.Size(16, 17);
            this.labelDriverIDValue.TabIndex = 6;
            this.labelDriverIDValue.Text = "0";
            // 
            // labelDriverID
            // 
            this.labelDriverID.AutoSize = true;
            this.labelDriverID.Location = new System.Drawing.Point(6, 114);
            this.labelDriverID.Name = "labelDriverID";
            this.labelDriverID.Size = new System.Drawing.Size(25, 17);
            this.labelDriverID.TabIndex = 5;
            this.labelDriverID.Text = "ID:";
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(9, 166);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(251, 24);
            this.comboBoxDrivers.TabIndex = 4;
            this.comboBoxDrivers.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBoxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelDriverSurnameValue
            // 
            this.labelDriverSurnameValue.AutoSize = true;
            this.labelDriverSurnameValue.Location = new System.Drawing.Point(80, 77);
            this.labelDriverSurnameValue.Name = "labelDriverSurnameValue";
            this.labelDriverSurnameValue.Size = new System.Drawing.Size(67, 17);
            this.labelDriverSurnameValue.TabIndex = 3;
            this.labelDriverSurnameValue.Text = "Nazwisko";
            // 
            // labelDriverNameValue
            // 
            this.labelDriverNameValue.AutoSize = true;
            this.labelDriverNameValue.Location = new System.Drawing.Point(80, 38);
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
            this.groupBoxRoute.Location = new System.Drawing.Point(363, 211);
            this.groupBoxRoute.Name = "groupBoxRoute";
            this.groupBoxRoute.Size = new System.Drawing.Size(295, 174);
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
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(46, 689);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(612, 35);
            this.buttonAddOrder.TabIndex = 5;
            this.buttonAddOrder.Text = "Dodaj zlecenie";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
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
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.buttonDeleteProduct);
            this.groupBoxProduct.Controls.Add(this.labelFreeVValue);
            this.groupBoxProduct.Controls.Add(this.labelFreeCValue);
            this.groupBoxProduct.Controls.Add(this.labelFreeV);
            this.groupBoxProduct.Controls.Add(this.labelFreeC);
            this.groupBoxProduct.Controls.Add(this.comboBoxProducts);
            this.groupBoxProduct.Controls.Add(this.listBoxProducts);
            this.groupBoxProduct.Controls.Add(this.buttonAddProduct);
            this.groupBoxProduct.Location = new System.Drawing.Point(46, 423);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(612, 244);
            this.groupBoxProduct.TabIndex = 7;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Produkty";
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Enabled = false;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(444, 23);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(149, 32);
            this.buttonDeleteProduct.TabIndex = 17;
            this.buttonDeleteProduct.Text = "Usuń";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // labelFreeVValue
            // 
            this.labelFreeVValue.AutoSize = true;
            this.labelFreeVValue.Location = new System.Drawing.Point(255, 103);
            this.labelFreeVValue.Name = "labelFreeVValue";
            this.labelFreeVValue.Size = new System.Drawing.Size(13, 17);
            this.labelFreeVValue.TabIndex = 16;
            this.labelFreeVValue.Text = "-";
            // 
            // labelFreeCValue
            // 
            this.labelFreeCValue.AutoSize = true;
            this.labelFreeCValue.Location = new System.Drawing.Point(22, 99);
            this.labelFreeCValue.Name = "labelFreeCValue";
            this.labelFreeCValue.Size = new System.Drawing.Size(13, 17);
            this.labelFreeCValue.TabIndex = 14;
            this.labelFreeCValue.Text = "-";
            // 
            // labelFreeV
            // 
            this.labelFreeV.AutoSize = true;
            this.labelFreeV.Location = new System.Drawing.Point(255, 82);
            this.labelFreeV.Name = "labelFreeV";
            this.labelFreeV.Size = new System.Drawing.Size(179, 17);
            this.labelFreeV.TabIndex = 15;
            this.labelFreeV.Text = "Pozostała Pojemność(m^2)";
            // 
            // labelFreeC
            // 
            this.labelFreeC.AutoSize = true;
            this.labelFreeC.Location = new System.Drawing.Point(22, 82);
            this.labelFreeC.Name = "labelFreeC";
            this.labelFreeC.Size = new System.Drawing.Size(174, 17);
            this.labelFreeC.TabIndex = 13;
            this.labelFreeC.Text = "Pozostała Ładowność (kg)";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(9, 28);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(251, 24);
            this.comboBoxProducts.TabIndex = 5;
            this.comboBoxProducts.DropDown += new System.EventHandler(this.comboBoxProducts_DropDown);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(9, 140);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(584, 84);
            this.listBoxProducts.TabIndex = 1;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(275, 23);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(149, 32);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Dodaj";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBegin.Location = new System.Drawing.Point(129, 31);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(131, 22);
            this.dateTimePickerBegin.TabIndex = 8;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.labelEndDate);
            this.groupBoxDate.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxDate.Controls.Add(this.labelBeginDate);
            this.groupBoxDate.Controls.Add(this.dateTimePickerBegin);
            this.groupBoxDate.Location = new System.Drawing.Point(46, 85);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(612, 93);
            this.groupBoxDate.TabIndex = 9;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Daty";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(301, 31);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(96, 17);
            this.labelEndDate.TabIndex = 11;
            this.labelEndDate.Text = "Data powrotu:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(408, 31);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(131, 22);
            this.dateTimePickerEnd.TabIndex = 10;
            // 
            // labelBeginDate
            // 
            this.labelBeginDate.AutoSize = true;
            this.labelBeginDate.Location = new System.Drawing.Point(22, 31);
            this.labelBeginDate.Name = "labelBeginDate";
            this.labelBeginDate.Size = new System.Drawing.Size(96, 17);
            this.labelBeginDate.TabIndex = 9;
            this.labelBeginDate.Text = "Data wyjazdu:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.groupBoxRoute);
            this.Controls.Add(this.groupBoxDriver);
            this.Controls.Add(this.label1);
            this.Name = "NewOrder";
            this.Size = new System.Drawing.Size(729, 894);
            this.groupBoxDriver.ResumeLayout(false);
            this.groupBoxDriver.PerformLayout();
            this.groupBoxRoute.ResumeLayout(false);
            this.groupBoxRoute.PerformLayout();
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.GroupBox groupBoxRoute;
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
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxDrivers;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label labelDriverIDValue;
        private System.Windows.Forms.Label labelDriverID;
        public System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelBeginDate;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label labelVolumeValue;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelCapacityValue;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelFreeVValue;
        private System.Windows.Forms.Label labelFreeCValue;
        private System.Windows.Forms.Label labelFreeV;
        private System.Windows.Forms.Label labelFreeC;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
