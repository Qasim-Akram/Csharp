namespace WindowsFormsApp1.forms
{
    partial class mainform
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
            this.pnlheader = new System.Windows.Forms.Panel();
            this.flpright = new System.Windows.Forms.FlowLayoutPanel();
            this.adminpic = new System.Windows.Forms.PictureBox();
            this.Admin = new System.Windows.Forms.Label();
            this.flpleft = new System.Windows.Forms.FlowLayoutPanel();
            this.titlepic = new System.Windows.Forms.PictureBox();
            this.pnlcontent = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pnlsidebar = new System.Windows.Forms.Panel();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnsync = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnlogs = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.pnlheader.SuspendLayout();
            this.flpright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminpic)).BeginInit();
            this.flpleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlepic)).BeginInit();
            this.pnlsidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.Controls.Add(this.flpright);
            this.pnlheader.Controls.Add(this.flpleft);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1009, 93);
            this.pnlheader.TabIndex = 0;
            // 
            // flpright
            // 
            this.flpright.Controls.Add(this.adminpic);
            this.flpright.Controls.Add(this.Admin);
            this.flpright.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpright.Location = new System.Drawing.Point(848, 0);
            this.flpright.Name = "flpright";
            this.flpright.Size = new System.Drawing.Size(161, 93);
            this.flpright.TabIndex = 1;
            this.flpright.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // adminpic
            // 
            this.adminpic.Image = global::WindowsFormsApp1.Properties.Resources.user1;
            this.adminpic.Location = new System.Drawing.Point(3, 3);
            this.adminpic.Name = "adminpic";
            this.adminpic.Size = new System.Drawing.Size(59, 50);
            this.adminpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.adminpic.TabIndex = 1;
            this.adminpic.TabStop = false;
            // 
            // Admin
            // 
            this.Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(68, 0);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(49, 56);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Admin";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpleft
            // 
            this.flpleft.Controls.Add(this.titlepic);
            this.flpleft.Controls.Add(this.title);
            this.flpleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpleft.Location = new System.Drawing.Point(0, 0);
            this.flpleft.Name = "flpleft";
            this.flpleft.Size = new System.Drawing.Size(246, 93);
            this.flpleft.TabIndex = 0;
            // 
            // titlepic
            // 
            this.titlepic.Image = global::WindowsFormsApp1.Properties.Resources.store;
            this.titlepic.Location = new System.Drawing.Point(3, 3);
            this.titlepic.Name = "titlepic";
            this.titlepic.Size = new System.Drawing.Size(81, 50);
            this.titlepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.titlepic.TabIndex = 0;
            this.titlepic.TabStop = false;
            // 
            // pnlcontent
            // 
            this.pnlcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontent.Location = new System.Drawing.Point(0, 93);
            this.pnlcontent.Name = "pnlcontent";
            this.pnlcontent.Size = new System.Drawing.Size(1009, 615);
            this.pnlcontent.TabIndex = 1;
            this.pnlcontent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 686);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1009, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "Ready";
            // 
            // pnlsidebar
            // 
            this.pnlsidebar.Controls.Add(this.btnsettings);
            this.pnlsidebar.Controls.Add(this.btnsync);
            this.pnlsidebar.Controls.Add(this.btnreports);
            this.pnlsidebar.Controls.Add(this.btnorders);
            this.pnlsidebar.Controls.Add(this.btnlogs);
            this.pnlsidebar.Controls.Add(this.btnproducts);
            this.pnlsidebar.Controls.Add(this.btndashboard);
            this.pnlsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsidebar.Location = new System.Drawing.Point(0, 93);
            this.pnlsidebar.Name = "pnlsidebar";
            this.pnlsidebar.Size = new System.Drawing.Size(188, 593);
            this.pnlsidebar.TabIndex = 3;
            // 
            // btnsettings
            // 
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Image = global::WindowsFormsApp1.Properties.Resources.settings;
            this.btnsettings.Location = new System.Drawing.Point(30, 420);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(122, 34);
            this.btnsettings.TabIndex = 6;
            this.btnsettings.Text = "Settings";
            this.btnsettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsettings.UseVisualStyleBackColor = true;
            // 
            // btnsync
            // 
            this.btnsync.FlatAppearance.BorderSize = 0;
            this.btnsync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsync.Image = global::WindowsFormsApp1.Properties.Resources.refresh;
            this.btnsync.Location = new System.Drawing.Point(30, 300);
            this.btnsync.Name = "btnsync";
            this.btnsync.Size = new System.Drawing.Size(122, 34);
            this.btnsync.TabIndex = 5;
            this.btnsync.Text = "Sync";
            this.btnsync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsync.UseVisualStyleBackColor = true;
            // 
            // btnreports
            // 
            this.btnreports.FlatAppearance.BorderSize = 0;
            this.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreports.Image = global::WindowsFormsApp1.Properties.Resources.reportanalytics;
            this.btnreports.Location = new System.Drawing.Point(30, 240);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(122, 34);
            this.btnreports.TabIndex = 1;
            this.btnreports.Text = "Reports";
            this.btnreports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreports.UseVisualStyleBackColor = true;
            // 
            // btnorders
            // 
            this.btnorders.FlatAppearance.BorderSize = 0;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.Image = global::WindowsFormsApp1.Properties.Resources.truck;
            this.btnorders.Location = new System.Drawing.Point(30, 180);
            this.btnorders.Name = "btnorders";
            this.btnorders.Size = new System.Drawing.Size(122, 34);
            this.btnorders.TabIndex = 4;
            this.btnorders.Text = "Orders";
            this.btnorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnorders.UseVisualStyleBackColor = true;
            // 
            // btnlogs
            // 
            this.btnlogs.FlatAppearance.BorderSize = 0;
            this.btnlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogs.Image = global::WindowsFormsApp1.Properties.Resources.logs;
            this.btnlogs.Location = new System.Drawing.Point(30, 360);
            this.btnlogs.Name = "btnlogs";
            this.btnlogs.Size = new System.Drawing.Size(122, 34);
            this.btnlogs.TabIndex = 3;
            this.btnlogs.Text = "Logs";
            this.btnlogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogs.UseVisualStyleBackColor = true;
            this.btnlogs.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.FlatAppearance.BorderSize = 0;
            this.btnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducts.Image = global::WindowsFormsApp1.Properties.Resources.products;
            this.btnproducts.Location = new System.Drawing.Point(30, 120);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(122, 34);
            this.btnproducts.TabIndex = 2;
            this.btnproducts.Text = "Products";
            this.btnproducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproducts.UseVisualStyleBackColor = true;
            // 
            // btndashboard
            // 
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Image = global::WindowsFormsApp1.Properties.Resources.dashboard;
            this.btndashboard.Location = new System.Drawing.Point(30, 60);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(122, 34);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(90, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(144, 56);
            this.title.TabIndex = 3;
            this.title.Text = "Ministore-Backoffice";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 708);
            this.Controls.Add(this.pnlsidebar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlcontent);
            this.Controls.Add(this.pnlheader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.pnlheader.ResumeLayout(false);
            this.flpright.ResumeLayout(false);
            this.flpright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminpic)).EndInit();
            this.flpleft.ResumeLayout(false);
            this.flpleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlepic)).EndInit();
            this.pnlsidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Panel pnlcontent;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel pnlsidebar;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnsync;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnlogs;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.FlowLayoutPanel flpright;
        private System.Windows.Forms.FlowLayoutPanel flpleft;
        private System.Windows.Forms.PictureBox adminpic;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.PictureBox titlepic;
        private System.Windows.Forms.Label title;
    }
}