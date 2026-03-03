namespace MYStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadControl(UserControl control)
        {
            panelFill.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelFill.Controls.Add(control);
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            LoadControl(new DashboardControl());
        }
    }
}
