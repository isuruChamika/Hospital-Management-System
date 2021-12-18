namespace HealthCare
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.elips = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaPictureBox4 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            this.chkbxRememberMe = new Guna.UI.WinForms.GunaCheckBox();
            this.lnkLblForgotPw = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.drag1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.drag2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnShwPass = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShwPass)).BeginInit();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.ElipseRadius = 5;
            this.elips.TargetControl = this;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.pnlLeft.Controls.Add(this.gunaPictureBox4);
            this.pnlLeft.Controls.Add(this.gunaLabel1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.ShadowDecoration.Parent = this.pnlLeft;
            this.pnlLeft.Size = new System.Drawing.Size(543, 827);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeft_Paint);
            // 
            // gunaPictureBox4
            // 
            this.gunaPictureBox4.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox4.Image")));
            this.gunaPictureBox4.Location = new System.Drawing.Point(32, 405);
            this.gunaPictureBox4.Name = "gunaPictureBox4";
            this.gunaPictureBox4.Size = new System.Drawing.Size(478, 428);
            this.gunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox4.TabIndex = 1;
            this.gunaPictureBox4.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gunaLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.gunaLabel1.Location = new System.Drawing.Point(54, 186);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(435, 183);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = resources.GetString("gunaLabel1.Text");
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.btnShwPass);
            this.pnlRight.Controls.Add(this.chkbxRememberMe);
            this.pnlRight.Controls.Add(this.lnkLblForgotPw);
            this.pnlRight.Controls.Add(this.gunaPictureBox1);
            this.pnlRight.Controls.Add(this.gunaPictureBox2);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.gunaLabel3);
            this.pnlRight.Controls.Add(this.gunaLabel2);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.btnClose);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(543, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.ShadowDecoration.Parent = this.pnlRight;
            this.pnlRight.Size = new System.Drawing.Size(524, 827);
            this.pnlRight.TabIndex = 1;
            // 
            // chkbxRememberMe
            // 
            this.chkbxRememberMe.BaseColor = System.Drawing.Color.White;
            this.chkbxRememberMe.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkbxRememberMe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.chkbxRememberMe.FillColor = System.Drawing.Color.White;
            this.chkbxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxRememberMe.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.chkbxRememberMe.Location = new System.Drawing.Point(131, 647);
            this.chkbxRememberMe.Name = "chkbxRememberMe";
            this.chkbxRememberMe.Size = new System.Drawing.Size(136, 21);
            this.chkbxRememberMe.TabIndex = 10;
            this.chkbxRememberMe.Text = "Remember me";
            this.chkbxRememberMe.CheckedChanged += new System.EventHandler(this.chkbxRememberMe_CheckedChanged);
            // 
            // lnkLblForgotPw
            // 
            this.lnkLblForgotPw.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(191)))), ((int)(((byte)(184)))));
            this.lnkLblForgotPw.AutoSize = true;
            this.lnkLblForgotPw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkLblForgotPw.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(127)))), ((int)(((byte)(122)))));
            this.lnkLblForgotPw.Location = new System.Drawing.Point(297, 647);
            this.lnkLblForgotPw.Name = "lnkLblForgotPw";
            this.lnkLblForgotPw.Size = new System.Drawing.Size(139, 20);
            this.lnkLblForgotPw.TabIndex = 9;
            this.lnkLblForgotPw.TabStop = true;
            this.lnkLblForgotPw.Text = "Forgotten Password";
            this.lnkLblForgotPw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblForgotPw_LinkClicked);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(155, 144);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(241, 180);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 7;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(215, 310);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 8;
            this.gunaPictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.btnLogin.BorderRadius = 17;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(181, 699);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel3.Location = new System.Drawing.Point(134, 546);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(80, 23);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Password";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel2.Location = new System.Drawing.Point(134, 443);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(87, 23);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.Control;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.Location = new System.Drawing.Point(122, 580);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 18;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(323, 48);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.Control;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUsername.Location = new System.Drawing.Point(122, 477);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 18;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(323, 48);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.btnClose.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.btnClose.Location = new System.Drawing.Point(445, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(145)))), ((int)(((byte)(136)))));
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(79, 43);
            this.btnClose.TabIndex = 3;
            // 
            // drag1
            // 
            this.drag1.Fixed = true;
            this.drag1.Horizontal = true;
            this.drag1.TargetControl = this.pnlLeft;
            this.drag1.Vertical = true;
            // 
            // drag2
            // 
            this.drag2.Fixed = true;
            this.drag2.Horizontal = true;
            this.drag2.TargetControl = this.pnlRight;
            this.drag2.Vertical = true;
            // 
            // btnShwPass
            // 
            this.btnShwPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShwPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShwPass.BackgroundImage")));
            this.btnShwPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShwPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShwPass.Image")));
            this.btnShwPass.ImageActive = null;
            this.btnShwPass.Location = new System.Drawing.Point(448, 591);
            this.btnShwPass.Margin = new System.Windows.Forms.Padding(0);
            this.btnShwPass.Name = "btnShwPass";
            this.btnShwPass.Size = new System.Drawing.Size(26, 25);
            this.btnShwPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShwPass.TabIndex = 11;
            this.btnShwPass.TabStop = false;
            this.btnShwPass.Zoom = 20;
            this.btnShwPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShwPass_MouseDown);
            this.btnShwPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShwPass_MouseUp);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1067, 827);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShwPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elips;
        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Panel pnlRight;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Bunifu.Framework.UI.BunifuDragControl drag1;
        private Bunifu.Framework.UI.BunifuDragControl drag2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox4;
        private Guna.UI.WinForms.GunaLinkLabel lnkLblForgotPw;
        private Guna.UI.WinForms.GunaCheckBox chkbxRememberMe;
        private Bunifu.Framework.UI.BunifuImageButton btnShwPass;
    }
}

