using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPanel
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,20, 20));
            ColorPaletteBase cpb = new ColorPaletteBase();
            this.BackColor = ColorTranslator.FromHtml(cpb.casterSugar);
            pnlTitleBar.BackColor = ColorTranslator.FromHtml(cpb.cleanNCrisp);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]                                          //
        private extern static void ReleaseCapture();                                                      //  This code block is written to assign the added panel 
                                                                                                          //  to act as a topbar and to be dragged with the form 
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]                                             //  has no borders.
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);     //

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();                                                                             //  Mouse movement is captured and location change is provided with response.
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}
