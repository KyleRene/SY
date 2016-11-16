using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.IO;

namespace TEST.UIGlobal
{
    public class Common
    {
        #region Variable Declarations

        private static Int32 iVisibleColCount;
        public static bool IsPreLogInExists = false;
        public static Color BackColorForForm = System.Drawing.Color.LightSteelBlue;
        public static Color BackColorForMDIForm = System.Drawing.Color.WhiteSmoke;
        public static Color BackColorForDetailGrid = System.Drawing.SystemColors.ButtonShadow;
        public static Color BackColorForDetailGridAlternateRow = System.Drawing.Color.GhostWhite;
        public static Color BackColorForDetailGridButton = default(Color);
        public static Color BackColorForDetailGridComboBox = default(Color);


        public enum MessageType
        {
            Information,
            Warning,
            Critical,
            Question
        }

        public static DialogResult ShowMessageBox(MessageType mt, string message)
        {
            DialogResult result = DialogResult.None;
            switch (mt)
            {
                case MessageType.Information:
                    MessageBox.Show(message,
                                        UIGlobal.FormName.sMDIFormName, 
                                            MessageBoxButtons.OK, 
                                                MessageBoxIcon.Information);
                    break;

                case MessageType.Warning:
                    MessageBox.Show(message,
                                        UIGlobal.FormName.sMDIFormName,
                                            MessageBoxButtons.OK, 
                                                MessageBoxIcon.Exclamation);
                    break;
                case MessageType.Critical:
                    MessageBox.Show(message,
                                        UIGlobal.FormName.sMDIFormName,
                                            MessageBoxButtons.OK, 
                                                MessageBoxIcon.Error);
                    break;
                case MessageType.Question:
                result = MessageBox.Show(message, 
                                        UIGlobal.FormName.sMDIFormName,
                                            MessageBoxButtons.YesNo, 
                                                MessageBoxIcon.Question);
                    break;
            }
            return result;
        }

        #endregion     

        #region Public Access Methods

        public static Image DisplayImage(String sImageName)
        {
            return (System.Drawing.Image)TEST.Properties.Resources.ResourceManager.GetObject("Png" + sImageName);
        }

        public static Icon DisplayIcon(String sImageName)
        {
            return (System.Drawing.Icon)TEST.Properties.Resources.ResourceManager.GetObject("Ico" + sImageName);
        }

        public static void SetToolStripMenuItem(String sImageName, ToolStripMenuItem tstCommon)
        {
            tstCommon.Image = DisplayImage(sImageName);
            tstCommon.ImageScaling = ToolStripItemImageScaling.None;
        }       

        public static void SetBrowseButtonDisplay(Button btnParam, String sToolTipText)
        {
            ToolTip tspBrowse = new ToolTip();
            tspBrowse.SetToolTip(btnParam, sToolTipText);
            btnParam.Image = DisplayImage("Browse_16x16x16");
            btnParam.BackgroundImage = DisplayImage("MistyRose_50x50x50");
        }

        public static void SetBrowseButtonDisplay(Button btnParam, String sToolTipText, String sImageName)
        {
            ToolTip tspBrowse = new ToolTip();
            tspBrowse.SetToolTip(btnParam, sToolTipText);
            //btnParam.Image = UIGlobal.Common.DisplayImage(sImageName);
            //btnParam.BackgroundImage = UIGlobal.Common.DisplayImage("MistyRose_50x50x50");
        }

        public static void SetButtonDisplay(Button btnParam, String sButtonText)
        {
            //btnParam.BackgroundImage = UIGlobal.Common.DisplayImage("MistyRose_50x50x50");
            btnParam.Text = sButtonText;
        }

        public static void SetDataGridViewBrowseButtonDisplay(DataGridViewButtonColumn btnParam, String sToolTipText)
        {
            //ToolTip tspBrowse = new ToolTip();
            //tspBrowse.SetToolTip((Button)btnParam, sToolTipText);
            //btnParam.Image = UIGlobal.Common.DisplayImage("Browse_16x16x16");
            //btnParam.BackgroundImage = UIGlobal.Common.DisplayImage("MistyRose_50x50x50");
        }

