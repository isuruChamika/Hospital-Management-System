namespace HealthCare
{
    partial class frmAddOrganization
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
            this.elips = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlTheme = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.lblDate = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.lblSurname = new Guna.UI.WinForms.GunaLabel();
            this.lblBillNumberErr = new Guna.UI.WinForms.GunaLabel();
            this.lblOrgNameErr = new Guna.UI.WinForms.GunaLabel();
            this.lblOrgAddressErr = new Guna.UI.WinForms.GunaLabel();
            this.lblRegNameErr = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtBillingOfficer = new Guna.UI.WinForms.GunaTextBox();
            this.txtBillNumber = new Guna.UI.WinForms.GunaTextBox();
            this.txtOrganixationName = new Guna.UI.WinForms.GunaTextBox();
            this.txtOrgAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtRegisterName = new Guna.UI.WinForms.GunaTextBox();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.Animate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.pnlTheme.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.Radius = 0;
            this.elips.TargetControl = this;
            // 
            // pnlTheme
            // 
            this.pnlTheme.AutoScroll = true;
            this.pnlTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.pnlTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTheme.Controls.Add(this.gunaLabel18);
            this.pnlTheme.Controls.Add(this.gunaGroupBox1);
            this.pnlTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheme.Location = new System.Drawing.Point(0, 0);
            this.pnlTheme.Name = "pnlTheme";
            this.pnlTheme.Size = new System.Drawing.Size(611, 951);
            this.pnlTheme.TabIndex = 0;
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.gunaLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.gunaLabel18.Location = new System.Drawing.Point(30, 27);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(445, 67);
            this.gunaLabel18.TabIndex = 1;
            this.gunaLabel18.Text = "Add Organization";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btnCancel);
            this.gunaGroupBox1.Controls.Add(this.btnPSave);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox1.Controls.Add(this.lblTime);
            this.gunaGroupBox1.Controls.Add(this.lblDate);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel14);
            this.gunaGroupBox1.Controls.Add(this.lblSurname);
            this.gunaGroupBox1.Controls.Add(this.lblBillNumberErr);
            this.gunaGroupBox1.Controls.Add(this.lblOrgNameErr);
            this.gunaGroupBox1.Controls.Add(this.lblOrgAddressErr);
            this.gunaGroupBox1.Controls.Add(this.lblRegNameErr);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel10);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.txtBillingOfficer);
            this.gunaGroupBox1.Controls.Add(this.txtBillNumber);
            this.gunaGroupBox1.Controls.Add(this.txtOrganixationName);
            this.gunaGroupBox1.Controls.Add(this.txtOrgAddress);
            this.gunaGroupBox1.Controls.Add(this.txtRegisterName);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaGroupBox1.LineTop = 40;
            this.gunaGroupBox1.Location = new System.Drawing.Point(23, 184);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(545, 686);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Admit Organization Details";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCancel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancel.CheckedImage = null;
            this.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.Location = new System.Drawing.Point(133, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 22;
            this.btnCancel.Size = new System.Drawing.Size(183, 71);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPSave
            // 
            this.btnPSave.AnimationHoverSpeed = 0.07F;
            this.btnPSave.AnimationSpeed = 0.03F;
            this.btnPSave.BackColor = System.Drawing.Color.Transparent;
            this.btnPSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnPSave.BorderColor = System.Drawing.Color.Black;
            this.btnPSave.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPSave.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnPSave.CheckedImage = null;
            this.btnPSave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnPSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPSave.ForeColor = System.Drawing.Color.White;
            this.btnPSave.Image = null;
            this.btnPSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPSave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPSave.Location = new System.Drawing.Point(342, 548);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnPSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPSave.OnHoverImage = null;
            this.btnPSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnPSave.Radius = 22;
            this.btnPSave.Size = new System.Drawing.Size(183, 71);
            this.btnPSave.TabIndex = 12;
            this.btnPSave.Text = "Save";
            this.btnPSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click_1);
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel13.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel13.Location = new System.Drawing.Point(15, 428);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(53, 23);
            this.gunaLabel13.TabIndex = 7;
            this.gunaLabel13.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(395, 428);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 23);
            this.lblTime.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(74, 428);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 23);
            this.lblDate.TabIndex = 9;
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel14.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel14.Location = new System.Drawing.Point(334, 428);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(55, 23);
            this.gunaLabel14.TabIndex = 10;
            this.gunaLabel14.Text = "Time:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblSurname.Location = new System.Drawing.Point(532, 139);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(0, 20);
            this.lblSurname.TabIndex = 6;
            // 
            // lblBillNumberErr
            // 
            this.lblBillNumberErr.AutoSize = true;
            this.lblBillNumberErr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBillNumberErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblBillNumberErr.Location = new System.Drawing.Point(22, 350);
            this.lblBillNumberErr.Name = "lblBillNumberErr";
            this.lblBillNumberErr.Size = new System.Drawing.Size(0, 20);
            this.lblBillNumberErr.TabIndex = 6;
            // 
            // lblOrgNameErr
            // 
            this.lblOrgNameErr.AutoSize = true;
            this.lblOrgNameErr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrgNameErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblOrgNameErr.Location = new System.Drawing.Point(276, 140);
            this.lblOrgNameErr.Name = "lblOrgNameErr";
            this.lblOrgNameErr.Size = new System.Drawing.Size(0, 20);
            this.lblOrgNameErr.TabIndex = 6;
            // 
            // lblOrgAddressErr
            // 
            this.lblOrgAddressErr.AutoSize = true;
            this.lblOrgAddressErr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrgAddressErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblOrgAddressErr.Location = new System.Drawing.Point(19, 251);
            this.lblOrgAddressErr.Name = "lblOrgAddressErr";
            this.lblOrgAddressErr.Size = new System.Drawing.Size(0, 20);
            this.lblOrgAddressErr.TabIndex = 6;
            // 
            // lblRegNameErr
            // 
            this.lblRegNameErr.AutoSize = true;
            this.lblRegNameErr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegNameErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblRegNameErr.Location = new System.Drawing.Point(19, 140);
            this.lblRegNameErr.Name = "lblRegNameErr";
            this.lblRegNameErr.Size = new System.Drawing.Size(0, 20);
            this.lblRegNameErr.TabIndex = 6;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel10.Location = new System.Drawing.Point(269, 281);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(146, 23);
            this.gunaLabel10.TabIndex = 1;
            this.gunaLabel10.Text = "Billing Officer ID";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel6.Location = new System.Drawing.Point(15, 281);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(107, 23);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Bill Number";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(269, 71);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(166, 23);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Organization Name";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel4.Location = new System.Drawing.Point(15, 182);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(183, 23);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Organization Address";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel1.Location = new System.Drawing.Point(15, 71);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(128, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Register Name";
            // 
            // txtBillingOfficer
            // 
            this.txtBillingOfficer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.txtBillingOfficer.BorderColor = System.Drawing.Color.Silver;
            this.txtBillingOfficer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillingOfficer.Enabled = false;
            this.txtBillingOfficer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBillingOfficer.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtBillingOfficer.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBillingOfficer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBillingOfficer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBillingOfficer.Location = new System.Drawing.Point(273, 307);
            this.txtBillingOfficer.Name = "txtBillingOfficer";
            this.txtBillingOfficer.PasswordChar = '\0';
            this.txtBillingOfficer.SelectedText = "";
            this.txtBillingOfficer.Size = new System.Drawing.Size(237, 39);
            this.txtBillingOfficer.TabIndex = 0;
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.txtBillNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtBillNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBillNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtBillNumber.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBillNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBillNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBillNumber.Location = new System.Drawing.Point(19, 307);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.PasswordChar = '\0';
            this.txtBillNumber.SelectedText = "";
            this.txtBillNumber.Size = new System.Drawing.Size(237, 39);
            this.txtBillNumber.TabIndex = 0;
            this.txtBillNumber.TextChanged += new System.EventHandler(this.txtBillNumber_TextChanged);
            // 
            // txtOrganixationName
            // 
            this.txtOrganixationName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.txtOrganixationName.BorderColor = System.Drawing.Color.Silver;
            this.txtOrganixationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrganixationName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOrganixationName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtOrganixationName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtOrganixationName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOrganixationName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtOrganixationName.Location = new System.Drawing.Point(273, 97);
            this.txtOrganixationName.Name = "txtOrganixationName";
            this.txtOrganixationName.PasswordChar = '\0';
            this.txtOrganixationName.SelectedText = "";
            this.txtOrganixationName.Size = new System.Drawing.Size(237, 39);
            this.txtOrganixationName.TabIndex = 0;
            this.txtOrganixationName.TextChanged += new System.EventHandler(this.txtMiddleName_TextChanged);
            // 
            // txtOrgAddress
            // 
            this.txtOrgAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.txtOrgAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtOrgAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrgAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOrgAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtOrgAddress.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtOrgAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOrgAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtOrgAddress.Location = new System.Drawing.Point(19, 208);
            this.txtOrgAddress.Name = "txtOrgAddress";
            this.txtOrgAddress.PasswordChar = '\0';
            this.txtOrgAddress.SelectedText = "";
            this.txtOrgAddress.Size = new System.Drawing.Size(491, 39);
            this.txtOrgAddress.TabIndex = 0;
            this.txtOrgAddress.TextChanged += new System.EventHandler(this.txtOrgAddress_TextChanged);
            // 
            // txtRegisterName
            // 
            this.txtRegisterName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.txtRegisterName.BorderColor = System.Drawing.Color.Silver;
            this.txtRegisterName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegisterName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRegisterName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtRegisterName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRegisterName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegisterName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRegisterName.Location = new System.Drawing.Point(19, 97);
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.PasswordChar = '\0';
            this.txtRegisterName.SelectedText = "";
            this.txtRegisterName.Size = new System.Drawing.Size(237, 39);
            this.txtRegisterName.TabIndex = 0;
            this.txtRegisterName.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // Animate
            // 
            this.Animate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.Animate.Interval = 800;
            this.Animate.TargetControl = this;
            // 
            // frmAddOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(611, 951);
            this.Controls.Add(this.pnlTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddOrganization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmADAddmitPatient";
            this.Load += new System.EventHandler(this.frmADAddmitPatient_Load);
            this.pnlTheme.ResumeLayout(false);
            this.pnlTheme.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elips;
        private Guna.UI.WinForms.GunaPanel pnlTheme;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtOrganixationName;
        private Guna.UI.WinForms.GunaTextBox txtRegisterName;
        private System.Windows.Forms.Timer tmrDateTime;
        private Guna.UI.WinForms.GunaLabel lblSurname;
        private Guna.UI.WinForms.GunaLabel lblOrgNameErr;
        private Guna.UI.WinForms.GunaLabel lblRegNameErr;
        private Guna.UI.WinForms.GunaAnimateWindow Animate;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaLabel lblBillNumberErr;
        private Guna.UI.WinForms.GunaLabel lblOrgAddressErr;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtBillingOfficer;
        private Guna.UI.WinForms.GunaTextBox txtBillNumber;
        private Guna.UI.WinForms.GunaTextBox txtOrgAddress;
        private Guna.UI.WinForms.GunaAdvenceButton btnCancel;
        private Guna.UI.WinForms.GunaAdvenceButton btnPSave;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private Guna.UI.WinForms.GunaLabel lblDate;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
    }
}