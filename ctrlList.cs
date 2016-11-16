using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TEST
{
    public partial class ctrlList : System.Windows.Forms.UserControl
    {
        #region Variable Declarations

        private int iVisibleColCount = 0;
        public event DataGridViewCellEventHandler GridCellClick;
        public event DataGridViewCellMouseEventHandler GridCellMouseClick;     

        #endregion     
  
        #region Constructors And Destructors

        public ctrlList()
        {
            InitializeComponent();
            this.SetGridView();
        }      

        #endregion

        #region Methods

        public DataGridView GridViewCommon
        {
            get { return this.dgvCommon; }
            set { this.dgvCommon = value; }
        }

        private void SetGridView()
        {
            //this.dgvCommon.AllowUserToAddRows = false;
            //this.dgvCommon.AllowUserToDeleteRows = false;
            //this.dgvCommon.AllowUserToOrderColumns = false;
            //this.dgvCommon.AllowUserToResizeColumns = false;
            //this.dgvCommon.AllowUserToResizeRows = false;
            //this.dgvCommon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(((int)(byte)(192)), ((int)(byte)(255)), ((int)(byte)(192)));

            //this.dgvCommon.BackgroundColor = Color.FromArgb(((int)(byte)(165)), ((int)(byte)(189)), ((int)(byte)(252)));

            ////this.dgvCommon.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            //this.dgvCommon.CellBorderStyle = DataGridViewCellBorderStyle.Raised;

            //this.dgvCommon.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);


            //this.dgvCommon.ReadOnly = true;
            ////this.dgvCommon.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //this.dgvCommon.RowHeadersVisible = false;

            //this.dgvCommon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            //----
            this.dgvCommon.AllowUserToAddRows = false;
            this.dgvCommon.AllowUserToDeleteRows = false;
            this.dgvCommon.AllowUserToOrderColumns = false;
            this.dgvCommon.AllowUserToResizeColumns = false;
            this.dgvCommon.AllowUserToResizeRows = false;
            this.dgvCommon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(((int)(byte)(192)), ((int)(byte)(255)), ((int)(byte)(192)));

            //this.dgvCommon.BackgroundColor = Color.FromArgb(((int)(byte)(165)), ((int)(byte)(189)), ((int)(byte)(252)));

            this.dgvCommon.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvCommon.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);

            this.dgvCommon.ReadOnly = true;
            this.dgvCommon.RowHeadersVisible = false;

            this.dgvCommon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void BindDataGridView(DataTable dtCommon)
        {
            this.iVisibleColCount = 0;

            DataTable dt = dtCommon.Clone();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Columns[i].ColumnName.Contains("Is"))
                {
                    dt.Columns[i].DataType = typeof(bool);
                }
            }

            //this.dgvCommon = new DataGridView();

            this.dgvCommon.DataSource = dt;

            this.dgvCommon.DataSource = dtCommon;
            for (int i = 0; i < this.dgvCommon.Columns.Count; i++)
            {
                this.dgvCommon.Columns[i].DataPropertyName = this.dgvCommon.Columns[i].Name;

                if (!this.dgvCommon.Columns[i].Name.Contains("Is"))
                {
                    this.dgvCommon.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                else
                {
                    this.dgvCommon.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (!this.dgvCommon.Columns[i].Name.Contains("ID"))
                {
                    StringBuilder strBuilder = new StringBuilder();
                    strBuilder.Append((char)this.dgvCommon.Columns[i].Name[0]);

                    for (int j = 1; j < this.dgvCommon.Columns[i].Name.Length; j++)
                    {
                        if (char.IsUpper(this.dgvCommon.Columns[i].Name[j]))
                        {
                            if (!(this.dgvCommon.Columns[i].Name[j - 1].Equals(' '))
                                && !(char.IsUpper(this.dgvCommon.Columns[i].Name[j - 1])))
                            {
                                strBuilder.Append(' ');
                            }
                        }
                        strBuilder.Append((char)this.dgvCommon.Columns[i].Name[j]);
                    }
                    this.dgvCommon.Columns[i].HeaderText = strBuilder.ToString();

                    this.iVisibleColCount++;
                }
                else
                {
                    this.dgvCommon.Columns[i].HeaderText = this.dgvCommon.Columns[i].Name;
                    this.dgvCommon.Columns[i].Visible = false;
                }
            }
            this.AdjustColWidth();

        }

        public void BindDataGridViewWButton(DataTable dtCommon)
        {
            //this.SetButtonGVCheckBox();

            this.iVisibleColCount = 0;

            DataTable dt = dtCommon.Clone();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Columns[i].ColumnName.Contains("Is"))
                {
                    dt.Columns[i].DataType = typeof(bool);
                }
            }

            //this.dgvCommon = new DataGridView();

            this.dgvCommon.DataSource = dt;

            this.dgvCommon.DataSource = dtCommon;
            for (int i = 0; i < this.dgvCommon.Columns.Count; i++)
            {
                this.dgvCommon.Columns[i].DataPropertyName = this.dgvCommon.Columns[i].Name;

                if (!this.dgvCommon.Columns[i].Name.Contains("Is"))
                {
                    this.dgvCommon.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                else
                {
                    this.dgvCommon.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (!this.dgvCommon.Columns[i].Name.Contains("ID"))
                {
                    StringBuilder strBuilder = new StringBuilder();
                    strBuilder.Append((char)this.dgvCommon.Columns[i].Name[0]);

                    for (int j = 1; j < this.dgvCommon.Columns[i].Name.Length; j++)
                    {
                        if (char.IsUpper(this.dgvCommon.Columns[i].Name[j]))
                        {
                            if (!(this.dgvCommon.Columns[i].Name[j - 1].Equals(' '))
                                && !(char.IsUpper(this.dgvCommon.Columns[i].Name[j - 1])))
                            {
                                strBuilder.Append(' ');
                            }
                        }
                        strBuilder.Append((char)this.dgvCommon.Columns[i].Name[j]);
                    }
                    this.dgvCommon.Columns[i].HeaderText = strBuilder.ToString();

                    this.iVisibleColCount++;
                }
                else
                {
                    this.dgvCommon.Columns[i].HeaderText = this.dgvCommon.Columns[i].Name;
                    this.dgvCommon.Columns[i].Visible = false;
                }
            }
            this.AdjustColWidth();

        }

        public void AdjustColWidth()
        {
            if (this.iVisibleColCount > 0)
            {
                for (int i = 0; i < this.dgvCommon.Columns.Count; i++)
                {
                    if (this.dgvCommon.Columns[i].Visible == true)
                    {
                        this.dgvCommon.Columns[i].Width = (this.dgvCommon.Width / this.iVisibleColCount); // -(45 / this.iVisibleColCount);

                        //this.dgvCommon.Columns[i].Width = (this.dgvCommon.Width / this.iVisibleColCount) - (5 / this.iVisibleColCount);
                    }
                }
            }
        }    

        #endregion

        #region Events

        private void dgvCommon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.GridCellClick != null && e.RowIndex > -1)
            {
                this.GridCellClick(sender, e);
            }
        }

        private void dgvCommon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCommon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.GridCellMouseClick != null)
            {
                this.GridCellMouseClick(sender, e);
            }
        }

        #endregion          

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {

        }
   
    }
}