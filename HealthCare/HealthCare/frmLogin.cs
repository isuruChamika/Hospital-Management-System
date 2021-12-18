using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDMessageBox;

namespace HealthCare
{
    public partial class frmLogin : Form
    {
        public static string passingRoll, passingRollName;
        public frmLogin()
        {
            InitializeComponent();
            LoadCredentials();
        }

        void LoadCredentials()
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkbxRememberMe.Checked = true;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            LoadCredentials();
        }
        private void rememberMe()
        {
            if (chkbxRememberMe.Checked == false)
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
            else if (chkbxRememberMe.Checked == true)
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkLblForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmForgetPassword().Show();
        }

        private void chkbxRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnShwPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnShwPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void rememberMe()
        //{
        //    if (chkbxRememberMe.Checked == false)
        //    {
        //        Properties.Settings.Default.Username = "";
        //        Properties.Settings.Default.Password = "";
        //        Properties.Settings.Default.Save();
        //    }
        //    else if (chkbxRememberMe.Checked == true)
        //    {
        //        Properties.Settings.Default.Username = txtUsername.Text;
        //        Properties.Settings.Default.Password = txtPassword.Text;
        //        Properties.Settings.Default.Save();
        //    }
        //}

        //void LoadCredentials()
        //{
        //    if (Properties.Settings.Default.Username != string.Empty)
        //    {
        //        txtUsername.Text = Properties.Settings.Default.Username;
        //        txtPassword.Text = Properties.Settings.Default.Password;
        //        chkbxRememberMe.Checked = true;
        //    }
        //}

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string a = SQLConnectionManager.ReadValue("SELECT * FROM ACCOUNT WHERE Login_Username = '" + txtUsername.Text + "' AND Login_Password = '" + txtPassword.Text + "' ");

            switch (a)
            {
                case "DOCTOR":
                    //rememberMe();
                    this.Hide();
                    passingRoll = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 1);
                    passingRollName = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 2);
                    new frmDctMain().Show();
                    if (txtPassword.Text == "RUBERU1212" || txtPassword.Text == "LOSALA45DO" || txtPassword.Text == "HARENDRAQ1" || txtPassword.Text == "SANJAYA123" || txtPassword.Text == "WARUNA2312")
                    {
                        new HealthCare.frmTranceparentBG(new frmChangePassword());
                    }


                    break;
                case "CHANNELING_OFFICER":
                    //rememberMe();
                    this.Hide();
                    passingRoll = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 1);
                    passingRollName = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 2);
                    new frmChanlingOfficer().Show();
                    if (txtPassword.Text == "SARANGA123" || txtPassword.Text == "THUSHDASA1" || txtPassword.Text == "RANGIPRIYA" || txtPassword.Text == "SANJU12341" || txtPassword.Text == "123NILANTH")
                    {
                        new HealthCare.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "ADMISSION_OFFICER":
                    //rememberMe();
                    this.Hide();
                    passingRoll = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 1);
                    passingRollName = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 2);
                    new frmAddmitionOfficer().Show();
                    if (txtPassword.Text == "123@HF8646" || txtPassword.Text == "9H5D431SAD" || txtPassword.Text == "8907GFDARH" || txtPassword.Text == "S90MGCDYNU" || txtPassword.Text == "LIKU76543D")
                    {
                        new HealthCare.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "BILLING_OFFICER":
                    //rememberMe();
                    this.Hide();
                    passingRoll = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 1);
                    passingRollName = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 2);
                    new frmBillingOfficer().Show();
                    if (txtPassword.Text == "KI7431DHDF" || txtPassword.Text == "F54FJYRCBJ" || txtPassword.Text == "0909NJG65B" || txtPassword.Text == "S86BC642CY" || txtPassword.Text == "097VFDEWH6")
                    {
                        new HealthCare.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "PHARMACY_STAFF":
                    //rememberMe();
                    this.Hide();
                    passingRoll = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 1);
                    passingRollName = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 2);
                    new frmPharmacy().Show();
                    if (txtPassword.Text == "87421LKJLH" || txtPassword.Text == "SAAYOM12B3" || txtPassword.Text == "KALUN2312D")
                    {
                        new HealthCare.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "WARD_STAFF":
                    //rememberMe();
                    this.Hide();
                    passingRoll = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 1);
                    passingRollName = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 2);
                    new frmWard().Show();
                    if (txtPassword.Text == "ACHINSUDHARK" || txtPassword.Text == "SACHINI12D34")
                    {
                        new HealthCare.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "LABORATORY_STAFF":
                    //rememberMe();
                    this.Hide();
                    passingRoll = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 1);
                    passingRollName = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 2);
                    new frmLaboratory().Show();
                    if (txtPassword.Text == "12FGR453ASDD" || txtPassword.Text == "HOSTR4E3W21W" || txtPassword.Text == "SASHOSLAB190")
                    {
                        new HealthCare.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "SCAN_ROOM":
                    //rememberMe();
                    this.Hide();
                    passingRoll = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 1);
                    passingRollName = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 2);
                    new frmScanRoom().Show();
                    if (txtPassword.Text == "WAYOMI2346" || txtPassword.Text == "MADAWA1009" || txtPassword.Text == "NALIN65430" || txtPassword.Text == "NISHADI980" || txtPassword.Text == "CHATHURA00")
                    {
                        new HealthCare.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "XRAY_ROOM":
                    //rememberMe();
                    this.Hide();
                    passingRoll = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 1);
                    passingRollName = SQLConnectionManager.getValue("SELECT * FROM ACCOUNT", txtUsername.Text, 3, 2);
                    new frmXray().Show();
                    if (txtPassword.Text == "LKLKHYT632" || txtPassword.Text == "LKHFUY763H" || txtPassword.Text == "09KJG54GSG" || txtPassword.Text == "NIHGY65412" || txtPassword.Text == "HU653VSJ6V")
                    {
                        new HealthCare.frmTranceparentBG(new frmChangePassword());
                    }
                    break;
                case "Error":
                    //HSMessageBox.Show("THE USERNAME OR PASSWORD \nTHAT YOU HAVE \nENTERED DOESN'T MATCH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SMDMessage.show("ERROR", "THE USERNAME OR PASSWORD \nTHAT YOU HAVE \nENTERED DOESN'T MATCH",SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    break;
            }
        }
    }
}
