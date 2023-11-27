namespace Garage.Screens.ServiceAdvisor
{
    partial class AllClientsForm
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
            this.AllClientsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllClientsGridView
            // 
            this.AllClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClientsGridView.Location = new System.Drawing.Point(12, 12);
            this.AllClientsGridView.Name = "AllClientsGridView";
            this.AllClientsGridView.Size = new System.Drawing.Size(644, 414);
            this.AllClientsGridView.TabIndex = 0;
            // 
            // AllClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllClientsGridView);
            this.Name = "AllClientsForm";
            this.Text = "AllClientsForm";
            this.Load += new System.EventHandler(this.AllClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllClientsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllClientsGridView;
    }
}