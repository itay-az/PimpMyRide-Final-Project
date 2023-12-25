namespace Garage.Screens.AdminScreens
{
    partial class MaintenanceForm
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
            this.laborTimeTxt = new System.Windows.Forms.TextBox();
            this.laborTimeLbl = new System.Windows.Forms.Label();
            this.updateLaborBtn = new System.Windows.Forms.Button();
            this.deleteLaborBtn = new System.Windows.Forms.Button();
            this.createLaborBtn = new System.Windows.Forms.Button();
            this.laborPriceTxt = new System.Windows.Forms.TextBox();
            this.laborDescriptionTxt = new System.Windows.Forms.TextBox();
            this.laborPriceLbl = new System.Windows.Forms.Label();
            this.partNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allLaborsDataGridView = new System.Windows.Forms.DataGridView();
            this.laborIdTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allLaborsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // laborTimeTxt
            // 
            this.laborTimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.laborTimeTxt.Location = new System.Drawing.Point(1038, 134);
            this.laborTimeTxt.Name = "laborTimeTxt";
            this.laborTimeTxt.Size = new System.Drawing.Size(286, 29);
            this.laborTimeTxt.TabIndex = 4;
            // 
            // laborTimeLbl
            // 
            this.laborTimeLbl.AutoSize = true;
            this.laborTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.laborTimeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.laborTimeLbl.Location = new System.Drawing.Point(802, 134);
            this.laborTimeLbl.Name = "laborTimeLbl";
            this.laborTimeLbl.Size = new System.Drawing.Size(69, 24);
            this.laborTimeLbl.TabIndex = 46;
            this.laborTimeLbl.Text = "Time :";
            // 
            // updateLaborBtn
            // 
            this.updateLaborBtn.BackColor = System.Drawing.SystemColors.Control;
            this.updateLaborBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateLaborBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateLaborBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateLaborBtn.Location = new System.Drawing.Point(983, 205);
            this.updateLaborBtn.Name = "updateLaborBtn";
            this.updateLaborBtn.Size = new System.Drawing.Size(165, 50);
            this.updateLaborBtn.TabIndex = 6;
            this.updateLaborBtn.Text = "Update Labor";
            this.updateLaborBtn.UseVisualStyleBackColor = false;
            this.updateLaborBtn.Click += new System.EventHandler(this.updateLaborBtn_Click);
            // 
            // deleteLaborBtn
            // 
            this.deleteLaborBtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteLaborBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteLaborBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteLaborBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteLaborBtn.Location = new System.Drawing.Point(1159, 205);
            this.deleteLaborBtn.Name = "deleteLaborBtn";
            this.deleteLaborBtn.Size = new System.Drawing.Size(165, 50);
            this.deleteLaborBtn.TabIndex = 7;
            this.deleteLaborBtn.Text = "Delete Labor";
            this.deleteLaborBtn.UseVisualStyleBackColor = false;
            this.deleteLaborBtn.Click += new System.EventHandler(this.deleteLaborBtn_Click);
            // 
            // createLaborBtn
            // 
            this.createLaborBtn.BackColor = System.Drawing.SystemColors.Control;
            this.createLaborBtn.FlatAppearance.BorderSize = 0;
            this.createLaborBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createLaborBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createLaborBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createLaborBtn.Location = new System.Drawing.Point(806, 205);
            this.createLaborBtn.Name = "createLaborBtn";
            this.createLaborBtn.Size = new System.Drawing.Size(165, 50);
            this.createLaborBtn.TabIndex = 5;
            this.createLaborBtn.Text = "Create Labor";
            this.createLaborBtn.UseVisualStyleBackColor = false;
            this.createLaborBtn.Click += new System.EventHandler(this.createLaborBtn_Click);
            // 
            // laborPriceTxt
            // 
            this.laborPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.laborPriceTxt.Location = new System.Drawing.Point(1038, 90);
            this.laborPriceTxt.Name = "laborPriceTxt";
            this.laborPriceTxt.Size = new System.Drawing.Size(286, 29);
            this.laborPriceTxt.TabIndex = 3;
            // 
            // laborDescriptionTxt
            // 
            this.laborDescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.laborDescriptionTxt.Location = new System.Drawing.Point(1038, 46);
            this.laborDescriptionTxt.Name = "laborDescriptionTxt";
            this.laborDescriptionTxt.Size = new System.Drawing.Size(286, 29);
            this.laborDescriptionTxt.TabIndex = 2;
            // 
            // laborPriceLbl
            // 
            this.laborPriceLbl.AutoSize = true;
            this.laborPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.laborPriceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.laborPriceLbl.Location = new System.Drawing.Point(802, 90);
            this.laborPriceLbl.Name = "laborPriceLbl";
            this.laborPriceLbl.Size = new System.Drawing.Size(70, 24);
            this.laborPriceLbl.TabIndex = 45;
            this.laborPriceLbl.Text = "Price :";
            // 
            // partNameLbl
            // 
            this.partNameLbl.AutoSize = true;
            this.partNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partNameLbl.Location = new System.Drawing.Point(802, 46);
            this.partNameLbl.Name = "partNameLbl";
            this.partNameLbl.Size = new System.Drawing.Size(127, 24);
            this.partNameLbl.TabIndex = 44;
            this.partNameLbl.Text = "Description :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.allLaborsDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 672);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Labors";
            // 
            // allLaborsDataGridView
            // 
            this.allLaborsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allLaborsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.allLaborsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.allLaborsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allLaborsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allLaborsDataGridView.Location = new System.Drawing.Point(6, 25);
            this.allLaborsDataGridView.Name = "allLaborsDataGridView";
            this.allLaborsDataGridView.ReadOnly = true;
            this.allLaborsDataGridView.Size = new System.Drawing.Size(650, 641);
            this.allLaborsDataGridView.TabIndex = 13;
            this.allLaborsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allLaborsDataGridView_CellContentClick);
            // 
            // laborIdTxt
            // 
            this.laborIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.laborIdTxt.Location = new System.Drawing.Point(1217, 658);
            this.laborIdTxt.Name = "laborIdTxt";
            this.laborIdTxt.ReadOnly = true;
            this.laborIdTxt.Size = new System.Drawing.Size(286, 29);
            this.laborIdTxt.TabIndex = 48;
            this.laborIdTxt.Visible = false;
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1515, 705);
            this.Controls.Add(this.laborIdTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.laborTimeTxt);
            this.Controls.Add(this.laborTimeLbl);
            this.Controls.Add(this.updateLaborBtn);
            this.Controls.Add(this.deleteLaborBtn);
            this.Controls.Add(this.createLaborBtn);
            this.Controls.Add(this.laborPriceTxt);
            this.Controls.Add(this.laborDescriptionTxt);
            this.Controls.Add(this.laborPriceLbl);
            this.Controls.Add(this.partNameLbl);
            this.Name = "MaintenanceForm";
            this.Text = "MaintenanceForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allLaborsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox laborTimeTxt;
        private System.Windows.Forms.Label laborTimeLbl;
        private System.Windows.Forms.Button updateLaborBtn;
        private System.Windows.Forms.Button deleteLaborBtn;
        private System.Windows.Forms.Button createLaborBtn;
        private System.Windows.Forms.TextBox laborPriceTxt;
        private System.Windows.Forms.TextBox laborDescriptionTxt;
        private System.Windows.Forms.Label laborPriceLbl;
        private System.Windows.Forms.Label partNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView allLaborsDataGridView;
        private System.Windows.Forms.TextBox laborIdTxt;
    }
}