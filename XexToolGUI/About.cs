using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XexToolGUI
{
    partial class About : Form
    {      
         System.Media.SoundPlayer player { get; set; }
        public About()
        {
            InitializeComponent();
            player = new System.Media.SoundPlayer(new MemoryStream(Properties.Resources.About_sound));
            player.PlayLooping();
            this.Text = "Info XexTool GUI";
            this.labelProductName.Text = "XexToolGUI for xorloser's xextool";
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = "Copyright © Serenity 2022";
            this.labelCompanyName.Text = "Thanks to:";
            this.textBoxDescription.Text = "xorloser  for your Program and your Hard work" + "\r\n" + "Open Sourced By Serenity." + "\r\n" + "Copyright ©  mLoaD 2011";
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
            Program.xexgui.Show();
            Program.About = null;
            if(player != null)
            {
                player.Stop();
                player = null;
            }
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.xexgui.Show();
            Program.About = null;

            if (player != null)
            {
                player.Stop();
                player = null;
            }
        }
    }
}
