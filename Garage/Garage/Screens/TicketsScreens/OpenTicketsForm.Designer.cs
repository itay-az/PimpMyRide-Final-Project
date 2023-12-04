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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.AllTicketsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AllTicketsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllTicketsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllTicketsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.AllTicketsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllTicketsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllTicketsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AllTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllTicketsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AllTicketsDataGridView.EnableHeadersVisualStyles = false;
            this.AllTicketsDataGridView.Location = new System.Drawing.Point(12, 79);
            this.AllTicketsDataGridView.Name = "AllTicketsDataGridView";
            this.AllTicketsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllTicketsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AllTicketsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.AllTicketsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.AllTicketsDataGridView.Size = new System.Drawing.Size(1199, 640);
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