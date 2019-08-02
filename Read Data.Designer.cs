namespace Call_Logging_Tool
{
    partial class CallLoggingSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallLoggingSearch));
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Close = new System.Windows.Forms.Button();
            this.addForm = new System.Windows.Forms.Button();
            this.errMsg = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.containerOne = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.date_lb = new System.Windows.Forms.Label();
            this.callLogDT = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sec_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.containerOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callLogDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 1;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.mainContainer.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 2;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainContainer.Size = new System.Drawing.Size(800, 450);
            this.mainContainer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Controls.Add(this.Close, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.addForm, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.errMsg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.search, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 403);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 44);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Close.Location = new System.Drawing.Point(720, 10);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(71, 24);
            this.Close.TabIndex = 12;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // addForm
            // 
            this.addForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addForm.Location = new System.Drawing.Point(643, 10);
            this.addForm.Name = "addForm";
            this.addForm.Size = new System.Drawing.Size(71, 24);
            this.addForm.TabIndex = 11;
            this.addForm.Text = "Add Record";
            this.addForm.UseVisualStyleBackColor = false;
            this.addForm.Click += new System.EventHandler(this.AddForm_Click);
            // 
            // errMsg
            // 
            this.errMsg.AutoSize = true;
            this.errMsg.ForeColor = System.Drawing.Color.Red;
            this.errMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errMsg.Location = new System.Drawing.Point(3, 7);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(79, 13);
            this.errMsg.TabIndex = 19;
            this.errMsg.Text = "Err Placeholder";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search.Location = new System.Drawing.Point(566, 10);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(71, 24);
            this.search.TabIndex = 10;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.containerOne, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 394);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // containerOne
            // 
            this.containerOne.Controls.Add(this.date);
            this.containerOne.Controls.Add(this.date_lb);
            this.containerOne.Controls.Add(this.callLogDT);
            this.containerOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.containerOne.Location = new System.Drawing.Point(3, 53);
            this.containerOne.Name = "containerOne";
            this.containerOne.Size = new System.Drawing.Size(788, 338);
            this.containerOne.TabIndex = 1;
            this.containerOne.TabStop = false;
            this.containerOne.Text = "Call Log Managment System";
            // 
            // date
            // 
            this.date.CustomFormat = "";
            this.date.Location = new System.Drawing.Point(592, 19);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(190, 20);
            this.date.TabIndex = 20;
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date_lb.Location = new System.Drawing.Point(535, 22);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(51, 13);
            this.date_lb.TabIndex = 21;
            this.date_lb.Text = "Log Date";
            // 
            // callLogDT
            // 
            this.callLogDT.AllowUserToAddRows = false;
            this.callLogDT.AllowUserToOrderColumns = true;
            this.callLogDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.callLogDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.sec_name,
            this.address,
            this.mobile,
            this.dataGridViewTextBoxColumn1,
            this.time,
            this.duration,
            this.notes,
            this.dataGridViewTextBoxColumn2});
            this.callLogDT.Location = new System.Drawing.Point(6, 45);
            this.callLogDT.Name = "callLogDT";
            this.callLogDT.Size = new System.Drawing.Size(776, 287);
            this.callLogDT.TabIndex = 19;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 60;
            // 
            // sec_name
            // 
            this.sec_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sec_name.DataPropertyName = "sec_name";
            this.sec_name.HeaderText = "Second Name";
            this.sec_name.Name = "sec_name";
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.Width = 70;
            // 
            // mobile
            // 
            this.mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "Mobile No.";
            this.mobile.Name = "mobile";
            this.mobile.Width = 83;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.Width = 55;
            // 
            // duration
            // 
            this.duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.duration.DataPropertyName = "duration";
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            this.duration.Width = 72;
            // 
            // notes
            // 
            this.notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.notes.DataPropertyName = "notes";
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn2.HeaderText = "Status";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Call_Logging_Tool.Properties.Resources.logo_collection_unlock_logo;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CallLoggingSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CallLoggingSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Logging Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Read_Data_FormClosing);
            this.mainContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.containerOne.ResumeLayout(false);
            this.containerOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.callLogDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button addForm;
        private System.Windows.Forms.Label errMsg;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox containerOne;
        private System.Windows.Forms.DataGridView callLogDT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sec_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DateTimePicker date;
    }
}