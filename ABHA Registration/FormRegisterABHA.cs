#region File Header
/*
Copyright Hodo. 2025
All rights are reserved. Reproduction or transmission in whole or in part, in any form or by any means, electronic, mechanical or otherwise, is prohibited without the prior written consent of the copyright owner.
File Name  :FormRegisterABHA.cs
Description  :Insert data from form to database.
Log
Date              Author                 Comment
08-06-2025        Pranav Embran S        ABHA Registration
*/
#endregion

#region Using
using System.Windows.Forms;
#endregion

namespace ABHA_Registration
{
    public partial class abhaRegisterForm : Form
    {
        public abhaRegisterForm()
        {
            InitializeComponent();
        }


        private OtpUserControl otpControl;
        private void otpDisplayUserControl(Panel panelObj)
        {
            //usingMobPanel.Visible = false;
            //usingMobPanel.Controls.Clear(); // remove previous controls (optional)


            otpControl = new OtpUserControl();
            otpControl.Size = panelObj.Size;
            otpControl.Location = panelObj.Location;
            //otpControl.Location = new Point(0, 0); // relative to the panel


            //this.Controls.Add(otpControl);
            panelObj.Controls.Add(otpControl);
            otpControl.BringToFront();
            //usingMobPanel.Visible = true; // make sure it's visible

        }


        private void mobileMobTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mobileMobTxtBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                mobTenLbl.Text = "✅";
                mobTenLbl.ForeColor = System.Drawing.Color.Green;
                return;
            }
            else
            {
                mobTenLbl.Text = "";
            }
        }

        private void mobileGenOtpBtn_Click(object sender, EventArgs e)
        {
            otpDisplayUserControl(usingMobPanel);
        }

        private void aadharMobTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aadharMobTxtBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                aadharTenLbl.Text = "✅";
                aadharTenLbl.ForeColor = System.Drawing.Color.Green;
                return;
            }
            else
            {
                mobTenLbl.Text = "";
            }
        }



        private void aadharGenOtpBtn_Click(object sender, EventArgs e)
        {
            otpDisplayUserControl(usingAadharPanel);
        }

        private void verifyGenOtpBtn_Click(object sender, EventArgs e)
        {
            otpDisplayUserControl(verifyPanel);
        }


    }
}
