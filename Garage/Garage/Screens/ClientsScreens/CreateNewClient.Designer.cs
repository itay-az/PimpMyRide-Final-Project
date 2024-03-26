namespace Garage.Screens.ClientsScreens
{
    partial class CreateNewClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewClient));
            this.clientPhoneTxt = new System.Windows.Forms.TextBox();
            this.clientFullNameTxt = new System.Windows.Forms.TextBox();
            this.clientIdTxt = new System.Windows.Forms.TextBox();
            this.clientEmailLbl = new System.Windows.Forms.Label();
            this.clientPhoneLbl = new System.Windows.Forms.Label();
            this.clientNameLbl = new System.Windows.Forms.Label();
            this.clientIdLbl = new System.Windows.Forms.Label();
            this.clientAddressLbl = new System.Windows.Forms.Label();
            this.clientEmailTxt = new System.Windows.Forms.TextBox();
            this.createNewClientBtn = new System.Windows.Forms.Button();
            this.clientAddressTxt = new System.Windows.Forms.TextBox();
            this.carYearTxt = new System.Windows.Forms.TextBox();
            this.carEngineTxt = new System.Windows.Forms.TextBox();
            this.carEngineLbl = new System.Windows.Forms.Label();
            this.carNumberTxt = new System.Windows.Forms.TextBox();
            this.carYearLbl = new System.Windows.Forms.Label();
            this.carModelLbl = new System.Windows.Forms.Label();
            this.carManufactureLbl = new System.Windows.Forms.Label();
            this.carNumberLbl = new System.Windows.Forms.Label();
            this.carKMTxt = new System.Windows.Forms.TextBox();
            this.kmLbl = new System.Windows.Forms.Label();
            this.vinNumberTxt = new System.Windows.Forms.TextBox();
            this.vinNumberLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manufactureComboBox = new System.Windows.Forms.ComboBox();
            this.modelsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // clientPhoneTxt
            // 
            this.clientPhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientPhoneTxt.Location = new System.Drawing.Point(219, 169);
            this.clientPhoneTxt.Name = "clientPhoneTxt";
            this.clientPhoneTxt.Size = new System.Drawing.Size(286, 29);
            this.clientPhoneTxt.TabIndex = 2;
            this.clientPhoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientPhoneTxt_KeyPress);
            // 
            // clientFullNameTxt
            // 
            this.clientFullNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientFullNameTxt.Location = new System.Drawing.Point(219, 115);
            this.clientFullNameTxt.Name = "clientFullNameTxt";
            this.clientFullNameTxt.Size = new System.Drawing.Size(286, 29);
            this.clientFullNameTxt.TabIndex = 1;
            this.clientFullNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientFullNameTxt_KeyPress);
            // 
            // clientIdTxt
            // 
            this.clientIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientIdTxt.Location = new System.Drawing.Point(219, 57);
            this.clientIdTxt.Name = "clientIdTxt";
            this.clientIdTxt.Size = new System.Drawing.Size(286, 29);
            this.clientIdTxt.TabIndex = 0;
            this.clientIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientIdTxt_KeyPress);
            // 
            // clientEmailLbl
            // 
            this.clientEmailLbl.AutoSize = true;
            this.clientEmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientEmailLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientEmailLbl.Location = new System.Drawing.Point(48, 223);
            this.clientEmailLbl.Name = "clientEmailLbl";
            this.clientEmailLbl.Size = new System.Drawing.Size(68, 24);
            this.clientEmailLbl.TabIndex = 26;
            this.clientEmailLbl.Text = "Email:";
            // 
            // clientPhoneLbl
            // 
            this.clientPhoneLbl.AutoSize = true;
            this.clientPhoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientPhoneLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientPhoneLbl.Location = new System.Drawing.Point(48, 169);
            this.clientPhoneLbl.Name = "clientPhoneLbl";
            this.clientPhoneLbl.Size = new System.Drawing.Size(91, 24);
            this.clientPhoneLbl.TabIndex = 25;
            this.clientPhoneLbl.Text = "Phone: *";
            // 
            // clientNameLbl
            // 
            this.clientNameLbl.AutoSize = true;
            this.clientNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientNameLbl.Location = new System.Drawing.Point(48, 115);
            this.clientNameLbl.Name = "clientNameLbl";
            this.clientNameLbl.Size = new System.Drawing.Size(126, 24);
            this.clientNameLbl.TabIndex = 24;
            this.clientNameLbl.Text = "Full Name: *";
            // 
            // clientIdLbl
            // 
            this.clientIdLbl.AutoSize = true;
            this.clientIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientIdLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientIdLbl.Location = new System.Drawing.Point(48, 57);
            this.clientIdLbl.Name = "clientIdLbl";
            this.clientIdLbl.Size = new System.Drawing.Size(108, 24);
            this.clientIdLbl.TabIndex = 23;
            this.clientIdLbl.Text = "Client ID: *";
            // 
            // clientAddressLbl
            // 
            this.clientAddressLbl.AutoSize = true;
            this.clientAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientAddressLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientAddressLbl.Location = new System.Drawing.Point(48, 282);
            this.clientAddressLbl.Name = "clientAddressLbl";
            this.clientAddressLbl.Size = new System.Drawing.Size(93, 24);
            this.clientAddressLbl.TabIndex = 31;
            this.clientAddressLbl.Text = "Address:";
            // 
            // clientEmailTxt
            // 
            this.clientEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientEmailTxt.Location = new System.Drawing.Point(219, 223);
            this.clientEmailTxt.Name = "clientEmailTxt";
            this.clientEmailTxt.Size = new System.Drawing.Size(286, 29);
            this.clientEmailTxt.TabIndex = 3;
            this.clientEmailTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientEmailTxt_KeyPress);
            // 
            // createNewClientBtn
            // 
            this.createNewClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createNewClientBtn.Location = new System.Drawing.Point(253, 372);
            this.createNewClientBtn.Name = "createNewClientBtn";
            this.createNewClientBtn.Size = new System.Drawing.Size(214, 45);
            this.createNewClientBtn.TabIndex = 12;
            this.createNewClientBtn.Text = "Create client";
            this.createNewClientBtn.UseVisualStyleBackColor = true;
            this.createNewClientBtn.Click += new System.EventHandler(this.createNewClientBtn_Click);
            // 
            // clientAddressTxt
            // 
            this.clientAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientAddressTxt.Location = new System.Drawing.Point(219, 282);
            this.clientAddressTxt.Name = "clientAddressTxt";
            this.clientAddressTxt.Size = new System.Drawing.Size(286, 29);
            this.clientAddressTxt.TabIndex = 4;
            this.clientAddressTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientAddressTxt_KeyPress);
            // 
            // carYearTxt
            // 
            this.carYearTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carYearTxt.Location = new System.Drawing.Point(735, 223);
            this.carYearTxt.Name = "carYearTxt";
            this.carYearTxt.Size = new System.Drawing.Size(286, 29);
            this.carYearTxt.TabIndex = 8;
            this.carYearTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carYearTxt_KeyPress);
            // 
            // carEngineTxt
            // 
            this.carEngineTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carEngineTxt.Location = new System.Drawing.Point(735, 282);
            this.carEngineTxt.Name = "carEngineTxt";
            this.carEngineTxt.Size = new System.Drawing.Size(286, 29);
            this.carEngineTxt.TabIndex = 9;
            this.carEngineTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carEngineTxt_KeyPress);
            // 
            // carEngineLbl
            // 
            this.carEngineLbl.AutoSize = true;
            this.carEngineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carEngineLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carEngineLbl.Location = new System.Drawing.Point(564, 282);
            this.carEngineLbl.Name = "carEngineLbl";
            this.carEngineLbl.Size = new System.Drawing.Size(97, 24);
            this.carEngineLbl.TabIndex = 44;
            this.carEngineLbl.Text = "Engine: *";
            // 
            // carNumberTxt
            // 
            this.carNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carNumberTxt.Location = new System.Drawing.Point(735, 57);
            this.carNumberTxt.Name = "carNumberTxt";
            this.carNumberTxt.Size = new System.Drawing.Size(286, 29);
            this.carNumberTxt.TabIndex = 5;
            this.carNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carNumberTxt_KeyPress);
            // 
            // carYearLbl
            // 
            this.carYearLbl.AutoSize = true;
            this.carYearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carYearLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carYearLbl.Location = new System.Drawing.Point(564, 223);
            this.carYearLbl.Name = "carYearLbl";
            this.carYearLbl.Size = new System.Drawing.Size(73, 24);
            this.carYearLbl.TabIndex = 40;
            this.carYearLbl.Text = "Year: *";
            // 
            // carModelLbl
            // 
            this.carModelLbl.AutoSize = true;
            this.carModelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carModelLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carModelLbl.Location = new System.Drawing.Point(564, 169);
            this.carModelLbl.Name = "carModelLbl";
            this.carModelLbl.Size = new System.Drawing.Size(88, 24);
            this.carModelLbl.TabIndex = 39;
            this.carModelLbl.Text = "Model: *";
            // 
            // carManufactureLbl
            // 
            this.carManufactureLbl.AutoSize = true;
            this.carManufactureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carManufactureLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carManufactureLbl.Location = new System.Drawing.Point(564, 115);
            this.carManufactureLbl.Name = "carManufactureLbl";
            this.carManufactureLbl.Size = new System.Drawing.Size(145, 24);
            this.carManufactureLbl.TabIndex = 38;
            this.carManufactureLbl.Text = "Manufacture: *";
            // 
            // carNumberLbl
            // 
            this.carNumberLbl.AutoSize = true;
            this.carNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carNumberLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carNumberLbl.Location = new System.Drawing.Point(564, 57);
            this.carNumberLbl.Name = "carNumberLbl";
            this.carNumberLbl.Size = new System.Drawing.Size(143, 24);
            this.carNumberLbl.TabIndex = 37;
            this.carNumberLbl.Text = "Car Number: *";
            // 
            // carKMTxt
            // 
            this.carKMTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carKMTxt.Location = new System.Drawing.Point(735, 341);
            this.carKMTxt.Name = "carKMTxt";
            this.carKMTxt.Size = new System.Drawing.Size(286, 29);
            this.carKMTxt.TabIndex = 10;
            this.carKMTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carKMTxt_KeyPress);
            // 
            // kmLbl
            // 
            this.kmLbl.AutoSize = true;
            this.kmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kmLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kmLbl.Location = new System.Drawing.Point(564, 341);
            this.kmLbl.Name = "kmLbl";
            this.kmLbl.Size = new System.Drawing.Size(60, 24);
            this.kmLbl.TabIndex = 47;
            this.kmLbl.Text = "KM: *";
            // 
            // vinNumberTxt
            // 
            this.vinNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vinNumberTxt.Location = new System.Drawing.Point(735, 400);
            this.vinNumberTxt.Name = "vinNumberTxt";
            this.vinNumberTxt.Size = new System.Drawing.Size(286, 29);
            this.vinNumberTxt.TabIndex = 11;
            this.vinNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vinNumberTxt_KeyPress);
            // 
            // vinNumberLbl
            // 
            this.vinNumberLbl.AutoSize = true;
            this.vinNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vinNumberLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vinNumberLbl.Location = new System.Drawing.Point(564, 400);
            this.vinNumberLbl.Name = "vinNumberLbl";
            this.vinNumberLbl.Size = new System.Drawing.Size(142, 24);
            this.vinNumberLbl.TabIndex = 49;
            this.vinNumberLbl.Text = "Vin Number: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Create new client";
            // 
            // manufactureComboBox
            // 
            this.manufactureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufactureComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manufactureComboBox.FormattingEnabled = true;
            this.manufactureComboBox.Location = new System.Drawing.Point(735, 106);
            this.manufactureComboBox.Name = "manufactureComboBox";
            this.manufactureComboBox.Size = new System.Drawing.Size(286, 32);
            this.manufactureComboBox.TabIndex = 6;
            this.manufactureComboBox.SelectedIndexChanged += new System.EventHandler(this.manufactureComboBox_SelectedIndexChanged);
            this.manufactureComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.manufactureComboBox_KeyPress);
            // 
            // modelsComboBox
            // 
            this.modelsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.modelsComboBox.FormattingEnabled = true;
            this.modelsComboBox.Location = new System.Drawing.Point(735, 169);
            this.modelsComboBox.Name = "modelsComboBox";
            this.modelsComboBox.Size = new System.Drawing.Size(286, 32);
            this.modelsComboBox.TabIndex = 7;
            this.modelsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modelsComboBox_KeyPress);
            // 
            // CreateNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1062, 545);
            this.Controls.Add(this.modelsComboBox);
            this.Controls.Add(this.manufactureComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vinNumberTxt);
            this.Controls.Add(this.vinNumberLbl);
            this.Controls.Add(this.carKMTxt);
            this.Controls.Add(this.kmLbl);
            this.Controls.Add(this.carYearTxt);
            this.Controls.Add(this.carEngineTxt);
            this.Controls.Add(this.carEngineLbl);
            this.Controls.Add(this.carNumberTxt);
            this.Controls.Add(this.carYearLbl);
            this.Controls.Add(this.carModelLbl);
            this.Controls.Add(this.carManufactureLbl);
            this.Controls.Add(this.carNumberLbl);
            this.Controls.Add(this.createNewClientBtn);
            this.Controls.Add(this.clientEmailTxt);
            this.Controls.Add(this.clientAddressTxt);
            this.Controls.Add(this.clientAddressLbl);
            this.Controls.Add(this.clientPhoneTxt);
            this.Controls.Add(this.clientFullNameTxt);
            this.Controls.Add(this.clientIdTxt);
            this.Controls.Add(this.clientEmailLbl);
            this.Controls.Add(this.clientPhoneLbl);
            this.Controls.Add(this.clientNameLbl);
            this.Controls.Add(this.clientIdLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewClient";
            this.Text = "CreateNewClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox clientPhoneTxt;
        private System.Windows.Forms.TextBox clientFullNameTxt;
        private System.Windows.Forms.TextBox clientIdTxt;
        private System.Windows.Forms.Label clientEmailLbl;
        private System.Windows.Forms.Label clientPhoneLbl;
        private System.Windows.Forms.Label clientNameLbl;
        private System.Windows.Forms.Label clientIdLbl;
        private System.Windows.Forms.Label clientAddressLbl;
        private System.Windows.Forms.TextBox clientEmailTxt;
        private System.Windows.Forms.Button createNewClientBtn;
        private System.Windows.Forms.TextBox clientAddressTxt;
        private System.Windows.Forms.TextBox carYearTxt;
        private System.Windows.Forms.TextBox carEngineTxt;
        private System.Windows.Forms.Label carEngineLbl;
        private System.Windows.Forms.TextBox carNumberTxt;
        private System.Windows.Forms.Label carYearLbl;
        private System.Windows.Forms.Label carModelLbl;
        private System.Windows.Forms.Label carManufactureLbl;
        private System.Windows.Forms.Label carNumberLbl;
        private System.Windows.Forms.TextBox carKMTxt;
        private System.Windows.Forms.Label kmLbl;
        private System.Windows.Forms.TextBox vinNumberTxt;
        private System.Windows.Forms.Label vinNumberLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox manufactureComboBox;
        private System.Windows.Forms.ComboBox modelsComboBox;
    }
}