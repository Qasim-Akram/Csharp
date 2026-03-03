using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class btn_refresh : Form
    {
        public btn_refresh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnRefresh_Click(Object sender, EventArgs e)
        { MessageBox.Show(textBox1.Text); }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
