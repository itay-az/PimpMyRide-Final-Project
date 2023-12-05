namespace Garage.Screens.TicketsScreens
{
    partial class CloseTicketForm
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
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.closeTicketBtn = new System.Windows.Forms.Button();
            this.cardDateLbl = new System.Windows.Forms.Label();
            this.cardDateTxt = new System.Windows.Forms.TextBox();
            this.cardDigitsLbl = new System.Windows.Forms.Label();
            this.cardDigitsTxt = new System.Windows.Forms.TextBox();
            this.cardNumberLbl = new System.Windows.Forms.Label();
            this.cardNumberTxt = new System.Windows.Forms.TextBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.ticketPriceTxt = new System.Windows.Forms.TextBox();
            this.amountOfPaymentsComboBox = new System.Windows.Forms.ComboBox();
            this.amountOfPaymentsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Location = new System.Drawing.Point(23, 21);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(286, 32);
            this.paymentMethodComboBox.TabIndex = 80;
            this.paymentMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentMethodComboBox_SelectedIndexChanged);
            // 
            // closeTicketBtn
            // 
            this.closeTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.closeTicketBtn.Location = new System.Drawing.Point(749, 463);
            this.closeTicketBtn.Name = "closeTicketBtn";
            this.closeTicketBtn.Size = new System.Drawing.Size(249, 45);
            this.closeTicketBtn.TabIndex = 113;
            this.closeTicketBtn.Text = "Close Ticket";
            this.closeTicketBtn.UseVisualStyleBackColor = true;
            this.closeTicketBtn.Click += new System.EventHandler(this.closeTicketBtn_Click);
            // 
            // cardDateLbl
            // 
            this.cardDateLbl.AutoSize = true;
            this.cardDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cardDateLbl.ForeColor = System.Drawing.Color.White;
            this.cardDateLbl.Location = new System.Drawing.Point(147, 172);
            this.cardDateLbl.Name = "cardDateLbl";
            this.cardDateLbl.Size = new System.Drawing.Size(185, 24);
            this.cardDateLbl.TabIndex = 130;
            this.cardDateLbl.Text = "Date of expiration :";
            this.cardDateLbl.Visible = false;
            // 
            // cardDateTxt
            // 
            this.cardDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cardDateTxt.Location = new System.Drawing.Point(359, 172);
            this.cardDateTxt.Name = "cardDateTxt";
            this.cardDateTxt.Size = new System.Drawing.Size(188, 29);
            this.cardDateTxt.TabIndex = 129;
            this.cardDateTxt.Visible = false;
            this.cardDateTxt.TextChanged += new System.EventHandler(this.cardDateTxt_TextChanged);
            this.cardDateTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardDateTxt_KeyPress);
            this.cardDateTxt.Validating += new System.ComponentModel.CancelEventHandler(this.cardDateTxt_Validating);
            // 
            // cardDigitsLbl
            // 
            this.cardDigitsLbl.AutoSize = true;
            this.cardDigitsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cardDigitsLbl.ForeColor = System.Drawing.Color.White;
            this.cardDigitsLbl.Location = new System.Drawing.Point(147, 219);
            this.cardDigitsLbl.Name = "cardDigitsLbl";
            this.cardDigitsLbl.Size = new System.Drawing.Size(90, 24);
            this.cardDigitsLbl.TabIndex = 128;
            this.cardDigitsLbl.Text = "3 Digits :";
            this.cardDigitsLbl.Visible = false;
            // 
            // cardDigitsTxt
            // 
            this.cardDigitsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cardDigitsTxt.Location = new System.Drawing.Point(359, 219);
            this.cardDigitsTxt.Name = "cardDigitsTxt";
            this.cardDigitsTxt.Size = new System.Drawing.Size(188, 29);
            this.cardDigitsTxt.TabIndex = 127;
            this.cardDigitsTxt.Visible = false;
            this.cardDigitsTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardDigitsTxt_KeyPress);
            // 
            // cardNumberLbl
            // 
            this.cardNumberLbl.AutoSize = true;
            this.cardNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cardNumberLbl.ForeColor = System.Drawing.Color.White;
            this.cardNumberLbl.Location = new System.Drawing.Point(147, 129);
            this.cardNumberLbl.Name = "cardNumberLbl";
            this.cardNumberLbl.Size = new System.Drawing.Size(144, 24);
            this.cardNumberLbl.TabIndex = 126;
            this.cardNumberLbl.Text = "Card number :";
            this.cardNumberLbl.Visible = false;
            // 
            // cardNumberTxt
            // 
            this.cardNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cardNumberTxt.Location = new System.Drawing.Point(359, 129);
            this.cardNumberTxt.Name = "cardNumberTxt";
            this.cardNumberTxt.Size = new System.Drawing.Size(188, 29);
            this.cardNumberTxt.TabIndex = 125;
            this.cardNumberTxt.Visible = false;
            this.cardNumberTxt.TextChanged += new System.EventHandler(this.cardNumberTxt_TextChanged);
            this.cardNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardNumberTxt_KeyPress);
            this.cardNumberTxt.Validating += new System.ComponentModel.CancelEventHandler(this.cardNumberTxt_Validating);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.amountLbl.ForeColor = System.Drawing.Color.White;
            this.amountLbl.Location = new System.Drawing.Point(147, 268);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(94, 24);
            this.amountLbl.TabIndex = 132;
            this.amountLbl.Text = "Amount :";
            // 
            // ticketPriceTxt
            // 
            this.ticketPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ticketPriceTxt.Location = new System.Drawing.Point(359, 268);
            this.ticketPriceTxt.Name = "ticketPriceTxt";
            this.ticketPriceTxt.ReadOnly = true;
            this.ticketPriceTxt.Size = new System.Drawing.Size(188, 29);
            this.ticketPriceTxt.TabIndex = 131;
            // 
            // amountOfPaymentsComboBox
            // 
            this.amountOfPaymentsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.amountOfPaymentsComboBox.FormattingEnabled = true;
            this.amountOfPaymentsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.amountOfPaymentsComboBox.Location = new System.Drawing.Point(452, 339);
            this.amountOfPaymentsComboBox.Name = "amountOfPaymentsComboBox";
            this.amountOfPaymentsComboBox.Size = new System.Drawing.Size(95, 32);
            this.amountOfPaymentsComboBox.TabIndex = 133;
            this.amountOfPaymentsComboBox.Visible = false;
            // 
            // amountOfPaymentsLbl
            // 
            this.amountOfPaymentsLbl.AutoSize = true;
            this.amountOfPaymentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.amountOfPaymentsLbl.ForeColor = System.Drawing.Color.White;
            this.amountOfPaymentsLbl.Location = new System.Drawing.Point(147, 347);
            this.amountOfPaymentsLbl.Name = "amountOfPaymentsLbl";
            this.amountOfPaymentsLbl.Size = new System.Drawing.Size(215, 24);
            this.amountOfPaymentsLbl.TabIndex = 134;
            this.amountOfPaymentsLbl.Text = "How many payments :";
            this.amountOfPaymentsLbl.Visible = false;
            // 
            // CloseTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1027, 545);
            this.Controls.Add(this.amountOfPaymentsLbl);
            this.Controls.Add(this.amountOfPaymentsComboBox);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.ticketPriceTxt);
            this.Controls.Add(this.cardDateLbl);
            this.Controls.Add(this.cardDateTxt);
            this.Controls.Add(this.cardDigitsLbl);
            this.Controls.Add(this.cardDigitsTxt);
            this.Controls.Add(this.cardNumberLbl);
            this.Controls.Add(this.cardNumberTxt);
            this.Controls.Add(this.closeTicketBtn);
            this.Controls.Add(this.paymentMethodComboBox);
            this.Name = "CloseTicketForm";
            this.Text = "CloseTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.Button closeTicketBtn;
        private System.Windows.Forms.Label cardDateLbl;
        private System.Windows.Forms.TextBox cardDateTxt;
        private System.Windows.Forms.Label cardDigitsLbl;
        private System.Windows.Forms.TextBox cardDigitsTxt;
        private System.Windows.Forms.Label cardNumberLbl;
        private System.Windows.Forms.TextBox cardNumberTxt;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TextBox ticketPriceTxt;
        private System.Windows.Forms.ComboBox amountOfPaymentsComboBox;
        private System.Windows.Forms.Label amountOfPaymentsLbl;
    }
}