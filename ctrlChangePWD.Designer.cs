namespace TEST.UserControl
{
    partial class ctrlChangePWD
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
            this.tblChangePwd = new System.Windows.Forms.TableLayoutPanel();
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.lblErrOldPwd = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.lblErrNewPwd = new System.Windows.Forms.Label();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.lblErrConfirmPwd = new System.Windows.Forms.Label();
            this.tblChangePwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblChangePwd
            // 
            this.tblChangePwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tblChangePwd.ColumnCount = 2;
            this.tblChangePwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblChangePwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblChangePwd.Controls.Add(this.lblOldPwd, 0, 0);
            this.tblChangePwd.Controls.Add(this.txtOldPwd, 1, 0);
            this.tblChangePwd.Controls.Add(this.lblErrOldPwd, 1, 1);
            this.tblChangePwd.Controls.Add(this.lblNewPwd, 0, 2);
            this.tblChangePwd.Controls.Add(this.txtNewPwd, 1, 2);
            this.tblChangePwd.Controls.Add(this.lblErrNewPwd, 1, 3);
            this.tblChangePwd.Controls.Add(this.lblConfirmPwd, 0, 4);
            this.tblChangePwd.Controls.Add(this.txtConfirmPwd, 1, 4);
            this.tblChangePwd.Controls.Add(this.lblErrConfirmPwd, 1, 5);
            this.tblChangePwd.Location = new System.Drawing.Point(0, 1);
            this.tblChangePwd.Name = "tblChangePwd";
            this.tblChangePwd.RowCount = 6;
            this.tblChangePwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblChangePwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tblChangePwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblChangePwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tblChangePwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblChangePwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChangePwd.Size = new System.Drawing.Size(264, 138);
            this.tblChangePwd.TabIndex = 63;
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOldPwd.Location = new System.Drawing.Point(3, 0);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(99, 25);
            this.lblOldPwd.TabIndex = 6;
            this.lblOldPwd.Text = "Old Password:";
            this.lblOldPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtOldPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOldPwd.Location = new System.Drawing.Point(108, 3);
            this.txtOldPwd.MaxLength = 50;
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(153, 20);
            this.txtOldPwd.TabIndex = 43;
            this.txtOldPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOldPwd_KeyDown);
            this.txtOldPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOldPwd_KeyPress);
            // 
            // lblErrOldPwd
            // 
            this.lblErrOldPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErrOldPwd.ForeColor = System.Drawing.Color.Red;
            this.lblErrOldPwd.Location = new System.Drawing.Point(108, 25);
            this.lblErrOldPwd.Name = "lblErrOldPwd";
            this.lblErrOldPwd.Size = new System.Drawing.Size(153, 18);
            this.lblErrOldPwd.TabIndex = 44;
            this.lblErrOldPwd.Text = "Old Password:";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewPwd.Location = new System.Drawing.Point(3, 43);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(99, 25);
            this.lblNewPwd.TabIndex = 42;
            this.lblNewPwd.Text = "New Password:";
            this.lblNewPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNewPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPwd.Location = new System.Drawing.Point(108, 46);
            this.txtNewPwd.MaxLength = 50;
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(153, 20);
            this.txtNewPwd.TabIndex = 45;
            this.txtNewPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPwd_KeyDown);
            this.txtNewPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPwd_KeyPress);
            // 
            // lblErrNewPwd
            // 
            this.lblErrNewPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErrNewPwd.ForeColor = System.Drawing.Color.Red;
            this.lblErrNewPwd.Location = new System.Drawing.Point(108, 68);
            this.lblErrNewPwd.Name = "lblErrNewPwd";
            this.lblErrNewPwd.Size = new System.Drawing.Size(153, 18);
            this.lblErrNewPwd.TabIndex = 46;
            this.lblErrNewPwd.Text = "New Password:";
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmPwd.Location = new System.Drawing.Point(3, 86);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(99, 25);
            this.lblConfirmPwd.TabIndex = 47;
            this.lblConfirmPwd.Text = "Confirm Password:";
            this.lblConfirmPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtConfirmPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmPwd.Location = new System.Drawing.Point(108, 89);
            this.txtConfirmPwd.MaxLength = 50;
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(153, 20);
            this.txtConfirmPwd.TabIndex = 48;
            this.txtConfirmPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPwd_KeyDown);
            this.txtConfirmPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPwd_KeyPress);
            // 
            // lblErrConfirmPwd
            // 
            this.lblErrConfirmPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErrConfirmPwd.ForeColor = System.Drawing.Color.Red;
            this.lblErrConfirmPwd.Location = new System.Drawing.Point(108, 111);
            this.lblErrConfirmPwd.Name = "lblErrConfirmPwd";
            this.lblErrConfirmPwd.Size = new System.Drawing.Size(153, 27);
            this.lblErrConfirmPwd.TabIndex = 51;
            this.lblErrConfirmPwd.Text = "Confirm Password:";
            // 
            // ctrlChangePWD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.tblChangePwd);
            this.Name = "ctrlChangePWD2";
            this.Size = new System.Drawing.Size(264, 138);
            this.tblChangePwd.ResumeLayout(false);
            this.tblChangePwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblChangePwd;
        private System.Windows.Forms.Label lblOldPwd;
        public System.Windows.Forms.TextBox txtOldPwd;
        public System.Windows.Forms.Label lblErrOldPwd;
        private System.Windows.Forms.Label lblNewPwd;
        public System.Windows.Forms.TextBox txtNewPwd;
        public System.Windows.Forms.Label lblErrNewPwd;
        private System.Windows.Forms.Label lblConfirmPwd;
        public System.Windows.Forms.TextBox txtConfirmPwd;
        public System.Windows.Forms.Label lblErrConfirmPwd;






    }
}
