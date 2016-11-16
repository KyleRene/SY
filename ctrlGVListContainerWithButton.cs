using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;


namespace TEST
{
    public class ctrlGVListContainerWithButton : DataGridView
    {
        #region Variable Declarations

        private Int32 iVisibleColCount = 0;
        private Int32 iVisibleFirstColIndex = 0;
        private Int32 iVisibleLastColIndex = 0;
        #endregion

        #region Constructors and Destructors

        public ctrlGVListContainerWithButton()
        { 
            
        }

        #endregion

        #region Methods

        private void CountVisibleCol()
        {
            this.iVisibleColCount = 0;
            this.iVisibleFirstColIndex = 0;
            this.iVisibleLastColIndex = 0;
            for (int i = 0; i < this.Columns.Count; i++)
            {
                if (this[i, this.CurrentCell.RowIndex].Visible == true)
                {
                    this.iVisibleColCount++;

                    if (this.iVisibleColCount == 1)
                        this.iVisibleFirstColIndex = i;

                    this.iVisibleLastColIndex = i;

                }
            }
        }

        //protected override bool ProcessDialogKey(Keys keyData)
        //{
        //    if (keyData == Keys.Enter)
        //    {
        //        if (this["ShiftDetailCode", this.CurrentCell.RowIndex].EditedFormattedValue.ToString() == String.Empty)
        //        {
        //            this.CurrentCell = this["ShiftDetailCode", this.CurrentCell.RowIndex];
        //            UIGlobal.Common.ShowMessageBox(Common.MessageType.Warning, AppExceptionMessage.ShiftDetail.sInvalidShiftDetail);
        //        }
        //        else
        //        {
        //            int col = this.CurrentCell.ColumnIndex;
        //            int row = this.CurrentCell.RowIndex;
        //            this.CountVisibleCol();
        //            if (col == (this.iVisibleLastColIndex))
        //            {
        //                row++;
        //                this.CurrentCell = this[this.iVisibleFirstColIndex, row];
        //            }
        //            else
        //            {
        //                do
        //                {
        //                   col++;
        //                }
        //                while (this[col, row].Visible == false ||
        //                            this.Columns[col].Name.Contains("Button") ||
        //                                this.Columns[col].Name.Contains("Separator"));

        //                if (this[col, row].Visible == true)
        //                    this.CurrentCell = this[col, row];

        //            }
        //        }
        //        return true;

        //    }
        //    return base.ProcessDialogKey(keyData);

        //}

        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Enter)
        //    {
        //        if (this["ShiftDetailCode", this.CurrentCell.RowIndex].EditedFormattedValue.ToString() == String.Empty)
        //        {
        //            this.CurrentCell = this["ShiftDetailCode", this.CurrentCell.RowIndex];
        //            //UIGlobal.Common.ShowMessageBox(Common.MessageType.Warning, AppExceptionMessage.ShiftDetail.sInvalidShiftDetail);
        //        }
        //        else
        //        {
        //            int col = this.CurrentCell.ColumnIndex;
        //            int row = this.CurrentCell.RowIndex;
        //            this.CountVisibleCol();
        //            if (col == (this.iVisibleLastColIndex))
        //            {
        //                row++;
        //                this.CurrentCell = this[this.iVisibleFirstColIndex, row];
        //            }
        //            else
        //            {
        //                do
        //                {
        //                    col++;
        //                }
        //                while (this[col, row].Visible == false ||
        //                            this.Columns[col].Name.Contains("Button") ||
        //                                this.Columns[col].Name.Contains("Separator"));

        //                if (this[col, row].Visible == true)
        //                    this.CurrentCell = this[col, row];
        //            }
        //            e.Handled = true;
        //            base.OnKeyDown(e);
        //        }
        //    }

        //    if (e.KeyCode == Keys.Left)
        //    {
        //        int col = this.CurrentCell.ColumnIndex;
        //        int row = this.CurrentCell.RowIndex;
        //        this.CountVisibleCol();
        //        if (col == this.iVisibleFirstColIndex)
        //        {
        //            if (row > 0)
        //                row--;
        //            this.CurrentCell = this[this.iVisibleLastColIndex, row];
        //        }
        //        else
        //        {
        //            do
        //            {
        //               col--;
        //            }
        //            while (this[col, row].Visible == false ||
        //                            this.Columns[col].Name.Contains("Button") ||
        //                                this.Columns[col].Name.Contains("Separator"));

        //            if (this[col, row].Visible == true)
        //                this.CurrentCell = this[col, row];
        //        }
        //        e.Handled = true;
        //        base.OnKeyDown(e);
        //    }
        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        base.OnKeyDown(e);
        //    }

        //}

        #endregion

        #region Events
        #endregion
    }

}
