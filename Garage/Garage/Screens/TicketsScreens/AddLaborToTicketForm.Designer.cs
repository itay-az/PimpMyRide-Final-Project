namespace Garage.Screens.TicketsScreens
{
    partial class AddLaborToTicketForm
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
            this.addPartToTicketBtn = new System.Windows.Forms.Button();
            this.allLaborsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchPartBtn = new System.Windows.Forms.Button();
            this.laborNameLbl = new System.Windows.Forms.Label();
            this.searchLaborTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allLaborsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPartToTicketBtn
            // 
            this.addPartToTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addPartToTicketBtn.Location = new System.Drawing.Point(797, 478);
            this.addPartToTicketBtn.Name = "addPartToTicketBtn";
            this.addPartToTicketBtn.Size = new System.Drawing.Size(214, 45);
            this.addPartToTicketBtn.TabIndex = 4;
            this.addPartToTicketBtn.Text = "Add Labor";
            this.addPartToTicketBtn.UseVisualStyleBackColor = true;
            this.addPartToTicketBtn.Click += new System.EventHandler(this.addPartToTicketBtn_Click);
            // 
            // allLaborsDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.allLaborsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allLaborsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allLaborsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.allLaborsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.allLaborsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allLaborsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allLaborsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.allLaborsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allLaborsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.allLaborsDataGridView.EnableHeadersVisualStyles = false;
            this.allLaborsDataGridView.Location = new System.Drawing.Point(12, 77);
            this.allLaborsDataGridView.Name = "allLaborsDataGridView";
            this.allLaborsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allLaborsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.allLaborsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.allLaborsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.allLaborsDataGridView.Size = new System.Drawing.Size(999, 324);
            this.allLaborsDataGridView.TabIndex = 3;
            this.allLaborsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allLaborsDataGridView_CellContentClick);
            // 
            // searchPartBtn
            // 
            this.searchPartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchPartBtn.Location = new System.Drawing.Point(553, 18);
            this.searchPartBtn.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.searchPartBtn.Name = "searchPartBtn";
            this.searchPartBtn.Size = new System.Drawing.Size(138, 41);
            this.searchPartBtn.TabIndex = 2;
            this.searchPartBtn.Text = "Search";
            this.searchPartBtn.UseVisualStyleBackColor = true;
            this.searchPartBtn.Click += new System.EventHandler(this.searchPartBtn_Click);
            // 
            // laborNameLbl
            // 
            this.laborNameLbl.AutoSize = true;
            this.laborNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.laborNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.laborNameLbl.Location = new System.Drawing.Point(8, 18);
            this.laborNameLbl.Name = "laborNameLbl";
            this.laborNameLbl.Size = new System.Drawing.Size(136, 24);
            this.laborNameLbl.TabIndex = 115;
            this.laborNameLbl.Text = "Labor Name :";
            // 
            // searchLaborTxt
            // 
            this.searchLaborTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchLaborTxt.Location = new System.Drawing.Point(184, 18);
            this.searchLaborTxt.Name = "searchLaborTxt";
            this.searchLaborTxt.Size = new System.Drawing.Size(286, 29);
            this.searchLaborTxt.TabIndex = 1;
            // 
            // AddLaborToTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1027, 545);
            this.Controls.Add(this.addPartToTicketBtn);
            this.Controls.Add(this.allLaborsDataGridView);
            this.Controls.Add(this.searchPartBtn);
            this.Controls.Add(this.laborNameLbl);
            this.Controls.Add(this.searchLaborTxt);
            this.Name = "AddLaborToTicketForm";
            this.Text = "AddLaborToTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.allLaborsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addPartToTicketBtn;
        private System.Windows.Forms.DataGridView allLaborsDataGridView;
        private System.Windows.Forms.Button searchPartBtn;
        private System.Windows.Forms.Label laborNameLbl;
        private System.Windows.Forms.TextBox searchLaborTxt;
    }
}