using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Call_Logging_Tool
{
    public partial class CallLoggingTool : Form
    {
        public CallLoggingTool()
        {
            InitializeComponent();
            errMsg.Text = "";
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
            else if (string.IsNullOrWhiteSpace(pTelNo.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(pTelNo, "Provide Phone Number");
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
            else if (string.IsNullOrWhiteSpace(logTime.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(logTime, "Provide time of log");
            }
            else if (string.IsNullOrWhiteSpace(callDuration.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(callDuration, "Provide call duration");
            }
            else if (string.IsNullOrWhiteSpace(addInfo.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(addInfo, "Provide Additional Infromation");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save this contact now?", "Save person's details", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    saveToDB();
                    Clear();
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Form RD = new CallLoggingSearch();
            RD.Show();
            this.Hide();
        }



        void Clear()
        {
            pName.Clear();
            pSecondName.Clear();
            pTelNo.Clear();
            pAddress.Clear();
            status.SelectedIndex = -1; status.Text = "";
            date.Value = DateTime.Now;
            logTime.Clear();
            callDuration.Clear();
            addInfo.Clear();
        }

        void saveToDB()
        {
            Connection cn = new Connection();
            string qry = @"
                INSERT INTO `callmanagment`
                    (
                    `name`, `sec_name`, `mobile`,
                    `address`, `status`, `date`,
                    `time`, `duration`, `notes`
                    )
                VALUES
                    (
                    '" + pName.Text + "', '" + pSecondName.Text + "', '" + pTelNo.Text + @"',
                    '" + pAddress.Text + "', '" + status.Text + "', '" + date.Value.ToString("yyyy-MM-dd") + @"',
                    '" + logTime.Text + "', '" + callDuration.Text + "', '" + addInfo.Text + "'" +
                    ")";
            if (cn.Insert(qry))
            {
                errMsg.ForeColor = System.Drawing.Color.ForestGreen;
                errMsg.Text = "Data Succesfully Saved";
            }
            else
            {
                errMsg.ForeColor = System.Drawing.Color.Red;
                errMsg.Text = "There was an error saving the data";
            }
            
        }



        private void CallerLogApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit the Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
