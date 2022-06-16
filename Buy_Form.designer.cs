namespace WindowsFormsApp1
{
    partial class Buy_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.cboxStore = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboxCategotyName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.cboxSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboxProductName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.gviewPurchases = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuy = new Guna.UI2.WinForms.Guna2Button();
            this.DatePicher = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gviewPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 17;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(94, 332);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(154, 37);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboxStore
            // 
            this.cboxStore.AutoRoundedCorners = true;
            this.cboxStore.BackColor = System.Drawing.Color.Transparent;
            this.cboxStore.BorderRadius = 17;
            this.cboxStore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStore.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxStore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxStore.FocusedState.Parent = this.cboxStore;
            this.cboxStore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxStore.HoverState.Parent = this.cboxStore;
            this.cboxStore.ItemHeight = 30;
            this.cboxStore.ItemsAppearance.Parent = this.cboxStore;
            this.cboxStore.Location = new System.Drawing.Point(114, 44);
            this.cboxStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxStore.Name = "cboxStore";
            this.cboxStore.ShadowDecoration.Parent = this.cboxStore;
            this.cboxStore.Size = new System.Drawing.Size(210, 36);
            this.cboxStore.TabIndex = 24;
            this.cboxStore.SelectedIndexChanged += new System.EventHandler(this.cboxStore_SelectedIndexChanged);
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblStore.Location = new System.Drawing.Point(41, 44);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(54, 23);
            this.lblStore.TabIndex = 23;
            this.lblStore.Text = "Store";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblSupplier.Location = new System.Drawing.Point(433, 44);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(79, 23);
            this.lblSupplier.TabIndex = 21;
            this.lblSupplier.Text = "Supplier";
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
            this.txtQuantity.Location = new System.Drawing.Point(538, 145);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(214, 29);
            this.txtQuantity.TabIndex = 20;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Animated = true;
            this.txtPrice.AutoRoundedCorners = true;
            this.txtPrice.BorderRadius = 13;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(127, 145);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(171, 29);
            this.txtPrice.TabIndex = 18;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // cboxCategotyName
            // 
            this.cboxCategotyName.AutoRoundedCorners = true;
            this.cboxCategotyName.BackColor = System.Drawing.Color.Transparent;
            this.cboxCategotyName.BorderRadius = 17;
            this.cboxCategotyName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxCategotyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategotyName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxCategotyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxCategotyName.FocusedState.Parent = this.cboxCategotyName;
            this.cboxCategotyName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxCategotyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxCategotyName.HoverState.Parent = this.cboxCategotyName;
            this.cboxCategotyName.ItemHeight = 30;
            this.cboxCategotyName.ItemsAppearance.Parent = this.cboxCategotyName;
            this.cboxCategotyName.Location = new System.Drawing.Point(184, 95);
            this.cboxCategotyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxCategotyName.Name = "cboxCategotyName";
            this.cboxCategotyName.ShadowDecoration.Parent = this.cboxCategotyName;
            this.cboxCategotyName.Size = new System.Drawing.Size(210, 36);
            this.cboxCategotyName.TabIndex = 17;
            this.cboxCategotyName.SelectedIndexChanged += new System.EventHandler(this.cboxCategotyName_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblPrice.Location = new System.Drawing.Point(38, 145);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 23);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price ";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblCategoryName.Location = new System.Drawing.Point(16, 101);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(139, 23);
            this.lblCategoryName.TabIndex = 13;
            this.lblCategoryName.Text = "Category Name";
            // 
            // cboxSupplier
            // 
            this.cboxSupplier.AutoRoundedCorners = true;
            this.cboxSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cboxSupplier.BorderRadius = 17;
            this.cboxSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSupplier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxSupplier.FocusedState.Parent = this.cboxSupplier;
            this.cboxSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxSupplier.HoverState.Parent = this.cboxSupplier;
            this.cboxSupplier.ItemHeight = 30;
            this.cboxSupplier.ItemsAppearance.Parent = this.cboxSupplier;
            this.cboxSupplier.Location = new System.Drawing.Point(529, 44);
            this.cboxSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSupplier.Name = "cboxSupplier";
            this.cboxSupplier.ShadowDecoration.Parent = this.cboxSupplier;
            this.cboxSupplier.Size = new System.Drawing.Size(210, 36);
            this.cboxSupplier.TabIndex = 26;
            // 
            // cboxProductName
            // 
            this.cboxProductName.AutoRoundedCorners = true;
            this.cboxProductName.BackColor = System.Drawing.Color.Transparent;
            this.cboxProductName.BorderRadius = 17;
            this.cboxProductName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProductName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxProductName.FocusedState.Parent = this.cboxProductName;
            this.cboxProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxProductName.HoverState.Parent = this.cboxProductName;
            this.cboxProductName.ItemHeight = 30;
            this.cboxProductName.ItemsAppearance.Parent = this.cboxProductName;
            this.cboxProductName.Location = new System.Drawing.Point(568, 95);
            this.cboxProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxProductName.Name = "cboxProductName";
            this.cboxProductName.ShadowDecoration.Parent = this.cboxProductName;
            this.cboxProductName.Size = new System.Drawing.Size(210, 36);
            this.cboxProductName.TabIndex = 28;
            this.cboxProductName.SelectedIndexChanged += new System.EventHandler(this.cboxProductName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(424, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Product Name";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTotalPrice.Location = new System.Drawing.Point(450, 346);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(103, 23);
            this.lblTotalPrice.TabIndex = 29;
            this.lblTotalPrice.Text = "Total Price ";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblQuantity.Location = new System.Drawing.Point(435, 145);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 23);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Animated = true;
            this.txtTotalPrice.AutoRoundedCorners = true;
            this.txtTotalPrice.BorderRadius = 13;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Location = new System.Drawing.Point(559, 346);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(165, 29);
            this.txtTotalPrice.TabIndex = 31;
            // 
            // gviewPurchases
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gviewPurchases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gviewPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gviewPurchases.BackgroundColor = System.Drawing.Color.White;
            this.gviewPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gviewPurchases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gviewPurchases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gviewPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gviewPurchases.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gviewPurchases.DefaultCellStyle = dataGridViewCellStyle6;
            this.gviewPurchases.EnableHeadersVisualStyles = false;
            this.gviewPurchases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewPurchases.Location = new System.Drawing.Point(21, 195);
            this.gviewPurchases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gviewPurchases.Name = "gviewPurchases";
            this.gviewPurchases.ReadOnly = true;
            this.gviewPurchases.RowHeadersVisible = false;
            this.gviewPurchases.RowHeadersWidth = 51;
            this.gviewPurchases.RowTemplate.Height = 26;
            this.gviewPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gviewPurchases.Size = new System.Drawing.Size(747, 109);
            this.gviewPurchases.TabIndex = 33;
            this.gviewPurchases.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gviewPurchases.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gviewPurchases.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gviewPurchases.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gviewPurchases.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gviewPurchases.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gviewPurchases.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewPurchases.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gviewPurchases.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gviewPurchases.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gviewPurchases.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gviewPurchases.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gviewPurchases.ThemeStyle.HeaderStyle.Height = 30;
            this.gviewPurchases.ThemeStyle.ReadOnly = true;
            this.gviewPurchases.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gviewPurchases.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gviewPurchases.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gviewPurchases.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gviewPurchases.ThemeStyle.RowsStyle.Height = 26;
            this.gviewPurchases.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gviewPurchases.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 17;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(94, 395);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(154, 37);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete item";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Animated = true;
            this.btnBuy.AutoRoundedCorners = true;
            this.btnBuy.BackColor = System.Drawing.Color.Transparent;
            this.btnBuy.BorderRadius = 17;
            this.btnBuy.CheckedState.Parent = this.btnBuy;
            this.btnBuy.CustomImages.Parent = this.btnBuy;
            this.btnBuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuy.DisabledState.Parent = this.btnBuy;
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.HoverState.Parent = this.btnBuy;
            this.btnBuy.Location = new System.Drawing.Point(529, 393);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.ShadowDecoration.Parent = this.btnBuy;
            this.btnBuy.Size = new System.Drawing.Size(154, 37);
            this.btnBuy.TabIndex = 35;
            this.btnBuy.Text = "Buy";
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // DatePicher
            // 
            this.DatePicher.Checked = true;
            this.DatePicher.CheckedState.Parent = this.DatePicher;
            this.DatePicher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePicher.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePicher.HoverState.Parent = this.DatePicher;
            this.DatePicher.Location = new System.Drawing.Point(329, 12);
            this.DatePicher.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePicher.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePicher.Name = "DatePicher";
            this.DatePicher.ShadowDecoration.Parent = this.DatePicher;
            this.DatePicher.Size = new System.Drawing.Size(186, 19);
            this.DatePicher.TabIndex = 36;
            this.DatePicher.Value = new System.DateTime(2022, 2, 4, 19, 14, 23, 273);
            // 
            // Buy_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 555);
            this.Controls.Add(this.DatePicher);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gviewPurchases);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.cboxProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxSupplier);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboxStore);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cboxCategotyName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategoryName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Buy_Form";
            this.Text = "Form_Purchase";
            this.Load += new System.EventHandler(this.Buy_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gviewPurchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cboxStore;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblSupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cboxCategotyName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategoryName;
        private Guna.UI2.WinForms.Guna2ComboBox cboxSupplier;
        private Guna.UI2.WinForms.Guna2ComboBox cboxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2DataGridView gviewPurchases;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnBuy;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePicher;
    }
}