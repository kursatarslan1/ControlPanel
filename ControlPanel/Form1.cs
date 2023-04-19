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
        private Button currentButton;
        private Form activeForm;
        ColorPaletteBase cpb = new ColorPaletteBase();

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

        private void SetColorTheme()
        {
            this.BackColor = ColorTranslator.FromHtml(cpb.casterSugar);
            pnlTitleBar.BackColor = ColorTranslator.FromHtml(cpb.cleanNCrisp);
            pnlLogo.BackColor = ColorTranslator.FromHtml(cpb.cleanNCrisp);
            pnlSideBar.BackColor = ColorTranslator.FromHtml(cpb.limeGranita);
            lblLogo.ForeColor = ColorTranslator.FromHtml(cpb.cherryBomb);
            lblDayIn.ForeColor = ColorTranslator.FromHtml(cpb.superSilver);
            lblDayOff.ForeColor = ColorTranslator.FromHtml(cpb.superSilver);
            lblOther.ForeColor = ColorTranslator.FromHtml(cpb.superSilver);
            lblTitle.ForeColor = ColorTranslator.FromHtml(cpb.cherryBomb);
        }
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,Width,Height,20, 20));
            SetColorTheme();
            
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
            {
                this.Region = null;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml(cpb.gnomeGreen);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = ColorTranslator.FromHtml(cpb.cherryBomb);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previosBtn in pnlSideBar.Controls)
            {
                if (previosBtn.GetType() == typeof(Button))
                {
                    previosBtn.BackColor = ColorTranslator.FromHtml(cpb.limeGranita);

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Add(childForm);
            this.pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHomePage.PerformClick();
            btnCloseChildForm.Visible = false;
        }

        
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.HomePageForm(), sender);
            btnCloseChildForm.Visible = false;
        }

        private void Reset()
        {
            DisableButton();
            currentButton = null;
            btnCloseChildForm.Visible = false;
            lblTitle.Text = "Ana Sayfa";
        }

        private void btnSellPage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.SellForm(), sender);
        }

        private void btnAddProductPage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.AddProductForm(), sender);
        }

        private void btnDeleteProductPage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.DeleteProductForm(), sender);
        }

        private void btnAccountingPage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.AccountingForm(), sender);
        }

        private void btnSettingsPage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.SettingsForm(), sender);
        }
    }
}
