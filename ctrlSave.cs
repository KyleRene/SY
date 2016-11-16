using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TEST.UserControl
{
    public partial class ctrlSave : System.Windows.Forms.UserControl
    {

        #region Variable Declarations

        public event EventHandler SaveButtonClick;

        #endregion

        #region Constructors And Destructors

        public ctrlSave()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods
        #endregion

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.SaveButtonClick != null)
                this.SaveButtonClick(sender, e);
        }

        #endregion       

        
    }
}
