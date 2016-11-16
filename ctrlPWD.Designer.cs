namespace TEST.UserControl
{
    partial class ctrlPWD
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
            this.tblPWD = new System.Windows.Forms.TableLayoutPanel();
            this.lblErrConfirmPwd = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.lblErrPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.tblPWD.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPWD
            // 
            this.tblPWD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPWD.ColumnCount = 2;
            this.tblPWD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblPWD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPWD.Controls.Add(this.lblErrConfirmPwd, 1, 4);
            this.tblPWD.Controls.Add(this.txtConfirmPwd, 1, 3);
            this.tblPWD.Controls.Add(this.lblErrPwd, 1, 2);
            this.tblPWD.Controls.Add(this.txtPwd, 1, 1);
            this.tblPWD.Controls.Add(this.lblPwd, 0, 1);
            this.tblPWD.Controls.Add(this.lblConfirmPwd, 0, 3);
            this.tblPWD.Location = new System.Drawing.Point(0, 0);
            this.tblPWD.Name = "tblPWD";
            this.tblPWD.RowCount = 6;
            this.tblPWD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPWD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPWD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPWD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPWD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPWD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPWD.Size = new System.Drawing.Size(262, 135);
            this.tblPWD.TabIndex = 58;
            // 
            // lblErrConfirmPwd
            // 
            this.lblErrConfirmPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErrConfirmPwd.ForeColor = System.Drawing.Color.Red;
            this.lblErrConfirmPwd.Location = new System.Drawing.Point(108, 90);
            this.lblErrConfirmPwd.Name = "lblErrConfirmPwd";
            this.lblErrConfirmPwd.Size = new System.Drawing.Size(151, 20);
            this.lblErrConfirmPwd.TabIndex = 46;
            this.lblErrConfirmPwd.Text = "Confirm Password:";
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtConfirmPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirmPwd.Location = new System.Drawing.Point(108, 68);
            this.txtConfirmPwd.MaxLength = 50;
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(151, 20);
            this.txtConfirmPwd.TabIndex = 45;
            this.txtConfirmPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPwd_KeyDown);
            this.txtConfirmPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPwd_KeyPress);
            // 
            // lblErrPwd
            // 
            this.lblErrPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErrPwd.ForeColor = System.Drawing.Color.Red;
            this.lblErrPwd.Location = new System.Drawing.Point(108, 45);
            this.lblErrPwd.Name = "lblErrPwd";
            this.lblErrPwd.Size = new System.Drawing.Size(151, 20);
            this.lblErrPwd.TabIndex = 44;
            this.lblErrPwd.Text = "Password:";
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPwd.Location = new System.Drawing.Point(108, 23);
            this.txtPwd.MaxLength = 50;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(151, 20);
            this.txtPwd.TabIndex = 43;
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // lblPwd
            // 
            this.lblPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPwd.Location = new System.Drawing.Point(3, 20);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(99, 25);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "Password:";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfirmPwd.Location = new System.Drawing.Point(3, 65);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(99, 25);
            this.lblConfirmPwd.TabIndex = 42;
            this.lblConfirmPwd.Text = "Confirm Password:";
            this.lblConfirmPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctrlPWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.tblPWD);
            this.Name = "ctrlPWD";
            this.Size = new System.Drawing.Size(262, 135);
            this.tblPWD.ResumeLayout(false);
            this.tblPWD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPWD;
        public System.Windows.Forms.Label lblErrConfirmPwd;
        public System.Windows.Forms.TextBox txtConfirmPwd;
        public System.Windows.Forms.Label lblErrPwd;
        public System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblConfirmPwd;




    }
}
