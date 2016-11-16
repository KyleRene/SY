using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TEST
{
    public partial class ctrlBTContainer : System.Windows.Forms.UserControl
    {
        public event EventHandler NewButtonClick;
        public event EventHandler EditButtonClick;
        public event EventHandler ExitButtonClick;

        public string strPreTextNew { get; set; }
        public string strPreTextEdit { get; set; }
        public string strPreTextExit { get; set; }

        public ctrlBTContainer()
        {
            InitializeComponent();
            this.InitializeButton();
        }
        public void InitializeButton()
        {
            this.btnNew.Text = "New";
            this.btnEdit.Text = "Edit";
            this.btnExit.Text = "Exit";

            this.strPreTextNew = string.Empty;
            this.strPreTextEdit = string.Empty;
            this.strPreTextExit = string.Empty;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.strPreTextNew = this.btnNew.Text;
            this.strPreTextEdit = this.btnEdit.Text;
            this.strPreTextExit = this.btnExit.Text;

            if (this.btnNew.Text.Equals("New"))
            {
                this.btnNew.Text = "Save";
                this.btnExit.Text = "Cancel";
            }
            if (this.NewButtonClick != null)
            {
                this.NewButtonClick(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.strPreTextNew = this.btnNew.Text;
            this.strPreTextEdit = this.btnEdit.Text;
            this.strPreTextExit = this.btnExit.Text;

            if (this.btnEdit.Text.Equals("Edit"))
            {
                this.btnNew.Text = "Update";
                this.btnEdit.Text = "Delete";
                this.btnExit.Text = "Cancel";
            }

            if (this.EditButtonClick != null)
            {
                this.EditButtonClick(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.strPreTextNew = this.btnNew.Text;
            this.strPreTextEdit = this.btnEdit.Text;
            this.strPreTextExit = this.btnExit.Text;

            if (this.btnExit.Text.Equals("Cancel"))
            {
                this.btnNew.Text = "New";
                this.btnEdit.Text = "Edit";
            }

            if (this.ExitButtonClick != null)
            {
                this.ExitButtonClick(sender, e);
            }
        }
        

    }
}
