namespace Garage.Screens.AdminScreens
{
    partial class AddNewManufactureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewManufactureForm));
            this.addManufactureNameLbl = new System.Windows.Forms.Label();
            this.addModelNameLbl = new System.Windows.Forms.Label();
            this.addManufactureNameTxt = new System.Windows.Forms.TextBox();
            this.addModelNameTxt = new System.Windows.Forms.TextBox();
            this.addManufactureWithModelBtn = new System.Windows.Forms.Button();
            this.deleteModelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addManufactureNameLbl
            // 
            this.addManufactureNameLbl.AutoSize = true;
            this.addManufactureNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addManufactureNameLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addManufactureNameLbl.Location = new System.Drawing.Point(54, 44);
            this.addManufactureNameLbl.Name = "addManufactureNameLbl";
            this.addManufactureNameLbl.Size = new System.Drawing.Size(189, 24);
            this.addManufactureNameLbl.TabIndex = 0;
            this.addManufactureNameLbl.Text = "Manufacture name:";
            // 
            // addModelNameLbl
            // 
            this.addModelNameLbl.AutoSize = true;
            this.addModelNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addModelNameLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addModelNameLbl.Location = new System.Drawing.Point(54, 95);
            this.addModelNameLbl.Name = "addModelNameLbl";
            this.addModelNameLbl.Size = new System.Drawing.Size(132, 24);
            this.addModelNameLbl.TabIndex = 1;
            this.addModelNameLbl.Text = "Model name:";
            // 
            // addManufactureNameTxt
            // 
            this.addManufactureNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addManufactureNameTxt.Location = new System.Drawing.Point(309, 47);
            this.addManufactureNameTxt.Name = "addManufactureNameTxt";
            this.addManufactureNameTxt.Size = new System.Drawing.Size(214, 29);
            this.addManufactureNameTxt.TabIndex = 1;
            // 
            // addModelNameTxt
            // 
            this.addModelNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addModelNameTxt.Location = new System.Drawing.Point(309, 99);
            this.addModelNameTxt.Name = "addModelNameTxt";
            this.addModelNameTxt.Size = new System.Drawing.Size(214, 29);
            this.addModelNameTxt.TabIndex = 2;
            // 
            // addManufactureWithModelBtn
            // 
            this.addManufactureWithModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addManufactureWithModelBtn.Location = new System.Drawing.Point(58, 191);
            this.addManufactureWithModelBtn.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.addManufactureWithModelBtn.Name = "addManufactureWithModelBtn";
            this.addManufactureWithModelBtn.Size = new System.Drawing.Size(214, 45);
            this.addManufactureWithModelBtn.TabIndex = 3;
            this.addManufactureWithModelBtn.Text = "Add model";
            this.addManufactureWithModelBtn.UseVisualStyleBackColor = true;
            this.addManufactureWithModelBtn.Click += new System.EventHandler(this.addManufactureWithModelBtn_Click);
            // 
            // deleteModelBtn
            // 
            this.deleteModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteModelBtn.Location = new System.Drawing.Point(309, 191);
            this.deleteModelBtn.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.deleteModelBtn.Name = "deleteModelBtn";
            this.deleteModelBtn.Size = new System.Drawing.Size(214, 45);
            this.deleteModelBtn.TabIndex = 4;
            this.deleteModelBtn.Text = "Delete model";
            this.deleteModelBtn.UseVisualStyleBackColor = true;
            this.deleteModelBtn.Click += new System.EventHandler(this.deleteModelBtn_Click);
            // 
            // AddNewManufactureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.deleteModelBtn);
            this.Controls.Add(this.addManufactureWithModelBtn);
            this.Controls.Add(this.addModelNameTxt);
            this.Controls.Add(this.addManufactureNameTxt);
            this.Controls.Add(this.addModelNameLbl);
            this.Controls.Add(this.addManufactureNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewManufactureForm";
            this.Text = "AddNewManufacture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addManufactureNameLbl;
        private System.Windows.Forms.Label addModelNameLbl;
        private System.Windows.Forms.TextBox addManufactureNameTxt;
        private System.Windows.Forms.TextBox addModelNameTxt;
        private System.Windows.Forms.Button addManufactureWithModelBtn;
        private System.Windows.Forms.Button deleteModelBtn;
    }
}