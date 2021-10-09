
namespace Player
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImportExportForm3 = new System.Windows.Forms.Button();
            this.StockGridView = new System.Windows.Forms.DataGridView();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.labelStockName = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnImportExportForm2 = new System.Windows.Forms.Button();
            this.CategoryGridView = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.btnImportExportForm = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.labelItemCategory = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.labelItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 711);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tabPage1.Controls.Add(this.btnImportExportForm3);
            this.tabPage1.Controls.Add(this.StockGridView);
            this.tabPage1.Controls.Add(this.btnAddStock);
            this.tabPage1.Controls.Add(this.labelStockName);
            this.tabPage1.Controls.Add(this.txtStockName);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(668, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADD Stock";
            // 
            // btnImportExportForm3
            // 
            this.btnImportExportForm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExportForm3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnImportExportForm3.Location = new System.Drawing.Point(183, 585);
            this.btnImportExportForm3.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportExportForm3.Name = "btnImportExportForm3";
            this.btnImportExportForm3.Size = new System.Drawing.Size(276, 49);
            this.btnImportExportForm3.TabIndex = 23;
            this.btnImportExportForm3.Text = "Import / Export";
            this.btnImportExportForm3.UseVisualStyleBackColor = true;
            this.btnImportExportForm3.Click += new System.EventHandler(this.btnImportExportForm_Click);
            // 
            // StockGridView
            // 
            this.StockGridView.AllowUserToAddRows = false;
            this.StockGridView.AllowUserToDeleteRows = false;
            this.StockGridView.AllowUserToResizeColumns = false;
            this.StockGridView.AllowUserToResizeRows = false;
            this.StockGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StockGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StockGridView.Location = new System.Drawing.Point(157, 206);
            this.StockGridView.Margin = new System.Windows.Forms.Padding(4);
            this.StockGridView.MultiSelect = false;
            this.StockGridView.Name = "StockGridView";
            this.StockGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StockGridView.RowHeadersVisible = false;
            this.StockGridView.RowHeadersWidth = 51;
            this.StockGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StockGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StockGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockGridView.ShowCellToolTips = false;
            this.StockGridView.ShowEditingIcon = false;
            this.StockGridView.Size = new System.Drawing.Size(384, 346);
            this.StockGridView.TabIndex = 6;
            // 
            // btnAddStock
            // 
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddStock.Location = new System.Drawing.Point(285, 137);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(105, 49);
            this.btnAddStock.TabIndex = 3;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // labelStockName
            // 
            this.labelStockName.AutoSize = true;
            this.labelStockName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelStockName.Location = new System.Drawing.Point(267, 31);
            this.labelStockName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockName.Name = "labelStockName";
            this.labelStockName.Size = new System.Drawing.Size(131, 28);
            this.labelStockName.TabIndex = 1;
            this.labelStockName.Text = "Stock Name ";
            // 
            // txtStockName
            // 
            this.txtStockName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtStockName.Location = new System.Drawing.Point(158, 78);
            this.txtStockName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(383, 34);
            this.txtStockName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tabPage2.Controls.Add(this.btnImportExportForm2);
            this.tabPage2.Controls.Add(this.CategoryGridView);
            this.tabPage2.Controls.Add(this.btnAddCategory);
            this.tabPage2.Controls.Add(this.labelCategoryName);
            this.tabPage2.Controls.Add(this.txtNameCategory);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(668, 670);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADD Category";
            // 
            // btnImportExportForm2
            // 
            this.btnImportExportForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExportForm2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnImportExportForm2.Location = new System.Drawing.Point(179, 590);
            this.btnImportExportForm2.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportExportForm2.Name = "btnImportExportForm2";
            this.btnImportExportForm2.Size = new System.Drawing.Size(276, 49);
            this.btnImportExportForm2.TabIndex = 23;
            this.btnImportExportForm2.Text = "Import / Export";
            this.btnImportExportForm2.UseVisualStyleBackColor = true;
            this.btnImportExportForm2.Click += new System.EventHandler(this.btnImportExportForm_Click);
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.AllowUserToAddRows = false;
            this.CategoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoryGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CategoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.CategoryGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CategoryGridView.Location = new System.Drawing.Point(135, 198);
            this.CategoryGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryGridView.MultiSelect = false;
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CategoryGridView.RowHeadersVisible = false;
            this.CategoryGridView.RowHeadersWidth = 51;
            this.CategoryGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CategoryGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CategoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryGridView.ShowCellToolTips = false;
            this.CategoryGridView.ShowEditingIcon = false;
            this.CategoryGridView.Size = new System.Drawing.Size(415, 367);
            this.CategoryGridView.TabIndex = 14;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddCategory.Location = new System.Drawing.Point(276, 127);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(105, 44);
            this.btnAddCategory.TabIndex = 9;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelCategoryName.Location = new System.Drawing.Point(240, 30);
            this.labelCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(160, 28);
            this.labelCategoryName.TabIndex = 7;
            this.labelCategoryName.Text = "Category Name";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNameCategory.Location = new System.Drawing.Point(135, 73);
            this.txtNameCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(413, 34);
            this.txtNameCategory.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tabPage3.Controls.Add(this.ItemGridView);
            this.tabPage3.Controls.Add(this.btnImportExportForm);
            this.tabPage3.Controls.Add(this.cmbCategory);
            this.tabPage3.Controls.Add(this.labelItemCategory);
            this.tabPage3.Controls.Add(this.btnAddItem);
            this.tabPage3.Controls.Add(this.labelItemName);
            this.tabPage3.Controls.Add(this.txtItemName);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(668, 670);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ADD Item";
            // 
            // ItemGridView
            // 
            this.ItemGridView.AllowUserToAddRows = false;
            this.ItemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ItemGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.ItemGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ItemGridView.Location = new System.Drawing.Point(52, 297);
            this.ItemGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ItemGridView.MultiSelect = false;
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ItemGridView.RowHeadersVisible = false;
            this.ItemGridView.RowHeadersWidth = 51;
            this.ItemGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ItemGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ItemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemGridView.ShowCellToolTips = false;
            this.ItemGridView.ShowEditingIcon = false;
            this.ItemGridView.Size = new System.Drawing.Size(559, 263);
            this.ItemGridView.TabIndex = 23;
            // 
            // btnImportExportForm
            // 
            this.btnImportExportForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExportForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnImportExportForm.Location = new System.Drawing.Point(195, 582);
            this.btnImportExportForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportExportForm.Name = "btnImportExportForm";
            this.btnImportExportForm.Size = new System.Drawing.Size(276, 49);
            this.btnImportExportForm.TabIndex = 22;
            this.btnImportExportForm.Text = "Import / Export";
            this.btnImportExportForm.UseVisualStyleBackColor = true;
            this.btnImportExportForm.Click += new System.EventHandler(this.btnImportExportForm_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(112, 165);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(388, 36);
            this.cmbCategory.TabIndex = 21;
            this.cmbCategory.SelectedValueChanged += new System.EventHandler(this.cmbCategory_SelectedValueChanged);
            // 
            // labelItemCategory
            // 
            this.labelItemCategory.AutoSize = true;
            this.labelItemCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelItemCategory.Location = new System.Drawing.Point(223, 123);
            this.labelItemCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItemCategory.Name = "labelItemCategory";
            this.labelItemCategory.Size = new System.Drawing.Size(161, 28);
            this.labelItemCategory.TabIndex = 20;
            this.labelItemCategory.Text = "Select Category";
            // 
            // btnAddItem
            // 
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddItem.Location = new System.Drawing.Point(255, 227);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(105, 46);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelItemName.Location = new System.Drawing.Point(243, 28);
            this.labelItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(117, 28);
            this.labelItemName.TabIndex = 15;
            this.labelItemName.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtItemName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(112, 73);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(389, 34);
            this.txtItemName.TabIndex = 14;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(676, 711);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Label labelStockName;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label labelItemCategory;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnImportExportForm;
        private System.Windows.Forms.DataGridView StockGridView;
        private System.Windows.Forms.DataGridView CategoryGridView;
        private System.Windows.Forms.DataGridView ItemGridView;
        private System.Windows.Forms.Button btnImportExportForm3;
        private System.Windows.Forms.Button btnImportExportForm2;
    }
}