        public static void SetComboBoxDisplay(ComboBox cboCommon)
        {
            cboCommon.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCommon.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCommon.SelectedValue = 0;
        }

        public static void SetDataGridViewComboBoxDisplay(DataGridViewComboBoxColumn dgvComboBoxCol)
        {
            dgvComboBoxCol.AutoComplete = true;
            dgvComboBoxCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvComboBoxCol.MaxDropDownItems = 10;
            dgvComboBoxCol.DefaultCellStyle.BackColor = UIGlobal.Common.BackColorForDetailGridComboBox;
            dgvComboBoxCol.FlatStyle = FlatStyle.Popup;
            dgvComboBoxCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            dgvComboBoxCol.DisplayStyleForCurrentCellOnly = false;

        }

        public static void SetDateTimePickerDisplay(DateTimePicker dtpCommon)
        {
            dtpCommon.Format = DateTimePickerFormat.Custom;
            dtpCommon.CustomFormat = "dd MMM yyyy";
            dtpCommon.Value = DateTime.Now;
        }

        public static void SetDateTimePickerDisplayNull(DateTimePicker dtpCommon)
        {
            dtpCommon.Format = DateTimePickerFormat.Custom;
            dtpCommon.CustomFormat = "dd MMM yyyy";
            dtpCommon.Value = Convert.ToDateTime("1900-01-01");
        }

        public static Boolean IsCorrectFormatInteger(System.Windows.Forms.KeyEventArgs e)
        {
            bool bValid = true;
            // Determine whether the keystroke is a backspace or delete or enter
            if (e.KeyCode != Keys.Back && 
                    e.KeyCode != Keys.Delete && 
                        e.KeyCode != Keys.Enter)
            {
                //	number keystrokes  from the keypad and number keystrokes from the top of the keyboard
                if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && 
                        (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9))
                {
                    // A non-numerical keystroke was pressed so set the flag to false
                    bValid = false;
                }
            }
            return bValid;
        }

