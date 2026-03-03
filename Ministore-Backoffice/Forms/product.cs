using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class product : UserControl
    {
        public product()
        {
            InitializeComponent();
            this.Load += product_Load;
        }

        private void dgvProducts_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dgvProducts_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                // Handle dropped files here
                foreach (string file in files)
                {
                    // Add your file handling logic
                }
            }
        }

        private void product_Load(object sender, EventArgs e)
        {
            // Configure DataGridView to match screenshot layout
            dgvProducts.Columns.Clear();
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.Columns.Add("colId", "ID");
            dgvProducts.Columns.Add("colName", "Name");
            dgvProducts.Columns.Add("colCategory", "Category");
            dgvProducts.Columns.Add("colPrice", "Price");
            dgvProducts.Columns.Add("colStock", "Stock");
            dgvProducts.Columns.Add("colStatus", "Status");

            // Sample widths that reflect screenshot proportions
            dgvProducts.Columns[0].FillWeight = 10; // ID
            dgvProducts.Columns[1].FillWeight = 25; // Name
            dgvProducts.Columns[2].FillWeight = 20; // Category
            dgvProducts.Columns[3].FillWeight = 15; // Price
            dgvProducts.Columns[4].FillWeight = 15; // Stock
            dgvProducts.Columns[5].FillWeight = 15; // Status

            // Populate filter comboboxes with placeholder values
            if (cmbCategory.Items.Count == 0)
            {
                cmbCategory.Items.AddRange(new object[] { "All", "Electronics", "Groceries", "Clothing" });
                cmbCategory.SelectedIndex = 0;
            }

            if (cmbStockStatus.Items.Count == 0)
            {
                cmbStockStatus.Items.AddRange(new object[] { "All", "In Stock", "Out of Stock", "Low Stock" });
                cmbStockStatus.SelectedIndex = 0;
            }
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            // Open add dialog or raise event
            MessageBox.Show("Add product - implement dialog", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            // Edit selected product
            MessageBox.Show("Edit selected product - implement logic", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbtnView_Click(object sender, EventArgs e)
        {
            // View details of selected product
            MessageBox.Show("View product details - implement logic", "View", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            // Delete selected product
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the selected product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                // Implement deletion
            }
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh grid data
            MessageBox.Show("Refresh - implement data reload", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
