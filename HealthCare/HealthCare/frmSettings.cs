using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI;
using Guna.UI.WinForms;
using SMDLogic;

namespace HealthCare
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        //clsOpnChild obj = new clsOpnChild();

        private void btnStngLogin_Click(object sender, EventArgs e)
        {
            lblSubSetings.Text = ((GunaAdvenceButton)sender).Text;
            //pbIcon.Image = Properties.Resources.password;
            SMDChildFormOpen.OpenWithActiveForm(new frmSettingsLogin(), pnlDctSettingsChild, Color.FromArgb(42, 49, 59));
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            lblSubSetings.Text = ((GunaAdvenceButton)sender).Text;
            //pbIcon.Image = Properties.Resources.account;
            SMDChildFormOpen.OpenWithActiveForm(new frmSettingsAccount(), pnlDctSettingsChild, Color.FromArgb(42, 49, 59));
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            lblSubSetings.Text = ((GunaAdvenceButton)sender).Text;
            //pbIcon.Image = Properties.Resources.ContactUs;
            //obj.openChild(new frmdct(), pnlDctSettingsChild);
            //SMDChildFormOpen.OpenWithActiveForm(new frmdct(), pnlDctSettingsChild, Color.FromArgb(42, 49, 59));
        }

        private void frmDctSettings_Load(object sender, EventArgs e)
        {
            //pbIcon.Image = Properties.Resources.password;
            SMDChildFormOpen.OpenWithActiveForm(new frmSettingsLogin(), pnlDctSettingsChild, Color.FromArgb(42, 49, 59));
        }
    }
}
