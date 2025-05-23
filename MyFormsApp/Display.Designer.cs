namespace MyFormsApp
{
    partial class Display
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
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterByCGPALabel = new System.Windows.Forms.Label();
            this.filterByCGPAComboBox = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pdfBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(3, 54);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.Size = new System.Drawing.Size(1261, 341);
            this.mainDataGridView.TabIndex = 0;
            this.mainDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pdfBtn);
            this.panel1.Controls.Add(this.filterByCGPALabel);
            this.panel1.Controls.Add(this.filterByCGPAComboBox);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.deleteRowButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mainDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 474);
            this.panel1.TabIndex = 1;
            // 
            // filterByCGPALabel
            // 
            this.filterByCGPALabel.AutoSize = true;
            this.filterByCGPALabel.Location = new System.Drawing.Point(9, 410);
            this.filterByCGPALabel.Name = "filterByCGPALabel";
            this.filterByCGPALabel.Size = new System.Drawing.Size(78, 13);
            this.filterByCGPALabel.TabIndex = 5;
            this.filterByCGPALabel.Text = "Filter by CGPA:";
            this.filterByCGPALabel.Click += new System.EventHandler(this.filterByGradeLabel_Click);
            // 
            // filterByCGPAComboBox
            // 
            this.filterByCGPAComboBox.FormattingEnabled = true;
            this.filterByCGPAComboBox.Items.AddRange(new object[] {
            "ALL",
            "5",
            ">=4",
            ">=3",
            ">=2",
            ">=1",
            "0"});
            this.filterByCGPAComboBox.Location = new System.Drawing.Point(91, 407);
            this.filterByCGPAComboBox.Name = "filterByCGPAComboBox";
            this.filterByCGPAComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterByCGPAComboBox.TabIndex = 4;
            this.filterByCGPAComboBox.SelectedIndexChanged += new System.EventHandler(this.filterByGradeComboBox_SelectedIndexChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(1155, 407);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Location = new System.Drawing.Point(1155, 436);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRowButton.TabIndex = 2;
            this.deleteRowButton.Text = "Delete Row";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Course Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pdfBtn
            // 
            this.pdfBtn.Location = new System.Drawing.Point(1033, 410);
            this.pdfBtn.Name = "pdfBtn";
            this.pdfBtn.Size = new System.Drawing.Size(75, 23);
            this.pdfBtn.TabIndex = 6;
            this.pdfBtn.Text = "PDF";
            this.pdfBtn.UseVisualStyleBackColor = true;
            this.pdfBtn.Click += new System.EventHandler(this.pdfBtn_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 498);
            this.Controls.Add(this.panel1);
            this.Name = "Display";
            this.Text = "Display";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteRowButton;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ComboBox filterByCGPAComboBox;
        private System.Windows.Forms.Label filterByCGPALabel;
        private System.Windows.Forms.Button pdfBtn;
    }
}