namespace HealthCare
{
    partial class frmMessageQuestion
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
            Guna.UI.WinForms.GunaElipse Elips;
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageQuestion));
            this.DragCtrl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.pnlMessage = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.lblMessage = new Guna.UI.WinForms.GunaLabel();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblCaption = new Guna.UI.WinForms.GunaLabel();
            this.pnlDrag = new Guna.UI.WinForms.GunaElipsePanel();
            Elips = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.pnlDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elips
            // 
            Elips.Radius = 0;
            Elips.TargetControl = this;
            // 
            // DragCtrl
            // 
            this.DragCtrl.TargetControl = this.pnlDrag;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.gunaTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation2;
            // 
            // pnlMessage
            // 
            this.pnlMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMessage.BackColor = System.Drawing.Color.Transparent;
            this.pnlMessage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.pnlMessage.Controls.Add(this.btnNo);
            this.pnlMessage.Controls.Add(this.btnYes);
            this.pnlMessage.Controls.Add(this.lblMessage);
            this.pnlMessage.Controls.Add(this.pictureBox);
            this.gunaTransition1.SetDecoration(this.pnlMessage, Guna.UI.Animation.DecorationType.None);
            this.pnlMessage.Location = new System.Drawing.Point(12, 55);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Radius = 10;
            this.pnlMessage.Size = new System.Drawing.Size(576, 218);
            this.pnlMessage.TabIndex = 0;
            this.pnlMessage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMessage_Paint);
            // 
            // pictureBox
            // 
            this.pictureBox.BaseColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.pictureBox, Guna.UI.Animation.DecorationType.None);
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(14, 17);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(139, 137);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.lblMessage, Guna.UI.Animation.DecorationType.None);
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.lblMessage.Location = new System.Drawing.Point(173, 17);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(87, 24);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message";
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaTransition1.SetDecoration(this.btnYes, Guna.UI.Animation.DecorationType.None);
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYes.Location = new System.Drawing.Point(253, 142);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(138, 60);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.button1_Click);
            this.btnYes.MouseHover += new System.EventHandler(this.btnYes_MouseHover_1);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaTransition1.SetDecoration(this.btnNo, Guna.UI.Animation.DecorationType.None);
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(191)))), ((int)(((byte)(198)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNo.Location = new System.Drawing.Point(408, 142);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(138, 60);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.button2_Click);
            this.btnNo.MouseLeave += new System.EventHandler(this.btnNo_MouseLeave);
            this.btnNo.MouseHover += new System.EventHandler(this.btnNo_MouseHover);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTransition1.SetDecoration(this.gunaCirclePictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(13, 11);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(43, 29);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 1;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.lblCaption, Guna.UI.Animation.DecorationType.None);
            this.lblCaption.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.lblCaption.Location = new System.Drawing.Point(62, 10);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(94, 30);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "Caption";
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.Transparent;
            this.pnlDrag.BackgroundImage = global::HealthCare.Properties.Resources._0NxcDA1;
            this.pnlDrag.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlDrag.Controls.Add(this.lblCaption);
            this.pnlDrag.Controls.Add(this.gunaCirclePictureBox1);
            this.pnlDrag.Controls.Add(this.pnlMessage);
            this.gunaTransition1.SetDecoration(this.pnlDrag, Guna.UI.Animation.DecorationType.None);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Radius = 20;
            this.pnlDrag.Size = new System.Drawing.Size(600, 285);
            this.pnlDrag.TabIndex = 0;
            // 
            // frmMessageQuestion
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(600, 285);
            this.Controls.Add(this.pnlDrag);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMessageQuestion";
            this.Load += new System.EventHandler(this.frmMessageQuestion_Load);
            this.pnlMessage.ResumeLayout(false);
            this.pnlMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.pnlDrag.ResumeLayout(false);
            this.pnlDrag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl DragCtrl;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private System.Windows.Forms.Button btnYes;
        private Guna.UI.WinForms.GunaElipsePanel pnlDrag;
        private Guna.UI.WinForms.GunaLabel lblCaption;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaElipsePanel pnlMessage;
        private System.Windows.Forms.Button btnNo;
        private Guna.UI.WinForms.GunaLabel lblMessage;
        private Guna.UI.WinForms.GunaTransfarantPictureBox pictureBox;
    }
}