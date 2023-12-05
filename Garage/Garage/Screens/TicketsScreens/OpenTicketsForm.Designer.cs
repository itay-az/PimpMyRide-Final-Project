namespace Garage.Screens.TicketsScreens
{
    partial class OpenTicketsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AllTicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.selectTicketBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.carNumberLbl = new System.Windows.Forms.Label();
            this.searchCarNumberTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllTicketsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTicketsDataGridView
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.AllTicketsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.AllTicketsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllTicketsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllTicketsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.AllTicketsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllTicketsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllTicketsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.AllTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllTicketsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.AllTicketsDataGridView.EnableHeadersVisualStyles = false;
            this.AllTicketsDataGridView.Location = new System.Drawing.Point(12, 79);
            this.AllTicketsDataGridView.Name = "AllTicketsDataGridView";
            this.AllTicketsDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllTicketsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.AllTicketsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.AllTicketsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.AllTicketsDataGridView.Size = new System.Drawing.Size(1200, 640);
            this.AllTicketsDataGridView.TabIndex = 2;
            this.AllTicketsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllTicketsDataGridView_CellContentClick);
            // 
            // selectTicketBtn
            // 
            this.selectTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.selectTicketBtn.Location = new System.Drawing.Point(1225, 79);
            this.selectTicketBtn.Name = "selectTicketBtn";
            this.selectTicketBtn.Size = new System.Drawing.Size(214, 45);
            this.selectTicketBtn.TabIndex = 88;
            this.selectTicketBtn.Text = "Select";
            this.selectTicketBtn.UseVisualStyleBackColor = true;
            this.selectTicketBtn.Click += new System.EventHandler(this.selectTicketBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchBtn.Location = new System.Drawing.Point(560, 23);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(138, 41);
            this.searchBtn.TabIndex = 91;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // carNumberLbl
            // 
            this.carNumberLbl.AutoSize = true;
            this.carNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.carNumberLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carNumberLbl.Location = new System.Drawing.Point(15, 23);
            this.carNumberLbl.Name = "carNumberLbl";
            this.carNumberLbl.Size = new System.Drawing.Size(135, 24);
            this.carNumberLbl.TabIndex = 90;
            this.carNumberLbl.Text = "Car Number :";
            // 
            // searchCarNumberTxt
            // 
            this.searchCarNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchCarNumberTxt.Location = new System.Drawing.Point(191, 23);
            this.searchCarNumberTxt.Name = "searchCarNumberTxt";
            this.searchCarNumberTxt.Size = new System.Drawing.Size(286, 29);
            this.searchCarNumberTxt.TabIndex = 89;
            this.searchCarNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchCarNumberTxt_KeyPress);
            this.searchCarNumberTxt.Validating += new System.ComponentModel.CancelEventHandler(this.searchCarNumberTxt_Validating);
            // 
            // OpenTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1554, 734);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.carNumberLbl);
            this.Controls.Add(this.searchCarNumberTxt);
            this.Controls.Add(this.selectTicketBtn);
            this.Controls.Add(this.AllTicketsDataGridView);
            this.Name = "OpenTicketsForm";
            this.Text = "OpenTicketsForm";
            ((System.ComponentModel.ISupportInitialize)(this.AllTicketsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllTicketsDataGridView;
        private System.Windows.Forms.Button selectTicketBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label carNumberLbl;
        private System.Windows.Forms.TextBox searchCarNumberTxt;
    }
}