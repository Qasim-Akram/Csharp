using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MiniStoreBackOffice
{
    public partial class MainForm : Form
    {
        // ── Color palette (match screenshot) ────────────────────────
        private readonly Color clrSidebar  = Color.FromArgb(240, 240, 240);
        private readonly Color clrSelected = Color.FromArgb(180, 180, 180);
        private readonly Color clrMainBg   = Color.FromArgb(245, 245, 245);
        private readonly Color clrText     = Color.FromArgb(60,  60,  60);
        private readonly Color clrCardBg   = Color.White;

        public MainForm()
        {
            InitializeComponent();
            AttachEvents();
            DrawIcons();
            ShowStartScreen();
        }

        private void AttachEvents()
        {
            btnDashboard.Click += MenuButton_Click;
            btnProducts .Click += MenuButton_Click;
            btnOrders   .Click += MenuButton_Click;
            btnReports  .Click += MenuButton_Click;
            btnSync     .Click += MenuButton_Click;
            btnLogs     .Click += MenuButton_Click;
            btnSettings .Click += MenuButton_Click;
        }

        private void DrawIcons()
        {
            pbLogoIcon.Image = DrawStoreLogo(32, 32);
            pbUserIcon.Image = DrawUserIcon(30, 30);
        }

        private Bitmap DrawStoreLogo(int w, int h)
        {
            var bmp = new Bitmap(w, h);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            using var pen = new Pen(clrText, 2f);
            g.DrawLines(pen, new[] { new Point(w/2-10,h/2-5), new Point(w/2,h/2-12), new Point(w/2+10,h/2-5) });
            g.DrawRectangle(pen, w/2-9, h/2-5, 18, 14);
            g.DrawRectangle(pen, w/2-3, h/2+2, 6, 7);
            return bmp;
        }

        private Bitmap DrawUserIcon(int w, int h)
        {
            var bmp = new Bitmap(w, h);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            using var pen = new Pen(clrText, 2f);
            g.DrawEllipse(pen, w/2-7, 3, 14, 14);
            g.DrawArc(pen, w/2-10, h/2+2, 20, 12, 180, 180);
            return bmp;
        }

        private void MenuButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;
            SelectButton(btn);
            switch (btn.Tag?.ToString())
            {
                case "Dashboard": ShowDashboard(); break;
                default: ShowPlaceholder(btn.Tag?.ToString() ?? ""); break;
            }
        }

        private void SelectButton(Button active)
        {
            foreach (Control c in pnlSidebar.Controls)
                if (c is Button b) b.BackColor = clrSidebar;
            active.BackColor = clrSelected;
        }

        private void ShowStartScreen()
        {
            pnlMain.Controls.Clear();

            var logo = new PictureBox { Image = DrawStoreLogo(100, 100), Size = new Size(100, 100), SizeMode = PictureBoxSizeMode.CenterImage };
            var title = new Label { Text = "MiniStore Back-Office", Font = new Font("Segoe UI", 22, FontStyle.Bold), ForeColor = clrText, AutoSize = true };
            var startBtn = new Button
            {
                Text = "Get Started", Size = new Size(200, 46),
                BackColor = Color.FromArgb(0, 120, 215), ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat, Cursor = Cursors.Hand
            };
            startBtn.FlatAppearance.BorderSize = 0;
            startBtn.Click += (_, _) => { SelectButton(btnDashboard); ShowDashboard(); };

            void Center()
            {
                int cx = pnlMain.ClientSize.Width / 2;
                int cy = pnlMain.ClientSize.Height / 2;
                logo    .Location = new Point(cx - 50, cy - 130);
                title   .Location = new Point(cx - title.PreferredWidth / 2, cy - 20);
                startBtn.Location = new Point(cx - 100, cy + 40);
            }

            pnlMain.Resize += (_, _) => Center();
            pnlMain.Controls.AddRange(new Control[] { logo, title, startBtn });
            Center();
        }

        private void ShowDashboard()
        {
            pnlMain.Controls.Clear();
            var scroll = new Panel { Dock = DockStyle.Fill, AutoScroll = true, BackColor = clrMainBg, Padding = new Padding(20) };

            var statsRow = new FlowLayoutPanel
            {
                AutoSize = true, FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false, BackColor = Color.Transparent, Location = new Point(20, 20)
            };
            statsRow.Controls.Add(StatCard("Sales",   "163"));
            statsRow.Controls.Add(StatCard("Orders",  "33"));
            statsRow.Controls.Add(StatCard("Revenue", "37,356 PKR"));

            var lowStock = SectionPanel("Low Stock", 20, 160, scroll,
                new[] { "Product", "Stock" },
                new[] {
                    new[] { "Notebook",    "2" },
                    new[] { "Water Bottle","4" },
                    new[] { "Backpack",    "7" },
                    new[] { "Headphones",  "5" },
                    new[] { "HDMI Cable",  "5" }
                });

            var recentOrders = SectionPanel("Recent Orders", 20, 440, scroll,
                new[] { "Order #", "Customer", "Total", "Status" },
                new[] {
                    new[] { "MS-1001", "Maryam", "20,471", "Pending" },
                    new[] { "MS-1002", "Maryam", "9,039",  "Paid"    },
                    new[] { "MS-1003", "Zain",   "2,825",  "Pending" },
                    new[] { "MS-1004", "Sara",   "1,442",  "Pending" },
                    new[] { "MS-1005", "Sara",   "13,960", "Paid"    },
                    new[] { "MS-1006", "Ayesha", "3,644",  "Pending" }
                });

            scroll.Controls.Add(statsRow);
            scroll.Controls.Add(lowStock);
            scroll.Controls.Add(recentOrders);
            pnlMain.Controls.Add(scroll);
        }

        private Panel StatCard(string title, string value)
        {
            var card = new Panel { Size = new Size(220, 100), BackColor = clrCardBg, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(0, 0, 15, 0) };
            card.Controls.Add(new Label { Text = title, Location = new Point(15, 15), AutoSize = true, Font = new Font("Segoe UI", 9), ForeColor = Color.Gray });
            card.Controls.Add(new Label { Text = value, Location = new Point(15, 42), AutoSize = true, Font = new Font("Segoe UI", 16, FontStyle.Bold), ForeColor = clrText });
            return card;
        }

        private Panel SectionPanel(string heading, int x, int y, Panel parent, string[] columns, string[][] rows)
        {
            var panel = new Panel
            {
                Location = new Point(x, y),
                Size = new Size(parent.ClientSize.Width - 60, rows.Length * 32 + 90),
                BackColor = clrCardBg, BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            panel.Controls.Add(new Label { Text = heading, Location = new Point(15, 12), AutoSize = true, Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = clrText });

            int colW = Math.Max(1, (panel.Width - 30) / columns.Length);
            var header = new Panel { Location = new Point(10, 45), Size = new Size(panel.Width - 20, 28), BackColor = Color.FromArgb(248, 248, 248) };
            for (int c = 0; c < columns.Length; c++)
                header.Controls.Add(new Label { Text = columns[c], Location = new Point(c * colW + 8, 6), Size = new Size(colW - 4, 18), Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = clrText });
            panel.Controls.Add(header);

            for (int r = 0; r < rows.Length; r++)
            {
                var row = new Panel { Location = new Point(10, 78 + r * 30), Size = new Size(panel.Width - 20, 28), BackColor = r % 2 == 0 ? clrCardBg : Color.FromArgb(250, 250, 250) };
                for (int c = 0; c < rows[r].Length; c++)
                    row.Controls.Add(new Label { Text = rows[r][c], Location = new Point(c * colW + 8, 6), Size = new Size(colW - 4, 18), Font = new Font("Segoe UI", 9), ForeColor = clrText });
                panel.Controls.Add(row);
            }

            parent.Resize += (_, _) =>
            {
                panel.Width = parent.ClientSize.Width - 60;
                int newColW = Math.Max(1, (panel.Width - 30) / columns.Length);
                for (int c = 0; c < header.Controls.Count; c++)
                    header.Controls[c].Location = new Point(c * newColW + 8, 6);
            };

            return panel;
        }

        private void ShowPlaceholder(string name)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new Label { Text = name, Location = new Point(40, 40), AutoSize = true, Font = new Font("Segoe UI", 26, FontStyle.Bold), ForeColor = clrText });
        }
    }
}
