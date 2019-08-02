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
    public partial class CallLoggingSearch : Form
    {
        public CallLoggingSearch()
        {
            InitializeComponent();
            errMsg.Text = "";
        }
        private void Read_Data_FormClosing(object sender, FormClosingEventArgs e)
        {
            CallLoggingTool cla = new CallLoggingTool();
            cla.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            string qry = @"SELECT * FROM callmanagment WHERE date = '" + date.Value.ToString("yyyy-MM-dd") + "'";
            callLogDT.AutoGenerateColumns = false;
            callLogDT.DataSource = cn.Select(qry);
            if (callLogDT.Rows.Count <= 0)
            {
                errMsg.ForeColor = System.Drawing.Color.Red;
                errMsg.Text = "No Data Retrieved";
            }
            else
            {
                errMsg.ForeColor = System.Drawing.Color.ForestGreen;
                errMsg.Text = "Data Retrieved Successfully";
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddForm_Click(object sender, EventArgs e)
        {
            CallLoggingTool cla = new CallLoggingTool();
            this.Close();
        }
    }
}
