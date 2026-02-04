using System;
using System.Windows.Forms;

namespace FirstWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Form properties
            this.Text = "My First WinForms App";
            this.Width = 600;
            this.Height = 400;

            // Button logic (event connection)
            Btnclickme.Click += Btnclickme_Click;
        }

        // EVENT HANDLER
        private void Btnclickme_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Button clicked successfully!\nWelcome to Advanced Programming 🚀",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
