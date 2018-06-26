namespace Projekt.Forms
{
    partial class AddProductForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.labelAddCustomer = new System.Windows.Forms.Label();
            this.labelChooseCustomer = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCommodityName = new System.Windows.Forms.TextBox();
            this.labelCommodityName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxCustomer.SuspendLayout();
            this.groupBoxCommodity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(12, 336);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(554, 43);
            this.buttonAddProduct.TabIndex = 10;
            this.buttonAddProduct.Text = "Dodaj";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.labelAddCustomer);
            this.groupBoxCustomer.Controls.Add(this.labelChooseCustomer);
            this.groupBoxCustomer.Controls.Add(this.comboBox1);
            this.groupBoxCustomer.Controls.Add(this.buttonCustomerAdd);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerSurname);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerName);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerCompanyName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerSurname);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerCompanyName);
            this.groupBoxCustomer.Location = new System.Drawing.Point(12, 21);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(254, 303);
            this.groupBoxCustomer.TabIndex = 8;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Klient";
            // 
            // labelAddCustomer
            // 
            this.labelAddCustomer.AutoSize = true;
            this.labelAddCustomer.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelAddCustomer.Location = new System.Drawing.Point(6, 104);
            this.labelAddCustomer.Name = "labelAddCustomer";
            this.labelAddCustomer.Size = new System.Drawing.Size(123, 17);
            this.labelAddCustomer.TabIndex = 9;
            this.labelAddCustomer.Text = "lub dodaj nowego:";
            // 
            // labelChooseCustomer
            // 
            this.labelChooseCustomer.AutoSize = true;
            this.labelChooseCustomer.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelChooseCustomer.Location = new System.Drawing.Point(6, 25);
            this.labelChooseCustomer.Name = "labelChooseCustomer";
            this.labelChooseCustomer.Size = new System.Drawing.Size(102, 17);
            this.labelChooseCustomer.TabIndex = 8;
            this.labelChooseCustomer.Text = "Wybierz z listy:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonCustomerAdd
            // 
            this.buttonCustomerAdd.Location = new System.Drawing.Point(9, 254);
            this.buttonCustomerAdd.Name = "buttonCustomerAdd";
            this.buttonCustomerAdd.Size = new System.Drawing.Size(222, 33);
            this.buttonCustomerAdd.TabIndex = 6;
            this.buttonCustomerAdd.Text = "Dodaj klienta";
            this.buttonCustomerAdd.UseVisualStyleBackColor = true;
            this.buttonCustomerAdd.Click += new System.EventHandler(this.buttonCustomerAdd_Click);
            // 
            // textBoxCustomerSurname
            // 
            this.textBoxCustomerSurname.Location = new System.Drawing.Point(83, 215);
            this.textBoxCustomerSurname.Name = "textBoxCustomerSurname";
            this.textBoxCustomerSurname.Size = new System.Drawing.Size(148, 22);
            this.textBoxCustomerSurname.TabIndex = 5;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(83, 178);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(148, 22);
            this.textBoxCustomerName.TabIndex = 4;
            // 
            // textBoxCustomerCompanyName
            // 
            this.textBoxCustomerCompanyName.Location = new System.Drawing.Point(83, 139);
            this.textBoxCustomerCompanyName.Name = "textBoxCustomerCompanyName";
            this.textBoxCustomerCompanyName.Size = new System.Drawing.Size(148, 22);
            this.textBoxCustomerCompanyName.TabIndex = 3;
            // 
            // labelCustomerSurname
            // 
            this.labelCustomerSurname.AutoSize = true;
            this.labelCustomerSurname.Location = new System.Drawing.Point(6, 215);
            this.labelCustomerSurname.Name = "labelCustomerSurname";
            this.labelCustomerSurname.Size = new System.Drawing.Size(71, 17);
            this.labelCustomerSurname.TabIndex = 2;
            this.labelCustomerSurname.Text = "Nazwisko:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(6, 178);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(37, 17);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Imię:";
            // 
            // labelCustomerCompanyName
            // 
            this.labelCustomerCompanyName.AutoSize = true;
            this.labelCustomerCompanyName.Location = new System.Drawing.Point(6, 139);
            this.labelCustomerCompanyName.Name = "labelCustomerCompanyName";
            this.labelCustomerCompanyName.Size = new System.Drawing.Size(54, 17);
            this.labelCustomerCompanyName.TabIndex = 0;
            this.labelCustomerCompanyName.Text = "Nazwa:";
            // 
            // groupBoxCommodity
            // 
            this.groupBoxCommodity.Controls.Add(this.textBoxCommodityName);
            this.groupBoxCommodity.Controls.Add(this.labelCommodityName);
            this.groupBoxCommodity.Controls.Add(this.textBoxCommodityVolume);
            this.groupBoxCommodity.Controls.Add(this.textBoxCommodityWeight);
            this.groupBoxCommodity.Controls.Add(this.labelCommodityVolume);
            this.groupBoxCommodity.Controls.Add(this.labelCommodityWeight);
            this.groupBoxCommodity.Location = new System.Drawing.Point(281, 21);
            this.groupBoxCommodity.Name = "groupBoxCommodity";
            this.groupBoxCommodity.Size = new System.Drawing.Size(285, 161);
            this.groupBoxCommodity.TabIndex = 9;
            this.groupBoxCommodity.TabStop = false;
            this.groupBoxCommodity.Text = "Towar";
            // 
            // textBoxCommodityVolume
            // 
            this.textBoxCommodityVolume.Location = new System.Drawing.Point(106, 114);
            this.textBoxCommodityVolume.Name = "textBoxCommodityVolume";
            this.textBoxCommodityVolume.Size = new System.Drawing.Size(148, 22);
            this.textBoxCommodityVolume.TabIndex = 7;
            // 
            // textBoxCommodityWeight
            // 
            this.textBoxCommodityWeight.Location = new System.Drawing.Point(106, 75);
            this.textBoxCommodityWeight.Name = "textBoxCommodityWeight";
            this.textBoxCommodityWeight.Size = new System.Drawing.Size(148, 22);
            this.textBoxCommodityWeight.TabIndex = 6;
            // 
            // labelCommodityVolume
            // 
            this.labelCommodityVolume.AutoSize = true;
            this.labelCommodityVolume.Location = new System.Drawing.Point(21, 114);
            this.labelCommodityVolume.Name = "labelCommodityVolume";
            this.labelCommodityVolume.Size = new System.Drawing.Size(68, 17);
            this.labelCommodityVolume.TabIndex = 5;
            this.labelCommodityVolume.Text = "Objętość:";
            // 
            // labelCommodityWeight
            // 
            this.labelCommodityWeight.AutoSize = true;
            this.labelCommodityWeight.Location = new System.Drawing.Point(21, 75);
            this.labelCommodityWeight.Name = "labelCommodityWeight";
            this.labelCommodityWeight.Size = new System.Drawing.Size(49, 17);
            this.labelCommodityWeight.TabIndex = 4;
            this.labelCommodityWeight.Text = "Waga:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // textBoxCommodityName
            // 
            this.textBoxCommodityName.Location = new System.Drawing.Point(106, 36);
            this.textBoxCommodityName.Name = "textBoxCommodityName";
            this.textBoxCommodityName.Size = new System.Drawing.Size(148, 22);
            this.textBoxCommodityName.TabIndex = 9;
            // 
            // labelCommodityName
            // 
            this.labelCommodityName.AutoSize = true;
            this.labelCommodityName.Location = new System.Drawing.Point(21, 36);
            this.labelCommodityName.Name = "labelCommodityName";
            this.labelCommodityName.Size = new System.Drawing.Size(54, 17);
            this.labelCommodityName.TabIndex = 8;
            this.labelCommodityName.Text = "Nazwa:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.groupBoxCommodity);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.groupBoxCommodity.ResumeLayout(false);
            this.groupBoxCommodity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Button buttonCustomerAdd;
        private System.Windows.Forms.TextBox textBoxCustomerSurname;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerCompanyName;
        private System.Windows.Forms.Label labelCustomerSurname;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerCompanyName;
        private System.Windows.Forms.GroupBox groupBoxCommodity;
        private System.Windows.Forms.TextBox textBoxCommodityVolume;
        private System.Windows.Forms.TextBox textBoxCommodityWeight;
        private System.Windows.Forms.Label labelCommodityVolume;
        private System.Windows.Forms.Label labelCommodityWeight;
        private System.Windows.Forms.Label labelAddCustomer;
        private System.Windows.Forms.Label labelChooseCustomer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxCommodityName;
        private System.Windows.Forms.Label labelCommodityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}