        public static Boolean IsCorrectFormatDecimal(String sText, System.Windows.Forms.KeyEventArgs e)
        {
            bool bValid = true;
            // Determine whether the keystroke is a backspace or delete or enter
            if (e.KeyCode != Keys.Back && 
                    e.KeyCode != Keys.Delete && 
                        e.KeyCode != Keys.Enter)
            {
                // Check decimal keystroke from the keypad or OemPeriod (Decimal) keystroke from the keyboard
                if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
                {
                    if (sText.IndexOf(".") != -1)
                        // A non-numerical keystroke was pressed so set the flag to false
                        bValid = false;
                }
                else
                {
                    //	number keystrokes  from the keypad and number keystrokes from the top of the keyboard
                    if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && 
                            (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9))
                    {
                        // A non-numerical keystroke was pressed so set the flag to false
                        bValid = false;
                    }
                }
            }
            return bValid;
        }

        public static void SetFormDisplayMaximize(Form obj_Form, String sFormName)
        {
            //obj_Form.Icon = UIGlobal.Common.DisplayIcon(UIGlobal.ImageName.sPlanning);
            obj_Form.Size = new Size(800, 600);
            obj_Form.StartPosition = FormStartPosition.CenterScreen;
            obj_Form.WindowState = FormWindowState.Maximized;            
            obj_Form.BackColor = UIGlobal.Common.BackColorForForm;

            obj_Form.Text = sFormName;
        }

        public static void SetFormDisplayNormal(Form obj_Form, String sFormName)
        {
            //obj_Form.Icon = UIGlobal.Common.DisplayIcon(UIGlobal.ImageName.sPlanning);            
            obj_Form.Size = new Size(800, 600);
            obj_Form.StartPosition = FormStartPosition.CenterScreen;
            obj_Form.WindowState = FormWindowState.Normal;
            //obj_Form.BackColor = UIGlobal.Common.BackColorForForm;

            obj_Form.Text = sFormName;
        }

        public static void SetFormDisplayCustom(Form obj_Form, Int32 iFormWidth, Int32 iFormHeight, String sFormName)
        {
            //obj_Form.Icon = UIGlobal.Common.DisplayIcon(UIGlobal.ImageName.sPlanning);
            obj_Form.Size = new Size(iFormWidth, iFormHeight);
            obj_Form.StartPosition = FormStartPosition.CenterScreen;
            obj_Form.WindowState = FormWindowState.Normal;
            //obj_Form.BackColor = UIGlobal.Common.BackColorForForm;
            obj_Form.MaximizeBox = false;

            obj_Form.Text = sFormName;
        }

        public static void SetPictureBoxDisplay(PictureBox pic_Common)
        {
            pic_Common.BackColor = System.Drawing.Color.Thistle;
            pic_Common.BorderStyle = BorderStyle.FixedSingle;
            pic_Common.SizeMode = PictureBoxSizeMode.StretchImage;            
        }           

        public static byte[] ConvertImageToByteArray(System.Drawing.Image imgParam)
        {
            MemoryStream ms = null;
            byte[] byteArrayResult = null;
            try
            {
                ms = new MemoryStream();

                // Save to memory using the Jpeg format
                imgParam.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

                // read to end
                byteArrayResult = ms.GetBuffer();
            }
            catch (Exception ex)
            {
                ShowMessageBox(MessageType.Critical, ex.Message);
            }
            finally
            {
                imgParam.Dispose();
                if (ms != null)
                {
                    ms.Close();
                }
            }
            return byteArrayResult;
        }

        public static Image ConvertByteArrayToImage(Byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            Image imgResult = Image.FromStream(ms); // here gives me error as `parameter is not valid`       

            return imgResult;
        }

        public static void SetGridView(DataGridView dgvCommon)
        {
            dgvCommon.AllowUserToAddRows = false;
            dgvCommon.AllowUserToDeleteRows = false;
            dgvCommon.AllowUserToOrderColumns = false;
            dgvCommon.AllowUserToResizeColumns = true;
            dgvCommon.AllowUserToResizeRows = false;
            dgvCommon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(((int)(byte)(192)), ((int)(byte)(255)), ((int)(byte)(192)));

            //this.dgvCommon.BackgroundColor = Color.FromArgb(((int)(byte)(165)), ((int)(byte)(189)), ((int)(byte)(252)));

            dgvCommon.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvCommon.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);

            dgvCommon.ReadOnly = true;
            dgvCommon.RowHeadersVisible = false;

            dgvCommon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public static void BindDataGridView(DataGridView dgvCommon, 
                                                DataTable dtCommon, 
                                                    string strControlName)
        {
            SetGridView(dgvCommon);
            iVisibleColCount = 0;

            DataTable dt = dtCommon.Clone();

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Columns[i].ColumnName.Contains("Is") ||
                        dt.Columns[i].ColumnName.Contains("MakeYN") ||
                            dt.Columns[i].ColumnName.Contains("Tick"))
                {
                    dt.Columns[i].DataType = typeof(bool);
                }
            }

            dgvCommon.DataSource = dt;

            dgvCommon.DataSource = dtCommon;
            for (int i = 0; i < dgvCommon.Columns.Count; i++)
            {
                dgvCommon.Columns[i].DataPropertyName = dgvCommon.Columns[i].Name;

                if (!(dt.Columns[i].ColumnName.Contains("Is") ||
                        dt.Columns[i].ColumnName.Contains("MakeYN") ||
                            dt.Columns[i].ColumnName.Contains("Tick")))
                {
                    dgvCommon.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                else
                {
                    dgvCommon.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (!(dgvCommon.Columns[i].Name.Contains("ID") ||
                       dgvCommon.Columns[i].Name.Contains("Password") ||
                        dgvCommon.Columns[i].Name.Contains("LoginName")))
                {
                    StringBuilder strBuilder = new StringBuilder();
                    strBuilder.Append((char)dgvCommon.Columns[i].Name[0]);

                    for (int j = 1; j < dgvCommon.Columns[i].Name.Length; j++)
                    {
                        if (char.IsUpper(dgvCommon.Columns[i].Name[j]))
                        {
                            if (!(dgvCommon.Columns[i].Name[j - 1].Equals(' '))
                                && !(char.IsUpper(dgvCommon.Columns[i].Name[j - 1])))
                            {
                                strBuilder.Append(' ');
                            }
                        }
                        strBuilder.Append((char)dgvCommon.Columns[i].Name[j]);
                    }
                    dgvCommon.Columns[i].HeaderText = strBuilder.ToString();

                    iVisibleColCount++;
                    if (dgvCommon.Columns[i].Name.Equals("Tick"))
                    {
                        iVisibleColCount--;
                        dgvCommon.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
                else
                {
                    dgvCommon.Columns[i].HeaderText = dgvCommon.Columns[i].Name;
                    dgvCommon.Columns[i].Visible = false;
                }
            }
            AdjustColWidth(dgvCommon, strControlName);

        }

        public static void AdjustColWidth(DataGridView dgvCommon,
                                        string strControlName)
        {
            if (iVisibleColCount > 0)
            {
                for (int i = 0; i < dgvCommon.Columns.Count; i++)
                {
                    if (dgvCommon.Columns[i].Visible == true)
                    {
                        switch (strControlName)
                        {
                            case UIGlobal.ControlName.sctrlStaff:
                                if (dgvCommon.Columns[i].Name.Equals("StaffNo"))
                                    dgvCommon.Columns[i].HeaderText = "Staff ID";
                                        dgvCommon.Columns[i].Width = (dgvCommon.Width / (iVisibleColCount - 2)); //- (5 / this.iVisibleColCount);
                                break;
                            case UIGlobal.ControlName.sctrlUser:
                                if (dgvCommon.Columns[i].Name.Equals("UserNo"))
                                    dgvCommon.Columns[i].HeaderText = "User ID";
                                dgvCommon.Columns[i].Width = (dgvCommon.Width / (iVisibleColCount - 3)); //- (5 / this.iVisibleColCount);
                                break;
                            case UIGlobal.ControlName.sctrlService:
                                if (dgvCommon.Columns[i].Name.Equals("ServiceNo"))
                                    dgvCommon.Columns[i].HeaderText = "Service ID";
                                if (dgvCommon.Columns[i].Name.Equals("UserNo"))
                                    dgvCommon.Columns[i].HeaderText = "User ID";
                                if (dgvCommon.Columns[i].Name.Equals("StaffNo"))
                                    dgvCommon.Columns[i].HeaderText = "Staff ID";
                                dgvCommon.Columns[i].Width = (dgvCommon.Width / (iVisibleColCount / 2)); //- (5 / this.iVisibleColCount);
                                break;
                            case UIGlobal.FormName.sfrmStaffList:
                                if (dgvCommon.Columns[i].Name.Equals("StaffNo"))
                                    dgvCommon.Columns[i].HeaderText = "Staff ID";
                                dgvCommon.Columns[i].Width = (dgvCommon.Width / (iVisibleColCount - 2)); //- (5 / this.iVisibleColCount);
                                break;
                            case UIGlobal.FormName.sfrmUserList:
                                if (dgvCommon.Columns[i].Name.Equals("UserNo"))
                                    dgvCommon.Columns[i].HeaderText = "User ID";
                                dgvCommon.Columns[i].Width = (dgvCommon.Width / (iVisibleColCount - 2)); //- (5 / this.iVisibleColCount);
                                break;
                            default:
                                dgvCommon.Columns[i].Width = (dgvCommon.Width / iVisibleColCount);

                                if (dgvCommon.Columns[i].Name.Equals("Tick"))
                                    dgvCommon.Columns[i].Width = 60;
                                break;
                        }

                    }
                }
            }
        }

        #endregion
    }

    public class ComboText
    {
        public const String sChooseOne = "<<Choose One>>";
        public const String sChooseAll = "<<Choose All>>";
    }

    public class InfoMessage
    {     
        public const String sAddInfo = "Added Successfully";
        public const String sUpdateInfo = "Updated Successfully";
        public const String sDeleteInfo = "Deleted Successfully";
        public const String sReleaseInfo = "Released Successfully";
        public const String sCloseInfo = "Closed Successfully";
        public const String sSOCloseInfo = "Closed Sales Order Successfully";

    }

    public class QuestionMessage
    {
        public const String sUpdateConfirm = "Are you sure to update?";
        public const String sDeleteConfirm = "Are you sure to delete?";
        public const String sLogOffConfirm = "Are you sure to log off?";
        public const String sExitConfirm = "Are you sure to exit?";
        public const String sCloseConfirm = "Are you sure to close?";
        public const String sCloseSOConfirm = "Are you sure to close the Sales Order in uncompleted status?";
        public const String sInvalidFilePath = "File not found and choose another file instead?";

    }

    public class WarningMessage
    {
        public const String sInValidLogIn = "User Name or Password is incorrect!";
        public const String sUsedInOtherTrans = " as it has been used in other transactions!";
        public const String sOrderQtyLessThanFromInventoryQty = "Order Qty can't be less than Inventory Qty!";
        public const String sCurrentlyNoRecordToBeUpdated = "Currently, no record to be updated!";
        public const String sNoItemsToBeGerenated = "No items to be generated!";        

    }
  
    public class LoginUserInfo
    {
        public static Int32 iUserID = 0;
        public static String sUserName = String.Empty;
        public static String sUserGroupName = String.Empty;
        public static String sServerName = String.Empty;
        public static String sDatabaseName = String.Empty;
        
    }

    public class ControlName
    {
        public const String sctrlUser = "ctrlUser";       
        public const String sctrlDepartment = "ctrlDepartment";
        public const String sctrlPosition = "ctrlPosition";
        public const String sctrlStaff = "ctrlStaff";
        public const String sctrlWorkingDate = "ctrlWorkingDate";
        public const String sctrlAttendance = "ctrlAttendance";
        public const String sctrlService = "ctrlService";
        public const String sctrlServicePlan = "ctrlServicePlan";
        public const String sctrlMarketing = "ctrlMarketing";
        public const String sctrlReport = "ctrlReport";        
    }

    public class MenuItemName
    {
        public const String ststUser = "tstUser";
        public const String ststLogOff = "tstLogOff";
        public const String ststExit = "tstExit";

        public const String ststDepartment = "tstDepartment";
        public const String ststPosition = "tstPosition";

        public const String ststStaff = "tstStaff";
        public const String ststStaffPayroll = "tstStaffPayroll";
        public const String ststAttendance = "tstAttendance";

        public const String ststService = "tstService";
        public const String ststServicePlan = "tstServicePlan";

        public const String ststMarketing = "tstMarketing";
        public const String ststReport = "tstReport";
    }
    public class Paging
    {
        public const int MaxValue = 10;
    }

    public class ButtonText
    {
        
    }

    public class BrowseFormName
    {
        
    }

    public class FormName
    {
        public const String sMDIFormName = "Evo Tech Myanmar";
        public const String sLoginFormName = "User Login";
        public const String sLogOff = "Log Off";
        public const String sExit = "Exit";

        public const String sfrmUserPhone = "frmUserPhone";
        public const String sfrmStaffList = "frmStaffList";
        public const String sfrmUserList = "frmUserList";
        
    }

    public class ImageName
    {
        public const String sLogOff = "LogOff";
        public const String sExit = "Exit";
        
    }

   

}
