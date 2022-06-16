namespace WindowsFormsApp1
{
    partial class Add_Category
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbDescriotion = new System.Windows.Forms.TextBox();
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.gviewCategory = new System.Windows.Forms.DataGridView();
            this.cmbStoreName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gviewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(255, 140);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 37);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRemove.Location = new System.Drawing.Point(488, 140);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(165, 39);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(40, 138);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 40);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbDescriotion
            // 
            this.txtbDescriotion.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtbDescriotion.Location = new System.Drawing.Point(255, 65);
            this.txtbDescriotion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbDescriotion.Multiline = true;
            this.txtbDescriotion.Name = "txtbDescriotion";
            this.txtbDescriotion.Size = new System.Drawing.Size(188, 36);
            this.txtbDescriotion.TabIndex = 17;
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblCategoryDescription.Location = new System.Drawing.Point(103, 76);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(107, 24);
            this.lblCategoryDescription.TabIndex = 16;
            this.lblCategoryDescription.Text = " Decription";
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtbName.Location = new System.Drawing.Point(427, 12);
            this.txtbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbName.Multiline = true;
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(194, 30);
            this.txtbName.TabIndex = 13;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblCategoryName.Location = new System.Drawing.Point(339, 12);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(68, 24);
            this.lblCategoryName.TabIndex = 12;
            this.lblCategoryName.Text = " Name";
            // 
            // gviewCategory
            // 
            this.gviewCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gviewCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gviewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gviewCategory.BackgroundColor = System.Drawing.Color.White;
            this.gviewCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gviewCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gviewCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gviewCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gviewCategory.ColumnHeadersHeight = 18;
            this.gviewCategory.EnableHeadersVisualStyles = false;
            this.gviewCategory.Location = new System.Drawing.Point(15, 232);
            this.gviewCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gviewCategory.Name = "gviewCategory";
            this.gviewCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gviewCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gviewCategory.RowHeadersWidth = 51;
            this.gviewCategory.RowTemplate.Height = 26;
            this.gviewCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gviewCategory.Size = new System.Drawing.Size(670, 328);
            this.gviewCategory.TabIndex = 23;
            this.gviewCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gviewCategory_CellContentClick);
            this.gviewCategory.SelectionChanged += new System.EventHandler(this.gviewCategory_SelectionChanged);
            // 
            // cmbStoreName
            // 
            this.cmbStoreName.BackColor = System.Drawing.Color.Transparent;
            this.cmbStoreName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStoreName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStoreName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStoreName.FocusedState.Parent = this.cmbStoreName;
            this.cmbStoreName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStoreName.HoverState.Parent = this.cmbStoreName;
            this.cmbStoreName.ItemHeight = 30;
            this.cmbStoreName.ItemsAppearance.Parent = this.cmbStoreName;
            this.cmbStoreName.Location = new System.Drawing.Point(171, 12);
            this.cmbStoreName.Name = "cmbStoreName";
            this.cmbStoreName.ShadowDecoration.Parent = this.cmbStoreName;
            this.cmbStoreName.Size = new System.Drawing.Size(140, 36);
            this.cmbStoreName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Store Name ";
            // 
            // Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStoreName);
            this.Controls.Add(this.gviewCategory);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbDescriotion);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblCategoryName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add_Category";
            this.Text = "Add_Category";
            this.Load += new System.EventHandler(this.Add_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gviewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbDescriotion;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.DataGridView gviewCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStoreName;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label1;
    }
}

