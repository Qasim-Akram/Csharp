namespace WindowsFormsApp1.Forms
{
    partial class product
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripProducts = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnView = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.cmbStockStatus = new System.Windows.Forms.ComboBox();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.toolStripProducts.SuspendLayout();
            this.grpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripProducts
            // 
            this.toolStripProducts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnEdit,
            this.tsbtnView,
            this.tsbtnDelete,
            this.tsbtnRefresh});
            this.toolStripProducts.Location = new System.Drawing.Point(0, 0);
            this.toolStripProducts.Name = "toolStripProducts";
            this.toolStripProducts.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripProducts.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripProducts.Size = new System.Drawing.Size(800, 32);
            this.toolStripProducts.TabIndex = 0;
            this.toolStripProducts.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = global::WindowsFormsApp1.Properties.Resources.products;
            this.tsbtnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(60, 20);
            this.tsbtnAdd.Text = " Add";
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Image = global::WindowsFormsApp1.Properties.Resources.reportanalytics;
            this.tsbtnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(60, 20);
            this.tsbtnEdit.Text = " Edit";
            this.tsbtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // tsbtnView
            // 
            this.tsbtnView.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.tsbtnView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnView.Name = "tsbtnView";
            this.tsbtnView.Size = new System.Drawing.Size(60, 20);
            this.tsbtnView.Text = " View";
            this.tsbtnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tsbtnView.Click += new System.EventHandler(this.tsbtnView_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = global::WindowsFormsApp1.Properties.Resources.logs;
            this.tsbtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(70, 20);
            this.tsbtnDelete.Text = " Delete";
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.Image = global::WindowsFormsApp1.Properties.Resources.refresh;
            this.tsbtnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(80, 20);
            this.tsbtnRefresh.Text = " Refresh";
            this.tsbtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.cmbStockStatus);
            this.grpFilters.Controls.Add(this.lblStockStatus);
            this.grpFilters.Controls.Add(this.cmbCategory);
            this.grpFilters.Controls.Add(this.lblCategory);
            this.grpFilters.Controls.Add(this.txtSearch);
            this.grpFilters.Controls.Add(this.lblSearch);
            this.grpFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilters.Location = new System.Drawing.Point(0, 32);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Padding = new System.Windows.Forms.Padding(8);
            this.grpFilters.Size = new System.Drawing.Size(800, 72);
            this.grpFilters.TabIndex = 1;
            this.grpFilters.TabStop = false;
            // 
            // cmbStockStatus
            // 
            this.cmbStockStatus.FormattingEnabled = true;
            this.cmbStockStatus.Location = new System.Drawing.Point(610, 36);
            this.cmbStockStatus.Name = "cmbStockStatus";
            this.cmbStockStatus.Size = new System.Drawing.Size(175, 21);
            this.cmbStockStatus.TabIndex = 5;
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Location = new System.Drawing.Point(610, 18);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(70, 13);
            this.lblStockStatus.TabIndex = 4;
            this.lblStockStatus.Text = "Stock Status";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(320, 36);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(260, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(320, 18);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 104);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(800, 396);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.AllowDrop = true;
            this.dgvProducts.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvProducts_DragEnter);
            this.dgvProducts.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvProducts_DragDrop);
            // 
            // product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.toolStripProducts);
            this.Name = "product";
            this.Size = new System.Drawing.Size(800, 500);
            this.toolStripProducts.ResumeLayout(false);
            this.toolStripProducts.PerformLayout();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripProducts;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripButton tsbtnView;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.DataGridView dgvProducts;
    }

}
