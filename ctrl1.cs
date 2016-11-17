using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TEST.UserControl
{
    public partial class ctrl1 : System.Windows.Forms.UserControl
    {       
        #region Variable Declarations

        #endregion

        #region Constructors And Destructors

        public ctrl1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            obj_ctrlStaff = new ctrlStaff();
            obj_ctrlStaff.tblSave.Controls.Add(this);
            this.InitializeControl();

        }

        #endregion

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        #region Methods

        public void InitializeControl()
        {
            this.cbo1.SelectedIndex = 0;
            this.txt1.Text = string.Empty;
            this.lblErrTxt1.Visible = false;
        }

        #endregion

        #region Events


        #endregion      
    }
}
