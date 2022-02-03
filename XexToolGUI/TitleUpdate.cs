using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XexToolGUI
{
    public partial class TitleUpdate : Form
    {
        public TitleUpdate()
        {
            InitializeComponent();
        }

        private void XUpdatexbuc_Click(object sender, EventArgs e) => Process.Start("http://www.xbuc.net/?searchString=" + this.XGamename.Text + this.XMediaID.Text);

        private void XUpdateJQE360_Click(object sender, EventArgs e) => Process.Start("http://marketplace.jqe360.com/index.php?search=" + this.XGamename.Text + this.XMediaID.Text);

        private void Button1_Click(object sender, EventArgs e) => this.Close();

        private void Xcleartu_Click(object sender, EventArgs e)
        {
            this.XMediaID.Text = "";
            this.XGamename.Text = "";
        }

        private void Xclosetu_Click(object sender, EventArgs e)
        {
            Close();
            Program.xexgui.Show();
            Program.TitleUpdate = null;
        }

        private void TitleUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.xexgui.Show();
            Program.TitleUpdate = null;
        }
    }
}
