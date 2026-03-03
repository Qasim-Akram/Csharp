using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.views;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.forms
{
    public partial class mainform : Form
    {
        private Button activeButton;
        private DashboardView dashboardView;
        private product productsView;

        public mainform()
        {
            InitializeComponent();
            // wire sidebar buttons
            this.btndashboard.Click += btndashboard_Click;
            this.btnproducts.Click += btnproducts_Click;
            this.btnlogs.Click += button3_Click; // keep existing handler
            // set default view
            this.Load += mainform_Load;
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlsidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flpleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {
            // show dashboard by default
            ShowDashboard();
        }

        private void ShowControl(UserControl ctrl)
        {
            if (ctrl == null) return;
            this.pnlcontent.Controls.Clear();
            ctrl.Dock = DockStyle.Fill;
            this.pnlcontent.Controls.Add(ctrl);
        }

        private void ShowDashboard()
        {
            if (dashboardView == null)
                dashboardView = new DashboardView();
            ShowControl(dashboardView);
            SetActiveButton(btndashboard);
        }

        private void ShowProducts()
        {
            if (productsView == null)
                productsView = new product();
            ShowControl(productsView);
            SetActiveButton(btnproducts);
        }

        private void SetActiveButton(Button btn)
        {
            // reset previous
            if (activeButton != null)
            {
                activeButton.BackColor = SystemColors.Control;
                activeButton.ForeColor = SystemColors.ControlText;
            }

            activeButton = btn;
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(64, 64, 64); // darker
                activeButton.ForeColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
