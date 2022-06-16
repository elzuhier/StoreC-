namespace WindowsFormsApp1
{
    partial class SellsReport
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
            this.FromTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ToTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ReportGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceTPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.From = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.TotalPrices = new System.Windows.Forms.Label();
            this.txtBills = new System.Windows.Forms.Label();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalBills = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.Checked = true;
            this.FromTimePicker.CheckedState.Parent = this.FromTimePicker;
            this.FromTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FromTimePicker.HoverState.Parent = this.FromTimePicker;
            this.FromTimePicker.Location = new System.Drawing.Point(172, 23);
            this.FromTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.ShadowDecoration.Parent = this.FromTimePicker;
            this.FromTimePicker.Size = new System.Drawing.Size(204, 29);
            this.FromTimePicker.TabIndex = 0;
            this.FromTimePicker.Value = new System.DateTime(2022, 2, 4, 17, 1, 2, 581);
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.Checked = true;
            this.ToTimePicker.CheckedState.Parent = this.ToTimePicker;
            this.ToTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ToTimePicker.HoverState.Parent = this.ToTimePicker;
            this.ToTimePicker.Location = new System.Drawing.Point(470, 23);
            this.ToTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.ShadowDecoration.Parent = this.ToTimePicker;
            this.ToTimePicker.Size = new System.Drawing.Size(205, 29);
            this.ToTimePicker.TabIndex = 1;
            this.ToTimePicker.Value = new System.DateTime(2022, 2, 4, 17, 1, 2, 581);
            // 
            // ReportGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ReportGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReportGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReportGrid.BackgroundColor = System.Drawing.Color.White;
            this.ReportGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReportGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReportGrid.ColumnHeadersHeight = 30;
            this.ReportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.InvoiceTPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReportGrid.EnableHeadersVisualStyles = false;
            this.ReportGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReportGrid.Location = new System.Drawing.Point(12, 223);
            this.ReportGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportGrid.Name = "ReportGrid";
            this.ReportGrid.ReadOnly = true;
            this.ReportGrid.RowHeadersVisible = false;
            this.ReportGrid.RowHeadersWidth = 51;
            this.ReportGrid.RowTemplate.Height = 26;
            this.ReportGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportGrid.Size = new System.Drawing.Size(463, 220);
            this.ReportGrid.TabIndex = 4;
            this.ReportGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReportGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReportGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReportGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReportGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReportGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReportGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReportGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReportGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReportGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReportGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReportGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReportGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.ReportGrid.ThemeStyle.ReadOnly = true;
            this.ReportGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReportGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReportGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReportGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReportGrid.ThemeStyle.RowsStyle.Height = 26;
            this.ReportGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReportGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Invoice date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // InvoiceTPrice
            // 
            this.InvoiceTPrice.HeaderText = "Invoice Total Price";
            this.InvoiceTPrice.Name = "InvoiceTPrice";
            this.InvoiceTPrice.ReadOnly = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Animated = true;
            this.btnPrint.AutoRoundedCorners = true;
            this.btnPrint.BorderRadius = 15;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.DefaultAutoSize = true;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.DisabledState.Parent = this.btnPrint;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(669, 435);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(65, 33);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(131, 23);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(35, 13);
            this.From.TabIndex = 8;
            this.From.Text = "From:";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(441, 23);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(23, 13);
            this.To.TabIndex = 9;
            this.To.Text = "To:";
            // 
            // TotalPrices
            // 
            this.TotalPrices.AutoSize = true;
            this.TotalPrices.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrices.Location = new System.Drawing.Point(501, 259);
            this.TotalPrices.Name = "TotalPrices";
            this.TotalPrices.Size = new System.Drawing.Size(84, 19);
            this.TotalPrices.TabIndex = 10;
            this.TotalPrices.Text = "Total price";
            // 
            // txtBills
            // 
            this.txtBills.AutoSize = true;
            this.txtBills.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBills.Location = new System.Drawing.Point(501, 356);
            this.txtBills.Name = "txtBills";
            this.txtBills.Size = new System.Drawing.Size(78, 19);
            this.txtBills.TabIndex = 11;
            this.txtBills.Text = "Total Bills";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderRadius = 20;
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
            this.txtTotalPrice.Location = new System.Drawing.Point(595, 259);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 36);
            this.txtTotalPrice.TabIndex = 12;
            // 
            // txtTotalBills
            // 
            this.txtTotalBills.BorderRadius = 20;
            this.txtTotalBills.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalBills.DefaultText = "";
            this.txtTotalBills.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalBills.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalBills.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalBills.DisabledState.Parent = this.txtTotalBills;
            this.txtTotalBills.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalBills.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalBills.FocusedState.Parent = this.txtTotalBills;
            this.txtTotalBills.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalBills.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalBills.HoverState.Parent = this.txtTotalBills;
            this.txtTotalBills.Location = new System.Drawing.Point(595, 356);
            this.txtTotalBills.Name = "txtTotalBills";
            this.txtTotalBills.PasswordChar = '\0';
            this.txtTotalBills.PlaceholderText = "";
            this.txtTotalBills.SelectedText = "";
            this.txtTotalBills.ShadowDecoration.Parent = this.txtTotalBills;
            this.txtTotalBills.Size = new System.Drawing.Size(200, 36);
            this.txtTotalBills.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.DisabledState.Parent = this.btnClear;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(322, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(190, 32);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Show Sills Invoice";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SellsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(848, 583);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTotalBills);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtBills);
            this.Controls.Add(this.TotalPrices);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.ReportGrid);
            this.Controls.Add(this.ToTimePicker);
            this.Controls.Add(this.FromTimePicker);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SellsReport";
            this.Text = "Form_Report";
            this.Load += new System.EventHandler(this.Form_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker FromTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToTimePicker;
        private Guna.UI2.WinForms.Guna2DataGridView ReportGrid;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label TotalPrices;
        private System.Windows.Forms.Label txtBills;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceTPrice;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}