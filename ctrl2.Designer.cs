namespace TEST.UserControl
{
    partial class ctrlMe2
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
            this.tblPhoneList = new System.Windows.Forms.TableLayoutPanel();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.tblPhoneList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPhoneList
            // 
            this.tblPhoneList.ColumnCount = 4;
            this.tblPhoneList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPhoneList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPhoneList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblPhoneList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPhoneList.Controls.Add(this.cbo1, 0, 0);
            this.tblPhoneList.Controls.Add(this.txt1, 1, 0);
            this.tblPhoneList.Controls.Add(this.btn1, 2, 0);
            this.tblPhoneList.Controls.Add(this.cbo2, 0, 1);
            this.tblPhoneList.Controls.Add(this.txt2, 1, 1);
            this.tblPhoneList.Controls.Add(this.btn2, 2, 1);
            this.tblPhoneList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPhoneList.Location = new System.Drawing.Point(0, 0);
            this.tblPhoneList.Name = "tblPhoneList";
            this.tblPhoneList.RowCount = 4;
            this.tblPhoneList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblPhoneList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblPhoneList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblPhoneList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblPhoneList.Size = new System.Drawing.Size(350, 180);
            this.tblPhoneList.TabIndex = 80;
            // 
            // cbo1
            // 
            this.cbo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            "Mobile",
            "Office",
            "Home",
            "Other"});
            this.cbo1.Location = new System.Drawing.Point(3, 10);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(64, 21);
            this.cbo1.TabIndex = 66;
            // 
            // txt1
            // 
            this.txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txt1.Location = new System.Drawing.Point(73, 11);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(212, 20);
            this.txt1.TabIndex = 6;
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(291, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 35);
            this.btn1.TabIndex = 75;
            this.btn1.Text = "-";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // cbo2
            // 
            this.cbo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Items.AddRange(new object[] {
            "Mobile",
            "Office",
            "Home",
            "Other"});
            this.cbo2.Location = new System.Drawing.Point(3, 52);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(64, 21);
            this.cbo2.TabIndex = 82;
            // 
            // txt2
            // 
            this.txt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txt2.Location = new System.Drawing.Point(73, 53);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(212, 20);
            this.txt2.TabIndex = 79;
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(291, 46);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 35);
            this.btn2.TabIndex = 85;
            this.btn2.Text = "-";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // ctrlMe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.tblPhoneList);
            this.Name = "ctrlMe2";
            this.Size = new System.Drawing.Size(350, 180);
            this.tblPhoneList.ResumeLayout(false);
            this.tblPhoneList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPhoneList;
        public System.Windows.Forms.ComboBox cbo1;
        public System.Windows.Forms.TextBox txt1;
        public System.Windows.Forms.Button btn1;
        public System.Windows.Forms.ComboBox cbo2;
        public System.Windows.Forms.TextBox txt2;
        public System.Windows.Forms.Button btn2;






    }
}
