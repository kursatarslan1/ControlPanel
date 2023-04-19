namespace ControlPanel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMid = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOther = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDayOff = new System.Windows.Forms.Label();
            this.pnlDayIn = new System.Windows.Forms.Panel();
            this.lblDayIn = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnSettingsPage = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAccountingPage = new System.Windows.Forms.Button();
            this.btnDeleteProductPage = new System.Windows.Forms.Button();
            this.btnAddProductPage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSellPage = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMid.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDayIn.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.pnlBody);
            this.pnlMid.Controls.Add(this.pnlTitleBar);
            this.pnlMid.Controls.Add(this.pnlSideBar);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(0, 0);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(1531, 859);
            this.pnlMid.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(241, 96);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1290, 763);
            this.pnlBody.TabIndex = 3;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnCloseChildForm);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(241, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1290, 96);
            this.pnlTitleBar.TabIndex = 2;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(564, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Ana Sayfa";
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(103, 96);
            this.btnCloseChildForm.TabIndex = 0;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Crimson;
            this.btnMinimize.Location = new System.Drawing.Point(1160, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 96);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnMaximize.Location = new System.Drawing.Point(1203, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(39, 96);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "o";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1242, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 96);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Controls.Add(this.btnSettingsPage);
            this.pnlSideBar.Controls.Add(this.panel2);
            this.pnlSideBar.Controls.Add(this.btnAccountingPage);
            this.pnlSideBar.Controls.Add(this.btnDeleteProductPage);
            this.pnlSideBar.Controls.Add(this.btnAddProductPage);
            this.pnlSideBar.Controls.Add(this.panel1);
            this.pnlSideBar.Controls.Add(this.btnSellPage);
            this.pnlSideBar.Controls.Add(this.btnHomePage);
            this.pnlSideBar.Controls.Add(this.pnlDayIn);
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(241, 859);
            this.pnlSideBar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblOther);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 72);
            this.panel2.TabIndex = 10;
            // 
            // lblOther
            // 
            this.lblOther.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(66, 18);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(58, 25);
            this.lblOther.TabIndex = 3;
            this.lblOther.Text = "Diğer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblDayOff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 72);
            this.panel1.TabIndex = 6;
            // 
            // lblDayOff
            // 
            this.lblDayOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDayOff.AutoSize = true;
            this.lblDayOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayOff.Location = new System.Drawing.Point(66, 18);
            this.lblDayOff.Name = "lblDayOff";
            this.lblDayOff.Size = new System.Drawing.Size(86, 25);
            this.lblDayOff.TabIndex = 3;
            this.lblDayOff.Text = "Gün Dışı";
            // 
            // pnlDayIn
            // 
            this.pnlDayIn.Controls.Add(this.pictureBox1);
            this.pnlDayIn.Controls.Add(this.lblDayIn);
            this.pnlDayIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDayIn.Location = new System.Drawing.Point(0, 96);
            this.pnlDayIn.Name = "pnlDayIn";
            this.pnlDayIn.Size = new System.Drawing.Size(241, 72);
            this.pnlDayIn.TabIndex = 3;
            // 
            // lblDayIn
            // 
            this.lblDayIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDayIn.AutoSize = true;
            this.lblDayIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayIn.Location = new System.Drawing.Point(66, 18);
            this.lblDayIn.Name = "lblDayIn";
            this.lblDayIn.Size = new System.Drawing.Size(73, 25);
            this.lblDayIn.TabIndex = 3;
            this.lblDayIn.Text = "Gün İçi";
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(241, 96);
            this.pnlLogo.TabIndex = 3;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(42, 34);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(121, 29);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "FOODIES";
            // 
            // btnSettingsPage
            // 
            this.btnSettingsPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettingsPage.FlatAppearance.BorderSize = 0;
            this.btnSettingsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnSettingsPage.Image = global::ControlPanel.Properties.Resources.icons8_settings_20;
            this.btnSettingsPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsPage.Location = new System.Drawing.Point(0, 691);
            this.btnSettingsPage.Name = "btnSettingsPage";
            this.btnSettingsPage.Size = new System.Drawing.Size(241, 76);
            this.btnSettingsPage.TabIndex = 11;
            this.btnSettingsPage.Text = "   Ayarlar";
            this.btnSettingsPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettingsPage.UseVisualStyleBackColor = true;
            this.btnSettingsPage.Click += new System.EventHandler(this.btnSettingsPage_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ControlPanel.Properties.Resources.icons8_view_more_50;
            this.pictureBox3.Location = new System.Drawing.Point(20, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnAccountingPage
            // 
            this.btnAccountingPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountingPage.FlatAppearance.BorderSize = 0;
            this.btnAccountingPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountingPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountingPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnAccountingPage.Image = global::ControlPanel.Properties.Resources.icons8_accounting_20;
            this.btnAccountingPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountingPage.Location = new System.Drawing.Point(0, 544);
            this.btnAccountingPage.Name = "btnAccountingPage";
            this.btnAccountingPage.Size = new System.Drawing.Size(241, 75);
            this.btnAccountingPage.TabIndex = 9;
            this.btnAccountingPage.Text = "   Muhasebe";
            this.btnAccountingPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountingPage.UseVisualStyleBackColor = true;
            this.btnAccountingPage.Click += new System.EventHandler(this.btnAccountingPage_Click);
            // 
            // btnDeleteProductPage
            // 
            this.btnDeleteProductPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteProductPage.FlatAppearance.BorderSize = 0;
            this.btnDeleteProductPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProductPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProductPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnDeleteProductPage.Image = global::ControlPanel.Properties.Resources.icons8_delete_20;
            this.btnDeleteProductPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProductPage.Location = new System.Drawing.Point(0, 468);
            this.btnDeleteProductPage.Name = "btnDeleteProductPage";
            this.btnDeleteProductPage.Size = new System.Drawing.Size(241, 76);
            this.btnDeleteProductPage.TabIndex = 8;
            this.btnDeleteProductPage.Text = "   Ürün Sil";
            this.btnDeleteProductPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteProductPage.UseVisualStyleBackColor = true;
            this.btnDeleteProductPage.Click += new System.EventHandler(this.btnDeleteProductPage_Click);
            // 
            // btnAddProductPage
            // 
            this.btnAddProductPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProductPage.FlatAppearance.BorderSize = 0;
            this.btnAddProductPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnAddProductPage.Image = global::ControlPanel.Properties.Resources.icons8_add_20;
            this.btnAddProductPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProductPage.Location = new System.Drawing.Point(0, 393);
            this.btnAddProductPage.Name = "btnAddProductPage";
            this.btnAddProductPage.Size = new System.Drawing.Size(241, 75);
            this.btnAddProductPage.TabIndex = 7;
            this.btnAddProductPage.Text = "   Ürün Ekle";
            this.btnAddProductPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProductPage.UseVisualStyleBackColor = true;
            this.btnAddProductPage.Click += new System.EventHandler(this.btnAddProductPage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ControlPanel.Properties.Resources.icons8_day_off_80;
            this.pictureBox2.Location = new System.Drawing.Point(20, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnSellPage
            // 
            this.btnSellPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSellPage.FlatAppearance.BorderSize = 0;
            this.btnSellPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnSellPage.Image = global::ControlPanel.Properties.Resources.icons8_sell_20;
            this.btnSellPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellPage.Location = new System.Drawing.Point(0, 244);
            this.btnSellPage.Name = "btnSellPage";
            this.btnSellPage.Size = new System.Drawing.Size(241, 77);
            this.btnSellPage.TabIndex = 4;
            this.btnSellPage.Text = "   Satış Yap";
            this.btnSellPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSellPage.UseVisualStyleBackColor = true;
            this.btnSellPage.Click += new System.EventHandler(this.btnSellPage_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnHomePage.Image = global::ControlPanel.Properties.Resources.icons8_home_20;
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.Location = new System.Drawing.Point(0, 168);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(241, 76);
            this.btnHomePage.TabIndex = 3;
            this.btnHomePage.Text = "   Ana Sayfa";
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ControlPanel.Properties.Resources.sun_icon;
            this.pictureBox1.Location = new System.Drawing.Point(20, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 859);
            this.Controls.Add(this.pnlMid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foodies ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMid.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlSideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDayIn.ResumeLayout(false);
            this.pnlDayIn.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlDayIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDayIn;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnSettingsPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Button btnAccountingPage;
        private System.Windows.Forms.Button btnDeleteProductPage;
        private System.Windows.Forms.Button btnAddProductPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDayOff;
        private System.Windows.Forms.Button btnSellPage;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
    }
}

