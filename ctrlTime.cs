using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TEST.UserControl
{
    public partial class ctrlTime : System.Windows.Forms.UserControl
    {
        #region Variable Declarations

        private Boolean bIsCorrectFormat;
        public event KeyEventHandler DmDropDownKeyDownEventStartTime;       
        public event EventHandler TextBoxTextChangedEventStartTimeHr;
        
        #endregion

        #region Constructors and Destructors

        public ctrlTime()
        {
            InitializeComponent();
            this.BindDomainDropDown();
            this.ClearData();
        }

        #endregion

        #region Get And Set Properties

        public TextBox TextBoxStartTimeHr
        {
            get { return this.txtStartTimeHr; }
            set { this.txtStartTimeHr = value; }
        }
               
        public TextBox TextBoxStartTimeMin
        {
            get { return this.txtStartTimeMin; }
            set { this.txtStartTimeMin = value; }
        }

        public DomainUpDown DmUpDownStartTime
        {
            get { return this.dmStartTime; }
            set { this.dmStartTime = value; }
        }

        #endregion

        #region Methods

        private void ClearData()
        {
            this.txtStartTimeHr.Text = "00";
            this.txtStartTimeMin.Text = "00";
            this.dmStartTime.SelectedIndex = 0;
            this.dmStartTime.ReadOnly = true;
        }

        private void BindDomainDropDown()
        {
            this.dmStartTime.Items.Insert(0, "AM");
            this.dmStartTime.Items.Insert(1, "PM");

        }

        private bool IsCorrectFormat(string Text, System.Windows.Forms.KeyEventArgs e)
        {
            bool bValid = true;
            // Determine whether the keystroke is a backspace or delete or enter
            if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete && e.KeyCode != Keys.Enter)
            {
                //	number keystrokes  from the keypad and number keystrokes from the top of the keyboard
                if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9))
                {
                    // A non-numerical keystroke was pressed so set the flag to false
                    bValid = false;
                }
            }
            return bValid;
        }

        private void SetStartTimeHrByDomainUpDown()
        {
            if (this.txtStartTimeHr.Text.Trim() != string.Empty)
            {               
                if (this.dmStartTime.SelectedIndex == 0)
                {
                    if (Convert.ToInt32(this.txtStartTimeHr.Text.Trim()) > 23)
                        this.txtStartTimeHr.Text = (0).ToString();
                    else
                    {
                        if(Convert.ToInt32(this.txtStartTimeHr.Text.Trim()) >= 12)
                            this.txtStartTimeHr.Text = Convert.ToString(Convert.ToInt32(this.txtStartTimeHr.Text.Trim()) - 12);
                    }
                }
                else
                {
                    if(Convert.ToInt32(this.txtStartTimeHr.Text.Trim()) < 12)
                        this.txtStartTimeHr.Text = Convert.ToString(Convert.ToInt32(this.txtStartTimeHr.Text.Trim()) + 12);
                } 

            }
            if (this.txtStartTimeHr.TextLength < 2)
                this.txtStartTimeHr.Text = this.txtStartTimeHr.Text.Trim().PadLeft(2, '0');

        }

        private void SetStartTimeHr()
        {
            if (this.txtStartTimeHr.Text.Trim() != string.Empty)
            {
                if (Convert.ToInt32(this.txtStartTimeHr.Text.Trim()) > 23)
                {
                    this.txtStartTimeHr.Text = (0).ToString();
                    this.dmStartTime.SelectedIndex = 0;
                }
                else
                {
                    if (Convert.ToInt32(this.txtStartTimeHr.Text.Trim()) >= 12)
                        this.dmStartTime.SelectedIndex = 1;
                    else
                        this.dmStartTime.SelectedIndex = 0;
                }

            }
            if (this.txtStartTimeHr.TextLength < 2)
                this.txtStartTimeHr.Text = this.txtStartTimeHr.Text.Trim().PadLeft(2, '0');

        }

        private void SetStartTimeMin()
        {
            if (this.txtStartTimeMin.Text.Trim() != string.Empty)
            {
                if (Convert.ToInt32(this.txtStartTimeMin.Text.Trim()) > 60)
                    this.txtStartTimeMin.Text = (0).ToString();

                if (Convert.ToInt32(this.txtStartTimeMin.Text.Trim()) == 60)
                {
                    this.txtStartTimeMin.Text = (0).ToString();
                    this.txtStartTimeHr.Text = Convert.ToString(Convert.ToInt32(this.txtStartTimeHr.Text.Trim()) + 1);
                    this.SetStartTimeHr();
                }
            }
            if (this.txtStartTimeMin.TextLength < 2)
                this.txtStartTimeMin.Text = this.txtStartTimeMin.Text.Trim().PadLeft(2, '0');

        }

        #endregion

        #region Events

        private void txtStartTimeHr_KeyDown(object sender, KeyEventArgs e)
        {
            this.bIsCorrectFormat = this.IsCorrectFormat(this.txtStartTimeHr.Text.Trim(), e);
        }

        private void txtStartTimeHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.bIsCorrectFormat == false)
                e.Handled = true;
            if (e.KeyChar == (Char)Keys.Enter)
                this.txtStartTimeMin.Focus();

        }

        private void txtStartTimeHr_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.txtStartTimeHr.TextLength == 2 && this.txtStartTimeHr.Text.Trim() != "00")
                this.txtStartTimeMin.Focus();
        }

        private void txtStartTimeHr_Leave(object sender, EventArgs e)
        {
            this.SetStartTimeHr();
        }

        private void txtStartTimeMin_KeyDown(object sender, KeyEventArgs e)
        {
            this.bIsCorrectFormat = this.IsCorrectFormat(this.txtStartTimeMin.Text.Trim(), e);
        }

        private void txtStartTimeMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (this.bIsCorrectFormat == false)
                e.Handled = true;
            if (e.KeyChar == (Char)Keys.Enter)
                this.dmStartTime.Focus();

        }

        private void txtStartTimeMin_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.txtStartTimeMin.TextLength == 2 &&
                    this.txtStartTimeMin.Text.Trim() != "00")
                this.dmStartTime.Focus();
        }

        private void txtStartTimeMin_Leave(object sender, EventArgs e)
        {
            this.SetStartTimeMin();
        }    
        
        private void dmStartTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                //this.txtEndTimeHr.Focus();
            if (this.DmDropDownKeyDownEventStartTime != null)
                this.DmDropDownKeyDownEventStartTime(sender, e);

        }

        private void dmStartTime_SelectedItemChanged(object sender, EventArgs e)
        {
            //if (this.TextBoxTextChangedEventStartTimeHr != null)
            //    this.TextBoxTextChangedEventStartTimeHr(sender, e);
            this.SetStartTimeHrByDomainUpDown();
        }

        private void txtStartTimeHr_TextChanged(object sender, EventArgs e)
        {
            if (this.TextBoxTextChangedEventStartTimeHr != null)
                this.TextBoxTextChangedEventStartTimeHr(sender, e);
            //if (this.txtStartTimeHr.Text.Trim() == String.Empty)
            //    this.txtStartTimeHr.Text = "00";
        }

        private void txtStartTimeMin_TextChanged(object sender, EventArgs e)
        {
            if (this.TextBoxTextChangedEventStartTimeHr != null)
                this.TextBoxTextChangedEventStartTimeHr(sender, e);
            //if (this.txtStartTimeMin.Text.Trim() == String.Empty)
            //    this.txtStartTimeMin.Text = "00";

        }

        #endregion      
               
    }
}
