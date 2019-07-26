namespace Caller_Log_App
{
    partial class callerLogApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(callerLogApp));
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.save = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.containerOne = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.addInfo_lb = new System.Windows.Forms.Label();
            this.duration_lb = new System.Windows.Forms.Label();
            this.time_lb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.status_lb = new System.Windows.Forms.Label();
            this.pAddress_lb = new System.Windows.Forms.Label();
            this.pNo_lb = new System.Windows.Forms.Label();
            this.pSecondName_lb = new System.Windows.Forms.Label();
            this.pName_lb = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.addInfo = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.pAddress = new System.Windows.Forms.TextBox();
            this.pNo = new System.Windows.Forms.TextBox();
            this.pSecondName = new System.Windows.Forms.TextBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mainContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.containerOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            resources.ApplyResources(this.mainContainer, "mainContainer");
            this.mainContainer.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.mainContainer.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.mainContainer.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.mainContainer.Name = "mainContainer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.save, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.save, "save");
            this.save.Name = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.containerOne, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // containerOne
            // 
            this.containerOne.Controls.Add(this.date);
            this.containerOne.Controls.Add(this.addInfo_lb);
            this.containerOne.Controls.Add(this.duration_lb);
            this.containerOne.Controls.Add(this.time_lb);
            this.containerOne.Controls.Add(this.date_lb);
            this.containerOne.Controls.Add(this.status_lb);
            this.containerOne.Controls.Add(this.pAddress_lb);
            this.containerOne.Controls.Add(this.pNo_lb);
            this.containerOne.Controls.Add(this.pSecondName_lb);
            this.containerOne.Controls.Add(this.pName_lb);
            this.containerOne.Controls.Add(this.status);
            this.containerOne.Controls.Add(this.addInfo);
            this.containerOne.Controls.Add(this.duration);
            this.containerOne.Controls.Add(this.time);
            this.containerOne.Controls.Add(this.pAddress);
            this.containerOne.Controls.Add(this.pNo);
            this.containerOne.Controls.Add(this.pSecondName);
            this.containerOne.Controls.Add(this.pName);
            resources.ApplyResources(this.containerOne, "containerOne");
            this.containerOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.containerOne.Name = "containerOne";
            this.containerOne.TabStop = false;
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            // 
            // addInfo_lb
            // 
            resources.ApplyResources(this.addInfo_lb, "addInfo_lb");
            this.addInfo_lb.Name = "addInfo_lb";
            // 
            // duration_lb
            // 
            resources.ApplyResources(this.duration_lb, "duration_lb");
            this.duration_lb.Name = "duration_lb";
            // 
            // time_lb
            // 
            resources.ApplyResources(this.time_lb, "time_lb");
            this.time_lb.Name = "time_lb";
            // 
            // date_lb
            // 
            resources.ApplyResources(this.date_lb, "date_lb");
            this.date_lb.Name = "date_lb";
            // 
            // status_lb
            // 
            resources.ApplyResources(this.status_lb, "status_lb");
            this.status_lb.Name = "status_lb";
            // 
            // pAddress_lb
            // 
            resources.ApplyResources(this.pAddress_lb, "pAddress_lb");
            this.pAddress_lb.Name = "pAddress_lb";
            // 
            // pNo_lb
            // 
            resources.ApplyResources(this.pNo_lb, "pNo_lb");
            this.pNo_lb.Name = "pNo_lb";
            // 
            // pSecondName_lb
            // 
            resources.ApplyResources(this.pSecondName_lb, "pSecondName_lb");
            this.pSecondName_lb.Name = "pSecondName_lb";
            // 
            // pName_lb
            // 
            resources.ApplyResources(this.pName_lb, "pName_lb");
            this.pName_lb.Name = "pName_lb";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            resources.GetString("status.Items"),
            resources.GetString("status.Items1")});
            resources.ApplyResources(this.status, "status");
            this.status.Name = "status";
            // 
            // addInfo
            // 
            this.addInfo.AcceptsReturn = true;
            this.addInfo.AcceptsTab = true;
            resources.ApplyResources(this.addInfo, "addInfo");
            this.addInfo.Name = "addInfo";
            // 
            // duration
            // 
            resources.ApplyResources(this.duration, "duration");
            this.duration.Name = "duration";
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.Name = "time";
            // 
            // pAddress
            // 
            resources.ApplyResources(this.pAddress, "pAddress");
            this.pAddress.Name = "pAddress";
            // 
            // pNo
            // 
            resources.ApplyResources(this.pNo, "pNo");
            this.pNo.Name = "pNo";
            // 
            // pSecondName
            // 
            resources.ApplyResources(this.pSecondName, "pSecondName");
            this.pSecondName.Name = "pSecondName";
            // 
            // pName
            // 
            resources.ApplyResources(this.pName, "pName");
            this.pName.Name = "pName";
            this.pName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pName_KeyDown);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Caller_Log_App.Properties.Resources.logo_collection_unlock_logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // callerLogApp
            // 
            this.AcceptButton = this.save;
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "callerLogApp";
            this.mainContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.containerOne.ResumeLayout(false);
            this.containerOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox containerOne;
        private System.Windows.Forms.Label pName_lb;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.TextBox addInfo;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox pAddress;
        private System.Windows.Forms.TextBox pNo;
        private System.Windows.Forms.TextBox pSecondName;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label addInfo_lb;
        private System.Windows.Forms.Label duration_lb;
        private System.Windows.Forms.Label time_lb;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.Label status_lb;
        private System.Windows.Forms.Label pAddress_lb;
        private System.Windows.Forms.Label pNo_lb;
        private System.Windows.Forms.Label pSecondName_lb;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

