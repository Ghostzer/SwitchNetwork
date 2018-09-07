namespace SwitchNetworkUI
{
    partial class U_PARAM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U_PARAM));
            this.Tbl_wifi = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Force = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Connecte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel_detail = new System.Windows.Forms.Panel();
            this.Btn_listWifiInterface = new System.Windows.Forms.Button();
            this.Btn_listInterface = new System.Windows.Forms.Button();
            this.Cb_autoClose = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Txt_sb = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_rafraichirListeWifi = new System.Windows.Forms.Button();
            this.Btn_valider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_wifiNetworkName = new System.Windows.Forms.TextBox();
            this.Txt_interfaceWifiName = new System.Windows.Forms.TextBox();
            this.Txt_InterfaceEthernetName = new System.Windows.Forms.TextBox();
            this.MenuInterfaceEthernet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuInterfaceWifi = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_wifi)).BeginInit();
            this.Panel_detail.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbl_wifi
            // 
            this.Tbl_wifi.AllowUserToAddRows = false;
            this.Tbl_wifi.AllowUserToDeleteRows = false;
            this.Tbl_wifi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_wifi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Force,
            this.Connecte});
            this.Tbl_wifi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_wifi.Location = new System.Drawing.Point(0, 0);
            this.Tbl_wifi.MultiSelect = false;
            this.Tbl_wifi.Name = "Tbl_wifi";
            this.Tbl_wifi.ReadOnly = true;
            this.Tbl_wifi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tbl_wifi.Size = new System.Drawing.Size(398, 420);
            this.Tbl_wifi.TabIndex = 10;
            this.Tbl_wifi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Tbl_wifi_CellFormatting);
            this.Tbl_wifi.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_wifi_RowEnter);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Force
            // 
            this.Force.HeaderText = "Force";
            this.Force.Name = "Force";
            this.Force.ReadOnly = true;
            // 
            // Connecte
            // 
            this.Connecte.HeaderText = "Connecté";
            this.Connecte.Name = "Connecte";
            this.Connecte.ReadOnly = true;
            this.Connecte.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Panel_detail
            // 
            this.Panel_detail.Controls.Add(this.Btn_listWifiInterface);
            this.Panel_detail.Controls.Add(this.Btn_listInterface);
            this.Panel_detail.Controls.Add(this.Cb_autoClose);
            this.Panel_detail.Controls.Add(this.statusStrip1);
            this.Panel_detail.Controls.Add(this.Btn_rafraichirListeWifi);
            this.Panel_detail.Controls.Add(this.Btn_valider);
            this.Panel_detail.Controls.Add(this.label3);
            this.Panel_detail.Controls.Add(this.label2);
            this.Panel_detail.Controls.Add(this.label1);
            this.Panel_detail.Controls.Add(this.Txt_wifiNetworkName);
            this.Panel_detail.Controls.Add(this.Txt_interfaceWifiName);
            this.Panel_detail.Controls.Add(this.Txt_InterfaceEthernetName);
            this.Panel_detail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_detail.Location = new System.Drawing.Point(0, 200);
            this.Panel_detail.Name = "Panel_detail";
            this.Panel_detail.Size = new System.Drawing.Size(398, 220);
            this.Panel_detail.TabIndex = 11;
            // 
            // Btn_listWifiInterface
            // 
            this.Btn_listWifiInterface.Location = new System.Drawing.Point(161, 126);
            this.Btn_listWifiInterface.Name = "Btn_listWifiInterface";
            this.Btn_listWifiInterface.Size = new System.Drawing.Size(23, 23);
            this.Btn_listWifiInterface.TabIndex = 23;
            this.Btn_listWifiInterface.Text = ">";
            this.Btn_listWifiInterface.UseVisualStyleBackColor = true;
            this.Btn_listWifiInterface.Click += new System.EventHandler(this.Btn_listWifiInterface_Click);
            // 
            // Btn_listInterface
            // 
            this.Btn_listInterface.Location = new System.Drawing.Point(161, 73);
            this.Btn_listInterface.Name = "Btn_listInterface";
            this.Btn_listInterface.Size = new System.Drawing.Size(23, 23);
            this.Btn_listInterface.TabIndex = 22;
            this.Btn_listInterface.Text = ">";
            this.Btn_listInterface.UseVisualStyleBackColor = true;
            this.Btn_listInterface.Click += new System.EventHandler(this.Btn_listInterface_Click);
            // 
            // Cb_autoClose
            // 
            this.Cb_autoClose.AutoSize = true;
            this.Cb_autoClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cb_autoClose.Location = new System.Drawing.Point(230, 128);
            this.Cb_autoClose.Name = "Cb_autoClose";
            this.Cb_autoClose.Size = new System.Drawing.Size(142, 17);
            this.Cb_autoClose.TabIndex = 21;
            this.Cb_autoClose.Text = "Fermer automatiquement";
            this.Cb_autoClose.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Txt_sb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 198);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(398, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Txt_sb
            // 
            this.Txt_sb.Name = "Txt_sb";
            this.Txt_sb.Size = new System.Drawing.Size(39, 17);
            this.Txt_sb.Text = "Status";
            // 
            // Btn_rafraichirListeWifi
            // 
            this.Btn_rafraichirListeWifi.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_rafraichirListeWifi.Location = new System.Drawing.Point(0, 0);
            this.Btn_rafraichirListeWifi.Name = "Btn_rafraichirListeWifi";
            this.Btn_rafraichirListeWifi.Size = new System.Drawing.Size(398, 29);
            this.Btn_rafraichirListeWifi.TabIndex = 19;
            this.Btn_rafraichirListeWifi.Text = "Rafraichir la liste.";
            this.Btn_rafraichirListeWifi.UseVisualStyleBackColor = true;
            this.Btn_rafraichirListeWifi.Click += new System.EventHandler(this.Btn_rafraichirListeWifi_Click);
            // 
            // Btn_valider
            // 
            this.Btn_valider.Location = new System.Drawing.Point(159, 163);
            this.Btn_valider.Name = "Btn_valider";
            this.Btn_valider.Size = new System.Drawing.Size(75, 23);
            this.Btn_valider.TabIndex = 18;
            this.Btn_valider.Text = "Valider";
            this.Btn_valider.UseVisualStyleBackColor = true;
            this.Btn_valider.Click += new System.EventHandler(this.Btn_valider_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nom du réseau Wifi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nom interface Wifi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom interface Ethernet";
            // 
            // Txt_wifiNetworkName
            // 
            this.Txt_wifiNetworkName.Location = new System.Drawing.Point(230, 74);
            this.Txt_wifiNetworkName.Name = "Txt_wifiNetworkName";
            this.Txt_wifiNetworkName.Size = new System.Drawing.Size(131, 20);
            this.Txt_wifiNetworkName.TabIndex = 13;
            // 
            // Txt_interfaceWifiName
            // 
            this.Txt_interfaceWifiName.Location = new System.Drawing.Point(25, 128);
            this.Txt_interfaceWifiName.Name = "Txt_interfaceWifiName";
            this.Txt_interfaceWifiName.Size = new System.Drawing.Size(131, 20);
            this.Txt_interfaceWifiName.TabIndex = 11;
            // 
            // Txt_InterfaceEthernetName
            // 
            this.Txt_InterfaceEthernetName.Location = new System.Drawing.Point(25, 74);
            this.Txt_InterfaceEthernetName.Name = "Txt_InterfaceEthernetName";
            this.Txt_InterfaceEthernetName.Size = new System.Drawing.Size(131, 20);
            this.Txt_InterfaceEthernetName.TabIndex = 10;
            // 
            // MenuInterfaceEthernet
            // 
            this.MenuInterfaceEthernet.Name = "contextMenuStrip1";
            this.MenuInterfaceEthernet.Size = new System.Drawing.Size(61, 4);
            this.MenuInterfaceEthernet.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuInterfaceEthernet_ItemClicked);
            // 
            // MenuInterfaceWifi
            // 
            this.MenuInterfaceWifi.Name = "MenuInterfaceWifi";
            this.MenuInterfaceWifi.Size = new System.Drawing.Size(61, 4);
            this.MenuInterfaceWifi.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuInterfaceWifi_ItemClicked);
            // 
            // U_PARAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 420);
            this.Controls.Add(this.Panel_detail);
            this.Controls.Add(this.Tbl_wifi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "U_PARAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration des interfaces";
            this.Load += new System.EventHandler(this.U_PARAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_wifi)).EndInit();
            this.Panel_detail.ResumeLayout(false);
            this.Panel_detail.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Tbl_wifi;
        private System.Windows.Forms.Panel Panel_detail;
        private System.Windows.Forms.Button Btn_rafraichirListeWifi;
        private System.Windows.Forms.Button Btn_valider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_wifiNetworkName;
        private System.Windows.Forms.TextBox Txt_interfaceWifiName;
        private System.Windows.Forms.TextBox Txt_InterfaceEthernetName;
        private System.Windows.Forms.ContextMenuStrip MenuInterfaceEthernet;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Txt_sb;
        private System.Windows.Forms.CheckBox Cb_autoClose;
        private System.Windows.Forms.Button Btn_listInterface;
        private System.Windows.Forms.Button Btn_listWifiInterface;
        private System.Windows.Forms.ContextMenuStrip MenuInterfaceWifi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Force;
        private System.Windows.Forms.DataGridViewTextBoxColumn Connecte;
    }
}