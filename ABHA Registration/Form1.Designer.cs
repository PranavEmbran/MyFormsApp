namespace ABHA_Registration
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            registerMobBtn = new ToolStripButton();
            registerAadharBtn = new ToolStripButton();
            verifyBtn = new ToolStripButton();
            cancelBtn = new ToolStripButton();
            usingMobPanel = new Panel();
            tenLbl = new Label();
            genOtpBtn = new Button();
            mobTxtBox = new TextBox();
            label1 = new Label();
            mobHeadingLbl = new Label();
            toolStrip1.SuspendLayout();
            usingMobPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { registerMobBtn, registerAadharBtn, verifyBtn, cancelBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(505, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // registerMobBtn
            // 
            registerMobBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            registerMobBtn.Image = (Image)resources.GetObject("registerMobBtn.Image");
            registerMobBtn.ImageTransparentColor = Color.Magenta;
            registerMobBtn.Name = "registerMobBtn";
            registerMobBtn.Size = new Size(115, 22);
            registerMobBtn.Text = "ABHA using Mobile";
            // 
            // registerAadharBtn
            // 
            registerAadharBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            registerAadharBtn.Image = (Image)resources.GetObject("registerAadharBtn.Image");
            registerAadharBtn.ImageTransparentColor = Color.Magenta;
            registerAadharBtn.Name = "registerAadharBtn";
            registerAadharBtn.Size = new Size(116, 22);
            registerAadharBtn.Text = "ABHA using Aadhar";
            // 
            // verifyBtn
            // 
            verifyBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            verifyBtn.Image = (Image)resources.GetObject("verifyBtn.Image");
            verifyBtn.ImageTransparentColor = Color.Magenta;
            verifyBtn.Name = "verifyBtn";
            verifyBtn.Size = new Size(105, 22);
            verifyBtn.Text = "ABHA Verification";
            // 
            // cancelBtn
            // 
            cancelBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cancelBtn.Image = (Image)resources.GetObject("cancelBtn.Image");
            cancelBtn.ImageTransparentColor = Color.Magenta;
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(47, 22);
            cancelBtn.Text = "Cancel";
            // 
            // usingMobPanel
            // 
            usingMobPanel.Controls.Add(tenLbl);
            usingMobPanel.Controls.Add(genOtpBtn);
            usingMobPanel.Controls.Add(mobTxtBox);
            usingMobPanel.Controls.Add(label1);
            usingMobPanel.Controls.Add(mobHeadingLbl);
            usingMobPanel.Location = new Point(0, 28);
            usingMobPanel.Name = "usingMobPanel";
            usingMobPanel.Size = new Size(503, 273);
            usingMobPanel.TabIndex = 1;
            // 
            // tenLbl
            // 
            tenLbl.AutoSize = true;
            tenLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenLbl.Location = new Point(293, 83);
            tenLbl.Name = "tenLbl";
            tenLbl.Size = new Size(0, 25);
            tenLbl.TabIndex = 4;
            // 
            // genOtpBtn
            // 
            genOtpBtn.Location = new Point(332, 83);
            genOtpBtn.Name = "genOtpBtn";
            genOtpBtn.Size = new Size(109, 23);
            genOtpBtn.TabIndex = 3;
            genOtpBtn.Text = "Generate OTP";
            genOtpBtn.UseVisualStyleBackColor = true;
            // 
            // mobTxtBox
            // 
            mobTxtBox.Location = new Point(127, 83);
            mobTxtBox.Name = "mobTxtBox";
            mobTxtBox.PlaceholderText = "Enter Mobile Number";
            mobTxtBox.Size = new Size(160, 23);
            mobTxtBox.TabIndex = 2;
            mobTxtBox.KeyPress += mobTxtBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 86);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = " Mobile No:";
            // 
            // mobHeadingLbl
            // 
            mobHeadingLbl.AutoSize = true;
            mobHeadingLbl.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobHeadingLbl.ForeColor = SystemColors.ActiveCaptionText;
            mobHeadingLbl.Location = new Point(18, 37);
            mobHeadingLbl.Name = "mobHeadingLbl";
            mobHeadingLbl.Size = new Size(411, 19);
            mobHeadingLbl.TabIndex = 0;
            mobHeadingLbl.Text = "Please Enter Your Mobile Number  Registered with ABHA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 303);
            Controls.Add(usingMobPanel);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            usingMobPanel.ResumeLayout(false);
            usingMobPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton registerMobBtn;
        private Panel usingMobPanel;
        private Label label1;
        private Label mobHeadingLbl;
        private ToolStripButton registerAadharBtn;
        private Button genOtpBtn;
        private TextBox mobTxtBox;
        private ToolStripButton verifyBtn;
        private ToolStripButton cancelBtn;
        private Label tenLbl;
    }
}
