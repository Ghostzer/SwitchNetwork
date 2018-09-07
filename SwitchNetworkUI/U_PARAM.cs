using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWifi;


namespace SwitchNetworkUI
{
    public partial class U_PARAM : Form
    {
        public U_PARAM()
        {
            InitializeComponent();
            
        }

        private static Wifi wifi;
        

        private void Btn_valider_Click(object sender, EventArgs e)
        {

            try
            {
                var Config = new IniFile("Settings.ini");
                Config.Write("InterfaceEthernetName", Txt_InterfaceEthernetName.Text);
                Config.Write("InterfaceWifiName", Txt_interfaceWifiName.Text);
                Config.Write("WifiNetworkName", Txt_wifiNetworkName.Text);
                Config.Write("AutoClose", Cb_autoClose.Checked.ToString());

                this.Close();
            }
            catch (Exception ex)
            {

                Txt_sb.Text = "Une erreur s'est produite.";
                MessageBox.Show("Une erreur s'est produite : " + ex, "Erreur");
            }
  

        }

        private void U_PARAM_Load(object sender, EventArgs e)
        {

            var Config = new IniFile("Settings.ini");
            string curFile = @"Settings.ini";

            if (File.Exists(curFile) == false)
            {

                Config.Write("InterfaceEthernetName", "");
                Config.Write("InterfaceWifiName", "");
                Config.Write("WifiNetworkName", "");
                Config.Write("AutoClose", "");

            }

            Txt_sb.Text = "En attente...";

            // Tbl
            Tbl_wifi.BackgroundColor = Color.White;
            Tbl_wifi.RowHeadersVisible = false;
            Tbl_wifi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tbl_wifi.AllowUserToAddRows = false;
            Tbl_wifi.AllowUserToResizeRows = false;

            // Fichier ini
            var InterfaceEthernetName = Config.Read("InterfaceEthernetName");
            var InterfaceWifiName = Config.Read("InterfaceWifiName");
            var WifiNetworkName = Config.Read("WifiNetworkName");
            var AutoClose = Config.Read("AutoClose");

            Txt_InterfaceEthernetName.Text = InterfaceEthernetName;
            Txt_interfaceWifiName.Text = InterfaceWifiName;
            Txt_wifiNetworkName.Text = WifiNetworkName;

            if (AutoClose != "") {
                Cb_autoClose.Checked = Convert.ToBoolean(AutoClose);
            }

            wifi = new Wifi();
            
            ListWifiPoints();

            // ToolTip
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.Cb_autoClose, "Ferme automatiquement l'application quand un mode est choisi sur l'écran de lancement.");

            

        }

        private IEnumerable<AccessPoint> ListWifiPoints()
        {

            Tbl_wifi.Rows.Clear();
            Tbl_wifi.Refresh();

            IEnumerable<AccessPoint> accessPoints = wifi.GetAccessPoints().OrderByDescending(ap => ap.SignalStrength);

            int i = 0;
            foreach (AccessPoint ap in accessPoints)
            {

                Tbl_wifi.Rows.Add();
                Tbl_wifi.Rows[i].Cells[0].Value = ap.Name;
                Tbl_wifi.Rows[i].Cells[1].Value = ap.SignalStrength;
                Tbl_wifi.Rows[i].Cells[2].Value = ap.IsConnected;

                i++;
            }

            if (Tbl_wifi.RowCount == 0)
            {
                Btn_rafraichirListeWifi.Text = "Aucune interface Wifi trouvée, impossible de rafraichir.";
            }
            else
            {
                Btn_rafraichirListeWifi.Text = "Rafraichir la liste.";
            }

            return accessPoints;
        }


        // BTN RAFRAICHIR WIFI
        private void Btn_rafraichirListeWifi_Click(object sender, EventArgs e)
        {
            ListWifiPoints();
        }

        private void Tbl_wifi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            string WifiName = Tbl_wifi.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

            Txt_wifiNetworkName.Text = WifiName;

        }

        // List des cartes ethernet
        private void ListEthernetInterface()
        {

            MenuInterfaceEthernet.Items.Clear();

            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    MenuInterfaceEthernet.Items.Add(netInterface.Name);
                }
            }

        }

        // List des cartes WIFI
        private void ListWifiInterface()
        {

            MenuInterfaceWifi.Items.Clear();

            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    MenuInterfaceWifi.Items.Add(netInterface.Name);
                }
            }

        }

        // Remplissage du menu ETHERNET
        private void Btn_listInterface_Click(object sender, EventArgs e)
        {
            ListEthernetInterface();
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            MenuInterfaceEthernet.Show(ptLowerLeft);
        }

        // Remplissage du menu WIFI
        private void Btn_listWifiInterface_Click(object sender, EventArgs e)
        {

            ListWifiInterface();
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            MenuInterfaceWifi.Show(ptLowerLeft);

        }

        private void MenuInterfaceEthernet_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Txt_InterfaceEthernetName.Text = e.ClickedItem.Text;
        }

        private void MenuInterfaceWifi_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Txt_interfaceWifiName.Text = e.ClickedItem.Text;
        }


        // Change True/False en Oui/Non pour la colonne "connecté"
        private void Tbl_wifi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "Connecte")
            {
                e.Value = (bool)e.Value ? "Oui" : "Non";
                e.FormattingApplied = true;
            }
        }

        
    }
}
