using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Security.Principal;
using System.Net.NetworkInformation;
using System.Threading;

namespace SwitchNetworkUI
{
    public partial class U_MAIN : Form
    {

        public U_MAIN()
        {
            InitializeComponent();

            Btn_wifi.FlatStyle = FlatStyle.Flat;
            Btn_wifi.FlatAppearance.BorderSize = 0;

            Btn_ethernet.FlatStyle = FlatStyle.Flat;
            Btn_ethernet.FlatAppearance.BorderSize = 0;

            Btn_connexionsReseau.FlatStyle = FlatStyle.Flat;
            Btn_connexionsReseau.FlatAppearance.BorderSize = 0;

            var Config = new IniFile("Settings.ini");

        }

        // BOUTON WIFI
        // Ethernet se désactive, le wifi s'active
        // Connexion auto au réseau wifi ciblé

        private void Btn_wifi_Click(object sender, EventArgs e)
        {

            if (IsUserAdministrator())
            {

                try
                {

                    var Config = new IniFile("Settings.ini");

                    var InterfaceEthernetName = Config.Read("InterfaceEthernetName");
                    var InterfaceWifiName = Config.Read("InterfaceWifiName");
                    var WifiNetworkName = Config.Read("WifiNetworkName");
                    var AutoClose = Config.Read("AutoClose");

                    Txt_sb.Text = "Désactivation de l'ethernet.";
                    DisableAdapter(InterfaceEthernetName);
                    Txt_sb.Text = "Activation Wifi.";
                    EnableAdapter(InterfaceWifiName);

                    Txt_sb.Text = "Connexion au wifi... ";
                    // future Attente de 2sec

                    ConnectTo(WifiNetworkName);
                    Txt_sb.Text = "Processus terminé." ;

                    if (AutoClose == "True")
                    {
                        Application.Exit();
                    }

                }
                catch (Exception ee)
                {
                    Txt_sb.Text = "Une erreur est survenue.";
                    MessageBox.Show("Une erreur est survenue : " + ee, "Erreur");
                }


            }
            else
            {
                MessageBox.Show("Merci de lancer le programme en Mode Administrateur.", "Admin requis");
                Txt_sb.Text = "Mode administrateur requis.";
            } 

        }


        // BOUTON ETHERNET
        // Le wifi se désactive, l'ethernet s'active

        private void Btn_ethernet_Click(object sender, EventArgs e)
        {

            if (IsUserAdministrator())
            {

                try
                {
                    var Config = new IniFile("Settings.ini");

                    var InterfaceEthernetName = Config.Read("InterfaceEthernetName");
                    var InterfaceWifiName = Config.Read("InterfaceWifiName");
                    var AutoClose = Config.Read("Auto_Close");

                    Txt_sb.Text = "Activation Wifi.";
                    DisableAdapter(InterfaceWifiName);
                    Txt_sb.Text = "Désactivation de l'ethernet.";
                    EnableAdapter(InterfaceEthernetName);
                    Txt_sb.Text = "Processus terminé.";

                    if (AutoClose == "True")
                    {
                        Application.Exit();
                    }

                }
                catch (Exception ee)
                {
                    Txt_sb.Text = "Une erreur est survenue.";
                    MessageBox.Show("Une erreur est survenue : " + ee, "Erreur");
                }


            }
            else
            {
                MessageBox.Show("Merci de lancer le programme en Mode Administrateur.", "Admin requis");
                Txt_sb.Text = "Mode administrateur requis.";
            }


        }

        // Commande de l'activation de l'interface

        static void EnableAdapter(string interfaceName)
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" enable");

            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            Process.Start(psi);

        }

        // Commande désactivation de l'interface

        static void DisableAdapter(string interfaceName)
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" disable");

            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            Process.Start(psi);

        }

        // Commande connexion automatique au réseau WIFI

        static void ConnectTo(string interfaceWifiName)
        {

            ProcessStartInfo psi = new ProcessStartInfo("netsh", "wlan connect name= \"" + interfaceWifiName + "\" ");

            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            Process.Start(psi);

        }

        // Affiche fenêtre connexions réseau
        static void AfficherConnexionsReseau()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("NCPA.cpl");
            startInfo.UseShellExecute = true;

            Process.Start(startInfo);
        }

        // Check si admin

        public bool IsUserAdministrator()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        private void Btn_connexionsReseau_Click(object sender, EventArgs e)
        {

            AfficherConnexionsReseau();

        }

        private void configurerLesInterfacesToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (CheckIfWifiActif() == false)
            {
                DialogResult dialogResult = MessageBox.Show("Une interface WIFI active est nécessaire. Voulez-vous en activer une ?", "Erreur", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AfficherConnexionsReseau();
                }
            }
            else
            {
                U_PARAM parametre = new U_PARAM();
                parametre.ShowDialog();
            }

            

        }

        private void U_MAIN_Load(object sender, EventArgs e)
        {
            Txt_sb.Text = "En attente...";

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.Btn_wifi, "Activer le WIFI => Désactiver l'ethernet => Connexion auto au WIFI");
            toolTip1.SetToolTip(this.Btn_ethernet, "Désactiver le WIFI => Activer l'ethernet");
            toolTip1.SetToolTip(this.Btn_connexionsReseau, "Ouvrir les connexions réseau");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Boolean CheckIfWifiActif()
        {

            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    return true;
                }
            }

            return false;


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            U_APropos apropos = new U_APropos();
            apropos.ShowDialog();
        }
    }
}
