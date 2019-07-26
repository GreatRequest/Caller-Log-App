using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caller_Log_App
{
    public partial class callerLogApp : Form
    {
        public callerLogApp()
        {
            InitializeComponent();
        }

        private void pName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                pSecondName_lb.Focus();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(pName, "Provide name");
            }
            else if (string.IsNullOrWhiteSpace(pSecondName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(pSecondName, "Provide Second Name");
            }
            else if (string.IsNullOrWhiteSpace(pNo.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(pNo, "Provide Phone Number");
            }
            else if (string.IsNullOrWhiteSpace(pAddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(pAddress, "Provide Address");
            }
            else if (string.IsNullOrWhiteSpace(status.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(status, "Provide Status");
            }
            else if (string.IsNullOrWhiteSpace(time.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(time, "Provide time of log");
            }
            else if (string.IsNullOrWhiteSpace(duration.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(duration, "Provide call duration");
            }
            else if (string.IsNullOrWhiteSpace(addInfo.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(addInfo, "Provide Additional Infromation");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save this contact now?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }
    }
}
