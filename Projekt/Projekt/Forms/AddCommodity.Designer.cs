namespace Projekt.Forms
{
    partial class AddCommodity
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
            this.groupBoxCommodity = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelCommodityName = new System.Windows.Forms.Label();
            this.textBoxCommodityName = new System.Windows.Forms.TextBox();
            this.textBoxCommodityVolume = new System.Windows.Forms.TextBox();
            this.textBoxCommodityWeight = new System.Windows.Forms.TextBox();
            this.labelCommodityVolume = new System.Windows.Forms.Label();
            this.labelCommodityWeight = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxCommodity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCommodity
            // 
            this.groupBoxCommodity.Controls.Add(this.comboBox1);
            this.groupBoxCommodity.Controls.Add(this.labelCustomer);
            this.groupBoxCommodity.Controls.Add(this.labelCommodityName);
            this.groupBoxCommodity.Controls.Add(this.textBoxCommodityName);
            this.groupBoxCommodity.Controls.Add(this.textBoxCommodityVolume);
            this.groupBoxCommodity.Controls.Add(this.textBoxCommodityWeight);
            this.groupBoxCommodity.Controls.Add(this.labelCommodityVolume);
            this.groupBoxCommodity.Controls.Add(this.labelCommodityWeight);
            this.groupBoxCommodity.Location = new System.Drawing.Point(13, 65);
            this.groupBoxCommodity.Name = "groupBoxCommodity";
            this.groupBoxCommodity.Size = new System.Drawing.Size(292, 219);
            this.groupBoxCommodity.TabIndex = 10;
            this.groupBoxCommodity.TabStop = false;
            this.groupBoxCommodity.Text = "Towar";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(6, 154);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(47, 17);
            this.labelCustomer.TabIndex = 10;
            this.labelCustomer.Text = "Klient:";
            // 
            // labelCommodityName
            // 
            this.labelCommodityName.AutoSize = true;
            this.labelCommodityName.Location = new System.Drawing.Point(6, 37);
            this.labelCommodityName.Name = "labelCommodityName";
            this.labelCommodityName.Size = new System.Drawing.Size(54, 17);
            this.labelCommodityName.TabIndex = 9;
            this.labelCommodityName.Text = "Nazwa:";
            // 
            // textBoxCommodityName
            // 
            this.textBoxCommodityName.Location = new System.Drawing.Point(91, 37);
            this.textBoxCommodityName.Name = "textBoxCommodityName";
            this.textBoxCommodityName.Size = new System.Drawing.Size(148, 22);
            this.textBoxCommodityName.TabIndex = 0;
            // 
            // textBoxCommodityVolume
            // 
            this.textBoxCommodityVolume.Location = new System.Drawing.Point(91, 116);
            this.textBoxCommodityVolume.Name = "textBoxCommodityVolume";
            this.textBoxCommodityVolume.Size = new System.Drawing.Size(148, 22);
            this.textBoxCommodityVolume.TabIndex = 3;
            // 
            // textBoxCommodityWeight
            // 
            this.textBoxCommodityWeight.Location = new System.Drawing.Point(91, 77);
            this.textBoxCommodityWeight.Name = "textBoxCommodityWeight";
            this.textBoxCommodityWeight.Size = new System.Drawing.Size(148, 22);
            this.textBoxCommodityWeight.TabIndex = 2;
            // 
            // labelCommodityVolume
            // 
            this.labelCommodityVolume.AutoSize = true;
            this.labelCommodityVolume.Location = new System.Drawing.Point(6, 116);
            this.labelCommodityVolume.Name = "labelCommodityVolume";
            this.labelCommodityVolume.Size = new System.Drawing.Size(68, 17);
            this.labelCommodityVolume.TabIndex = 5;
            this.labelCommodityVolume.Text = "Objętość:";
            // 
            // labelCommodityWeight
            // 
            this.labelCommodityWeight.AutoSize = true;
            this.labelCommodityWeight.Location = new System.Drawing.Point(6, 77);
            this.labelCommodityWeight.Name = "labelCommodityWeight";
            this.labelCommodityWeight.Size = new System.Drawing.Size(49, 17);
            this.labelCommodityWeight.TabIndex = 4;
            this.labelCommodityWeight.Text = "Waga:";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(13, 299);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(292, 40);
            this.buttonAddProduct.TabIndex = 5;
            this.buttonAddProduct.Text = "Dodaj";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(22, 14);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 31);
            this.buttonBack.TabIndex = 6;
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
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // AddCommodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.groupBoxCommodity);
            this.Name = "AddCommodity";
            this.Size = new System.Drawing.Size(323, 364);
            this.groupBoxCommodity.ResumeLayout(false);
            this.groupBoxCommodity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCommodity;
        private System.Windows.Forms.TextBox textBoxCommodityVolume;
        private System.Windows.Forms.TextBox textBoxCommodityWeight;
        private System.Windows.Forms.Label labelCommodityVolume;
        private System.Windows.Forms.Label labelCommodityWeight;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelCommodityName;
        private System.Windows.Forms.TextBox textBoxCommodityName;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}
