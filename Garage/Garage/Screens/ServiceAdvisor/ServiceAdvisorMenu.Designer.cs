namespace Garage.Screens.ServiceAdvisor
{
    partial class ServiceAdvisorMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOffersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.offersToolStripMenuItem,
            this.ticketsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allClientsToolStripMenuItem,
            this.createNewClientToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // allClientsToolStripMenuItem
            // 
            this.allClientsToolStripMenuItem.Name = "allClientsToolStripMenuItem";
            this.allClientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allClientsToolStripMenuItem.Text = "All clients";
            this.allClientsToolStripMenuItem.Click += new System.EventHandler(this.allClientsToolStripMenuItem_Click);
            // 
            // createNewClientToolStripMenuItem
            // 
            this.createNewClientToolStripMenuItem.Name = "createNewClientToolStripMenuItem";
            this.createNewClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNewClientToolStripMenuItem.Text = "Create new client";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "Search client";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // offersToolStripMenuItem
            // 
            this.offersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allOffersToolStripMenuItem,
            this.createOfferToolStripMenuItem});
            this.offersToolStripMenuItem.Name = "offersToolStripMenuItem";
            this.offersToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.offersToolStripMenuItem.Text = "Offers";
            // 
            // allOffersToolStripMenuItem
            // 
            this.allOffersToolStripMenuItem.Name = "allOffersToolStripMenuItem";
            this.allOffersToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.allOffersToolStripMenuItem.Text = "All offers";
            // 
            // createOfferToolStripMenuItem
            // 
            this.createOfferToolStripMenuItem.Name = "createOfferToolStripMenuItem";
            this.createOfferToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.createOfferToolStripMenuItem.Text = "Create offer";
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // ServiceAdvisorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ServiceAdvisorMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOffersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
    }
}