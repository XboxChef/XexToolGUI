using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XexToolGUI
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void XClose_Click(object sender, EventArgs e)
        {
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
            checker();
        }
    }
}
