using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchNetworkUI
{
    public partial class U_APropos : Form
    {
        public U_APropos()
        {
            InitializeComponent();
        }

        private void U_APropos_Load(object sender, EventArgs e)
        {

            pictureBox1.Load("https://avatars1.githubusercontent.com/u/22911286?s=460&v=4");


        }
    }
}
