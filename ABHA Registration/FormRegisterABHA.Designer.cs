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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(abhaRegisterForm));
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
            verifyTxtBox = new TextBox();
            verifyMobLbl = new Label();
            verifyHeadingLbl = new Label();
            cancelTabPage = new TabPage();
            pictureBox1 = new PictureBox();
            usingMobPanel.SuspendLayout();
            abhaTabControl.SuspendLayout();
            mobTabPage.SuspendLayout();
            aadharTabPage.SuspendLayout();
            usingAadharPanel.SuspendLayout();
            verifyTabPage.SuspendLayout();
            verifyPanel.SuspendLayout();
            cancelTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usingMobPanel
            // 
            usingMobPanel.BackColor = Color.Transparent;
            usingMobPanel.BorderStyle = BorderStyle.Fixed3D;
            usingMobPanel.Controls.Add(mobTenLbl);
            usingMobPanel.Controls.Add(mobileGenOtpBtn);
            usingMobPanel.Controls.Add(mobileMobTxtBox);
            usingMobPanel.Controls.Add(mobileMobLbl);
            usingMobPanel.Controls.Add(mobHeadingLbl);
            usingMobPanel.Location = new Point(5, 5);
            usingMobPanel.Name = "usingMobPanel";
            usingMobPanel.Size = new Size(517, 308);
            usingMobPanel.TabIndex = 1;
            // 
            // mobTenLbl
            // 
            mobTenLbl.AutoSize = true;
            mobTenLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobTenLbl.Location = new Point(293, 83);
            mobTenLbl.Name = "mobTenLbl";
            mobTenLbl.Size = new Size(0, 25);
            mobTenLbl.TabIndex = 4;
            // 
            // mobileGenOtpBtn
            // 
            mobileGenOtpBtn.BackColor = Color.Silver;
            mobileGenOtpBtn.Cursor = Cursors.Hand;
            mobileGenOtpBtn.Enabled = false;
            mobileGenOtpBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            mobileGenOtpBtn.FlatStyle = FlatStyle.System;
            mobileGenOtpBtn.Location = new Point(374, 83);
            mobileGenOtpBtn.Name = "mobileGenOtpBtn";
            mobileGenOtpBtn.Size = new Size(109, 23);
            mobileGenOtpBtn.TabIndex = 3;
            mobileGenOtpBtn.Text = "Generate OTP";
            mobileGenOtpBtn.UseVisualStyleBackColor = false;
            mobileGenOtpBtn.Click += mobileGenOtpBtn_Click;
            // 
            // mobileMobTxtBox
            // 
            mobileMobTxtBox.Location = new Point(127, 83);
            mobileMobTxtBox.Name = "mobileMobTxtBox";
            mobileMobTxtBox.PlaceholderText = "Enter Mobile Number";
            mobileMobTxtBox.Size = new Size(160, 23);
            mobileMobTxtBox.TabIndex = 2;
            mobileMobTxtBox.KeyPress += mobileMobTxtBox_KeyPress;
            // 
            // mobileMobLbl
            // 
            mobileMobLbl.AutoSize = true;
            mobileMobLbl.Location = new Point(24, 86);
            mobileMobLbl.Name = "mobileMobLbl";
            mobileMobLbl.Size = new Size(69, 15);
            mobileMobLbl.TabIndex = 1;
            mobileMobLbl.Text = " Mobile No:";
            // 
            // mobHeadingLbl
            // 
            mobHeadingLbl.AutoSize = true;
            mobHeadingLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobHeadingLbl.ForeColor = SystemColors.ActiveCaptionText;
            mobHeadingLbl.Location = new Point(18, 37);
            mobHeadingLbl.Name = "mobHeadingLbl";
            mobHeadingLbl.Size = new Size(415, 20);
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
            abhaTabControl.Margin = new Padding(3, 2, 3, 2);
            abhaTabControl.Name = "abhaTabControl";
            abhaTabControl.SelectedIndex = 0;
            abhaTabControl.Size = new Size(532, 340);
            abhaTabControl.TabIndex = 2;
            abhaTabControl.MouseClick += abhaTabControl_MouseClick;
            // 
            // mobTabPage
            // 
            mobTabPage.Controls.Add(usingMobPanel);
            mobTabPage.Location = new Point(4, 24);
            mobTabPage.Margin = new Padding(3, 2, 3, 2);
            mobTabPage.Name = "mobTabPage";
            mobTabPage.Padding = new Padding(3, 2, 3, 2);
            mobTabPage.Size = new Size(524, 312);
            mobTabPage.TabIndex = 0;
            mobTabPage.Text = "ABHA using Mobile";
            mobTabPage.UseVisualStyleBackColor = true;
            // 
            // aadharTabPage
            // 
            aadharTabPage.Controls.Add(usingAadharPanel);
            aadharTabPage.Location = new Point(4, 24);
            aadharTabPage.Margin = new Padding(3, 2, 3, 2);
            aadharTabPage.Name = "aadharTabPage";
            aadharTabPage.Padding = new Padding(3, 2, 3, 2);
            aadharTabPage.Size = new Size(524, 312);
            aadharTabPage.TabIndex = 1;
            aadharTabPage.Text = "ABHA using Aadhar";
            aadharTabPage.UseVisualStyleBackColor = true;
            // 
            // usingAadharPanel
            // 
            usingAadharPanel.BackColor = Color.Transparent;
            usingAadharPanel.BorderStyle = BorderStyle.Fixed3D;
            usingAadharPanel.Controls.Add(aadharTxtBox);
            usingAadharPanel.Controls.Add(aadharTxtField);
            usingAadharPanel.Controls.Add(aadharTenLbl);
            usingAadharPanel.Controls.Add(aadharGenOtpBtn);
            usingAadharPanel.Controls.Add(aadharMobTxtBox);
            usingAadharPanel.Controls.Add(aadharMobLbl);
            usingAadharPanel.Controls.Add(aadharHeadingLbl);
            usingAadharPanel.Location = new Point(3, 3);
            usingAadharPanel.Name = "usingAadharPanel";
            usingAadharPanel.Size = new Size(517, 308);
            usingAadharPanel.TabIndex = 3;
            // 
            // aadharTxtBox
            // 
            aadharTxtBox.Location = new Point(127, 119);
            aadharTxtBox.Name = "aadharTxtBox";
            aadharTxtBox.PlaceholderText = "Enter Aadhar Number";
            aadharTxtBox.Size = new Size(160, 23);
            aadharTxtBox.TabIndex = 6;
            // 
            // aadharTxtField
            // 
            aadharTxtField.AutoSize = true;
            aadharTxtField.Location = new Point(24, 122);
            aadharTxtField.Name = "aadharTxtField";
            aadharTxtField.Size = new Size(67, 15);
            aadharTxtField.TabIndex = 5;
            aadharTxtField.Text = "Aadhar No:";
            // 
            // aadharTenLbl
            // 
            aadharTenLbl.AutoSize = true;
            aadharTenLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aadharTenLbl.Location = new Point(293, 83);
            aadharTenLbl.Name = "aadharTenLbl";
            aadharTenLbl.Size = new Size(0, 25);
            aadharTenLbl.TabIndex = 4;
            // 
            // aadharGenOtpBtn
            // 
            aadharGenOtpBtn.FlatStyle = FlatStyle.System;
            aadharGenOtpBtn.Location = new Point(374, 83);
            aadharGenOtpBtn.Name = "aadharGenOtpBtn";
            aadharGenOtpBtn.Size = new Size(109, 23);
            aadharGenOtpBtn.TabIndex = 3;
            aadharGenOtpBtn.Text = "Generate OTP";
            aadharGenOtpBtn.UseVisualStyleBackColor = true;
            aadharGenOtpBtn.Click += aadharGenOtpBtn_Click;
            // 
            // aadharMobTxtBox
            // 
            aadharMobTxtBox.Location = new Point(127, 83);
            aadharMobTxtBox.Name = "aadharMobTxtBox";
            aadharMobTxtBox.PlaceholderText = "Enter Mobile Number";
            aadharMobTxtBox.Size = new Size(160, 23);
            aadharMobTxtBox.TabIndex = 2;
            aadharMobTxtBox.KeyPress += aadharMobTxtBox_KeyPress;
            // 
            // aadharMobLbl
            // 
            aadharMobLbl.AutoSize = true;
            aadharMobLbl.Location = new Point(24, 86);
            aadharMobLbl.Name = "aadharMobLbl";
            aadharMobLbl.Size = new Size(69, 15);
            aadharMobLbl.TabIndex = 1;
            aadharMobLbl.Text = " Mobile No:";
            // 
            // aadharHeadingLbl
            // 
            aadharHeadingLbl.AutoSize = true;
            aadharHeadingLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aadharHeadingLbl.ForeColor = SystemColors.ActiveCaptionText;
            aadharHeadingLbl.Location = new Point(18, 37);
            aadharHeadingLbl.Name = "aadharHeadingLbl";
            aadharHeadingLbl.Size = new Size(152, 20);
            aadharHeadingLbl.TabIndex = 0;
            aadharHeadingLbl.Text = "ABHA using Aadhar";
            // 
            // verifyTabPage
            // 
            verifyTabPage.Controls.Add(verifyPanel);
            verifyTabPage.Location = new Point(4, 24);
            verifyTabPage.Margin = new Padding(3, 2, 3, 2);
            verifyTabPage.Name = "verifyTabPage";
            verifyTabPage.Size = new Size(524, 312);
            verifyTabPage.TabIndex = 2;
            verifyTabPage.Text = "ABHA Verification";
            verifyTabPage.UseVisualStyleBackColor = true;
            // 
            // verifyPanel
            // 
            verifyPanel.BackColor = Color.Transparent;
            verifyPanel.BorderStyle = BorderStyle.Fixed3D;
            verifyPanel.Controls.Add(verifyTenLabel);
            verifyPanel.Controls.Add(verifyGenOtpBtn);
            verifyPanel.Controls.Add(verifyTxtBox);
            verifyPanel.Controls.Add(verifyMobLbl);
            verifyPanel.Controls.Add(verifyHeadingLbl);
            verifyPanel.Location = new Point(4, 4);
            verifyPanel.Name = "verifyPanel";
            verifyPanel.Size = new Size(517, 308);
            verifyPanel.TabIndex = 2;
            // 
            // verifyTenLabel
            // 
            verifyTenLabel.AutoSize = true;
            verifyTenLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verifyTenLabel.Location = new Point(293, 83);
            verifyTenLabel.Name = "verifyTenLabel";
            verifyTenLabel.Size = new Size(0, 25);
            verifyTenLabel.TabIndex = 4;
            // 
            // verifyGenOtpBtn
            // 
            verifyGenOtpBtn.FlatStyle = FlatStyle.System;
            verifyGenOtpBtn.Location = new Point(374, 83);
            verifyGenOtpBtn.Name = "verifyGenOtpBtn";
            verifyGenOtpBtn.Size = new Size(109, 23);
            verifyGenOtpBtn.TabIndex = 3;
            verifyGenOtpBtn.Text = "Generate OTP";
            verifyGenOtpBtn.UseVisualStyleBackColor = true;
            verifyGenOtpBtn.Click += verifyGenOtpBtn_Click;
            // 
            // verifyTxtBox
            // 
            verifyTxtBox.BackColor = SystemColors.Window;
            verifyTxtBox.Location = new Point(127, 83);
            verifyTxtBox.Name = "verifyTxtBox";
            verifyTxtBox.PlaceholderText = "Enter ABHA Address";
            verifyTxtBox.Size = new Size(160, 23);
            verifyTxtBox.TabIndex = 2;
            // 
            // verifyMobLbl
            // 
            verifyMobLbl.AutoSize = true;
            verifyMobLbl.Location = new Point(24, 86);
            verifyMobLbl.Name = "verifyMobLbl";
            verifyMobLbl.Size = new Size(84, 15);
            verifyMobLbl.TabIndex = 1;
            verifyMobLbl.Text = "ABHA Address";
            // 
            // verifyHeadingLbl
            // 
            verifyHeadingLbl.AutoSize = true;
            verifyHeadingLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verifyHeadingLbl.ForeColor = SystemColors.ActiveCaptionText;
            verifyHeadingLbl.Location = new Point(18, 37);
            verifyHeadingLbl.Name = "verifyHeadingLbl";
            verifyHeadingLbl.Size = new Size(250, 20);
            verifyHeadingLbl.TabIndex = 0;
            verifyHeadingLbl.Text = "Please Enter Your ABHA Address";
            // 
            // cancelTabPage
            // 
            cancelTabPage.BackColor = Color.Transparent;
            cancelTabPage.Controls.Add(pictureBox1);
            cancelTabPage.Location = new Point(4, 24);
            cancelTabPage.Margin = new Padding(3, 2, 3, 2);
            cancelTabPage.Name = "cancelTabPage";
            cancelTabPage.Size = new Size(524, 312);
            cancelTabPage.TabIndex = 3;
            cancelTabPage.Text = "Reset";
            cancelTabPage.MouseClick += cancelTabPage_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(110, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 183);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // abhaRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 340);
            Controls.Add(abhaTabControl);
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
            cancelTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox verifyTxtBox;
        private Label verifyMobLbl;
        private Label verifyHeadingLbl;
        private PictureBox pictureBox1;
    }
}
