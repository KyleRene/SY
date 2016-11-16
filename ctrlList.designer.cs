namespace TEST
{
    partial class ctrlList
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.tblList = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblList = new System.Windows.Forms.Label();
            this.pnlGVLlist = new System.Windows.Forms.Panel();
            this.dgvCommon = new System.Windows.Forms.DataGridView();
            this.tblOperation = new System.Windows.Forms.TableLayoutPanel();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            this.tblList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGVLlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommon)).BeginInit();
            this.tblOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.Tan;
            this.pnlList.Controls.Add(this.tblList);
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(581, 442);
            this.pnlList.TabIndex = 0;
            // 
            // tblList
            // 
            this.tblList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tblList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tblList.ColumnCount = 4;
            this.tblList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblList.Controls.Add(this.panel1, 0, 0);
            this.tblList.Controls.Add(this.pnlGVLlist, 1, 3);
            this.tblList.Controls.Add(this.tblOperation, 1, 2);
            this.tblList.Location = new System.Drawing.Point(3, 4);
            this.tblList.Name = "tblList";
            this.tblList.RowCount = 5;
            this.tblList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tblList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblList.Size = new System.Drawing.Size(575, 434);
            this.tblList.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.tblList.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.lblList);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 54);
            this.panel1.TabIndex = 1;
            // 
            // lblList
            // 
            this.lblList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(0, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(569, 54);
            this.lblList.TabIndex = 4;
            this.lblList.Text = "List";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGVLlist
            // 
            this.tblList.SetColumnSpan(this.pnlGVLlist, 2);
            this.pnlGVLlist.Controls.Add(this.dgvCommon);
            this.pnlGVLlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGVLlist.Location = new System.Drawing.Point(23, 113);
            this.pnlGVLlist.Name = "pnlGVLlist";
            this.pnlGVLlist.Size = new System.Drawing.Size(528, 298);
            this.pnlGVLlist.TabIndex = 0;
            // 
            // dgvCommon
            // 
            this.dgvCommon.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCommon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommon.Location = new System.Drawing.Point(0, 0);
            this.dgvCommon.Name = "dgvCommon";
            this.dgvCommon.Size = new System.Drawing.Size(528, 298);
            this.dgvCommon.TabIndex = 3;
            // 
            // tblOperation
            // 
            this.tblOperation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tblOperation.ColumnCount = 2;
            this.tblOperation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblOperation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tblOperation.Controls.Add(this.chkSelectAll, 0, 0);
            this.tblOperation.Controls.Add(this.btnSave, 1, 0);
            this.tblOperation.Location = new System.Drawing.Point(23, 78);
            this.tblOperation.Name = "tblOperation";
            this.tblOperation.RowCount = 1;
            this.tblOperation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOperation.Size = new System.Drawing.Size(179, 29);
            this.tblOperation.TabIndex = 2;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(3, 6);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chkSelectAll.TabIndex = 1;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(100, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Delete";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // ctrlList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.pnlList);
            this.Name = "ctrlList";
            this.Size = new System.Drawing.Size(581, 442);
            this.pnlList.ResumeLayout(false);
            this.tblList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlGVLlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommon)).EndInit();
            this.tblOperation.ResumeLayout(false);
            this.tblOperation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.TableLayoutPanel tblList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Panel pnlGVLlist;
        private System.Windows.Forms.DataGridView dgvCommon;
        private System.Windows.Forms.TableLayoutPanel tblOperation;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnSave;




    }
}
