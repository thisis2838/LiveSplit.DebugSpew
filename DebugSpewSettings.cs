using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.DebugSpew
{
    public partial class DebugSpewSettings : UserControl
    {
        public DebugSpewSettings()
        {
            InitializeComponent();
        }

        private void butOpenView_Click(object sender, EventArgs e)
        {
            DebugSpewComponent.SpewWindow.Show();
        }
    }
}
