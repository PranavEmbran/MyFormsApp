namespace ABHA_Registration
{
    partial class OtpUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            otpPanel = new Panel();
            tenLbl = new Label();
            verifyOtpBtn = new Button();
            otpTxtBox = new TextBox();
            otpLabel = new Label();
            otpHeadingLbl = new Label();
            otpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // otpPanel
            // 
            otpPanel.Controls.Add(tenLbl);
            otpPanel.Controls.Add(verifyOtpBtn);
            otpPanel.Controls.Add(otpTxtBox);
            otpPanel.Controls.Add(otpLabel);
            otpPanel.Controls.Add(otpHeadingLbl);
            otpPanel.Location = new Point(0, 0);
            otpPanel.Margin = new Padding(3, 4, 3, 4);
            otpPanel.Name = "otpPanel";
            otpPanel.Size = new Size(591, 410);
            otpPanel.TabIndex = 2;
            // 
            // tenLbl
            // 
            tenLbl.AutoSize = true;
            tenLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tenLbl.Location = new Point(335, 111);
            tenLbl.Name = "tenLbl";
            tenLbl.Size = new Size(0, 32);
            tenLbl.TabIndex = 4;
            // 
            // verifyOtpBtn
            // 
            verifyOtpBtn.Location = new Point(427, 111);
            verifyOtpBtn.Margin = new Padding(3, 4, 3, 4);
            verifyOtpBtn.Name = "verifyOtpBtn";
            verifyOtpBtn.Size = new Size(125, 31);
            verifyOtpBtn.TabIndex = 3;
            verifyOtpBtn.Text = "Verify OTP";
            verifyOtpBtn.UseVisualStyleBackColor = true;
            // 
            // otpTxtBox
            // 
            otpTxtBox.Location = new Point(145, 111);
            otpTxtBox.Margin = new Padding(3, 4, 3, 4);
            otpTxtBox.Name = "otpTxtBox";
            otpTxtBox.PlaceholderText = "Enter OTP";
            otpTxtBox.Size = new Size(182, 27);
            otpTxtBox.TabIndex = 2;
            // 
            // otpLabel
            // 
            otpLabel.AutoSize = true;
            otpLabel.Location = new Point(27, 115);
            otpLabel.Name = "otpLabel";
            otpLabel.Size = new Size(35, 20);
            otpLabel.TabIndex = 1;
            otpLabel.Text = "OTP";
            // 
            // otpHeadingLbl
            // 
            otpHeadingLbl.AutoSize = true;
            otpHeadingLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otpHeadingLbl.ForeColor = SystemColors.ActiveCaptionText;
            otpHeadingLbl.Location = new Point(21, 49);
            otpHeadingLbl.Name = "otpHeadingLbl";
            otpHeadingLbl.Size = new Size(170, 25);
            otpHeadingLbl.TabIndex = 0;
            otpHeadingLbl.Text = "Please Enter OTP";
            // 
            // OtpUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(otpPanel);
            Name = "OtpUserControl";
            Size = new Size(594, 414);
            otpPanel.ResumeLayout(false);
            otpPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel otpPanel;
        private Label tenLbl;
        private Button verifyOtpBtn;
        private TextBox otpTxtBox;
        private Label otpLabel;
        private Label otpHeadingLbl;
    }
}
