using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TEST.UserControl
{
    public partial class ctrl4 : System.Windows.Forms.UserControl
    {       
        #region Variable Declarations

        #endregion

        #region Constructors And Destructors

        public ctrl4()
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
            string str = "How are you, sherry?";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string str1 = "Are you ok?";
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        #region Methods

        public void InitializeControl()
        {
            this.cbo1.SelectedIndex = 0;
            this.txt1.Text = string.Empty;

            this.cbo2.SelectedIndex = 1;
            this.txt2.Text = string.Empty;

            this.cbo3.SelectedIndex = 2;
            this.txt3.Text = string.Empty;

            this.cbo4.SelectedIndex = 3;
            this.txt4.Text = string.Empty;
        }

        #endregion

        #region Events


        #endregion      
    }
}
