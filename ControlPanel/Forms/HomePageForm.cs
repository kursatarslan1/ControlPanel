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
    public partial class HomePageForm : Form
    {
        ColorPaletteBase cpb = new ColorPaletteBase();
        Dictionary<string, string> dict = new Dictionary<string, string>();
        public HomePageForm()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml(cpb.casterSugar);
            lblClock.ForeColor = ColorTranslator.FromHtml(cpb.cherryBomb);
            lblDate.ForeColor = ColorTranslator.FromHtml(cpb.foggyLondon);
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMMM yyyy", new System.Globalization.CultureInfo("tr-TR"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
