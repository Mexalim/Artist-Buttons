using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace ArtistButtons
{
    public partial class Form1 : Form
    {
        AutoItX3 auto = new AutoItX3();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Under_Click(object sender, EventArgs e)
        {
            auto.WinActivate("[REGEXPTITLE:(?i)Figma]");
            auto.Send("^z");
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            auto.WinActivate("[REGEXPTITLE:(?i)Figma]");
            auto.Send("^y");
        }

        private void CtrlX_Click(object sender, EventArgs e)
        {
            auto.WinActivate("[REGEXPTITLE:(?i)Figma]");
            auto.Send("^x");
        }

        private void CtrlV_Click(object sender, EventArgs e)
        {
            auto.WinActivate("[REGEXPTITLE:(?i)Figma]");
            auto.Send("^v");
        }

        private void CtrlC_Click(object sender, EventArgs e)
        {
            auto.WinActivate("[REGEXPTITLE:(?i)Figma]");
            auto.Send("^c");
        }
    }
}
