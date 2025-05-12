namespace MyFormsApp
{
    partial class Update
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.updtBtn = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.cgpaTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.pwdCheckBox = new System.Windows.Forms.CheckBox();
            this.phpComboBox = new System.Windows.Forms.ComboBox();
            this.javaComboBox = new System.Windows.Forms.ComboBox();
            this.cSharpComboBox = new System.Windows.Forms.ComboBox();
            this.phpLabel = new System.Windows.Forms.Label();
            this.javaLabel = new System.Windows.Forms.Label();
            this.cSharpLabel = new System.Windows.Forms.Label();
            this.gradeHeading = new System.Windows.Forms.Label();
            this.headingLabel = new System.Windows.Forms.Label();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.otherRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.genderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updtBtn);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.phoneLabel);
            this.panel1.Controls.Add(this.dobLabel);
            this.panel1.Controls.Add(this.dobPicker);
            this.panel1.Controls.Add(this.cgpaTextBox);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.pwdLabel);
            this.panel1.Controls.Add(this.pwdCheckBox);
            this.panel1.Controls.Add(this.phpComboBox);
            this.panel1.Controls.Add(this.javaComboBox);
            this.panel1.Controls.Add(this.cSharpComboBox);
            this.panel1.Controls.Add(this.phpLabel);
            this.panel1.Controls.Add(this.javaLabel);
            this.panel1.Controls.Add(this.cSharpLabel);
            this.panel1.Controls.Add(this.gradeHeading);
            this.panel1.Controls.Add(this.headingLabel);
            this.panel1.Controls.Add(this.genderPanel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.genderLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.studentLabel);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 654);
            this.panel1.TabIndex = 1;
            // 
            // updtBtn
            // 
            this.updtBtn.Location = new System.Drawing.Point(96, 493);
            this.updtBtn.Name = "updtBtn";
            this.updtBtn.Size = new System.Drawing.Size(75, 23);
            this.updtBtn.TabIndex = 30;
            this.updtBtn.Text = "Update";
            this.updtBtn.UseVisualStyleBackColor = true;
            this.updtBtn.Click += new System.EventHandler(this.updtBtn_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(237, 162);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 29;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(96, 156);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(134, 20);
            this.emailTextBox.TabIndex = 28;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(26, 159);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "Email";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(209, 601);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(96, 198);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(134, 20);
            this.phoneTextBox.TabIndex = 25;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(25, 198);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 24;
            this.phoneLabel.Text = "Phone:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(23, 123);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(28, 13);
            this.dobLabel.TabIndex = 23;
            this.dobLabel.Text = "DoB";
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(96, 117);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(134, 20);
            this.dobPicker.TabIndex = 22;
            // 
            // cgpaTextBox
            // 
            this.cgpaTextBox.Enabled = false;
            this.cgpaTextBox.Location = new System.Drawing.Point(96, 532);
            this.cgpaTextBox.Name = "cgpaTextBox";
            this.cgpaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cgpaTextBox.TabIndex = 21;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(22, 535);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(36, 13);
            this.passLabel.TabIndex = 20;
            this.passLabel.Text = "CGPA";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(26, 336);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(36, 13);
            this.pwdLabel.TabIndex = 18;
            this.pwdLabel.Text = "PWD:";
            // 
            // pwdCheckBox
            // 
            this.pwdCheckBox.AutoSize = true;
            this.pwdCheckBox.Location = new System.Drawing.Point(96, 336);
            this.pwdCheckBox.Name = "pwdCheckBox";
            this.pwdCheckBox.Size = new System.Drawing.Size(52, 17);
            this.pwdCheckBox.TabIndex = 17;
            this.pwdCheckBox.Text = "PWD";
            this.pwdCheckBox.UseVisualStyleBackColor = true;
            // 
            // phpComboBox
            // 
            this.phpComboBox.FormattingEnabled = true;
            this.phpComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.phpComboBox.Location = new System.Drawing.Point(96, 455);
            this.phpComboBox.Name = "phpComboBox";
            this.phpComboBox.Size = new System.Drawing.Size(121, 21);
            this.phpComboBox.TabIndex = 16;
            // 
            // javaComboBox
            // 
            this.javaComboBox.FormattingEnabled = true;
            this.javaComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.javaComboBox.Location = new System.Drawing.Point(96, 426);
            this.javaComboBox.Name = "javaComboBox";
            this.javaComboBox.Size = new System.Drawing.Size(121, 21);
            this.javaComboBox.TabIndex = 15;
            // 
            // cSharpComboBox
            // 
            this.cSharpComboBox.FormattingEnabled = true;
            this.cSharpComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cSharpComboBox.Location = new System.Drawing.Point(96, 398);
            this.cSharpComboBox.Name = "cSharpComboBox";
            this.cSharpComboBox.Size = new System.Drawing.Size(121, 21);
            this.cSharpComboBox.TabIndex = 14;
            // 
            // phpLabel
            // 
            this.phpLabel.AutoSize = true;
            this.phpLabel.Location = new System.Drawing.Point(22, 458);
            this.phpLabel.Name = "phpLabel";
            this.phpLabel.Size = new System.Drawing.Size(29, 13);
            this.phpLabel.TabIndex = 13;
            this.phpLabel.Text = "PHP";
            // 
            // javaLabel
            // 
            this.javaLabel.AutoSize = true;
            this.javaLabel.Location = new System.Drawing.Point(22, 429);
            this.javaLabel.Name = "javaLabel";
            this.javaLabel.Size = new System.Drawing.Size(30, 13);
            this.javaLabel.TabIndex = 12;
            this.javaLabel.Text = "Java";
            // 
            // cSharpLabel
            // 
            this.cSharpLabel.AutoSize = true;
            this.cSharpLabel.Location = new System.Drawing.Point(23, 401);
            this.cSharpLabel.Name = "cSharpLabel";
            this.cSharpLabel.Size = new System.Drawing.Size(21, 13);
            this.cSharpLabel.TabIndex = 11;
            this.cSharpLabel.Text = "C#";
            // 
            // gradeHeading
            // 
            this.gradeHeading.AutoSize = true;
            this.gradeHeading.Location = new System.Drawing.Point(23, 372);
            this.gradeHeading.Name = "gradeHeading";
            this.gradeHeading.Size = new System.Drawing.Size(67, 13);
            this.gradeHeading.TabIndex = 10;
            this.gradeHeading.Text = "Enter Grade:";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(49, 7);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(196, 20);
            this.headingLabel.TabIndex = 9;
            this.headingLabel.Text = "Student Course Details";
            // 
            // genderPanel
            // 
            this.genderPanel.Controls.Add(this.femaleRadio);
            this.genderPanel.Controls.Add(this.otherRadio);
            this.genderPanel.Controls.Add(this.maleRadio);
            this.genderPanel.Location = new System.Drawing.Point(96, 243);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(89, 75);
            this.genderPanel.TabIndex = 8;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(3, 3);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 5;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // otherRadio
            // 
            this.otherRadio.AutoSize = true;
            this.otherRadio.Location = new System.Drawing.Point(3, 51);
            this.otherRadio.Name = "otherRadio";
            this.otherRadio.Size = new System.Drawing.Size(51, 17);
            this.otherRadio.TabIndex = 7;
            this.otherRadio.TabStop = true;
            this.otherRadio.Text = "Other";
            this.otherRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(3, 28);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(48, 17);
            this.maleRadio.TabIndex = 6;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(96, 82);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(134, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(96, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(134, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(23, 243);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 13);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "Gender:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(23, 85);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(23, 46);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(38, 13);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "Name:";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 796);
            this.Controls.Add(this.panel1);
            this.Name = "Update";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updtBtn;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox cgpaTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.CheckBox pwdCheckBox;
        private System.Windows.Forms.ComboBox phpComboBox;
        private System.Windows.Forms.ComboBox javaComboBox;
        private System.Windows.Forms.ComboBox cSharpComboBox;
        private System.Windows.Forms.Label phpLabel;
        private System.Windows.Forms.Label javaLabel;
        private System.Windows.Forms.Label cSharpLabel;
        private System.Windows.Forms.Label gradeHeading;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton otherRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label studentLabel;
    }
}