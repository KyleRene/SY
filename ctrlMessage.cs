using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TEST.UserControl
{
    public partial class ctrlMessage : System.Windows.Forms.UserControl
    {       
        #region Variable Declarations

        private string strCRUD;
        private int iTime;

        #endregion

        #region Constructors And Destructors

        public ctrlMessage(string strCRUD)
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.Manual;
            //obj_ctrlStaff = new ctrlStaff();
            //obj_ctrlStaff.tblSave.Controls.Add(this);
            
            this.tmrMessage.Start();
            this.iTime = 0;

            this.strCRUD = strCRUD;
        }

        #endregion

        #region Methods

        private void Execute(string strCRUD)
        {
            if (iTime < 50)
            {
                iTime = iTime + 1;
                if (iTime == 1)
                {
                    this.tmrMessage.Interval = 25;
                    this.lblMessage.Text = strCRUD + "...";
                }
                else if (iTime == 10)
                {
                    this.tmrMessage.Interval = 25;
                    this.lblMessage.Text = strCRUD + "..";
                }
                else if (iTime == 15)
                {
                    this.tmrMessage.Interval = 25;
                    this.lblMessage.Text = strCRUD + ".";
                }
                else if (iTime == 50)
                {
                    this.Visible = false;
                    this.tmrMessage.Stop();                   
                }
                
            }
            
        }

        #endregion

        #region Events

        private void tmrMessage_Tick(object sender, EventArgs e)
        {
            this.Execute(this.strCRUD);            
        }

        #endregion      
    }
}
