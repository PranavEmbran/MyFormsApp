#region File Header
/*
Copyright Hodo. 2025
All rights are reserved. Reproduction or transmission in whole or in part, in any form or by any means, electronic, mechanical or otherwise, is prohibited without the prior written consent of the copyright owner.
File Name  :UserCntrolOTP.cs
Description  :Insert data from form to database.
Log
Date              Author                 Comment
08-06-2025        Pranav Embran S        ABHA Registration
*/
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABHA_Registration
{
    public partial class OtpUserControl : UserControl
    {
        public OtpUserControl()
        {
            InitializeComponent();

            Label testLabel = new Label();
            testLabel.Text = "OTP Section Loaded!";
            testLabel.ForeColor = Color.Blue;
            testLabel.AutoSize = true;
            this.Controls.Add(testLabel);
        }

    }
}
