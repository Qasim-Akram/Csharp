namespace MiniStoreBackOffice
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pbLogoIcon = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoIcon)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            this.SuspendLayout();

            // ─── pnlSidebar ──────────────────────────────────────────
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.btnOrders);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnSync);
            this.pnlSidebar.Controls.Add(this.btnLogs);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 800);
            this.pnlSidebar.TabIndex = 0;

            // ─── pnlLogo ─────────────────────────────────────────────
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlLogo.Controls.Add(this.pbLogoIcon);
            this.pnlLogo.Controls.Add(this.lblAppName);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 80);
            this.pnlLogo.TabIndex = 0;

            // ─── pbLogoIcon ──────────────────────────────────────────
            this.pbLogoIcon.Location = new System.Drawing.Point(15, 24);
            this.pbLogoIcon.Name = "pbLogoIcon";
            this.pbLogoIcon.Size = new System.Drawing.Size(32, 32);
            this.pbLogoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogoIcon.TabIndex = 0;
            this.pbLogoIcon.TabStop = false;

            // ─── lblAppName ──────────────────────────────────────────
            this.lblAppName.AutoSize = false;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblAppName.Location = new System.Drawing.Point(52, 20);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(140, 40);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "MiniStore Back-Office";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ─── btnDashboard ────────────────────────────────────────
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnDashboard.Location = new System.Drawing.Point(0, 90);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 42);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   ●   Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Tag = "Dashboard";

            // ─── btnProducts ─────────────────────────────────────────
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnProducts.Location = new System.Drawing.Point(0, 132);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(200, 42);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "   📦   Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Tag = "Products";

            // ─── btnOrders ───────────────────────────────────────────
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnOrders.Location = new System.Drawing.Point(0, 174);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 42);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "   📋   Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.Tag = "Orders";

            // ─── btnReports ──────────────────────────────────────────
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnReports.Location = new System.Drawing.Point(0, 216);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 42);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "   📊   Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Tag = "Reports";

            // ─── btnSync ─────────────────────────────────────────────
            this.btnSync.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSync.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnSync.Location = new System.Drawing.Point(0, 258);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(200, 42);
            this.btnSync.TabIndex = 5;
            this.btnSync.Text = "   ↻   Sync";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSync.Tag = "Sync";

            // ─── btnLogs ─────────────────────────────────────────────
            this.btnLogs.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnLogs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogs.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnLogs.Location = new System.Drawing.Point(0, 300);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(200, 42);
            this.btnLogs.TabIndex = 6;
            this.btnLogs.Text = "   ⋮   Logs";
            this.btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogs.Tag = "Logs";

            // ─── btnSettings ─────────────────────────────────────────
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnSettings.Location = new System.Drawing.Point(0, 342);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 42);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "   ⚙   Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Tag = "Settings";

            // ─── pnlTop ──────────────────────────────────────────────
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.pbUserIcon);
            this.pnlTop.Controls.Add(this.lblAdmin);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1184, 60);
            this.pnlTop.TabIndex = 1;

            // ─── pbUserIcon ──────────────────────────────────────────
            this.pbUserIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pbUserIcon.Location = new System.Drawing.Point(1090, 15);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(30, 30);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUserIcon.TabIndex = 0;
            this.pbUserIcon.TabStop = false;

            // ─── lblAdmin ────────────────────────────────────────────
            this.lblAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblAdmin.Location = new System.Drawing.Point(1126, 20);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(40, 19);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin";

            // ─── pnlMain ─────────────────────────────────────────────
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1184, 740);
            this.pnlMain.TabIndex = 2;

            // ─── MainForm ────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniStore Back-Office";

            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoIcon)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // ── Designer-visible controls ────────────────────────────────
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox pbLogoIcon;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.Panel pnlMain;
    }
}
