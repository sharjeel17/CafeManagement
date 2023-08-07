namespace CafeManagement.UserControls
{
    partial class UserControl_PlaceOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ElipseUSPO = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.placeOrderLabel = new System.Windows.Forms.Label();
            this.placeOrderCategory = new System.Windows.Forms.Label();
            this.poCategoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.poSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.poItemNameLabel = new System.Windows.Forms.Label();
            this.poPriceLabel = new System.Windows.Forms.Label();
            this.poQuantityLabel = new System.Windows.Forms.Label();
            this.poTotalLabel = new System.Windows.Forms.Label();
            this.poItemNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.poPriceTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.poQuantityNumeric = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.poTotalTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.poAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.poCartDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poRemoveItem = new Guna.UI2.WinForms.Guna2Button();
            this.poOrder = new Guna.UI2.WinForms.Guna2Button();
            this.poGrandTotalLabel = new System.Windows.Forms.Label();
            this.poGrandTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poQuantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poCartDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ElipseUSPO
            // 
            this.guna2ElipseUSPO.BorderRadius = 20;
            this.guna2ElipseUSPO.TargetControl = this;
            // 
            // placeOrderLabel
            // 
            this.placeOrderLabel.AutoSize = true;
            this.placeOrderLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.placeOrderLabel.Location = new System.Drawing.Point(31, 28);
            this.placeOrderLabel.Name = "placeOrderLabel";
            this.placeOrderLabel.Size = new System.Drawing.Size(153, 34);
            this.placeOrderLabel.TabIndex = 0;
            this.placeOrderLabel.Text = "Place Order";
            // 
            // placeOrderCategory
            // 
            this.placeOrderCategory.AutoSize = true;
            this.placeOrderCategory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderCategory.Location = new System.Drawing.Point(33, 88);
            this.placeOrderCategory.Name = "placeOrderCategory";
            this.placeOrderCategory.Size = new System.Drawing.Size(76, 23);
            this.placeOrderCategory.TabIndex = 1;
            this.placeOrderCategory.Text = "category";
            // 
            // poCategoryComboBox
            // 
            this.poCategoryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.poCategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.poCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poCategoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poCategoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poCategoryComboBox.FocusedState.Parent = this.poCategoryComboBox;
            this.poCategoryComboBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.poCategoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.poCategoryComboBox.HoverState.Parent = this.poCategoryComboBox;
            this.poCategoryComboBox.ItemHeight = 30;
            this.poCategoryComboBox.Items.AddRange(new object[] {
            "Breakfast",
            "Italian",
            "Dessert",
            "Drinks"});
            this.poCategoryComboBox.ItemsAppearance.Parent = this.poCategoryComboBox;
            this.poCategoryComboBox.Location = new System.Drawing.Point(37, 114);
            this.poCategoryComboBox.Name = "poCategoryComboBox";
            this.poCategoryComboBox.ShadowDecoration.Parent = this.poCategoryComboBox;
            this.poCategoryComboBox.Size = new System.Drawing.Size(157, 36);
            this.poCategoryComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.poCategoryComboBox.TabIndex = 2;
            this.poCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.poCategoryComboBox_SelectedIndexChanged);
            // 
            // poSearch
            // 
            this.poSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.poSearch.DefaultText = "";
            this.poSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.poSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.poSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.poSearch.DisabledState.Parent = this.poSearch;
            this.poSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.poSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poSearch.FocusedState.Parent = this.poSearch;
            this.poSearch.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.poSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poSearch.HoverState.Parent = this.poSearch;
            this.poSearch.Location = new System.Drawing.Point(37, 177);
            this.poSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.poSearch.Name = "poSearch";
            this.poSearch.PasswordChar = '\0';
            this.poSearch.PlaceholderText = "Search";
            this.poSearch.SelectedText = "";
            this.poSearch.ShadowDecoration.Parent = this.poSearch;
            this.poSearch.Size = new System.Drawing.Size(157, 35);
            this.poSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.poSearch.TabIndex = 3;
            this.poSearch.TextChanged += new System.EventHandler(this.poSearch_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(36, 257);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 264);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // poItemNameLabel
            // 
            this.poItemNameLabel.AutoSize = true;
            this.poItemNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poItemNameLabel.Location = new System.Drawing.Point(313, 88);
            this.poItemNameLabel.Name = "poItemNameLabel";
            this.poItemNameLabel.Size = new System.Drawing.Size(95, 23);
            this.poItemNameLabel.TabIndex = 5;
            this.poItemNameLabel.Text = "Item Name";
            // 
            // poPriceLabel
            // 
            this.poPriceLabel.AutoSize = true;
            this.poPriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poPriceLabel.Location = new System.Drawing.Point(591, 88);
            this.poPriceLabel.Name = "poPriceLabel";
            this.poPriceLabel.Size = new System.Drawing.Size(47, 23);
            this.poPriceLabel.TabIndex = 6;
            this.poPriceLabel.Text = "Price";
            // 
            // poQuantityLabel
            // 
            this.poQuantityLabel.AutoSize = true;
            this.poQuantityLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poQuantityLabel.Location = new System.Drawing.Point(313, 151);
            this.poQuantityLabel.Name = "poQuantityLabel";
            this.poQuantityLabel.Size = new System.Drawing.Size(76, 23);
            this.poQuantityLabel.TabIndex = 7;
            this.poQuantityLabel.Text = "Quantity";
            // 
            // poTotalLabel
            // 
            this.poTotalLabel.AutoSize = true;
            this.poTotalLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poTotalLabel.Location = new System.Drawing.Point(591, 151);
            this.poTotalLabel.Name = "poTotalLabel";
            this.poTotalLabel.Size = new System.Drawing.Size(49, 23);
            this.poTotalLabel.TabIndex = 8;
            this.poTotalLabel.Text = "Total";
            // 
            // poItemNameTextbox
            // 
            this.poItemNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.poItemNameTextbox.DefaultText = "";
            this.poItemNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.poItemNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.poItemNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.poItemNameTextbox.DisabledState.Parent = this.poItemNameTextbox;
            this.poItemNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.poItemNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poItemNameTextbox.FocusedState.Parent = this.poItemNameTextbox;
            this.poItemNameTextbox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poItemNameTextbox.ForeColor = System.Drawing.Color.Black;
            this.poItemNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poItemNameTextbox.HoverState.Parent = this.poItemNameTextbox;
            this.poItemNameTextbox.Location = new System.Drawing.Point(284, 114);
            this.poItemNameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.poItemNameTextbox.Name = "poItemNameTextbox";
            this.poItemNameTextbox.PasswordChar = '\0';
            this.poItemNameTextbox.PlaceholderText = "";
            this.poItemNameTextbox.ReadOnly = true;
            this.poItemNameTextbox.SelectedText = "";
            this.poItemNameTextbox.ShadowDecoration.Parent = this.poItemNameTextbox;
            this.poItemNameTextbox.Size = new System.Drawing.Size(206, 36);
            this.poItemNameTextbox.TabIndex = 9;
            // 
            // poPriceTextbox
            // 
            this.poPriceTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.poPriceTextbox.DefaultText = "";
            this.poPriceTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.poPriceTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.poPriceTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.poPriceTextbox.DisabledState.Parent = this.poPriceTextbox;
            this.poPriceTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.poPriceTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poPriceTextbox.FocusedState.Parent = this.poPriceTextbox;
            this.poPriceTextbox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poPriceTextbox.ForeColor = System.Drawing.Color.Black;
            this.poPriceTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poPriceTextbox.HoverState.Parent = this.poPriceTextbox;
            this.poPriceTextbox.Location = new System.Drawing.Point(519, 114);
            this.poPriceTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.poPriceTextbox.Name = "poPriceTextbox";
            this.poPriceTextbox.PasswordChar = '\0';
            this.poPriceTextbox.PlaceholderText = "";
            this.poPriceTextbox.ReadOnly = true;
            this.poPriceTextbox.SelectedText = "";
            this.poPriceTextbox.ShadowDecoration.Parent = this.poPriceTextbox;
            this.poPriceTextbox.Size = new System.Drawing.Size(207, 36);
            this.poPriceTextbox.TabIndex = 10;
            // 
            // poQuantityNumeric
            // 
            this.poQuantityNumeric.BackColor = System.Drawing.Color.Transparent;
            this.poQuantityNumeric.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.poQuantityNumeric.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.poQuantityNumeric.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.poQuantityNumeric.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.poQuantityNumeric.DisabledState.Parent = this.poQuantityNumeric;
            this.poQuantityNumeric.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.poQuantityNumeric.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.poQuantityNumeric.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poQuantityNumeric.FocusedState.Parent = this.poQuantityNumeric;
            this.poQuantityNumeric.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poQuantityNumeric.ForeColor = System.Drawing.Color.Black;
            this.poQuantityNumeric.Location = new System.Drawing.Point(284, 177);
            this.poQuantityNumeric.Name = "poQuantityNumeric";
            this.poQuantityNumeric.ShadowDecoration.Parent = this.poQuantityNumeric;
            this.poQuantityNumeric.Size = new System.Drawing.Size(206, 35);
            this.poQuantityNumeric.TabIndex = 11;
            this.poQuantityNumeric.UpDownButtonFillColor = System.Drawing.Color.DarkCyan;
            this.poQuantityNumeric.ValueChanged += new System.EventHandler(this.poQuantityNumeric_ValueChanged);
            // 
            // poTotalTextbox
            // 
            this.poTotalTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.poTotalTextbox.DefaultText = "";
            this.poTotalTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.poTotalTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.poTotalTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.poTotalTextbox.DisabledState.Parent = this.poTotalTextbox;
            this.poTotalTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.poTotalTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poTotalTextbox.FocusedState.Parent = this.poTotalTextbox;
            this.poTotalTextbox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poTotalTextbox.ForeColor = System.Drawing.Color.Black;
            this.poTotalTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.poTotalTextbox.HoverState.Parent = this.poTotalTextbox;
            this.poTotalTextbox.Location = new System.Drawing.Point(519, 177);
            this.poTotalTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.poTotalTextbox.Name = "poTotalTextbox";
            this.poTotalTextbox.PasswordChar = '\0';
            this.poTotalTextbox.PlaceholderText = "";
            this.poTotalTextbox.ReadOnly = true;
            this.poTotalTextbox.SelectedText = "";
            this.poTotalTextbox.ShadowDecoration.Parent = this.poTotalTextbox;
            this.poTotalTextbox.Size = new System.Drawing.Size(207, 36);
            this.poTotalTextbox.TabIndex = 12;
            // 
            // poAddToCart
            // 
            this.poAddToCart.BorderRadius = 20;
            this.poAddToCart.CheckedState.Parent = this.poAddToCart;
            this.poAddToCart.CustomImages.Parent = this.poAddToCart;
            this.poAddToCart.FillColor = System.Drawing.Color.DarkCyan;
            this.poAddToCart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poAddToCart.ForeColor = System.Drawing.Color.White;
            this.poAddToCart.HoverState.Parent = this.poAddToCart;
            this.poAddToCart.Location = new System.Drawing.Point(541, 219);
            this.poAddToCart.Name = "poAddToCart";
            this.poAddToCart.ShadowDecoration.Parent = this.poAddToCart;
            this.poAddToCart.Size = new System.Drawing.Size(161, 43);
            this.poAddToCart.TabIndex = 13;
            this.poAddToCart.Text = "Add to cart";
            this.poAddToCart.Click += new System.EventHandler(this.poAddToCart_Click);
            // 
            // poCartDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.poCartDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.poCartDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.poCartDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.poCartDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.poCartDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.poCartDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poCartDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.poCartDataGrid.ColumnHeadersHeight = 25;
            this.poCartDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poCartDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.poCartDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.poCartDataGrid.EnableHeadersVisualStyles = false;
            this.poCartDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.poCartDataGrid.Location = new System.Drawing.Point(217, 285);
            this.poCartDataGrid.Name = "poCartDataGrid";
            this.poCartDataGrid.ReadOnly = true;
            this.poCartDataGrid.RowHeadersVisible = false;
            this.poCartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poCartDataGrid.Size = new System.Drawing.Size(525, 171);
            this.poCartDataGrid.TabIndex = 14;
            this.poCartDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.poCartDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.poCartDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.poCartDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.poCartDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.poCartDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.poCartDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.poCartDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.poCartDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkCyan;
            this.poCartDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.poCartDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.poCartDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.poCartDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.poCartDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            this.poCartDataGrid.ThemeStyle.ReadOnly = true;
            this.poCartDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.poCartDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.poCartDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poCartDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.poCartDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.poCartDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.poCartDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // poRemoveItem
            // 
            this.poRemoveItem.BorderRadius = 20;
            this.poRemoveItem.CheckedState.Parent = this.poRemoveItem;
            this.poRemoveItem.CustomImages.Parent = this.poRemoveItem;
            this.poRemoveItem.FillColor = System.Drawing.Color.DarkCyan;
            this.poRemoveItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poRemoveItem.ForeColor = System.Drawing.Color.White;
            this.poRemoveItem.HoverState.Parent = this.poRemoveItem;
            this.poRemoveItem.Location = new System.Drawing.Point(217, 474);
            this.poRemoveItem.Name = "poRemoveItem";
            this.poRemoveItem.ShadowDecoration.Parent = this.poRemoveItem;
            this.poRemoveItem.Size = new System.Drawing.Size(161, 43);
            this.poRemoveItem.TabIndex = 15;
            this.poRemoveItem.Text = "Remove";
            this.poRemoveItem.Click += new System.EventHandler(this.poRemoveItem_Click);
            // 
            // poOrder
            // 
            this.poOrder.BorderRadius = 20;
            this.poOrder.CheckedState.Parent = this.poOrder;
            this.poOrder.CustomImages.Parent = this.poOrder;
            this.poOrder.FillColor = System.Drawing.Color.DarkCyan;
            this.poOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poOrder.ForeColor = System.Drawing.Color.White;
            this.poOrder.HoverState.Parent = this.poOrder;
            this.poOrder.Location = new System.Drawing.Point(581, 474);
            this.poOrder.Name = "poOrder";
            this.poOrder.ShadowDecoration.Parent = this.poOrder;
            this.poOrder.Size = new System.Drawing.Size(161, 43);
            this.poOrder.TabIndex = 16;
            this.poOrder.Text = "Order";
            this.poOrder.Click += new System.EventHandler(this.poOrder_Click);
            // 
            // poGrandTotalLabel
            // 
            this.poGrandTotalLabel.AutoSize = true;
            this.poGrandTotalLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poGrandTotalLabel.Location = new System.Drawing.Point(416, 459);
            this.poGrandTotalLabel.Name = "poGrandTotalLabel";
            this.poGrandTotalLabel.Size = new System.Drawing.Size(125, 29);
            this.poGrandTotalLabel.TabIndex = 17;
            this.poGrandTotalLabel.Text = "Grand total";
            // 
            // poGrandTotalPrice
            // 
            this.poGrandTotalPrice.AutoSize = true;
            this.poGrandTotalPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poGrandTotalPrice.Location = new System.Drawing.Point(468, 494);
            this.poGrandTotalPrice.Name = "poGrandTotalPrice";
            this.poGrandTotalPrice.Size = new System.Drawing.Size(31, 23);
            this.poGrandTotalPrice.TabIndex = 18;
            this.poGrandTotalPrice.Text = "$0";
            // 
            // UserControl_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.poGrandTotalPrice);
            this.Controls.Add(this.poGrandTotalLabel);
            this.Controls.Add(this.poOrder);
            this.Controls.Add(this.poRemoveItem);
            this.Controls.Add(this.poCartDataGrid);
            this.Controls.Add(this.poAddToCart);
            this.Controls.Add(this.poTotalTextbox);
            this.Controls.Add(this.poQuantityNumeric);
            this.Controls.Add(this.poPriceTextbox);
            this.Controls.Add(this.poItemNameTextbox);
            this.Controls.Add(this.poTotalLabel);
            this.Controls.Add(this.poQuantityLabel);
            this.Controls.Add(this.poPriceLabel);
            this.Controls.Add(this.poItemNameLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.poSearch);
            this.Controls.Add(this.poCategoryComboBox);
            this.Controls.Add(this.placeOrderCategory);
            this.Controls.Add(this.placeOrderLabel);
            this.Name = "UserControl_PlaceOrder";
            this.Size = new System.Drawing.Size(766, 540);
            this.Load += new System.EventHandler(this.UserControl_PlaceOrder_Load);
            this.Leave += new System.EventHandler(this.UserControl_PlaceOrder_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.poQuantityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poCartDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseUSPO;
        private Guna.UI2.WinForms.Guna2ComboBox poCategoryComboBox;
        private System.Windows.Forms.Label placeOrderCategory;
        private System.Windows.Forms.Label placeOrderLabel;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2TextBox poSearch;
        private System.Windows.Forms.Label poTotalLabel;
        private System.Windows.Forms.Label poQuantityLabel;
        private System.Windows.Forms.Label poPriceLabel;
        private System.Windows.Forms.Label poItemNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox poPriceTextbox;
        private Guna.UI2.WinForms.Guna2TextBox poItemNameTextbox;
        private Guna.UI2.WinForms.Guna2NumericUpDown poQuantityNumeric;
        private Guna.UI2.WinForms.Guna2TextBox poTotalTextbox;
        private Guna.UI2.WinForms.Guna2Button poAddToCart;
        private Guna.UI2.WinForms.Guna2DataGridView poCartDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Button poOrder;
        private Guna.UI2.WinForms.Guna2Button poRemoveItem;
        private System.Windows.Forms.Label poGrandTotalPrice;
        private System.Windows.Forms.Label poGrandTotalLabel;
    }
}
