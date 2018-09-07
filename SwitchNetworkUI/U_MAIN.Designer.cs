namespace SwitchNetworkUI
{
    partial class U_MAIN
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U_MAIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_connexionsReseau = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Txt_sb = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurerLesInterfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_ethernet = new System.Windows.Forms.Button();
            this.Btn_wifi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_connexionsReseau);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.Btn_ethernet);
            this.panel1.Controls.Add(this.Btn_wifi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 306);
            this.panel1.TabIndex = 0;
            // 
            // Btn_connexionsReseau
            // 
            this.Btn_connexionsReseau.BackColor = System.Drawing.Color.Transparent;
            this.Btn_connexionsReseau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_connexionsReseau.BackgroundImage")));
            this.Btn_connexionsReseau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_connexionsReseau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_connexionsReseau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_connexionsReseau.Location = new System.Drawing.Point(0, 204);
            this.Btn_connexionsReseau.Name = "Btn_connexionsReseau";
            this.Btn_connexionsReseau.Size = new System.Drawing.Size(275, 77);
            this.Btn_connexionsReseau.TabIndex = 6;
            this.Btn_connexionsReseau.UseVisualStyleBackColor = false;
            this.Btn_connexionsReseau.Click += new System.EventHandler(this.Btn_connexionsReseau_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Txt_sb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(275, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Txt_sb
            // 
            this.Txt_sb.Name = "Txt_sb";
            this.Txt_sb.Size = new System.Drawing.Size(39, 17);
            this.Txt_sb.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.paramètresToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurerLesInterfacesToolStripMenuItem});
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.paramètresToolStripMenuItem.Text = "Configurations";
            // 
            // configurerLesInterfacesToolStripMenuItem
            // 
            this.configurerLesInterfacesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configurerLesInterfacesToolStripMenuItem.Image")));
            this.configurerLesInterfacesToolStripMenuItem.Name = "configurerLesInterfacesToolStripMenuItem";
            this.configurerLesInterfacesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.configurerLesInterfacesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configurerLesInterfacesToolStripMenuItem.Text = "Interfaces...";
            this.configurerLesInterfacesToolStripMenuItem.Click += new System.EventHandler(this.configurerLesInterfacesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Btn_ethernet
            // 
            this.Btn_ethernet.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ethernet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ethernet.BackgroundImage")));
            this.Btn_ethernet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ethernet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ethernet.FlatAppearance.BorderSize = 0;
            this.Btn_ethernet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ethernet.Location = new System.Drawing.Point(0, 116);
            this.Btn_ethernet.Name = "Btn_ethernet";
            this.Btn_ethernet.Size = new System.Drawing.Size(275, 77);
            this.Btn_ethernet.TabIndex = 3;
            this.Btn_ethernet.UseVisualStyleBackColor = false;
            this.Btn_ethernet.Click += new System.EventHandler(this.Btn_ethernet_Click);
            // 
            // Btn_wifi
            // 
            this.Btn_wifi.BackColor = System.Drawing.Color.Transparent;
            this.Btn_wifi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_wifi.BackgroundImage")));
            this.Btn_wifi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_wifi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_wifi.FlatAppearance.BorderSize = 0;
            this.Btn_wifi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_wifi.Location = new System.Drawing.Point(0, 27);
            this.Btn_wifi.Name = "Btn_wifi";
            this.Btn_wifi.Size = new System.Drawing.Size(275, 77);
            this.Btn_wifi.TabIndex = 2;
            this.Btn_wifi.UseVisualStyleBackColor = false;
            this.Btn_wifi.Click += new System.EventHandler(this.Btn_wifi_Click);
            // 
            // U_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 306);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "U_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SwitchNetworkUI";
            this.Load += new System.EventHandler(this.U_MAIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_ethernet;
        private System.Windows.Forms.Button Btn_wifi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurerLesInterfacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button Btn_connexionsReseau;
        private System.Windows.Forms.ToolStripStatusLabel Txt_sb;
    }
}

