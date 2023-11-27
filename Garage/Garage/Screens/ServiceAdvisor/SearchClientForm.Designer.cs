namespace Garage.Screens.ServiceAdvisor
{
    partial class SearchClientForm
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
            this.clientIdRadioBtn = new System.Windows.Forms.RadioButton();
            this.carIdRadioBtn = new System.Windows.Forms.RadioButton();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.searchClientBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientIdRadioBtn
            // 
            this.clientIdRadioBtn.AutoSize = true;
            this.clientIdRadioBtn.Location = new System.Drawing.Point(128, 54);
            this.clientIdRadioBtn.Name = "clientIdRadioBtn";
            this.clientIdRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.clientIdRadioBtn.TabIndex = 0;
            this.clientIdRadioBtn.TabStop = true;
            this.clientIdRadioBtn.Text = "Client id";
            this.clientIdRadioBtn.UseVisualStyleBackColor = true;
            this.clientIdRadioBtn.CheckedChanged += new System.EventHandler(this.clientIdRadioBtn_CheckedChanged);
            // 
            // carIdRadioBtn
            // 
            this.carIdRadioBtn.AutoSize = true;
            this.carIdRadioBtn.Location = new System.Drawing.Point(261, 54);
            this.carIdRadioBtn.Name = "carIdRadioBtn";
            this.carIdRadioBtn.Size = new System.Drawing.Size(52, 17);
            this.carIdRadioBtn.TabIndex = 1;
            this.carIdRadioBtn.TabStop = true;
            this.carIdRadioBtn.Text = "Car id";
            this.carIdRadioBtn.UseVisualStyleBackColor = true;
            this.carIdRadioBtn.CheckedChanged += new System.EventHandler(this.carIdRadioBtn_CheckedChanged);
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(128, 124);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(185, 20);
            this.inputTxt.TabIndex = 2;
            // 
            // searchClientBtn
            // 
            this.searchClientBtn.Location = new System.Drawing.Point(128, 224);
            this.searchClientBtn.Name = "searchClientBtn";
            this.searchClientBtn.Size = new System.Drawing.Size(185, 23);
            this.searchClientBtn.TabIndex = 3;
            this.searchClientBtn.Text = "Search";
            this.searchClientBtn.UseVisualStyleBackColor = true;
            this.searchClientBtn.Click += new System.EventHandler(this.searchClientBtn_Click);
            // 
            // SearchClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchClientBtn);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.carIdRadioBtn);
            this.Controls.Add(this.clientIdRadioBtn);
            this.Name = "SearchClientForm";
            this.Text = "SearchClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton clientIdRadioBtn;
        private System.Windows.Forms.RadioButton carIdRadioBtn;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Button searchClientBtn;
    }
}