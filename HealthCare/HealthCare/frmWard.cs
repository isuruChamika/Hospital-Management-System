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
    public partial class frmWard : Form
    {
        public frmWard()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
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
            SMDChildFormOpen.Open(new frmWdDash(), pnlPhrChild, Color.FromArgb(42, 49, 59));
        }


        private void btnCmt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            btnDashboard.Checked = false;
            btnPatient.Checked = false;
            btnStaff.Checked = false;
            btnSettings.Checked = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmWdDash(), pnlPhrChild, Color.FromArgb(42, 49, 59));
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmDctInpatient(), pnlPhrChild, Color.FromArgb(42, 49, 59));
        }

        private void btnPchas_Click(object sender, EventArgs e)
        {
            this.btnStaff.Checked = true;
            SMDChildFormOpen.Open(new frmOfficer(), pnlPhrChild, Color.FromArgb(42, 49, 59));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
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
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (HSMessageBox.Show("ARE YOU SURE TO EXIT?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) != DialogResult.No)
            {
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void btnInpatient_Click(object sender, EventArgs e)
        {
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmWdRoom(), pnlPhrChild, Color.FromArgb(42, 49, 59));
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
