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
            usingMobPanel = new Panel();
            tenLbl = new Label();
            genOtpBtn = new Button();
            mobTxtBox = new TextBox();
            label1 = new Label();
            mobHeadingLbl = new Label();
            abhaTabControl = new TabControl();
            mobTabPage = new TabPage();
            aadharTabPage = new TabPage();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            verifyTabPage = new TabPage();
            cancelTabPage = new TabPage();
            usingMobPanel.SuspendLayout();
            abhaTabControl.SuspendLayout();
            mobTabPage.SuspendLayout();
            aadharTabPage.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // usingMobPanel
            // 
            usingMobPanel.Controls.Add(tenLbl);
            usingMobPanel.Controls.Add(genOtpBtn);
            usingMobPanel.Controls.Add(mobTxtBox);
            usingMobPanel.Controls.Add(label1);
            usingMobPanel.Controls.Add(mobHeadingLbl);
            usingMobPanel.Location = new Point(6, 7);
            usingMobPanel.Margin = new Padding(3, 4, 3, 4);
            usingMobPanel.Name = "usingMobPanel";
            usingMobPanel.Size = new Size(591, 410);
            usingMobPanel.TabIndex = 1;
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
            // genOtpBtn
            // 
            genOtpBtn.Location = new Point(427, 111);
            genOtpBtn.Margin = new Padding(3, 4, 3, 4);
            genOtpBtn.Name = "genOtpBtn";
            genOtpBtn.Size = new Size(125, 31);
            genOtpBtn.TabIndex = 3;
            genOtpBtn.Text = "Generate OTP";
            genOtpBtn.UseVisualStyleBackColor = true;
            genOtpBtn.Click += genOtpBtn_Click;
            // 
            // mobTxtBox
            // 
            mobTxtBox.Location = new Point(145, 111);
            mobTxtBox.Margin = new Padding(3, 4, 3, 4);
            mobTxtBox.Name = "mobTxtBox";
            mobTxtBox.PlaceholderText = "Enter Mobile Number";
            mobTxtBox.Size = new Size(182, 27);
            mobTxtBox.TabIndex = 2;
            mobTxtBox.KeyPress += mobTxtBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 115);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = " Mobile No:";
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
            aadharTabPage.Controls.Add(panel1);
            aadharTabPage.Location = new Point(4, 29);
            aadharTabPage.Name = "aadharTabPage";
            aadharTabPage.Padding = new Padding(3);
            aadharTabPage.Size = new Size(600, 421);
            aadharTabPage.TabIndex = 1;
            aadharTabPage.Text = "ABHA using Aadhar";
            aadharTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 410);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 111);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(427, 111);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 31);
            button1.TabIndex = 3;
            button1.Text = "Generate OTP";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 111);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Mobile Number";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 115);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 1;
            label3.Text = " Mobile No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(21, 49);
            label4.Name = "label4";
            label4.Size = new Size(188, 25);
            label4.TabIndex = 0;
            label4.Text = "ABHA using Aadhar";
            // 
            // verifyTabPage
            // 
            verifyTabPage.Location = new Point(4, 29);
            verifyTabPage.Name = "verifyTabPage";
            verifyTabPage.Size = new Size(600, 421);
            verifyTabPage.TabIndex = 2;
            verifyTabPage.Text = "ABHA Verification";
            verifyTabPage.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 453);
            Controls.Add(abhaTabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            usingMobPanel.ResumeLayout(false);
            usingMobPanel.PerformLayout();
            abhaTabControl.ResumeLayout(false);
            mobTabPage.ResumeLayout(false);
            aadharTabPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel usingMobPanel;
        private Label label1;
        private Label mobHeadingLbl;
        private Button genOtpBtn;
        private TextBox mobTxtBox;
        private Label tenLbl;
        private TabControl abhaTabControl;
        private TabPage mobTabPage;
        private TabPage aadharTabPage;
        private TabPage verifyTabPage;
        private TabPage cancelTabPage;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
    }
}
