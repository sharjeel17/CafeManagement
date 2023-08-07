namespace CafeManagement.UserControls
{
    partial class UserControl_UppdateItems
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ElipseUSUI = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.updateItemsLabel = new System.Windows.Forms.Label();
            this.itemNameSearchLabel = new System.Windows.Forms.Label();
            this.itemSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.uiDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.updateCategoryTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.updateItemNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updatePriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateItemButton = new Guna.UI2.WinForms.Guna2Button();
            this.uiCategoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.updateItemsCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ElipseUSUI
            // 
            this.guna2ElipseUSUI.BorderRadius = 20;
            this.guna2ElipseUSUI.TargetControl = this;
            // 
            // updateItemsLabel
            // 
            this.updateItemsLabel.AutoSize = true;
            this.updateItemsLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemsLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.updateItemsLabel.Location = new System.Drawing.Point(27, 35);
            this.updateItemsLabel.Name = "updateItemsLabel";
            this.updateItemsLabel.Size = new System.Drawing.Size(175, 34);
            this.updateItemsLabel.TabIndex = 0;
            this.updateItemsLabel.Text = "Update Items";
            // 
            // itemNameSearchLabel
            // 
            this.itemNameSearchLabel.AutoSize = true;
            this.itemNameSearchLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameSearchLabel.Location = new System.Drawing.Point(526, 104);
            this.itemNameSearchLabel.Name = "itemNameSearchLabel";
            this.itemNameSearchLabel.Size = new System.Drawing.Size(95, 23);
            this.itemNameSearchLabel.TabIndex = 1;
            this.itemNameSearchLabel.Text = "Item Name";
            // 
            // itemSearchTextBox
            // 
            this.itemSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemSearchTextBox.DefaultText = "";
            this.itemSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemSearchTextBox.DisabledState.Parent = this.itemSearchTextBox;
            this.itemSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemSearchTextBox.FocusedState.Parent = this.itemSearchTextBox;
            this.itemSearchTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic);
            this.itemSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemSearchTextBox.HoverState.Parent = this.itemSearchTextBox;
            this.itemSearchTextBox.Location = new System.Drawing.Point(530, 132);
            this.itemSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemSearchTextBox.Name = "itemSearchTextBox";
            this.itemSearchTextBox.PasswordChar = '\0';
            this.itemSearchTextBox.PlaceholderText = "Search Item name";
            this.itemSearchTextBox.SelectedText = "";
            this.itemSearchTextBox.ShadowDecoration.Parent = this.itemSearchTextBox;
            this.itemSearchTextBox.Size = new System.Drawing.Size(206, 36);
            this.itemSearchTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.itemSearchTextBox.TabIndex = 2;
            this.itemSearchTextBox.TextChanged += new System.EventHandler(this.itemSearchTextBox_TextChanged);
            // 
            // uiDataGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.uiDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.uiDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGrid.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.uiDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uiDataGrid.EnableHeadersVisualStyles = false;
            this.uiDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.uiDataGrid.Location = new System.Drawing.Point(33, 185);
            this.uiDataGrid.Name = "uiDataGrid";
            this.uiDataGrid.ReadOnly = true;
            this.uiDataGrid.RowHeadersVisible = false;
            this.uiDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGrid.Size = new System.Drawing.Size(703, 170);
            this.uiDataGrid.TabIndex = 3;
            this.uiDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.uiDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.uiDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.uiDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.uiDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.uiDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.uiDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.uiDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.uiDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.uiDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.uiDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.uiDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.uiDataGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.uiDataGrid.ThemeStyle.ReadOnly = true;
            this.uiDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.uiDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.uiDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.uiDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.uiDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.uiDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.uiDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.uiDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGrid_CellClick);
            // 
            // updateCategoryTextBox
            // 
            this.updateCategoryTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateCategoryTextBox.DefaultText = "";
            this.updateCategoryTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateCategoryTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateCategoryTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateCategoryTextBox.DisabledState.Parent = this.updateCategoryTextBox;
            this.updateCategoryTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateCategoryTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateCategoryTextBox.FocusedState.Parent = this.updateCategoryTextBox;
            this.updateCategoryTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic);
            this.updateCategoryTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateCategoryTextBox.HoverState.Parent = this.updateCategoryTextBox;
            this.updateCategoryTextBox.Location = new System.Drawing.Point(33, 397);
            this.updateCategoryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateCategoryTextBox.Name = "updateCategoryTextBox";
            this.updateCategoryTextBox.PasswordChar = '\0';
            this.updateCategoryTextBox.PlaceholderText = "Category";
            this.updateCategoryTextBox.SelectedText = "";
            this.updateCategoryTextBox.ShadowDecoration.Parent = this.updateCategoryTextBox;
            this.updateCategoryTextBox.Size = new System.Drawing.Size(206, 36);
            this.updateCategoryTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.updateCategoryTextBox.TabIndex = 5;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(29, 369);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(78, 23);
            this.Category.TabIndex = 4;
            this.Category.Text = "Category";
            // 
            // updateItemNameTextBox
            // 
            this.updateItemNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateItemNameTextBox.DefaultText = "";
            this.updateItemNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updateItemNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updateItemNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateItemNameTextBox.DisabledState.Parent = this.updateItemNameTextBox;
            this.updateItemNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updateItemNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateItemNameTextBox.FocusedState.Parent = this.updateItemNameTextBox;
            this.updateItemNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic);
            this.updateItemNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateItemNameTextBox.HoverState.Parent = this.updateItemNameTextBox;
            this.updateItemNameTextBox.Location = new System.Drawing.Point(33, 484);
            this.updateItemNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateItemNameTextBox.Name = "updateItemNameTextBox";
            this.updateItemNameTextBox.PasswordChar = '\0';
            this.updateItemNameTextBox.PlaceholderText = "Item";
            this.updateItemNameTextBox.SelectedText = "";
            this.updateItemNameTextBox.ShadowDecoration.Parent = this.updateItemNameTextBox;
            this.updateItemNameTextBox.Size = new System.Drawing.Size(206, 36);
            this.updateItemNameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.updateItemNameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Name";
            // 
            // updatePriceTextBox
            // 
            this.updatePriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updatePriceTextBox.DefaultText = "";
            this.updatePriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.updatePriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.updatePriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updatePriceTextBox.DisabledState.Parent = this.updatePriceTextBox;
            this.updatePriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.updatePriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updatePriceTextBox.FocusedState.Parent = this.updatePriceTextBox;
            this.updatePriceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic);
            this.updatePriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updatePriceTextBox.HoverState.Parent = this.updatePriceTextBox;
            this.updatePriceTextBox.Location = new System.Drawing.Point(530, 397);
            this.updatePriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updatePriceTextBox.Name = "updatePriceTextBox";
            this.updatePriceTextBox.PasswordChar = '\0';
            this.updatePriceTextBox.PlaceholderText = "Price";
            this.updatePriceTextBox.SelectedText = "";
            this.updatePriceTextBox.ShadowDecoration.Parent = this.updatePriceTextBox;
            this.updatePriceTextBox.Size = new System.Drawing.Size(206, 36);
            this.updatePriceTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.updatePriceTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // updateItemButton
            // 
            this.updateItemButton.BorderRadius = 20;
            this.updateItemButton.CheckedState.Parent = this.updateItemButton;
            this.updateItemButton.CustomImages.Parent = this.updateItemButton;
            this.updateItemButton.FillColor = System.Drawing.Color.DarkCyan;
            this.updateItemButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemButton.ForeColor = System.Drawing.Color.White;
            this.updateItemButton.HoverState.Parent = this.updateItemButton;
            this.updateItemButton.Location = new System.Drawing.Point(548, 470);
            this.updateItemButton.Name = "updateItemButton";
            this.updateItemButton.ShadowDecoration.Parent = this.updateItemButton;
            this.updateItemButton.Size = new System.Drawing.Size(171, 50);
            this.updateItemButton.TabIndex = 10;
            this.updateItemButton.Text = "Update Item";
            this.updateItemButton.Click += new System.EventHandler(this.updateItemButton_Click);
            // 
            // uiCategoryComboBox
            // 
            this.uiCategoryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.uiCategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.uiCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiCategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uiCategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uiCategoryComboBox.FocusedState.Parent = this.uiCategoryComboBox;
            this.uiCategoryComboBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.uiCategoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.uiCategoryComboBox.HoverState.Parent = this.uiCategoryComboBox;
            this.uiCategoryComboBox.ItemHeight = 30;
            this.uiCategoryComboBox.Items.AddRange(new object[] {
            "Breakfast",
            "Italian",
            "Dessert",
            "Drinks"});
            this.uiCategoryComboBox.ItemsAppearance.Parent = this.uiCategoryComboBox;
            this.uiCategoryComboBox.Location = new System.Drawing.Point(33, 132);
            this.uiCategoryComboBox.Name = "uiCategoryComboBox";
            this.uiCategoryComboBox.ShadowDecoration.Parent = this.uiCategoryComboBox;
            this.uiCategoryComboBox.Size = new System.Drawing.Size(157, 36);
            this.uiCategoryComboBox.StartIndex = 0;
            this.uiCategoryComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.uiCategoryComboBox.TabIndex = 12;
            this.uiCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.uiCategoryComboBox_SelectedIndexChanged);
            // 
            // updateItemsCategory
            // 
            this.updateItemsCategory.AutoSize = true;
            this.updateItemsCategory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemsCategory.Location = new System.Drawing.Point(29, 106);
            this.updateItemsCategory.Name = "updateItemsCategory";
            this.updateItemsCategory.Size = new System.Drawing.Size(76, 23);
            this.updateItemsCategory.TabIndex = 11;
            this.updateItemsCategory.Text = "category";
            // 
            // UserControl_UppdateItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.uiCategoryComboBox);
            this.Controls.Add(this.updateItemsCategory);
            this.Controls.Add(this.updateItemButton);
            this.Controls.Add(this.updatePriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateItemNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateCategoryTextBox);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.uiDataGrid);
            this.Controls.Add(this.itemSearchTextBox);
            this.Controls.Add(this.itemNameSearchLabel);
            this.Controls.Add(this.updateItemsLabel);
            this.Name = "UserControl_UppdateItems";
            this.Size = new System.Drawing.Size(766, 540);
            this.Load += new System.EventHandler(this.UserControl_UppdateItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseUSUI;
        private System.Windows.Forms.Label updateItemsLabel;
        private System.Windows.Forms.Label itemNameSearchLabel;
        private Guna.UI2.WinForms.Guna2TextBox itemSearchTextBox;
        private Guna.UI2.WinForms.Guna2DataGridView uiDataGrid;
        private Guna.UI2.WinForms.Guna2Button updateItemButton;
        private Guna.UI2.WinForms.Guna2TextBox updatePriceTextBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox updateItemNameTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox updateCategoryTextBox;
        private System.Windows.Forms.Label Category;
        private Guna.UI2.WinForms.Guna2ComboBox uiCategoryComboBox;
        private System.Windows.Forms.Label updateItemsCategory;
    }
}
