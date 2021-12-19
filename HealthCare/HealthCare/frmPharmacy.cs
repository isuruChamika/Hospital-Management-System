using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDLogic;

namespace HealthCare
{
    public partial class frmPharmacy : Form
    {
        public frmPharmacy()
        {
            InitializeComponent();

            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            //phrAnimate.Start();
            pnlCmSubBtn.Visible = false;
            
        }

        private const int CS_Dropshadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_Dropshadow;
                return cp;
            }
        }

        private void frmPharmacy_Load(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            ////phrAnimate.Start();
            SMDChildFormOpen.Open(new frmPhrDash(), pnlPhrChild, Color.FromArgb(42, 49, 59));
        }

        private void subPnlClose()
        {
            if (pnlCmSubBtn.Visible == true)
            {
                pnlCmSubBtn.Visible = false;
                btnSupp.Checked = false;
                btnCus.Checked = false;
                btnOfficer.Checked = false;
            }
        }

        private void btnCmt_Click(object sender, EventArgs e)
        {
            btnCmt.Checked = false;
            if (pnlCmSubBtn.Visible != true)
            {
                btnDashboard.Checked = false;
                btnMed.Checked = false;
                pnlCmSubBtn.Visible = true;
            }
            else
            {
                pnlCmSubBtn.Visible = false;
                btnSupp.Checked = false;
                btnCus.Checked = false;
            }    
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnMed.Checked = false;
            btnOfficer.Checked = false;
            btnSettings.Checked = false;
            SMDChildFormOpen.Open(new frmPhrSplr(), pnlPhrChild, Color.FromArgb(42, 49, 59)); ;

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnMed.Checked = false;
            btnOfficer.Checked = false;
            btnSettings.Checked = false;
            SMDChildFormOpen.Open(new frmPhrCstmr(), pnlPhrChild, Color.FromArgb(42, 49, 59));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            subPnlClose();
            SMDChildFormOpen.Open(new frmPhrDash(), pnlPhrChild, Color.FromArgb(42, 49, 59));
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmPhrMdcn(), pnlPhrChild, Color.FromArgb(42, 49, 59));
            subPnlClose();
        }

        private void btnPchas_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmOfficer(), pnlPhrChild, Color.FromArgb(42, 49, 59));
            subPnlClose();
            this.btnOfficer.Checked = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            subPnlClose();
            SMDChildFormOpen.Open(new frmSettings(), pnlPhrChild, Color.FromArgb(42, 49, 59));
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (HSMessageBox.Show("ARE YOU SURE TO EXIT ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Error) != DialogResult.No)
            {
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            if (HSMessageBox.Show("ARE YOU SURE TO EXIT?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Error) != DialogResult.No)
            {
                this.Hide();
                new frmLogin().Show();
            }
        }
    }
}
