namespace MYStore
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
            panelLeft = new Panel();
            label1 = new Label();
            settingbtn = new Button();
            logsbtn = new Button();
            syncbtn = new Button();
            reportsbtn = new Button();
            productbtn = new Button();
            ordersbtn = new Button();
            dashboardbtn = new Button();
            panelTop = new Panel();
            Adminbtn = new Button();
            panelFill = new Panel();
            panelLeft.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.GrayText;
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(settingbtn);
            panelLeft.Controls.Add(logsbtn);
            panelLeft.Controls.Add(syncbtn);
            panelLeft.Controls.Add(reportsbtn);
            panelLeft.Controls.Add(productbtn);
            panelLeft.Controls.Add(ordersbtn);
            panelLeft.Controls.Add(dashboardbtn);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 510);
            panelLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Impact", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 84);
            label1.TabIndex = 7;
            label1.Text = "MY STORE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // settingbtn
            // 
            settingbtn.FlatAppearance.BorderSize = 0;
            settingbtn.FlatStyle = FlatStyle.Flat;
            settingbtn.Location = new Point(0, 394);
            settingbtn.Name = "settingbtn";
            settingbtn.Size = new Size(200, 51);
            settingbtn.TabIndex = 6;
            settingbtn.Text = "Settings";
            settingbtn.UseVisualStyleBackColor = true;
            // 
            // logsbtn
            // 
            logsbtn.FlatAppearance.BorderSize = 0;
            logsbtn.FlatStyle = FlatStyle.Flat;
            logsbtn.Location = new Point(0, 344);
            logsbtn.Name = "logsbtn";
            logsbtn.Size = new Size(200, 51);
            logsbtn.TabIndex = 5;
            logsbtn.Text = "Logs";
            logsbtn.UseVisualStyleBackColor = true;
            // 
            // syncbtn
            // 
            syncbtn.FlatAppearance.BorderSize = 0;
            syncbtn.FlatStyle = FlatStyle.Flat;
            syncbtn.Location = new Point(0, 294);
            syncbtn.Name = "syncbtn";
            syncbtn.Size = new Size(200, 51);
            syncbtn.TabIndex = 4;
            syncbtn.Text = "Sync";
            syncbtn.UseVisualStyleBackColor = true;
            // 
            // reportsbtn
            // 
            reportsbtn.FlatAppearance.BorderSize = 0;
            reportsbtn.FlatStyle = FlatStyle.Flat;
            reportsbtn.Location = new Point(0, 244);
            reportsbtn.Name = "reportsbtn";
            reportsbtn.Size = new Size(200, 51);
            reportsbtn.TabIndex = 3;
            reportsbtn.Text = "Reports";
            reportsbtn.UseVisualStyleBackColor = true;
            // 
            // productbtn
            // 
            productbtn.FlatAppearance.BorderSize = 0;
            productbtn.FlatStyle = FlatStyle.Flat;
            productbtn.Location = new Point(-2, 145);
            productbtn.Name = "productbtn";
            productbtn.Size = new Size(202, 51);
            productbtn.TabIndex = 2;
            productbtn.Text = "Products";
            productbtn.UseVisualStyleBackColor = true;
            // 
            // ordersbtn
            // 
            ordersbtn.FlatAppearance.BorderSize = 0;
            ordersbtn.FlatStyle = FlatStyle.Flat;
            ordersbtn.Location = new Point(0, 194);
            ordersbtn.Name = "ordersbtn";
            ordersbtn.Size = new Size(200, 51);
            ordersbtn.TabIndex = 1;
            ordersbtn.Text = "Orders";
            ordersbtn.UseVisualStyleBackColor = true;
            // 
            // dashboardbtn
            // 
            dashboardbtn.FlatAppearance.BorderSize = 0;
            dashboardbtn.FlatStyle = FlatStyle.Flat;
            dashboardbtn.Location = new Point(-2, 96);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(202, 51);
            dashboardbtn.TabIndex = 0;
            dashboardbtn.Text = "Dashboard";
            dashboardbtn.UseVisualStyleBackColor = true;
            dashboardbtn.Click += dashboardbtn_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ControlDarkDark;
            panelTop.Controls.Add(Adminbtn);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(200, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(600, 70);
            panelTop.TabIndex = 1;
            // 
            // Adminbtn
            // 
            Adminbtn.Dock = DockStyle.Right;
            Adminbtn.Image = (Image)resources.GetObject("Adminbtn.Image");
            Adminbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Adminbtn.Location = new Point(516, 0);
            Adminbtn.Name = "Adminbtn";
            Adminbtn.Size = new Size(84, 70);
            Adminbtn.TabIndex = 0;
            Adminbtn.Text = "ADMIN";
            Adminbtn.TextAlign = ContentAlignment.MiddleRight;
            Adminbtn.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.BackColor = SystemColors.GrayText;
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(200, 70);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(600, 440);
            panelFill.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            Name = "Form1";
            Text = "Form1";
            panelLeft.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelTop;
        private Panel panelFill;
        private Button logsbtn;
        private Button syncbtn;
        private Button reportsbtn;
        private Button productbtn;
        private Button ordersbtn;
        private Button dashboardbtn;
        private Button settingbtn;
        private Label label1;
        private Button Adminbtn;
    }
}
