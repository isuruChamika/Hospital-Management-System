namespace HealthCare
{
    partial class frmLaboratory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratory));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlPhr = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlPhrChild = new Guna.UI.WinForms.GunaElipsePanel();
            this.pnlPhrLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCmm = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSubbtn = new Guna.UI.WinForms.GunaPanel();
            this.pnlPhrLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.btnMaximize = new Guna.UI.WinForms.GunaControlBox();
            this.dragPhr = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnSettings = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnStaf = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnOutpatient = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnInpatient = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSample = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDashboard = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnlPhr.SuspendLayout();
            this.pnlPhrLeft.SuspendLayout();
            this.pnlCmm.SuspendLayout();
            this.pnlSubbtn.SuspendLayout();
            this.pnlPhrLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlPhr
            // 
            this.pnlPhr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlPhr.BackgroundImage = global::HealthCare.Properties.Resources._0NxcDA1;
            this.pnlPhr.Controls.Add(this.pnlPhrChild);
            this.pnlPhr.Controls.Add(this.pnlPhrLeft);
            this.pnlPhr.Controls.Add(this.btnMinimize);
            this.pnlPhr.Controls.Add(this.btnClose);
            this.pnlPhr.Controls.Add(this.btnMaximize);
            this.pnlPhr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhr.Location = new System.Drawing.Point(0, 0);
            this.pnlPhr.Name = "pnlPhr";
            this.pnlPhr.ShadowDecoration.Parent = this.pnlPhr;
            this.pnlPhr.Size = new System.Drawing.Size(1509, 887);
            this.pnlPhr.TabIndex = 0;
            // 
            // pnlPhrChild
            // 
            this.pnlPhrChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPhrChild.BackColor = System.Drawing.Color.Transparent;
            this.pnlPhrChild.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.pnlPhrChild.Location = new System.Drawing.Point(321, 48);
            this.pnlPhrChild.Name = "pnlPhrChild";
            this.pnlPhrChild.Size = new System.Drawing.Size(1176, 827);
            this.pnlPhrChild.TabIndex = 6;
            // 
            // pnlPhrLeft
            // 
            this.pnlPhrLeft.BackgroundImage = global::HealthCare.Properties.Resources._0NxcDA1;
            this.pnlPhrLeft.Controls.Add(this.btnLogout);
            this.pnlPhrLeft.Controls.Add(this.pnlCmm);
            this.pnlPhrLeft.Controls.Add(this.pnlPhrLogo);
            this.pnlPhrLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPhrLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlPhrLeft.Name = "pnlPhrLeft";
            this.pnlPhrLeft.ShadowDecoration.Parent = this.pnlPhrLeft;
            this.pnlPhrLeft.Size = new System.Drawing.Size(322, 887);
            this.pnlPhrLeft.TabIndex = 5;
            // 
            // pnlCmm
            // 
            this.pnlCmm.BackColor = System.Drawing.Color.Transparent;
            this.pnlCmm.Controls.Add(this.btnSettings);
            this.pnlCmm.Controls.Add(this.btnStaf);
            this.pnlCmm.Controls.Add(this.pnlSubbtn);
            this.pnlCmm.Controls.Add(this.btnSample);
            this.pnlCmm.Controls.Add(this.btnDashboard);
            this.pnlCmm.Location = new System.Drawing.Point(46, 284);
            this.pnlCmm.Name = "pnlCmm";
            this.pnlCmm.ShadowDecoration.Parent = this.pnlCmm;
            this.pnlCmm.Size = new System.Drawing.Size(258, 486);
            this.pnlCmm.TabIndex = 4;
            // 
            // pnlSubbtn
            // 
            this.pnlSubbtn.Controls.Add(this.btnOutpatient);
            this.pnlSubbtn.Controls.Add(this.btnInpatient);
            this.pnlSubbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubbtn.Location = new System.Drawing.Point(0, 122);
            this.pnlSubbtn.Name = "pnlSubbtn";
            this.pnlSubbtn.Size = new System.Drawing.Size(258, 132);
            this.pnlSubbtn.TabIndex = 8;
            this.pnlSubbtn.Visible = false;
            // 
            // pnlPhrLogo
            // 
            this.pnlPhrLogo.BackgroundImage = global::HealthCare.Properties.Resources._0NxcDA1;
            this.pnlPhrLogo.Controls.Add(this.guna2PictureBox1);
            this.pnlPhrLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPhrLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlPhrLogo.Name = "pnlPhrLogo";
            this.pnlPhrLogo.ShadowDecoration.Parent = this.pnlPhrLogo;
            this.pnlPhrLogo.Size = new System.Drawing.Size(322, 256);
            this.pnlPhrLogo.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconSize = 15F;
            this.btnMinimize.Location = new System.Drawing.Point(1324, -1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.btnMinimize.OnHoverIconColor = System.Drawing.Color.Black;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMinimize.Size = new System.Drawing.Size(54, 43);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(1431, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnClose.Size = new System.Drawing.Size(79, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.AnimationHoverSpeed = 0.07F;
            this.btnMaximize.AnimationSpeed = 0.03F;
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconSize = 15F;
            this.btnMaximize.Location = new System.Drawing.Point(1375, -1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(203)))));
            this.btnMaximize.OnHoverIconColor = System.Drawing.Color.Black;
            this.btnMaximize.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnMaximize.Size = new System.Drawing.Size(59, 43);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // dragPhr
            // 
            this.dragPhr.Fixed = true;
            this.dragPhr.Horizontal = true;
            this.dragPhr.TargetControl = this.pnlPhr;
            this.dragPhr.Vertical = true;
            // 
            // btnSettings
            // 
            this.btnSettings.AnimationHoverSpeed = 0.07F;
            this.btnSettings.AnimationSpeed = 0.03F;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BaseColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnSettings.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSettings.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSettings.CheckedForeColor = System.Drawing.Color.White;
            this.btnSettings.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.CheckedImage")));
            this.btnSettings.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FocusedColor = System.Drawing.Color.Empty;
            this.btnSettings.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSettings.LineColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(0, 315);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnSettings.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnSettings.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSettings.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.OnHoverImage")));
            this.btnSettings.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnSettings.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnSettings.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnSettings.Radius = 23;
            this.btnSettings.Size = new System.Drawing.Size(258, 61);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStaf
            // 
            this.btnStaf.AnimationHoverSpeed = 0.07F;
            this.btnStaf.AnimationSpeed = 0.03F;
            this.btnStaf.BackColor = System.Drawing.Color.Transparent;
            this.btnStaf.BaseColor = System.Drawing.Color.Transparent;
            this.btnStaf.BorderColor = System.Drawing.Color.Transparent;
            this.btnStaf.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnStaf.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnStaf.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnStaf.CheckedForeColor = System.Drawing.Color.White;
            this.btnStaf.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnStaf.CheckedImage")));
            this.btnStaf.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnStaf.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStaf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaf.FocusedColor = System.Drawing.Color.Empty;
            this.btnStaf.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnStaf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnStaf.Image = ((System.Drawing.Image)(resources.GetObject("btnStaf.Image")));
            this.btnStaf.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStaf.LineColor = System.Drawing.Color.Transparent;
            this.btnStaf.Location = new System.Drawing.Point(0, 254);
            this.btnStaf.Name = "btnStaf";
            this.btnStaf.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnStaf.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnStaf.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStaf.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnStaf.OnHoverImage")));
            this.btnStaf.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnStaf.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnStaf.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnStaf.Radius = 23;
            this.btnStaf.Size = new System.Drawing.Size(258, 61);
            this.btnStaf.TabIndex = 6;
            this.btnStaf.Text = "Staff";
            this.btnStaf.Click += new System.EventHandler(this.btnStaf_Click);
            // 
            // btnOutpatient
            // 
            this.btnOutpatient.AnimationHoverSpeed = 0.07F;
            this.btnOutpatient.AnimationSpeed = 0.03F;
            this.btnOutpatient.BackColor = System.Drawing.Color.Transparent;
            this.btnOutpatient.BaseColor = System.Drawing.Color.Transparent;
            this.btnOutpatient.BorderColor = System.Drawing.Color.Transparent;
            this.btnOutpatient.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnOutpatient.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnOutpatient.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnOutpatient.CheckedForeColor = System.Drawing.Color.White;
            this.btnOutpatient.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnOutpatient.CheckedImage")));
            this.btnOutpatient.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnOutpatient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOutpatient.FocusedColor = System.Drawing.Color.Empty;
            this.btnOutpatient.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnOutpatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnOutpatient.Image = ((System.Drawing.Image)(resources.GetObject("btnOutpatient.Image")));
            this.btnOutpatient.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOutpatient.LineColor = System.Drawing.Color.Transparent;
            this.btnOutpatient.Location = new System.Drawing.Point(37, 67);
            this.btnOutpatient.Name = "btnOutpatient";
            this.btnOutpatient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnOutpatient.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnOutpatient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOutpatient.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnOutpatient.OnHoverImage")));
            this.btnOutpatient.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnOutpatient.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnOutpatient.Radius = 22;
            this.btnOutpatient.Size = new System.Drawing.Size(221, 61);
            this.btnOutpatient.TabIndex = 5;
            this.btnOutpatient.Text = "Out Patient";
            this.btnOutpatient.Click += new System.EventHandler(this.btnOutpatient_Click);
            // 
            // btnInpatient
            // 
            this.btnInpatient.AnimationHoverSpeed = 0.07F;
            this.btnInpatient.AnimationSpeed = 0.03F;
            this.btnInpatient.BackColor = System.Drawing.Color.Transparent;
            this.btnInpatient.BaseColor = System.Drawing.Color.Transparent;
            this.btnInpatient.BorderColor = System.Drawing.Color.Transparent;
            this.btnInpatient.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnInpatient.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnInpatient.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnInpatient.CheckedForeColor = System.Drawing.Color.White;
            this.btnInpatient.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnInpatient.CheckedImage")));
            this.btnInpatient.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnInpatient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInpatient.FocusedColor = System.Drawing.Color.Empty;
            this.btnInpatient.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnInpatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnInpatient.Image = ((System.Drawing.Image)(resources.GetObject("btnInpatient.Image")));
            this.btnInpatient.ImageSize = new System.Drawing.Size(25, 25);
            this.btnInpatient.LineColor = System.Drawing.Color.Transparent;
            this.btnInpatient.Location = new System.Drawing.Point(37, 0);
            this.btnInpatient.Name = "btnInpatient";
            this.btnInpatient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnInpatient.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnInpatient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInpatient.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnInpatient.OnHoverImage")));
            this.btnInpatient.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnInpatient.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnInpatient.Radius = 22;
            this.btnInpatient.Size = new System.Drawing.Size(221, 61);
            this.btnInpatient.TabIndex = 4;
            this.btnInpatient.Text = "In Patient";
            this.btnInpatient.Click += new System.EventHandler(this.btnInpatient_Click);
            // 
            // btnSample
            // 
            this.btnSample.AnimationHoverSpeed = 0.07F;
            this.btnSample.AnimationSpeed = 0.03F;
            this.btnSample.BackColor = System.Drawing.Color.Transparent;
            this.btnSample.BaseColor = System.Drawing.Color.Transparent;
            this.btnSample.BorderColor = System.Drawing.Color.Transparent;
            this.btnSample.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnSample.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSample.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSample.CheckedForeColor = System.Drawing.Color.White;
            this.btnSample.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSample.CheckedImage")));
            this.btnSample.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSample.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSample.FocusedColor = System.Drawing.Color.Empty;
            this.btnSample.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnSample.Image = ((System.Drawing.Image)(resources.GetObject("btnSample.Image")));
            this.btnSample.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSample.LineColor = System.Drawing.Color.Transparent;
            this.btnSample.Location = new System.Drawing.Point(0, 61);
            this.btnSample.Name = "btnSample";
            this.btnSample.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnSample.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnSample.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSample.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnSample.OnHoverImage")));
            this.btnSample.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnSample.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnSample.Radius = 22;
            this.btnSample.Size = new System.Drawing.Size(258, 61);
            this.btnSample.TabIndex = 3;
            this.btnSample.Text = "Samples";
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BaseColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnDashboard.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.CheckedImage")));
            this.btnDashboard.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.LineColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.OnHoverImage")));
            this.btnDashboard.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(81)))));
            this.btnDashboard.Radius = 22;
            this.btnDashboard.Size = new System.Drawing.Size(258, 61);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(292, 188);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnLogout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.CheckedImage")));
            this.btnLogout.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(23, 23);
            this.btnLogout.LineColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(65, 767);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnLogout.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.OnHoverImage")));
            this.btnLogout.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnLogout.Size = new System.Drawing.Size(205, 70);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // frmLaboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 887);
            this.Controls.Add(this.pnlPhr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLaboratory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPharmacy";
            this.Load += new System.EventHandler(this.frmPharmacy_Load);
            this.pnlPhr.ResumeLayout(false);
            this.pnlPhrLeft.ResumeLayout(false);
            this.pnlCmm.ResumeLayout(false);
            this.pnlSubbtn.ResumeLayout(false);
            this.pnlPhrLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlPhr;
        private Guna.UI.WinForms.GunaControlBox btnMinimize;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaControlBox btnMaximize;
        private Guna.UI2.WinForms.Guna2Panel pnlPhrLeft;
        private Guna.UI2.WinForms.Guna2Panel pnlPhrLogo;
        private Guna.UI.WinForms.GunaElipsePanel pnlPhrChild;
        private Guna.UI.WinForms.GunaAdvenceButton btnSample;
        private Guna.UI.WinForms.GunaAdvenceButton btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel pnlCmm;
        private Guna.UI.WinForms.GunaAdvenceButton btnSettings;
        private Guna.UI.WinForms.GunaAdvenceButton btnStaf;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl dragPhr;
        private Guna.UI.WinForms.GunaPanel pnlSubbtn;
        private Guna.UI.WinForms.GunaAdvenceButton btnOutpatient;
        private Guna.UI.WinForms.GunaAdvenceButton btnInpatient;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
    }
}