namespace Garage.Screens.TicketsScreens
{
    partial class CreateNewTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewTicketForm));
            this.clientFullNameTxt = new System.Windows.Forms.TextBox();
            this.carNumberTxt = new System.Windows.Forms.TextBox();
            this.carNumberLbl = new System.Windows.Forms.Label();
            this.vinNumberTxt = new System.Windows.Forms.GroupBox();
            this.clientVinNumberTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.clientKmTxt = new System.Windows.Forms.TextBox();
            this.clientEngineTxt = new System.Windows.Forms.TextBox();
            this.clientYearTxt = new System.Windows.Forms.TextBox();
            this.clientModelTxt = new System.Windows.Forms.TextBox();
            this.clientManufactureTxt = new System.Windows.Forms.TextBox();
            this.clientEmailTxt = new System.Windows.Forms.TextBox();
            this.clientPhoneNumberTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchClientBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cuaseOfArrivalTxt = new System.Windows.Forms.TextBox();
            this.createTicketbtn = new System.Windows.Forms.Button();
            this.vinNumberTxt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientFullNameTxt
            // 
            this.clientFullNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientFullNameTxt.Location = new System.Drawing.Point(150, 44);
            this.clientFullNameTxt.Name = "clientFullNameTxt";
            this.clientFullNameTxt.Size = new System.Drawing.Size(153, 22);
            this.clientFullNameTxt.TabIndex = 3;
            // 
            // carNumberTxt
            // 
            this.carNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carNumberTxt.Location = new System.Drawing.Point(256, 27);
            this.carNumberTxt.Name = "carNumberTxt";
            this.carNumberTxt.Size = new System.Drawing.Size(214, 29);
            this.carNumberTxt.TabIndex = 1;
            this.carNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carNumberTxt_KeyPress);
            // 
            // carNumberLbl
            // 
            this.carNumberLbl.AutoSize = true;
            this.carNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carNumberLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carNumberLbl.Location = new System.Drawing.Point(85, 27);
            this.carNumberLbl.Name = "carNumberLbl";
            this.carNumberLbl.Size = new System.Drawing.Size(143, 24);
            this.carNumberLbl.TabIndex = 54;
            this.carNumberLbl.Text = "Car Number: *";
            // 
            // vinNumberTxt
            // 
            this.vinNumberTxt.BackColor = System.Drawing.Color.White;
            this.vinNumberTxt.Controls.Add(this.clientVinNumberTxt);
            this.vinNumberTxt.Controls.Add(this.label12);
            this.vinNumberTxt.Controls.Add(this.clientKmTxt);
            this.vinNumberTxt.Controls.Add(this.clientEngineTxt);
            this.vinNumberTxt.Controls.Add(this.clientYearTxt);
            this.vinNumberTxt.Controls.Add(this.clientModelTxt);
            this.vinNumberTxt.Controls.Add(this.clientManufactureTxt);
            this.vinNumberTxt.Controls.Add(this.clientEmailTxt);
            this.vinNumberTxt.Controls.Add(this.clientPhoneNumberTxt);
            this.vinNumberTxt.Controls.Add(this.label10);
            this.vinNumberTxt.Controls.Add(this.label8);
            this.vinNumberTxt.Controls.Add(this.label7);
            this.vinNumberTxt.Controls.Add(this.label6);
            this.vinNumberTxt.Controls.Add(this.label5);
            this.vinNumberTxt.Controls.Add(this.label3);
            this.vinNumberTxt.Controls.Add(this.label2);
            this.vinNumberTxt.Controls.Add(this.label1);
            this.vinNumberTxt.Controls.Add(this.clientFullNameTxt);
            this.vinNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vinNumberTxt.Location = new System.Drawing.Point(775, 27);
            this.vinNumberTxt.Name = "vinNumberTxt";
            this.vinNumberTxt.Size = new System.Drawing.Size(709, 279);
            this.vinNumberTxt.TabIndex = 68;
            this.vinNumberTxt.TabStop = false;
            this.vinNumberTxt.Text = "Car details";
            // 
            // clientVinNumberTxt
            // 
            this.clientVinNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientVinNumberTxt.Location = new System.Drawing.Point(465, 199);
            this.clientVinNumberTxt.Name = "clientVinNumberTxt";
            this.clientVinNumberTxt.Size = new System.Drawing.Size(153, 22);
            this.clientVinNumberTxt.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label12.Location = new System.Drawing.Point(363, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 87;
            this.label12.Text = "Vin Number:";
            // 
            // clientKmTxt
            // 
            this.clientKmTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientKmTxt.Location = new System.Drawing.Point(465, 241);
            this.clientKmTxt.Name = "clientKmTxt";
            this.clientKmTxt.Size = new System.Drawing.Size(153, 22);
            this.clientKmTxt.TabIndex = 11;
            // 
            // clientEngineTxt
            // 
            this.clientEngineTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientEngineTxt.Location = new System.Drawing.Point(465, 156);
            this.clientEngineTxt.Name = "clientEngineTxt";
            this.clientEngineTxt.Size = new System.Drawing.Size(153, 22);
            this.clientEngineTxt.TabIndex = 9;
            // 
            // clientYearTxt
            // 
            this.clientYearTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientYearTxt.Location = new System.Drawing.Point(465, 117);
            this.clientYearTxt.Name = "clientYearTxt";
            this.clientYearTxt.Size = new System.Drawing.Size(153, 22);
            this.clientYearTxt.TabIndex = 8;
            // 
            // clientModelTxt
            // 
            this.clientModelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientModelTxt.Location = new System.Drawing.Point(465, 75);
            this.clientModelTxt.Name = "clientModelTxt";
            this.clientModelTxt.Size = new System.Drawing.Size(153, 22);
            this.clientModelTxt.TabIndex = 7;
            // 
            // clientManufactureTxt
            // 
            this.clientManufactureTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientManufactureTxt.Location = new System.Drawing.Point(465, 34);
            this.clientManufactureTxt.Name = "clientManufactureTxt";
            this.clientManufactureTxt.Size = new System.Drawing.Size(153, 22);
            this.clientManufactureTxt.TabIndex = 6;
            // 
            // clientEmailTxt
            // 
            this.clientEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientEmailTxt.Location = new System.Drawing.Point(150, 120);
            this.clientEmailTxt.Name = "clientEmailTxt";
            this.clientEmailTxt.Size = new System.Drawing.Size(153, 22);
            this.clientEmailTxt.TabIndex = 5;
            // 
            // clientPhoneNumberTxt
            // 
            this.clientPhoneNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clientPhoneNumberTxt.Location = new System.Drawing.Point(150, 81);
            this.clientPhoneNumberTxt.Name = "clientPhoneNumberTxt";
            this.clientPhoneNumberTxt.Size = new System.Drawing.Size(153, 22);
            this.clientPhoneNumberTxt.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label10.Location = new System.Drawing.Point(363, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 78;
            this.label10.Text = "Manufacture:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label8.Location = new System.Drawing.Point(363, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "KM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label7.Location = new System.Drawing.Point(363, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 75;
            this.label7.Text = "Engine:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(363, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(363, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Phone number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Full Name: ";
            // 
            // searchClientBtn
            // 
            this.searchClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchClientBtn.Location = new System.Drawing.Point(256, 102);
            this.searchClientBtn.Name = "searchClientBtn";
            this.searchClientBtn.Size = new System.Drawing.Size(214, 45);
            this.searchClientBtn.TabIndex = 2;
            this.searchClientBtn.Text = "Search car";
            this.searchClientBtn.UseVisualStyleBackColor = true;
            this.searchClientBtn.Click += new System.EventHandler(this.searchClientBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cuaseOfArrivalTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(775, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 270);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cause of arrival";
            // 
            // cuaseOfArrivalTxt
            // 
            this.cuaseOfArrivalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cuaseOfArrivalTxt.Location = new System.Drawing.Point(9, 36);
            this.cuaseOfArrivalTxt.Multiline = true;
            this.cuaseOfArrivalTxt.Name = "cuaseOfArrivalTxt";
            this.cuaseOfArrivalTxt.Size = new System.Drawing.Size(694, 200);
            this.cuaseOfArrivalTxt.TabIndex = 12;
            // 
            // createTicketbtn
            // 
            this.createTicketbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createTicketbtn.Location = new System.Drawing.Point(569, 673);
            this.createTicketbtn.Name = "createTicketbtn";
            this.createTicketbtn.Size = new System.Drawing.Size(214, 45);
            this.createTicketbtn.TabIndex = 13;
            this.createTicketbtn.Text = "Create ticket";
            this.createTicketbtn.UseVisualStyleBackColor = true;
            this.createTicketbtn.Click += new System.EventHandler(this.createTicketbtn_Click);
            // 
            // CreateNewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1512, 743);
            this.Controls.Add(this.createTicketbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchClientBtn);
            this.Controls.Add(this.vinNumberTxt);
            this.Controls.Add(this.carNumberTxt);
            this.Controls.Add(this.carNumberLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(16, 40);
            this.Name = "CreateNewTicketForm";
            this.Text = "CreateNewTicketForm";
            this.vinNumberTxt.ResumeLayout(false);
            this.vinNumberTxt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox clientFullNameTxt;
        private System.Windows.Forms.TextBox carNumberTxt;
        private System.Windows.Forms.Label carNumberLbl;
        private System.Windows.Forms.GroupBox vinNumberTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientKmTxt;
        private System.Windows.Forms.TextBox clientEngineTxt;
        private System.Windows.Forms.TextBox clientYearTxt;
        private System.Windows.Forms.TextBox clientModelTxt;
        private System.Windows.Forms.TextBox clientManufactureTxt;
        private System.Windows.Forms.TextBox clientEmailTxt;
        private System.Windows.Forms.TextBox clientPhoneNumberTxt;
        private System.Windows.Forms.Button searchClientBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cuaseOfArrivalTxt;
        private System.Windows.Forms.Button createTicketbtn;
        private System.Windows.Forms.TextBox clientVinNumberTxt;
        private System.Windows.Forms.Label label12;
    }
}