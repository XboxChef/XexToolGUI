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

namespace XexToolGUI
{
    public partial class About : Form
    {
        System.Media.SoundPlayer player { get; set; }
        public About()
        {
            InitializeComponent();
            player = new System.Media.SoundPlayer(new MemoryStream(Properties.Resources.About_sound));
            player.PlayLooping();
        }

        private void XClose_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop();
                player = null;
            }
            Close();
            checker();

        }
        void checker()
        {
            if(Program.IDCScript != null)
            {
                Program.IDCScript.Show();
            }
            else if(Program.xml != null)
            {
                Program.xml.Show();
            }
            else if (Program.Dump != null)
            {
                Program.Dump.Show();
            }
            if(Program.IDCScript == null && Program.xml == null && Program.Dump == null)
            {
                Program.xexgui.Show();
                Program.Info = null;
            }
        }
        private void info_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (player != null)
            {
                player.Stop();
                player = null;
            }
            checker();
        }
    }
}
