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
using System.Text.RegularExpressions;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

#endregion

namespace ABHA_Registration
{
    public partial class abhaRegisterForm : MaterialForm
    //public partial class abhaRegisterForm : Form


    {
        public abhaRegisterForm()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Create a material skin manager and add the form to manage (this)
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Optional: Set theme and color scheme
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE);

            //usingMobPanel.BackColor = Color.CadetBlue;
            //usingMobPanel.BackColor = ColorTranslator.FromHtml("#0078D7");
        }


        private OtpUserControl otpControl;

        private void otpDisplayUserControl(Panel panelObj)
        {
            //usingMobPanel.Visible = false;
            //usingMobPanel.Controls.Clear(); // remove previous controls (optional)

            otpControl = new OtpUserControl();

            otpControl.Visible = true;



            otpControl.Size = panelObj.Size;
            otpControl.Location = panelObj.Location;
            //otpControl.Location = new Point(0, 0); // relative to the panel


            //this.Controls.Add(otpControl);
            panelObj.Controls.Add(otpControl);
            otpControl.BringToFront();
            //usingMobPanel.Visible = true; // make sure it's visible

        }

        // method containing the regex
        public static bool isValid(string str)
        {
            string strRegex = @"^(0|91)?[6-9][0-9]{9}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(str))
                return (true);
            else
                return (false);
        }


        private void mobileMobTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mobileMobTxtBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                mobTenLbl.Text = mobTenLbl.Text = $"{mobileMobTxtBox.Text.Length} ✅";
                mobTenLbl.ForeColor = System.Drawing.Color.Green;

                mobileGenOtpBtn.Enabled = true;

                string str = mobileMobTxtBox.Text;
                if (isValid(str))
                {
                    //Console.WriteLine("Valid Number");
                    //MessageBox.Show("Valid Number");
                }
                else
                {
                    //Console.WriteLine("Invalid Number");
                    //MessageBox.Show("Invalid Number");
                    mobTenLbl.Text = mobTenLbl.Text = "❌";
                    mobTenLbl.ForeColor = System.Drawing.Color.Red;
                    mobileGenOtpBtn.Enabled = false;

                }
                return;
            }
            else
            {
                mobTenLbl.Text = "";
                mobileGenOtpBtn.Enabled = false;
            }
        }

        private void mobileGenOtpBtn_Click(object sender, EventArgs e)
        {
            otpDisplayUserControl(usingMobPanel);
        }

        private void aadharMobTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (aadharMobTxtBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                aadharTenLbl.Text = "✅";
                aadharTenLbl.ForeColor = System.Drawing.Color.Green;

                aadharGenOtpBtn.Enabled = true;

                string str = aadharMobTxtBox.Text;
                if (isValid(str))
                {
                    //Console.WriteLine("Valid Number");
                    //MessageBox.Show("Valid Number");
                }
                else
                {
                    //Console.WriteLine("Invalid Number");
                    //MessageBox.Show("Invalid Number");
                    aadharTenLbl.Text = mobTenLbl.Text = "❌";
                    aadharTenLbl.ForeColor = System.Drawing.Color.Red;
                    aadharGenOtpBtn.Enabled = false;

                }
                return;
            }
            else
            {
                aadharTenLbl.Text = "";
                aadharGenOtpBtn.Enabled = false;
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

        private void cancelTabPage_MouseClick(object sender, MouseEventArgs e)
        {
            //otpControl.Visible = false;
        }

        private void abhaTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < abhaTabControl.TabCount; i++)
            {
                Rectangle tabRect = abhaTabControl.GetTabRect(i);

                if (tabRect.Contains(e.Location))
                {
                    if (abhaTabControl.TabPages[i] == cancelTabPage)
                    {
                        //MessageBox.Show("Cancel Tab Header Clicked!");
                        //otpControl.Visible = false;//System.NullReferenceException: 'Object reference not set to an instance of an object.' otpControl was null.

                       otpControl?.Hide();// Safe null check

                        HideOtpControlsIn(usingMobPanel);
                        HideOtpControlsIn(usingAadharPanel);
                        HideOtpControlsIn(verifyPanel);

                        //mobileMobTxtBox.Clear();
                        mobTenLbl.Text = "";

                        //aadharMobTxtBox.Clear();
                        //aadharTxtBox.Clear();
                        aadharTenLbl.Text = "";

                        //verifyTxtBox.Clear();
                    }
                }
            }
        }
        private void HideOtpControlsIn(Panel panel)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is OtpUserControl)
                {
                    ctrl.Visible = false;
                }
            }

            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is TextBox txtBox)
                {
                    txtBox.Clear();
                }
            }
        }

    }
}
