using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.DebugSpew
{
    public partial class DebugSpewWindow : Form
    {
        public DebugSpewWindow(LiveSplitState state)
        {
            InitializeComponent();
            bool onTop = state.LayoutSettings == null ? false : state.LayoutSettings.AlwaysOnTop;
            TopMost = onTop;
            chkOnTop.Checked = onTop;
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            boxDebugSpew.Clear();
        }

        private void butExport_Click(object sender, EventArgs e)
        {
            string[] dump = new string[] { boxDebugSpew.Text };
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Log Files (*.log)|*.log";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(dialog.FileName, dump);
            }
            else return;
        }

        private void DoClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void chkOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkOnTop.Checked;
        }

        private void OnResize(object sender, EventArgs e)
        {
            int butY = Size.Height - 74;
            butClear.Location = new Point(Size.Width - 103, butY);
            butExport.Location = new Point(butClear.Location.X - 81, butY);
            chkOnTop.Location = new Point(chkOnTop.Location.X, butY + 4);
            boxDebugSpew.Size = new Size(this.Size.Width - 40, this.Size.Height - 92);
        }
    }
}
