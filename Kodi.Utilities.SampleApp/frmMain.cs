using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodi.Utilities.SampleApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            setState(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void setState(bool state)
        {
            foreach (Control c in this.Controls)
                setControlState(state, c);
        }

        private void setControlState(bool state, Control c)
        {
            if (!(c is MenuStrip))
                c.Enabled = state;
            foreach (Control cc in c.Controls)
                setControlState(state, cc);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setState(true);
        }
    }
}
