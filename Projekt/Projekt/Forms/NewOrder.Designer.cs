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
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.labelDriverIDValue = new System.Windows.Forms.Label();
            this.labelDriverID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelVehicleIDValue = new System.Windows.Forms.Label();
            this.labelVehicleID = new System.Windows.Forms.Label();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.groupBoxDriver.SuspendLayout();
            this.groupBoxRoute.SuspendLayout();
            this.groupBoxVehicle.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
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
            this.groupBoxDriver.Controls.Add(this.labelDriverIDValue);
            this.groupBoxDriver.Controls.Add(this.labelDriverID);
            this.groupBoxDriver.Controls.Add(this.comboBox1);
            this.groupBoxDriver.Controls.Add(this.labelDriverSurnameValue);
            this.groupBoxDriver.Controls.Add(this.labelDriverNameValue);
            this.groupBoxDriver.Controls.Add(this.labelDriverSurname);
            this.groupBoxDriver.Controls.Add(this.labelDriverName);
            this.groupBoxDriver.Location = new System.Drawing.Point(21, 70);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(285, 199);
            this.groupBoxDriver.TabIndex = 3;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Kierowca";
            // 
            // labelDriverIDValue
            // 
            this.labelDriverIDValue.AutoSize = true;
            this.labelDriverIDValue.Location = new System.Drawing.Point(88, 114);
            this.labelDriverIDValue.Name = "labelDriverIDValue";
            this.labelDriverIDValue.Size = new System.Drawing.Size(21, 17);
            this.labelDriverIDValue.TabIndex = 6;
            this.labelDriverIDValue.Text = "ID";
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.groupBoxRoute.Location = new System.Drawing.Point(338, 70);
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
            // groupBoxVehicle
            // 
            this.groupBoxVehicle.Controls.Add(this.comboBox2);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleIDValue);
            this.groupBoxVehicle.Controls.Add(this.labelVehicleID);
            this.groupBoxVehicle.Location = new System.Drawing.Point(21, 563);
            this.groupBoxVehicle.Name = "groupBoxVehicle";
            this.groupBoxVehicle.Size = new System.Drawing.Size(285, 108);
            this.groupBoxVehicle.TabIndex = 4;
            this.groupBoxVehicle.TabStop = false;
            this.groupBoxVehicle.Text = "Pojazd";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(254, 24);
            this.comboBox2.TabIndex = 12;
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
            this.buttonAddOrder.Location = new System.Drawing.Point(338, 598);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(295, 35);
            this.buttonAddOrder.TabIndex = 5;
            this.buttonAddOrder.Text = "Dodaj zlecenie";
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
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.listBoxProducts);
            this.groupBoxProduct.Controls.Add(this.buttonAddProduct);
            this.groupBoxProduct.Location = new System.Drawing.Point(21, 282);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(612, 244);
            this.groupBoxProduct.TabIndex = 7;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Produkty";
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(9, 76);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(584, 148);
            this.listBoxProducts.TabIndex = 1;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(9, 30);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(251, 31);
            this.buttonAddProduct.TabIndex = 0;
            this.buttonAddProduct.Text = "Dodaj";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.groupBoxVehicle);
            this.Controls.Add(this.groupBoxRoute);
            this.Controls.Add(this.groupBoxDriver);
            this.Controls.Add(this.label1);
            this.Name = "NewOrder";
            this.Size = new System.Drawing.Size(662, 720);
            this.groupBoxDriver.ResumeLayout(false);
            this.groupBoxDriver.PerformLayout();
            this.groupBoxRoute.ResumeLayout(false);
            this.groupBoxRoute.PerformLayout();
            this.groupBoxVehicle.ResumeLayout(false);
            this.groupBoxVehicle.PerformLayout();
            this.groupBoxProduct.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.GroupBox groupBoxRoute;
        private System.Windows.Forms.GroupBox groupBoxVehicle;
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
        private System.Windows.Forms.Label labelVehicleID;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Label labelVehicleIDValue;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label labelDriverIDValue;
        private System.Windows.Forms.Label labelDriverID;
        public System.Windows.Forms.ListBox listBoxProducts;
    }
}
