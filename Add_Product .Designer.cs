namespace WindowsFormsApp1
{
    partial class Add_Product
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtNameProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.gviewShowProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.cboStores = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gviewShowProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPrice.Location = new System.Drawing.Point(480, 130);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 19);
            this.lblPrice.TabIndex = 26;
            this.lblPrice.Text = "Price ";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblProductDescription.Location = new System.Drawing.Point(21, 90);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(143, 19);
            this.lblProductDescription.TabIndex = 24;
            this.lblProductDescription.Text = "Product Descriptin ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblProductName.Location = new System.Drawing.Point(21, 26);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(114, 19);
            this.lblProductName.TabIndex = 22;
            this.lblProductName.Text = "Product Name ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblCategory.Location = new System.Drawing.Point(502, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(94, 24);
            this.lblCategory.TabIndex = 33;
            this.lblCategory.Text = "All Stores";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Animated = true;
            this.txtNameProduct.AutoRoundedCorners = true;
            this.txtNameProduct.BorderRadius = 13;
            this.txtNameProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameProduct.DefaultText = "";
            this.txtNameProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameProduct.DisabledState.Parent = this.txtNameProduct;
            this.txtNameProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameProduct.FocusedState.Parent = this.txtNameProduct;
            this.txtNameProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameProduct.HoverState.Parent = this.txtNameProduct;
            this.txtNameProduct.Location = new System.Drawing.Point(205, 16);
            this.txtNameProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.PasswordChar = '\0';
            this.txtNameProduct.PlaceholderText = "";
            this.txtNameProduct.SelectedText = "";
            this.txtNameProduct.ShadowDecoration.Parent = this.txtNameProduct;
            this.txtNameProduct.Size = new System.Drawing.Size(215, 29);
            this.txtNameProduct.TabIndex = 35;
            // 
            // txtPDescription
            // 
            this.txtPDescription.Animated = true;
            this.txtPDescription.AutoRoundedCorners = true;
            this.txtPDescription.BorderRadius = 13;
            this.txtPDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPDescription.DefaultText = "";
            this.txtPDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPDescription.DisabledState.Parent = this.txtPDescription;
            this.txtPDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDescription.FocusedState.Parent = this.txtPDescription;
            this.txtPDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDescription.HoverState.Parent = this.txtPDescription;
            this.txtPDescription.Location = new System.Drawing.Point(205, 80);
            this.txtPDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPDescription.Name = "txtPDescription";
            this.txtPDescription.PasswordChar = '\0';
            this.txtPDescription.PlaceholderText = "";
            this.txtPDescription.SelectedText = "";
            this.txtPDescription.ShadowDecoration.Parent = this.txtPDescription;
            this.txtPDescription.Size = new System.Drawing.Size(215, 29);
            this.txtPDescription.TabIndex = 36;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Animated = true;
            this.txtPPrice.AutoRoundedCorners = true;
            this.txtPPrice.BorderRadius = 13;
            this.txtPPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPPrice.DefaultText = "";
            this.txtPPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPrice.DisabledState.Parent = this.txtPPrice;
            this.txtPPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPrice.FocusedState.Parent = this.txtPPrice;
            this.txtPPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPrice.HoverState.Parent = this.txtPPrice;
            this.txtPPrice.Location = new System.Drawing.Point(570, 120);
            this.txtPPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.PasswordChar = '\0';
            this.txtPPrice.PlaceholderText = "";
            this.txtPPrice.SelectedText = "";
            this.txtPPrice.ShadowDecoration.Parent = this.txtPPrice;
            this.txtPPrice.Size = new System.Drawing.Size(215, 29);
            this.txtPPrice.TabIndex = 37;
            // 
            // cboxCategory
            // 
            this.cboxCategory.AutoRoundedCorners = true;
            this.cboxCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboxCategory.BorderRadius = 17;
            this.cboxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxCategory.FocusedState.Parent = this.cboxCategory;
            this.cboxCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxCategory.HoverState.Parent = this.cboxCategory;
            this.cboxCategory.ItemHeight = 30;
            this.cboxCategory.ItemsAppearance.Parent = this.cboxCategory;
            this.cboxCategory.Location = new System.Drawing.Point(685, 51);
            this.cboxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.ShadowDecoration.Parent = this.cboxCategory;
            this.cboxCategory.Size = new System.Drawing.Size(186, 36);
            this.cboxCategory.TabIndex = 38;
            this.cboxCategory.SelectedIndexChanged += new System.EventHandler(this.cboxCategory_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 17;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(97, 226);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(154, 37);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.AutoRoundedCorners = true;
            this.btnEdit.BorderRadius = 17;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.DisabledState.Parent = this.btnEdit;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(364, 226);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(154, 37);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Animated = true;
            this.btnRemove.AutoRoundedCorners = true;
            this.btnRemove.BorderRadius = 17;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.DisabledState.Parent = this.btnRemove;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(602, 226);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(154, 37);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gviewShowProduct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gviewShowProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gviewShowProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gviewShowProduct.BackgroundColor = System.Drawing.Color.White;
            this.gviewShowProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gviewShowProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gviewShowProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gviewShowProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gviewShowProduct.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gviewShowProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.gviewShowProduct.EnableHeadersVisualStyles = false;
            this.gviewShowProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewShowProduct.Location = new System.Drawing.Point(36, 311);
            this.gviewShowProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gviewShowProduct.Name = "gviewShowProduct";
            this.gviewShowProduct.ReadOnly = true;
            this.gviewShowProduct.RowHeadersVisible = false;
            this.gviewShowProduct.RowHeadersWidth = 51;
            this.gviewShowProduct.RowTemplate.Height = 26;
            this.gviewShowProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gviewShowProduct.Size = new System.Drawing.Size(783, 278);
            this.gviewShowProduct.TabIndex = 43;
            this.gviewShowProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gviewShowProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gviewShowProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gviewShowProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gviewShowProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gviewShowProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gviewShowProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewShowProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gviewShowProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gviewShowProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gviewShowProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gviewShowProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gviewShowProduct.ThemeStyle.HeaderStyle.Height = 30;
            this.gviewShowProduct.ThemeStyle.ReadOnly = true;
            this.gviewShowProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gviewShowProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gviewShowProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gviewShowProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gviewShowProduct.ThemeStyle.RowsStyle.Height = 26;
            this.gviewShowProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewShowProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gviewShowProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gviewShowProduct_CellContentClick);
            this.gviewShowProduct.SelectionChanged += new System.EventHandler(this.gviewShowProduct_SelectionChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(315, 24);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(17, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(17, 16);
            this.webBrowser1.TabIndex = 44;
            // 
            // cboStores
            // 
            this.cboStores.AutoRoundedCorners = true;
            this.cboStores.BackColor = System.Drawing.Color.Transparent;
            this.cboStores.BorderRadius = 17;
            this.cboStores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStores.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStores.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStores.FocusedState.Parent = this.cboStores;
            this.cboStores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboStores.HoverState.Parent = this.cboStores;
            this.cboStores.ItemHeight = 30;
            this.cboStores.ItemsAppearance.Parent = this.cboStores;
            this.cboStores.Location = new System.Drawing.Point(459, 51);
            this.cboStores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStores.Name = "cboStores";
            this.cboStores.ShadowDecoration.Parent = this.cboStores;
            this.cboStores.Size = new System.Drawing.Size(186, 36);
            this.cboStores.TabIndex = 45;
            this.cboStores.SelectedIndexChanged += new System.EventHandler(this.cboStores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(722, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "All Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(21, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Animated = true;
            this.txtQuantity.AutoRoundedCorners = true;
            this.txtQuantity.BorderRadius = 13;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(205, 142);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(215, 29);
            this.txtQuantity.TabIndex = 48;
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 600);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStores);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.gviewShowProduct);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.txtPPrice);
            this.Controls.Add(this.txtPDescription);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_Product";
            this.Text = "Add_Product";
            this.Load += new System.EventHandler(this.Add_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gviewShowProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtNameProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtPDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtPPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cboxCategory;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2DataGridView gviewShowProduct;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2ComboBox cboStores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
    }
}