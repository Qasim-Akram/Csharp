namespace MyPocket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTop = new Panel();
            panelLeft = new Panel();
            btnSettings = new Button();
            btnLogs = new Button();
            btnSync = new Button();
            btnReports = new Button();
            btnOrders = new Button();
            btnProducts = new Button();
            btnDashboard = new Button();
            panelFill = new Panel();
            name = new Label();
            admin = new Button();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(admin);
            panelTop.Controls.Add(name);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(598, 87);
            panelTop.TabIndex = 7;
            // 
            // panelLeft
            // 
            panelLeft.BorderStyle = BorderStyle.Fixed3D;
            panelLeft.Controls.Add(btnSettings);
            panelLeft.Controls.Add(btnLogs);
            panelLeft.Controls.Add(btnSync);
            panelLeft.Controls.Add(btnReports);
            panelLeft.Controls.Add(btnOrders);
            panelLeft.Controls.Add(btnProducts);
            panelLeft.Controls.Add(btnDashboard);
            panelLeft.Location = new Point(0, 93);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(132, 261);
            panelLeft.TabIndex = 0;
            panelLeft.Paint += panelLeft_Paint;
            // 
            // btnSettings
            // 
            btnSettings.AutoSize = true;
            btnSettings.BackColor = SystemColors.ControlDark;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(1, 186);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(131, 33);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogs
            // 
            btnLogs.AutoSize = true;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Image = (Image)resources.GetObject("btnLogs.Image");
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(0, 157);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(132, 33);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            btnSync.AutoSize = true;
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Image = (Image)resources.GetObject("btnSync.Image");
            btnSync.ImageAlign = ContentAlignment.MiddleLeft;
            btnSync.Location = new Point(0, 126);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(132, 33);
            btnSync.TabIndex = 4;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.AutoSize = true;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 97);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(132, 33);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            btnOrders.AutoSize = true;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 67);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(132, 33);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.AutoSize = true;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Image = (Image)resources.GetObject("btnProducts.Image");
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(0, 35);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(132, 33);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = true;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(1, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(131, 39);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.AutoSize = true;
            panelFill.Location = new Point(138, 93);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(460, 261);
            panelFill.TabIndex = 8;
            panelFill.Paint += panel1_Paint;
            // 
            // name
            // 
            name.BorderStyle = BorderStyle.Fixed3D;
            name.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Image = (Image)resources.GetObject("name.Image");
            name.ImageAlign = ContentAlignment.MiddleLeft;
            name.Location = new Point(3, 9);
            name.Name = "name";
            name.Size = new Size(169, 56);
            name.TabIndex = 0;
            name.Text = "Mini Store";
            name.TextAlign = ContentAlignment.MiddleRight;
            name.Click += label1_Click;
            // 
            // admin
            // 
            admin.BackColor = Color.Silver;
            admin.FlatStyle = FlatStyle.Flat;
            admin.Image = (Image)resources.GetObject("admin.Image");
            admin.ImageAlign = ContentAlignment.MiddleLeft;
            admin.Location = new Point(523, 0);
            admin.Name = "admin";
            admin.Size = new Size(75, 23);
            admin.TabIndex = 1;
            admin.Text = "Admin";
            admin.TextAlign = ContentAlignment.MiddleRight;
            admin.UseVisualStyleBackColor = false;
            admin.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(598, 380);
            Controls.Add(panelFill);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "MiniStore";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelTop;
        private Panel panelLeft;
        private Button btnReports;
        private Button btnOrders;
        private Button btnProducts;
        private Button btnDashboard;
        private Button btnSync;
        private Button btnSettings;
        private Button btnLogs;
        private Panel panelFill;
        private Label name;
        private Button admin;
    }
}
