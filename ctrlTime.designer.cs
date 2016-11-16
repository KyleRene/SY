namespace TEST.UserControl
{
    partial class ctrlTime
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
            this.tblStartTimeEndTime = new System.Windows.Forms.TableLayoutPanel();
            this.txtStartTimeHr = new System.Windows.Forms.TextBox();
            this.txtStartTimeMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dmStartTime = new System.Windows.Forms.DomainUpDown();
            this.tblStartTimeEndTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblStartTimeEndTime
            // 
            this.tblStartTimeEndTime.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tblStartTimeEndTime.ColumnCount = 5;
            this.tblStartTimeEndTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStartTimeEndTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblStartTimeEndTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStartTimeEndTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblStartTimeEndTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStartTimeEndTime.Controls.Add(this.txtStartTimeHr, 0, 0);
            this.tblStartTimeEndTime.Controls.Add(this.txtStartTimeMin, 2, 0);
            this.tblStartTimeEndTime.Controls.Add(this.label1, 1, 0);
            this.tblStartTimeEndTime.Controls.Add(this.dmStartTime, 4, 0);
            this.tblStartTimeEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStartTimeEndTime.Location = new System.Drawing.Point(0, 0);
            this.tblStartTimeEndTime.Name = "tblStartTimeEndTime";
            this.tblStartTimeEndTime.RowCount = 1;
            this.tblStartTimeEndTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblStartTimeEndTime.Size = new System.Drawing.Size(150, 26);
            this.tblStartTimeEndTime.TabIndex = 0;
            // 
            // txtStartTimeHr
            // 
            this.txtStartTimeHr.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtStartTimeHr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStartTimeHr.Location = new System.Drawing.Point(3, 3);
            this.txtStartTimeHr.MaxLength = 2;
            this.txtStartTimeHr.Name = "txtStartTimeHr";
            this.txtStartTimeHr.Size = new System.Drawing.Size(37, 20);
            this.txtStartTimeHr.TabIndex = 16;
            this.txtStartTimeHr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartTimeHr.TextChanged += new System.EventHandler(this.txtStartTimeHr_TextChanged);
            this.txtStartTimeHr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartTimeHr_KeyDown);
            this.txtStartTimeHr.Leave += new System.EventHandler(this.txtStartTimeHr_Leave);
            this.txtStartTimeHr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStartTimeHr_KeyUp);
            this.txtStartTimeHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartTimeHr_KeyPress);
            // 
            // txtStartTimeMin
            // 
            this.txtStartTimeMin.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtStartTimeMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStartTimeMin.Location = new System.Drawing.Point(56, 3);
            this.txtStartTimeMin.MaxLength = 2;
            this.txtStartTimeMin.Name = "txtStartTimeMin";
            this.txtStartTimeMin.Size = new System.Drawing.Size(37, 20);
            this.txtStartTimeMin.TabIndex = 10;
            this.txtStartTimeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartTimeMin.TextChanged += new System.EventHandler(this.txtStartTimeMin_TextChanged);
            this.txtStartTimeMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartTimeMin_KeyDown);
            this.txtStartTimeMin.Leave += new System.EventHandler(this.txtStartTimeMin_Leave);
            this.txtStartTimeMin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStartTimeMin_KeyUp);
            this.txtStartTimeMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartTimeMin_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(4, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dmStartTime
            // 
            this.dmStartTime.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dmStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dmStartTime.Location = new System.Drawing.Point(109, 3);
            this.dmStartTime.Name = "dmStartTime";
            this.dmStartTime.ReadOnly = true;
            this.dmStartTime.Size = new System.Drawing.Size(38, 20);
            this.dmStartTime.TabIndex = 11;
            this.dmStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dmStartTime.SelectedItemChanged += new System.EventHandler(this.dmStartTime_SelectedItemChanged);
            this.dmStartTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dmStartTime_KeyDown);
            // 
            // ctrlTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblStartTimeEndTime);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlTime";
            this.Size = new System.Drawing.Size(150, 26);
            this.tblStartTimeEndTime.ResumeLayout(false);
            this.tblStartTimeEndTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblStartTimeEndTime;
        public System.Windows.Forms.TextBox txtStartTimeHr;
        public System.Windows.Forms.TextBox txtStartTimeMin;
        private System.Windows.Forms.DomainUpDown dmStartTime;
        private System.Windows.Forms.Label label1;
    }
}
