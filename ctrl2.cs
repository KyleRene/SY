using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TEST.UserControl
{
    public partial class ctrl2 : System.Windows.Forms.UserControl
    {       
        #region Variable Declarations

        #endregion

        #region Constructors And Destructors

        public ctrl2()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.Manual;
            //obj_ctrlStaff = new ctrlStaff();
            //obj_ctrlStaff.tblSave.Controls.Add(this);
            this.InitializeControl();
        }

        #endregion

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        #region Methods

        public void InitializeControl()
        {
            this.cbo1.SelectedIndex = 0;
            this.txt1.Text = string.Empty;

            this.cbo2.SelectedIndex = 1;
            this.txt2.Text = string.Empty;
        }

        #endregion

        #region Events


        #endregion      
    }
}
