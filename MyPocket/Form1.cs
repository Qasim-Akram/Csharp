namespace MyPocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the Dashboard button!", "Dashboard");
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            panelFill.Controls.Clear();

            DashboardControl dashboard = new DashboardControl();
            dashboard.Dock = DockStyle.Fill;

            panelFill.Controls.Add(dashboard);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
