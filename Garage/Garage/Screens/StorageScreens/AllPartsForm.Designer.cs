namespace Garage.Screens.StorageScreens
{
    partial class AllPartsForm
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
            this.allPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.ticketsListComboBox = new System.Windows.Forms.ComboBox();
            this.updatePartBtn = new System.Windows.Forms.Button();
            this.deletePartBtn = new System.Windows.Forms.Button();
            this.createPartBtn = new System.Windows.Forms.Button();
            this.partPriceTxt = new System.Windows.Forms.TextBox();
            this.partNameTxt = new System.Windows.Forms.TextBox();
            this.partIdTxt = new System.Windows.Forms.TextBox();
            this.ticketsLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.partNameLbl = new System.Windows.Forms.Label();
            this.partIdLbl = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // allPartsDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.allPartsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allPartsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allPartsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.allPartsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.allPartsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allPartsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allPartsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.allPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allPartsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.allPartsDataGrid.EnableHeadersVisualStyles = false;
            this.allPartsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.allPartsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.allPartsDataGrid.Name = "allPartsDataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allPartsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.allPartsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.allPartsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.allPartsDataGrid.Size = new System.Drawing.Size(490, 615);
            this.allPartsDataGrid.TabIndex = 2;
            this.allPartsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allPartsDataGrid_CellContentClick);
            // 
            // ticketsListComboBox
            // 
            this.ticketsListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ticketsListComboBox.FormattingEnabled = true;
            this.ticketsListComboBox.Items.AddRange(new object[] {
            "Manager",
            "ServiceAdvisor",
            "Warehouse"});
            this.ticketsListComboBox.Location = new System.Drawing.Point(842, 271);
            this.ticketsListComboBox.Name = "ticketsListComboBox";
            this.ticketsListComboBox.Size = new System.Drawing.Size(286, 32);
            this.ticketsListComboBox.TabIndex = 33;
            // 
            // updatePartBtn
            // 
            this.updatePartBtn.BackColor = System.Drawing.Color.Gold;
            this.updatePartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updatePartBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updatePartBtn.Location = new System.Drawing.Point(823, 342);
            this.updatePartBtn.Name = "updatePartBtn";
            this.updatePartBtn.Size = new System.Drawing.Size(150, 50);
            this.updatePartBtn.TabIndex = 32;
            this.updatePartBtn.Text = "Update Part";
            this.updatePartBtn.UseVisualStyleBackColor = false;
            this.updatePartBtn.Click += new System.EventHandler(this.updatePartBtn_Click);
            // 
            // deletePartBtn
            // 
            this.deletePartBtn.BackColor = System.Drawing.Color.Red;
            this.deletePartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deletePartBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deletePartBtn.Location = new System.Drawing.Point(978, 342);
            this.deletePartBtn.Name = "deletePartBtn";
            this.deletePartBtn.Size = new System.Drawing.Size(150, 50);
            this.deletePartBtn.TabIndex = 31;
            this.deletePartBtn.Text = "Delete Part";
            this.deletePartBtn.UseVisualStyleBackColor = false;
            this.deletePartBtn.Click += new System.EventHandler(this.deletePartBtn_Click);
            // 
            // createPartBtn
            // 
            this.createPartBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.createPartBtn.FlatAppearance.BorderSize = 0;
            this.createPartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createPartBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createPartBtn.Location = new System.Drawing.Point(667, 342);
            this.createPartBtn.Name = "createPartBtn";
            this.createPartBtn.Size = new System.Drawing.Size(150, 50);
            this.createPartBtn.TabIndex = 30;
            this.createPartBtn.Text = "Create Part";
            this.createPartBtn.UseVisualStyleBackColor = false;
            this.createPartBtn.Click += new System.EventHandler(this.createPartBtn_Click);
            // 
            // partPriceTxt
            // 
            this.partPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partPriceTxt.Location = new System.Drawing.Point(842, 180);
            this.partPriceTxt.Name = "partPriceTxt";
            this.partPriceTxt.Size = new System.Drawing.Size(286, 29);
            this.partPriceTxt.TabIndex = 29;
            // 
            // partNameTxt
            // 
            this.partNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partNameTxt.Location = new System.Drawing.Point(842, 136);
            this.partNameTxt.Name = "partNameTxt";
            this.partNameTxt.Size = new System.Drawing.Size(286, 29);
            this.partNameTxt.TabIndex = 28;
            // 
            // partIdTxt
            // 
            this.partIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partIdTxt.Location = new System.Drawing.Point(842, 92);
            this.partIdTxt.Name = "partIdTxt";
            this.partIdTxt.Size = new System.Drawing.Size(286, 29);
            this.partIdTxt.TabIndex = 27;
            // 
            // ticketsLbl
            // 
            this.ticketsLbl.AutoSize = true;
            this.ticketsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ticketsLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ticketsLbl.Location = new System.Drawing.Point(672, 271);
            this.ticketsLbl.Name = "ticketsLbl";
            this.ticketsLbl.Size = new System.Drawing.Size(119, 24);
            this.ticketsLbl.TabIndex = 26;
            this.ticketsLbl.Text = "Tickets List:";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.priceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLbl.Location = new System.Drawing.Point(672, 180);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(70, 24);
            this.priceLbl.TabIndex = 25;
            this.priceLbl.Text = "Price: ";
            // 
            // partNameLbl
            // 
            this.partNameLbl.AutoSize = true;
            this.partNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partNameLbl.Location = new System.Drawing.Point(672, 136);
            this.partNameLbl.Name = "partNameLbl";
            this.partNameLbl.Size = new System.Drawing.Size(113, 24);
            this.partNameLbl.TabIndex = 24;
            this.partNameLbl.Text = "Part Name:";
            // 
            // partIdLbl
            // 
            this.partIdLbl.AutoSize = true;
            this.partIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partIdLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partIdLbl.Location = new System.Drawing.Point(672, 92);
            this.partIdLbl.Name = "partIdLbl";
            this.partIdLbl.Size = new System.Drawing.Size(83, 24);
            this.partIdLbl.TabIndex = 23;
            this.partIdLbl.Text = "Part ID :";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.quantityTxt.Location = new System.Drawing.Point(842, 224);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(286, 29);
            this.quantityTxt.TabIndex = 35;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.quantityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantityLbl.Location = new System.Drawing.Point(672, 224);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(92, 24);
            this.quantityLbl.TabIndex = 34;
            this.quantityLbl.Text = "Quantity:";
            // 
            // AllPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1515, 705);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.ticketsListComboBox);
            this.Controls.Add(this.updatePartBtn);
            this.Controls.Add(this.deletePartBtn);
            this.Controls.Add(this.createPartBtn);
            this.Controls.Add(this.partPriceTxt);
            this.Controls.Add(this.partNameTxt);
            this.Controls.Add(this.partIdTxt);
            this.Controls.Add(this.ticketsLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.partNameLbl);
            this.Controls.Add(this.partIdLbl);
            this.Controls.Add(this.allPartsDataGrid);
            this.Name = "AllPartsForm";
            this.Text = "AllPartsForm";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allPartsDataGrid;
        private System.Windows.Forms.ComboBox ticketsListComboBox;
        private System.Windows.Forms.Button updatePartBtn;
        private System.Windows.Forms.Button deletePartBtn;
        private System.Windows.Forms.Button createPartBtn;
        private System.Windows.Forms.TextBox partPriceTxt;
        private System.Windows.Forms.TextBox partNameTxt;
        private System.Windows.Forms.TextBox partIdTxt;
        private System.Windows.Forms.Label ticketsLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label partNameLbl;
        private System.Windows.Forms.Label partIdLbl;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label quantityLbl;
    }
}