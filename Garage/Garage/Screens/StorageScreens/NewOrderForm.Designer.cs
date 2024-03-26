namespace Garage.Screens.StorageScreens
{
    partial class NewOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrderForm));
            this.chooseSupplierComboBox = new System.Windows.Forms.ComboBox();
            this.chooseSupplierLbl = new System.Windows.Forms.Label();
            this.newOrderLbl = new System.Windows.Forms.Label();
            this.partQuantityTxt = new System.Windows.Forms.TextBox();
            this.partIdTxt = new System.Windows.Forms.TextBox();
            this.partNameTxt = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.partIdLbl = new System.Windows.Forms.Label();
            this.parNameLbl = new System.Windows.Forms.Label();
            this.morePartsBtn = new System.Windows.Forms.Button();
            this.placeOrderbtn = new System.Windows.Forms.Button();
            this.orderDetailsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sumPriceLbl = new System.Windows.Forms.Label();
            this.partPriceTxt = new System.Windows.Forms.TextBox();
            this.partPriceLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseSupplierComboBox
            // 
            this.chooseSupplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseSupplierComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseSupplierComboBox.FormattingEnabled = true;
            this.chooseSupplierComboBox.Location = new System.Drawing.Point(254, 94);
            this.chooseSupplierComboBox.Name = "chooseSupplierComboBox";
            this.chooseSupplierComboBox.Size = new System.Drawing.Size(193, 32);
            this.chooseSupplierComboBox.TabIndex = 1;
            // 
            // chooseSupplierLbl
            // 
            this.chooseSupplierLbl.AutoSize = true;
            this.chooseSupplierLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseSupplierLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chooseSupplierLbl.Location = new System.Drawing.Point(47, 94);
            this.chooseSupplierLbl.Name = "chooseSupplierLbl";
            this.chooseSupplierLbl.Size = new System.Drawing.Size(166, 24);
            this.chooseSupplierLbl.TabIndex = 53;
            this.chooseSupplierLbl.Text = "Choose Supplier";
            // 
            // newOrderLbl
            // 
            this.newOrderLbl.AutoSize = true;
            this.newOrderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newOrderLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newOrderLbl.Location = new System.Drawing.Point(47, 18);
            this.newOrderLbl.Name = "newOrderLbl";
            this.newOrderLbl.Size = new System.Drawing.Size(112, 24);
            this.newOrderLbl.TabIndex = 55;
            this.newOrderLbl.Text = "New Order";
            // 
            // partQuantityTxt
            // 
            this.partQuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partQuantityTxt.Location = new System.Drawing.Point(254, 297);
            this.partQuantityTxt.Name = "partQuantityTxt";
            this.partQuantityTxt.Size = new System.Drawing.Size(193, 29);
            this.partQuantityTxt.TabIndex = 5;
            this.partQuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partQuantityTxt_KeyPress);
            // 
            // partIdTxt
            // 
            this.partIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partIdTxt.Location = new System.Drawing.Point(254, 197);
            this.partIdTxt.Name = "partIdTxt";
            this.partIdTxt.Size = new System.Drawing.Size(193, 29);
            this.partIdTxt.TabIndex = 3;
            this.partIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partIdTxt_KeyPress);
            // 
            // partNameTxt
            // 
            this.partNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partNameTxt.Location = new System.Drawing.Point(254, 146);
            this.partNameTxt.Name = "partNameTxt";
            this.partNameTxt.Size = new System.Drawing.Size(193, 29);
            this.partNameTxt.TabIndex = 2;
            this.partNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partNameTxt_KeyPress);
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.quantityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantityLbl.Location = new System.Drawing.Point(47, 297);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(112, 24);
            this.quantityLbl.TabIndex = 58;
            this.quantityLbl.Text = "Quantity : *";
            // 
            // partIdLbl
            // 
            this.partIdLbl.AutoSize = true;
            this.partIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partIdLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partIdLbl.Location = new System.Drawing.Point(47, 197);
            this.partIdLbl.Name = "partIdLbl";
            this.partIdLbl.Size = new System.Drawing.Size(97, 24);
            this.partIdLbl.TabIndex = 57;
            this.partIdLbl.Text = "Part ID : *";
            // 
            // parNameLbl
            // 
            this.parNameLbl.AutoSize = true;
            this.parNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.parNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parNameLbl.Location = new System.Drawing.Point(47, 146);
            this.parNameLbl.Name = "parNameLbl";
            this.parNameLbl.Size = new System.Drawing.Size(133, 24);
            this.parNameLbl.TabIndex = 56;
            this.parNameLbl.Text = "Part Name : *";
            // 
            // morePartsBtn
            // 
            this.morePartsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.morePartsBtn.Location = new System.Drawing.Point(122, 382);
            this.morePartsBtn.Name = "morePartsBtn";
            this.morePartsBtn.Size = new System.Drawing.Size(214, 45);
            this.morePartsBtn.TabIndex = 6;
            this.morePartsBtn.Text = "More Parts";
            this.morePartsBtn.UseVisualStyleBackColor = true;
            this.morePartsBtn.Click += new System.EventHandler(this.morePartsBtn_Click);
            // 
            // placeOrderbtn
            // 
            this.placeOrderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.placeOrderbtn.Location = new System.Drawing.Point(418, 530);
            this.placeOrderbtn.Name = "placeOrderbtn";
            this.placeOrderbtn.Size = new System.Drawing.Size(214, 45);
            this.placeOrderbtn.TabIndex = 7;
            this.placeOrderbtn.Text = "Place Order";
            this.placeOrderbtn.UseVisualStyleBackColor = true;
            this.placeOrderbtn.Click += new System.EventHandler(this.placeOrderbtn_Click);
            // 
            // orderDetailsGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.orderDetailsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.orderDetailsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderDetailsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.orderDetailsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDetailsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDetailsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDetailsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderDetailsGridView.EnableHeadersVisualStyles = false;
            this.orderDetailsGridView.Location = new System.Drawing.Point(522, 94);
            this.orderDetailsGridView.Name = "orderDetailsGridView";
            this.orderDetailsGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDetailsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.orderDetailsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.orderDetailsGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.orderDetailsGridView.Size = new System.Drawing.Size(503, 294);
            this.orderDetailsGridView.TabIndex = 64;
            this.orderDetailsGridView.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(518, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Sum Order :";
            // 
            // sumPriceLbl
            // 
            this.sumPriceLbl.AutoSize = true;
            this.sumPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sumPriceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sumPriceLbl.Location = new System.Drawing.Point(718, 424);
            this.sumPriceLbl.Name = "sumPriceLbl";
            this.sumPriceLbl.Size = new System.Drawing.Size(0, 24);
            this.sumPriceLbl.TabIndex = 66;
            // 
            // partPriceTxt
            // 
            this.partPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partPriceTxt.Location = new System.Drawing.Point(254, 245);
            this.partPriceTxt.Name = "partPriceTxt";
            this.partPriceTxt.Size = new System.Drawing.Size(193, 29);
            this.partPriceTxt.TabIndex = 4;
            this.partPriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partPriceTxt_KeyPress);
            // 
            // partPriceLbl
            // 
            this.partPriceLbl.AutoSize = true;
            this.partPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partPriceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partPriceLbl.Location = new System.Drawing.Point(47, 245);
            this.partPriceLbl.Name = "partPriceLbl";
            this.partPriceLbl.Size = new System.Drawing.Size(126, 24);
            this.partPriceLbl.TabIndex = 67;
            this.partPriceLbl.Text = "Part Price : *";
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1232, 587);
            this.Controls.Add(this.partPriceTxt);
            this.Controls.Add(this.partPriceLbl);
            this.Controls.Add(this.sumPriceLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderDetailsGridView);
            this.Controls.Add(this.placeOrderbtn);
            this.Controls.Add(this.morePartsBtn);
            this.Controls.Add(this.partQuantityTxt);
            this.Controls.Add(this.partIdTxt);
            this.Controls.Add(this.partNameTxt);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.partIdLbl);
            this.Controls.Add(this.parNameLbl);
            this.Controls.Add(this.newOrderLbl);
            this.Controls.Add(this.chooseSupplierComboBox);
            this.Controls.Add(this.chooseSupplierLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewOrderForm";
            this.Text = "NewOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseSupplierComboBox;
        private System.Windows.Forms.Label chooseSupplierLbl;
        private System.Windows.Forms.Label newOrderLbl;
        private System.Windows.Forms.TextBox partQuantityTxt;
        private System.Windows.Forms.TextBox partIdTxt;
        private System.Windows.Forms.TextBox partNameTxt;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label partIdLbl;
        private System.Windows.Forms.Label parNameLbl;
        private System.Windows.Forms.Button morePartsBtn;
        private System.Windows.Forms.Button placeOrderbtn;
        private System.Windows.Forms.DataGridView orderDetailsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sumPriceLbl;
        private System.Windows.Forms.TextBox partPriceTxt;
        private System.Windows.Forms.Label partPriceLbl;
    }
}