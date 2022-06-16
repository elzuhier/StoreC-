namespace WindowsFormsApp1
{
    partial class Store_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buysReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gviewDataStore = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlStore = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.guna2ComboBox5 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewDataStore)).BeginInit();
            this.pnlStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.salesInvoiceToolStripMenuItem,
            this.purchaseInvoiceToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStoreToolStripMenuItem,
            this.addCategoyToolStripMenuItem,
            this.addProductsToolStripMenuItem,
            this.addSuppliersToolStripMenuItem,
            this.addCustomersToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.editToolStripMenuItem.Text = "Add";
            // 
            // addStoreToolStripMenuItem
            // 
            this.addStoreToolStripMenuItem.Name = "addStoreToolStripMenuItem";
            this.addStoreToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addStoreToolStripMenuItem.Text = "Store";
            this.addStoreToolStripMenuItem.Click += new System.EventHandler(this.addStoreToolStripMenuItem_Click);
            // 
            // addCategoyToolStripMenuItem
            // 
            this.addCategoyToolStripMenuItem.Name = "addCategoyToolStripMenuItem";
            this.addCategoyToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addCategoyToolStripMenuItem.Text = "Category";
            this.addCategoyToolStripMenuItem.Click += new System.EventHandler(this.addCategoyToolStripMenuItem_Click);
            // 
            // addProductsToolStripMenuItem
            // 
            this.addProductsToolStripMenuItem.Name = "addProductsToolStripMenuItem";
            this.addProductsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addProductsToolStripMenuItem.Text = "Products";
            this.addProductsToolStripMenuItem.Click += new System.EventHandler(this.addProductsToolStripMenuItem_Click);
            // 
            // addSuppliersToolStripMenuItem
            // 
            this.addSuppliersToolStripMenuItem.Name = "addSuppliersToolStripMenuItem";
            this.addSuppliersToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addSuppliersToolStripMenuItem.Text = "Suppliers";
            this.addSuppliersToolStripMenuItem.Click += new System.EventHandler(this.addSuppliersToolStripMenuItem_Click);
            // 
            // addCustomersToolStripMenuItem
            // 
            this.addCustomersToolStripMenuItem.Name = "addCustomersToolStripMenuItem";
            this.addCustomersToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addCustomersToolStripMenuItem.Text = "Distributers";
            this.addCustomersToolStripMenuItem.Click += new System.EventHandler(this.addCustomersToolStripMenuItem_Click);
            // 
            // salesInvoiceToolStripMenuItem
            // 
            this.salesInvoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salesInvoiceToolStripMenuItem.Name = "salesInvoiceToolStripMenuItem";
            this.salesInvoiceToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.salesInvoiceToolStripMenuItem.Text = "Sales Invoice";
            this.salesInvoiceToolStripMenuItem.Click += new System.EventHandler(this.salesInvoiceToolStripMenuItem_Click);
            // 
            // purchaseInvoiceToolStripMenuItem
            // 
            this.purchaseInvoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.purchaseInvoiceToolStripMenuItem.Name = "purchaseInvoiceToolStripMenuItem";
            this.purchaseInvoiceToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.purchaseInvoiceToolStripMenuItem.Text = "Purchase Invoice";
            this.purchaseInvoiceToolStripMenuItem.Click += new System.EventHandler(this.purchaseInvoiceToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellsReportToolStripMenuItem,
            this.buysReportToolStripMenuItem});
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportToolStripMenuItem.Text = "Reports";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // sellsReportToolStripMenuItem
            // 
            this.sellsReportToolStripMenuItem.Name = "sellsReportToolStripMenuItem";
            this.sellsReportToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sellsReportToolStripMenuItem.Text = "Sells Report";
            this.sellsReportToolStripMenuItem.Click += new System.EventHandler(this.sellsReportToolStripMenuItem_Click);
            // 
            // buysReportToolStripMenuItem
            // 
            this.buysReportToolStripMenuItem.Name = "buysReportToolStripMenuItem";
            this.buysReportToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.buysReportToolStripMenuItem.Text = "Buys Report";
            this.buysReportToolStripMenuItem.Click += new System.EventHandler(this.buysReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // gviewDataStore
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gviewDataStore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gviewDataStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gviewDataStore.BackgroundColor = System.Drawing.Color.White;
            this.gviewDataStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gviewDataStore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gviewDataStore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gviewDataStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gviewDataStore.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gviewDataStore.DefaultCellStyle = dataGridViewCellStyle3;
            this.gviewDataStore.EnableHeadersVisualStyles = false;
            this.gviewDataStore.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewDataStore.Location = new System.Drawing.Point(27, 104);
            this.gviewDataStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gviewDataStore.Name = "gviewDataStore";
            this.gviewDataStore.RowHeadersVisible = false;
            this.gviewDataStore.RowHeadersWidth = 51;
            this.gviewDataStore.RowTemplate.Height = 26;
            this.gviewDataStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gviewDataStore.Size = new System.Drawing.Size(829, 351);
            this.gviewDataStore.TabIndex = 22;
            this.gviewDataStore.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gviewDataStore.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gviewDataStore.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gviewDataStore.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gviewDataStore.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gviewDataStore.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gviewDataStore.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewDataStore.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gviewDataStore.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gviewDataStore.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gviewDataStore.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gviewDataStore.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gviewDataStore.ThemeStyle.HeaderStyle.Height = 30;
            this.gviewDataStore.ThemeStyle.ReadOnly = false;
            this.gviewDataStore.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gviewDataStore.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gviewDataStore.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gviewDataStore.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gviewDataStore.ThemeStyle.RowsStyle.Height = 26;
            this.gviewDataStore.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewDataStore.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gviewDataStore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gviewDataStore_CellContentClick);
            // 
            // pnlStore
            // 
            this.pnlStore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlStore.Controls.Add(this.lblCategory);
            this.pnlStore.Controls.Add(this.guna2ComboBox5);
            this.pnlStore.Controls.Add(this.gviewDataStore);
            this.pnlStore.Controls.Add(this.label1);
            this.pnlStore.Controls.Add(this.cmbCategory);
            this.pnlStore.Location = new System.Drawing.Point(0, 33);
            this.pnlStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlStore.Name = "pnlStore";
            this.pnlStore.Size = new System.Drawing.Size(884, 479);
            this.pnlStore.TabIndex = 9;
            this.pnlStore.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblCategory.Location = new System.Drawing.Point(490, 32);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 24);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // guna2ComboBox5
            // 
            this.guna2ComboBox5.AutoRoundedCorners = true;
            this.guna2ComboBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox5.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2ComboBox5.BorderRadius = 17;
            this.guna2ComboBox5.BorderThickness = 0;
            this.guna2ComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox5.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox5.FocusedState.Parent = this.guna2ComboBox5;
            this.guna2ComboBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox5.HoverState.Parent = this.guna2ComboBox5;
            this.guna2ComboBox5.ItemHeight = 30;
            this.guna2ComboBox5.ItemsAppearance.Parent = this.guna2ComboBox5;
            this.guna2ComboBox5.Location = new System.Drawing.Point(181, 32);
            this.guna2ComboBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ComboBox5.Name = "guna2ComboBox5";
            this.guna2ComboBox5.ShadowDecoration.Parent = this.guna2ComboBox5;
            this.guna2ComboBox5.Size = new System.Drawing.Size(185, 36);
            this.guna2ComboBox5.TabIndex = 16;
            this.guna2ComboBox5.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox5_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(86, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Store";
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoRoundedCorners = true;
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbCategory.BorderRadius = 17;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.FocusedState.Parent = this.cmbCategory;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategory.HoverState.Parent = this.cmbCategory;
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.ItemsAppearance.Parent = this.cmbCategory;
            this.cmbCategory.Location = new System.Drawing.Point(622, 32);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.ShadowDecoration.Parent = this.cmbCategory;
            this.cmbCategory.Size = new System.Drawing.Size(185, 36);
            this.cmbCategory.TabIndex = 15;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            this.cmbCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_SelectionChangeCommitted);
            // 
            // Store_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.pnlStore);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Store_Form";
            this.Text = "Store_Form";
            this.Load += new System.EventHandler(this.Store_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gviewDataStore)).EndInit();
            this.pnlStore.ResumeLayout(false);
            this.pnlStore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DataGridView gviewDataStore;
        private System.Windows.Forms.Panel pnlStore;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.ToolStripMenuItem sellsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buysReportToolStripMenuItem;
    }
}