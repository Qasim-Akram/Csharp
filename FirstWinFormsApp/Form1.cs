using System;
using System.Drawing;
using System.Windows.Forms;

namespace FirstWinFormsApp
{
    public partial class Form1 : Form
    {
        private Panel sidebar;
        private Panel header;
        private Panel contentPanel;

        public Form1()
        {
            InitializeComponent();
            BuildLayout();
        }

        private void BuildLayout()
        {
            // ===== FORM SETTINGS =====
            this.Text = "MiniStore BackOffice";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            // ===== SIDEBAR =====
            sidebar = new Panel();
            sidebar.Width = 200;
            sidebar.Dock = DockStyle.Left;
            sidebar.BackColor = Color.FromArgb(45, 45, 48);
            this.Controls.Add(sidebar);

            // ===== HEADER =====
            header = new Panel();
            header.Height = 80;
            header.Dock = DockStyle.Top;
            header.BackColor = Color.FromArgb(30, 30, 30);
            this.Controls.Add(header);

            Label title = new Label();
            title.Text = "MiniStore BackOffice";
            title.ForeColor = Color.White;
            title.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            title.AutoSize = true;
            title.Location = new Point(20, 20);
            header.Controls.Add(title);

            // ===== CONTENT PANEL =====
            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = Color.WhiteSmoke;
            this.Controls.Add(contentPanel);

            // ===== SIDEBAR BUTTONS =====
            string[] menuItems = 
            { 
                "Dashboard", 
                "Products", 
                "Orders", 
                "Reports", 
                "Sync", 
                "Logs", 
                "Settings" 
            };

            int topPosition = 100;

            foreach (string item in menuItems)
            {
                Button btn = new Button();
                btn.Text = item;
                btn.Width = 180;
                btn.Height = 40;
                btn.Left = 10;
                btn.Top = topPosition;
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.White;
                btn.BackColor = Color.FromArgb(28, 28, 28);
                btn.FlatAppearance.BorderSize = 0;

                btn.Click += MenuButton_Click;

                sidebar.Controls.Add(btn);

                topPosition += 50;
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            contentPanel.Controls.Clear();

            Label contentLabel = new Label();
            contentLabel.Text = clickedButton.Text + " Page";
            contentLabel.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            contentLabel.AutoSize = true;
            contentLabel.Location = new Point(50, 50);

            contentPanel.Controls.Add(contentLabel);
        }
    }
}
