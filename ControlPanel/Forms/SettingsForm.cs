using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPanel.Forms
{
    public partial class SettingsForm : Form
    {
        ColorPaletteBase cpb = new ColorPaletteBase();
        public SettingsForm()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml(cpb.casterSugar);
        }
    }
}
