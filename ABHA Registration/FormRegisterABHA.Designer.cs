namespace ABHA_Registration
{
    partial class abhaRegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usingMobPanel = new Panel();
            mobTenLbl = new Label();
            mobileGenOtpBtn = new Button();
            mobileMobTxtBox = new TextBox();
            mobileMobLbl = new Label();
            mobHeadingLbl = new Label();
            abhaTabControl = new TabControl();
            mobTabPage = new TabPage();
            aadharTabPage = new TabPage();
            usingAadharPanel = new Panel();
            aadharTxtBox = new TextBox();
            aadharTxtField = new Label();
            aadharTenLbl = new Label();
            aadharGenOtpBtn = new Button();
            aadharMobTxtBox = new TextBox();
            aadharMobLbl = new Label();
            aadharHeadingLbl = new Label();
            verifyTabPage = new TabPage();
            verifyPanel = new Panel();
            verifyTenLabel = new Label();
            verifyGenOtpBtn = new Button();
            verifyMobTxtBox = new TextBox();
            verifyMobLbl = new Label();
            verifyHeadingLbl = new Label();
            cancelTabPage = new TabPage();
            usingMobPanel.SuspendLayout();
            abhaTabControl.SuspendLayout();
            mobTabPage.SuspendLayout();
            aadharTabPage.SuspendLayout();
            usingAadharPanel.SuspendLayout();
            verifyTabPage.SuspendLayout();
            verifyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usingMobPanel
            // 
            usingMobPanel.Controls.Add(mobTenLbl);
            usingMobPanel.Controls.Add(mobileGenOtpBtn);
            usingMobPanel.Controls.Add(mobileMobTxtBox);
            usingMobPanel.Controls.Add(mobileMobLbl);
            usingMobPanel.Controls.Add(mobHeadingLbl);
            usingMobPanel.Location = new Point(6, 7);
            usingMobPanel.Margin = new Padding(3, 4, 3, 4);
            usingMobPanel.Name = "usingMobPanel";
            usingMobPanel.Size = new Size(591, 410);
            usingMobPanel.TabIndex = 1;
            // 
            // mobTenLbl
            // 
            mobTenLbl.AutoSize = true;
            mobTenLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobTenLbl.Location = new Point(335, 111);
            mobTenLbl.Name = "mobTenLbl";
            mobTenLbl.Size = new Size(0, 32);
            mobTenLbl.TabIndex = 4;
            // 
            // mobileGenOtpBtn
            // 
            mobileGenOtpBtn.Location = new Point(427, 111);
            mobileGenOtpBtn.Margin = new Padding(3, 4, 3, 4);
            mobileGenOtpBtn.Name = "mobileGenOtpBtn";
            mobileGenOtpBtn.Size = new Size(125, 31);
            mobileGenOtpBtn.TabIndex = 3;
            mobileGenOtpBtn.Text = "Generate OTP";
            mobileGenOtpBtn.UseVisualStyleBackColor = true;
            mobileGenOtpBtn.Click += mobileGenOtpBtn_Click;
            // 
            // mobileMobTxtBox
            // 
            mobileMobTxtBox.Location = new Point(145, 111);
            mobileMobTxtBox.Margin = new Padding(3, 4, 3, 4);
            mobileMobTxtBox.Name = "mobileMobTxtBox";
            mobileMobTxtBox.PlaceholderText = "Enter Mobile Number";
            mobileMobTxtBox.Size = new Size(182, 27);
            mobileMobTxtBox.TabIndex = 2;
            mobileMobTxtBox.KeyPress += mobileMobTxtBox_KeyPress;
            // 
            // mobileMobLbl
            // 
            mobileMobLbl.AutoSize = true;
            mobileMobLbl.Location = new Point(27, 115);
            mobileMobLbl.Name = "mobileMobLbl";
            mobileMobLbl.Size = new Size(87, 20);
            mobileMobLbl.TabIndex = 1;
            mobileMobLbl.Text = " Mobile No:";
            // 
            // mobHeadingLbl
            // 
            mobHeadingLbl.AutoSize = true;
            mobHeadingLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobHeadingLbl.ForeColor = SystemColors.ActiveCaptionText;
            mobHeadingLbl.Location = new Point(21, 49);
            mobHeadingLbl.Name = "mobHeadingLbl";
            mobHeadingLbl.Size = new Size(508, 25);
            mobHeadingLbl.TabIndex = 0;
            mobHeadingLbl.Text = "Please Enter Your Mobile Number  Registered with ABHA";
            // 
            // abhaTabControl
            // 
            abhaTabControl.Controls.Add(mobTabPage);
            abhaTabControl.Controls.Add(aadharTabPage);
            abhaTabControl.Controls.Add(verifyTabPage);
            abhaTabControl.Controls.Add(cancelTabPage);
            abhaTabControl.Location = new Point(0, 0);
            abhaTabControl.Name = "abhaTabControl";
            abhaTabControl.SelectedIndex = 0;
            abhaTabControl.Size = new Size(608, 454);
            abhaTabControl.TabIndex = 2;
            // 
            // mobTabPage
            // 
            mobTabPage.Controls.Add(usingMobPanel);
            mobTabPage.Location = new Point(4, 29);
            mobTabPage.Name = "mobTabPage";
            mobTabPage.Padding = new Padding(3);
            mobTabPage.Size = new Size(600, 421);
            mobTabPage.TabIndex = 0;
            mobTabPage.Text = "ABHA using Mobile";
            mobTabPage.UseVisualStyleBackColor = true;
            // 
            // aadharTabPage
            // 
            aadharTabPage.Controls.Add(usingAadharPanel);
            aadharTabPage.Location = new Point(4, 29);
            aadharTabPage.Name = "aadharTabPage";
            aadharTabPage.Padding = new Padding(3);
            aadharTabPage.Size = new Size(600, 421);
            aadharTabPage.TabIndex = 1;
            aadharTabPage.Text = "ABHA using Aadhar";
            aadharTabPage.UseVisualStyleBackColor = true;
            // 
            // usingAadharPanel
            // 
            usingAadharPanel.Controls.Add(aadharTxtBox);
            usingAadharPanel.Controls.Add(aadharTxtField);
            usingAadharPanel.Controls.Add(aadharTenLbl);
            usingAadharPanel.Controls.Add(aadharGenOtpBtn);
            usingAadharPanel.Controls.Add(aadharMobTxtBox);
            usingAadharPanel.Controls.Add(aadharMobLbl);
            usingAadharPanel.Controls.Add(aadharHeadingLbl);
            usingAadharPanel.Location = new Point(3, 4);
            usingAadharPanel.Margin = new Padding(3, 4, 3, 4);
            usingAadharPanel.Name = "usingAadharPanel";
            usingAadharPanel.Size = new Size(591, 410);
            usingAadharPanel.TabIndex = 3;
            // 
            // aadharTxtBox
            // 
            aadharTxtBox.Location = new Point(145, 159);
            aadharTxtBox.Margin = new Padding(3, 4, 3, 4);
            aadharTxtBox.Name = "aadharTxtBox";
            aadharTxtBox.PlaceholderText = "Enter Aadhar Number";
            aadharTxtBox.Size = new Size(182, 27);
            aadharTxtBox.TabIndex = 6;
            // 
            // aadharTxtField
            // 
            aadharTxtField.AutoSize = true;
            aadharTxtField.Location = new Point(27, 163);
            aadharTxtField.Name = "aadharTxtField";
            aadharTxtField.Size = new Size(84, 20);
            aadharTxtField.TabIndex = 5;
            aadharTxtField.Text = "Aadhar No:";
            // 
            // aadharTenLbl
            // 
            aadharTenLbl.AutoSize = true;
            aadharTenLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aadharTenLbl.Location = new Point(335, 111);
            aadharTenLbl.Name = "aadharTenLbl";
            aadharTenLbl.Size = new Size(0, 32);
            aadharTenLbl.TabIndex = 4;
            // 
            // aadharGenOtpBtn
            // 
            aadharGenOtpBtn.Location = new Point(427, 111);
            aadharGenOtpBtn.Margin = new Padding(3, 4, 3, 4);
            aadharGenOtpBtn.Name = "aadharGenOtpBtn";
            aadharGenOtpBtn.Size = new Size(125, 31);
            aadharGenOtpBtn.TabIndex = 3;
            aadharGenOtpBtn.Text = "Generate OTP";
            aadharGenOtpBtn.UseVisualStyleBackColor = true;
            aadharGenOtpBtn.Click += aadharGenOtpBtn_Click;
            // 
            // aadharMobTxtBox
            // 
            aadharMobTxtBox.Location = new Point(145, 111);
            aadharMobTxtBox.Margin = new Padding(3, 4, 3, 4);
            aadharMobTxtBox.Name = "aadharMobTxtBox";
            aadharMobTxtBox.PlaceholderText = "Enter Mobile Number";
            aadharMobTxtBox.Size = new Size(182, 27);
            aadharMobTxtBox.TabIndex = 2;
            aadharMobTxtBox.KeyPress += aadharMobTxtBox_KeyPress;
            // 
            // aadharMobLbl
            // 
            aadharMobLbl.AutoSize = true;
            aadharMobLbl.Location = new Point(27, 115);
            aadharMobLbl.Name = "aadharMobLbl";
            aadharMobLbl.Size = new Size(87, 20);
            aadharMobLbl.TabIndex = 1;
            aadharMobLbl.Text = " Mobile No:";
            // 
            // aadharHeadingLbl
            // 
            aadharHeadingLbl.AutoSize = true;
            aadharHeadingLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aadharHeadingLbl.ForeColor = SystemColors.ActiveCaptionText;
            aadharHeadingLbl.Location = new Point(21, 49);
            aadharHeadingLbl.Name = "aadharHeadingLbl";
            aadharHeadingLbl.Size = new Size(188, 25);
            aadharHeadingLbl.TabIndex = 0;
            aadharHeadingLbl.Text = "ABHA using Aadhar";
            // 
            // verifyTabPage
            // 
            verifyTabPage.Controls.Add(verifyPanel);
            verifyTabPage.Location = new Point(4, 29);
            verifyTabPage.Name = "verifyTabPage";
            verifyTabPage.Size = new Size(600, 421);
            verifyTabPage.TabIndex = 2;
            verifyTabPage.Text = "ABHA Verification";
            verifyTabPage.UseVisualStyleBackColor = true;
            // 
            // verifyPanel
            // 
            verifyPanel.Controls.Add(verifyTenLabel);
            verifyPanel.Controls.Add(verifyGenOtpBtn);
            verifyPanel.Controls.Add(verifyMobTxtBox);
            verifyPanel.Controls.Add(verifyMobLbl);
            verifyPanel.Controls.Add(verifyHeadingLbl);
            verifyPanel.Location = new Point(5, 5);
            verifyPanel.Margin = new Padding(3, 4, 3, 4);
            verifyPanel.Name = "verifyPanel";
            verifyPanel.Size = new Size(591, 410);
            verifyPanel.TabIndex = 2;
            // 
            // verifyTenLabel
            // 
            verifyTenLabel.AutoSize = true;
            verifyTenLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verifyTenLabel.Location = new Point(335, 111);
            verifyTenLabel.Name = "verifyTenLabel";
            verifyTenLabel.Size = new Size(0, 32);
            verifyTenLabel.TabIndex = 4;
            // 
            // verifyGenOtpBtn
            // 
            verifyGenOtpBtn.Location = new Point(427, 111);
            verifyGenOtpBtn.Margin = new Padding(3, 4, 3, 4);
            verifyGenOtpBtn.Name = "verifyGenOtpBtn";
            verifyGenOtpBtn.Size = new Size(125, 31);
            verifyGenOtpBtn.TabIndex = 3;
            verifyGenOtpBtn.Text = "Generate OTP";
            verifyGenOtpBtn.UseVisualStyleBackColor = true;
            verifyGenOtpBtn.Click += verifyGenOtpBtn_Click;
            // 
            // verifyMobTxtBox
            // 
            verifyMobTxtBox.Location = new Point(145, 111);
            verifyMobTxtBox.Margin = new Padding(3, 4, 3, 4);
            verifyMobTxtBox.Name = "verifyMobTxtBox";
            verifyMobTxtBox.PlaceholderText = "Enter ABHA Address";
            verifyMobTxtBox.Size = new Size(182, 27);
            verifyMobTxtBox.TabIndex = 2;
            // 
            // verifyMobLbl
            // 
            verifyMobLbl.AutoSize = true;
            verifyMobLbl.Location = new Point(27, 115);
            verifyMobLbl.Name = "verifyMobLbl";
            verifyMobLbl.Size = new Size(106, 20);
            verifyMobLbl.TabIndex = 1;
            verifyMobLbl.Text = "ABHA Address";
            // 
            // verifyHeadingLbl
            // 
            verifyHeadingLbl.AutoSize = true;
            verifyHeadingLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verifyHeadingLbl.ForeColor = SystemColors.ActiveCaptionText;
            verifyHeadingLbl.Location = new Point(21, 49);
            verifyHeadingLbl.Name = "verifyHeadingLbl";
            verifyHeadingLbl.Size = new Size(307, 25);
            verifyHeadingLbl.TabIndex = 0;
            verifyHeadingLbl.Text = "Please Enter Your ABHA Address";
            // 
            // cancelTabPage
            // 
            cancelTabPage.Location = new Point(4, 29);
            cancelTabPage.Name = "cancelTabPage";
            cancelTabPage.Size = new Size(600, 421);
            cancelTabPage.TabIndex = 3;
            cancelTabPage.Text = "Cancel";
            cancelTabPage.UseVisualStyleBackColor = true;
            // 
            // abhaRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 453);
            Controls.Add(abhaTabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "abhaRegisterForm";
            Text = "ABHA Registration";
            usingMobPanel.ResumeLayout(false);
            usingMobPanel.PerformLayout();
            abhaTabControl.ResumeLayout(false);
            mobTabPage.ResumeLayout(false);
            aadharTabPage.ResumeLayout(false);
            usingAadharPanel.ResumeLayout(false);
            usingAadharPanel.PerformLayout();
            verifyTabPage.ResumeLayout(false);
            verifyPanel.ResumeLayout(false);
            verifyPanel.PerformLayout();
            ResumeLayout(false);


        }

        #endregion
        private Panel usingMobPanel;
        private Label mobileMobLbl;
        private Label mobHeadingLbl;
        private Button mobileGenOtpBtn;
        private TextBox mobileMobTxtBox;
        private Label mobTenLbl;
        private TabControl abhaTabControl;
        private TabPage mobTabPage;
        private TabPage aadharTabPage;
        private TabPage verifyTabPage;
        private TabPage cancelTabPage;
        private Panel usingAadharPanel;
        private Label aadharTenLbl;
        private Button aadharGenOtpBtn;
        private TextBox aadharMobTxtBox;
        private Label aadharMobLbl;
        private Label aadharHeadingLbl;
        private TextBox aadharTxtBox;
        private Label aadharTxtField;
        private Panel verifyPanel;
        private Label verifyTenLabel;
        private Button verifyGenOtpBtn;
        private TextBox verifyMobTxtBox;
        private Label verifyMobLbl;
        private Label verifyHeadingLbl;
    }
}
