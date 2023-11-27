namespace Garage.Screens.ServiceAdvisor
{
    partial class AllOffersForm
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
            this.allOffersGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allOffersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allOffersGridView
            // 
            this.allOffersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allOffersGridView.Location = new System.Drawing.Point(25, 23);
            this.allOffersGridView.Name = "allOffersGridView";
            this.allOffersGridView.Size = new System.Drawing.Size(544, 396);
            this.allOffersGridView.TabIndex = 0;
            // 
            // AllOffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allOffersGridView);
            this.Name = "AllOffersForm";
            this.Text = "AllOffersForm";
            this.Load += new System.EventHandler(this.AllOffersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allOffersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allOffersGridView;
    }
}