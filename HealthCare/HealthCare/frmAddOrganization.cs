using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDValidation;
using SMDMessageBox;

namespace HealthCare
{
    public partial class frmAddOrganization : Form
    {
        public frmAddOrganization(/*Form frm*/)
        {
            InitializeComponent();
            tmrDateTime.Start();
        }

        public delegate void UpdateDelegate(Object sender, UpdateEvenetArgs args);
        public event UpdateDelegate UpdateEvenetHanler;

        public class UpdateEvenetArgs : EventArgs
        {
            public string Data { get; set; }
        }

        private void insert()
        {
            UpdateEvenetArgs args = new UpdateEvenetArgs();
            UpdateEvenetHanler.Invoke(this, args);
        }

        private void frmADAddmitPatient_Load(object sender, EventArgs e)
        {
            Animate.Start();
            txtRegisterName.Focus();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtRegisterName.Text) && !txtRegisterName.Text.Any(char.IsDigit))
            {
                Validation.texBoxValidate(true,txtRegisterName,lblRegNameErr);
            }
            else
            {
                Validation.texBoxValidate(false, txtRegisterName, lblRegNameErr, "*cannot have number");
            }
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOrganixationName.Text) && !txtOrganixationName.Text.Any(char.IsDigit))
            {
                Validation.texBoxValidate(true, txtOrganixationName, lblOrgNameErr);
            }
            else
            {
                Validation.texBoxValidate(false, txtOrganixationName, lblOrgNameErr, "*cannot have number");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegisterName.Text) && string.IsNullOrEmpty(txtOrganixationName.Text) && string.IsNullOrEmpty(txtOrgAddress.Text) && string.IsNullOrEmpty(txtBillNumber.Text))
            {
                Validation.texBoxValidate(false, txtRegisterName, lblRegNameErr, "*cannot be blank");
                Validation.texBoxValidate(false, txtOrganixationName, lblOrgNameErr, "*cannot be blank");
                Validation.texBoxValidate(false, txtOrgAddress, lblOrgAddressErr, "*cannot be blank");
                Validation.texBoxValidate(false, txtBillNumber, lblBillNumberErr, "*cannot be blank");
            }
            else if (txtRegisterName.Text.Any(char.IsDigit))
            {
                Validation.texBoxValidate(false, txtRegisterName, lblRegNameErr, "*cannot have number");
            }
            else if (txtOrganixationName.Text.Any(char.IsDigit))
            {
                Validation.texBoxValidate(false, txtOrganixationName, lblOrgNameErr, "*cannot have number");
            }
            else if (txtOrgAddress.Text.Any(char.IsDigit))
            {
                Validation.texBoxValidate(false, txtOrgAddress, lblOrgAddressErr, "*cannot have number");
            }
            else if (txtBillNumber.Text.Any(char.IsLetter))
            {
                Validation.texBoxValidate(false, txtBillNumber, lblBillNumberErr, "*cannot have number");
            }
            else if (string.IsNullOrEmpty(txtRegisterName.Text))
            {
                Validation.texBoxValidate(false, txtRegisterName, lblRegNameErr, "*cannot be blank");
            }
            else if (string.IsNullOrEmpty(txtOrganixationName.Text))
            {
                Validation.texBoxValidate(false, txtOrganixationName, lblOrgNameErr, "*cannot be blank");
            }
            else if (string.IsNullOrEmpty(txtOrgAddress.Text))
            {
                Validation.texBoxValidate(false, txtOrgAddress, lblOrgAddressErr, "*cannot be blank");
            }
            else if (string.IsNullOrEmpty(txtBillNumber.Text))
            {
                Validation.texBoxValidate(false, txtBillNumber, lblBillNumberErr, "*cannot be blank");
            }
            else
            {
                string addmitionOffId = SQLConnectionManager.getValue("SELECT * FROM ADMISSION_OFFICER", frmLogin.passingRoll, 10, 1);


                int i = SQLConnectionManager.insrtUpdteDelt("INSERT INTO GUARDIAN VALUES ('" + txtRegisterName.Text + "','" + txtOrganixationName.Text + "','" + txtOrgAddress.Text + "','" + txtBillNumber.Text + "','" + txtBillingOfficer.Text + "')");
                

                if (i == 1)
                {
                    //HSMessageBox.Show("DATA ADDED SUCCESSFULLY", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SMDMessage.show("INFORMATION", "DATA ADDED SUCCESSFULLY",SMDMessageBoxButtons.OK,SMDMessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show("DATA ADDED UNSUCCESSFULLY", "ERROR");
                    SMDMessage.show("ERROR", "DATA ADDED UNSUCCESSFULLY", SMDMessageBoxButtons.OK, SMDMessageBoxIcon.Error);
                }
                insert();
            }
        }

        private void txtOrgAddress_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOrganixationName.Text) && !txtOrganixationName.Text.Any(char.IsDigit))
            {
                Validation.texBoxValidate(true, txtOrgAddress, lblOrgAddressErr);
            }
            else
            {
                Validation.texBoxValidate(false, txtOrgAddress, lblOrgAddressErr, "*cannot have number");
            }
        }

        private void txtBillNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBillNumber.Text) && !txtBillNumber.Text.Any(char.IsLetter))
            {
                Validation.texBoxValidate(true, txtBillNumber, lblBillNumberErr);

            }
            else if (txtBillNumber.Text == SQLConnectionManager.getValue("SELECT * FROM BILL", txtBillNumber.Text, 1, 6))
            {
                txtBillingOfficer.Text = SQLConnectionManager.getValue("SELECT * FROM BILL", txtBillNumber.Text, 1, 6);
            }
            else
            {
                Validation.texBoxValidate(false, txtBillNumber, lblBillNumberErr, "*cannot have string");
            }
        }
    }
}
