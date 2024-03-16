namespace Garage.Screens.TicketsScreens
{
    partial class AddPartToTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPartToTicketForm));
            this.searchPartTxt = new System.Windows.Forms.TextBox();
            this.partNameLbl = new System.Windows.Forms.Label();
            this.searchPartBtn = new System.Windows.Forms.Button();
            this.allPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.addPartToTicketBtn = new System.Windows.Forms.Button();
            this.amountLbl = new System.Windows.Forms.Label();
            this.partAmountTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPartTxt
            // 
            this.searchPartTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchPartTxt.Location = new System.Drawing.Point(188, 28);
            this.searchPartTxt.Name = "searchPartTxt";
            this.searchPartTxt.Size = new System.Drawing.Size(286, 29);
            this.searchPartTxt.TabIndex = 1;
            // 
            // partNameLbl
            // 
            this.partNameLbl.AutoSize = true;
            this.partNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partNameLbl.Location = new System.Drawing.Point(12, 28);
            this.partNameLbl.Name = "partNameLbl";
            this.partNameLbl.Size = new System.Drawing.Size(119, 24);
            this.partNameLbl.TabIndex = 57;
            this.partNameLbl.Text = "Part Name :";
            // 
            // searchPartBtn
            // 
            this.searchPartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchPartBtn.Location = new System.Drawing.Point(557, 28);
            this.searchPartBtn.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.searchPartBtn.Name = "searchPartBtn";
            this.searchPartBtn.Size = new System.Drawing.Size(138, 41);
            this.searchPartBtn.TabIndex = 2;
            this.searchPartBtn.Text = "Search";
            this.searchPartBtn.UseVisualStyleBackColor = true;
            this.searchPartBtn.Click += new System.EventHandler(this.searchPartBtn_Click);
            // 
            // allPartsDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.allPartsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allPartsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.allPartsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.allPartsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allPartsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allPartsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.allPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allPartsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.allPartsDataGridView.EnableHeadersVisualStyles = false;
            this.allPartsDataGridView.Location = new System.Drawing.Point(16, 87);
            this.allPartsDataGridView.Name = "allPartsDataGridView";
            this.allPartsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allPartsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.allPartsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.allPartsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.allPartsDataGridView.Size = new System.Drawing.Size(999, 324);
            this.allPartsDataGridView.TabIndex = 3;
            this.allPartsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allPartsDataGridView_CellContentClick);
            // 
            // addPartToTicketBtn
            // 
            this.addPartToTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addPartToTicketBtn.Location = new System.Drawing.Point(801, 488);
            this.addPartToTicketBtn.Name = "addPartToTicketBtn";
            this.addPartToTicketBtn.Size = new System.Drawing.Size(214, 45);
            this.addPartToTicketBtn.TabIndex = 5;
            this.addPartToTicketBtn.Text = "Add Part";
            this.addPartToTicketBtn.UseVisualStyleBackColor = true;
            this.addPartToTicketBtn.Click += new System.EventHandler(this.addPartToTicketBtn_Click);
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.amountLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amountLbl.Location = new System.Drawing.Point(650, 431);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(94, 24);
            this.amountLbl.TabIndex = 113;
            this.amountLbl.Text = "Amount :";
            // 
            // partAmountTxt
            // 
            this.partAmountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partAmountTxt.Location = new System.Drawing.Point(801, 431);
            this.partAmountTxt.Name = "partAmountTxt";
            this.partAmountTxt.Size = new System.Drawing.Size(214, 29);
            this.partAmountTxt.TabIndex = 4;
            // 
            // AddPartToTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1027, 545);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.partAmountTxt);
            this.Controls.Add(this.addPartToTicketBtn);
            this.Controls.Add(this.allPartsDataGridView);
            this.Controls.Add(this.searchPartBtn);
            this.Controls.Add(this.partNameLbl);
            this.Controls.Add(this.searchPartTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPartToTicketForm";
            this.Text = "AddPartToTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchPartTxt;
        private System.Windows.Forms.Label partNameLbl;
        private System.Windows.Forms.Button searchPartBtn;
        private System.Windows.Forms.DataGridView allPartsDataGridView;
        private System.Windows.Forms.Button addPartToTicket;
        private System.Windows.Forms.Button addPartToTicketBtn;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TextBox partAmountTxt;
    }
}