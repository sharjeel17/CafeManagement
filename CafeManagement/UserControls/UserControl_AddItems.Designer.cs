namespace CafeManagement.UserControls
{
    partial class UserControl_AddItems
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.addNewItemLabel = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new Guna.UI2.WinForms.Guna2Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // addNewItemLabel
            // 
            this.addNewItemLabel.AutoSize = true;
            this.addNewItemLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewItemLabel.Location = new System.Drawing.Point(300, 13);
            this.addNewItemLabel.Name = "addNewItemLabel";
            this.addNewItemLabel.Size = new System.Drawing.Size(167, 29);
            this.addNewItemLabel.TabIndex = 0;
            this.addNewItemLabel.Text = "Add New Items";
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceLabel.Location = new System.Drawing.Point(110, 344);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(55, 26);
            this.itemPriceLabel.TabIndex = 3;
            this.itemPriceLabel.Text = "Price";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Breakfast",
            "Italian",
            "Dessert",
            "Drinks"});
            this.categoryComboBox.Location = new System.Drawing.Point(114, 137);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(273, 34);
            this.categoryComboBox.TabIndex = 4;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTextBox.Location = new System.Drawing.Point(114, 270);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(273, 34);
            this.itemNameTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(114, 392);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(273, 34);
            this.priceTextBox.TabIndex = 7;
            // 
            // AddItemButton
            // 
            this.AddItemButton.BorderRadius = 20;
            this.AddItemButton.CheckedState.Parent = this.AddItemButton;
            this.AddItemButton.CustomImages.Parent = this.AddItemButton;
            this.AddItemButton.FillColor = System.Drawing.Color.DarkCyan;
            this.AddItemButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.HoverState.Parent = this.AddItemButton;
            this.AddItemButton.Location = new System.Drawing.Point(296, 463);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.ShadowDecoration.Parent = this.AddItemButton;
            this.AddItemButton.Size = new System.Drawing.Size(180, 45);
            this.AddItemButton.TabIndex = 8;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.Location = new System.Drawing.Point(110, 216);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(111, 26);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "Item Name";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(110, 97);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(90, 26);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // UserControl_AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.addNewItemLabel);
            this.Name = "UserControl_AddItems";
            this.Size = new System.Drawing.Size(763, 537);
            this.Leave += new System.EventHandler(this.UserControl_AddItems_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label addNewItemLabel;
        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private Guna.UI2.WinForms.Guna2Button AddItemButton;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label itemNameLabel;
    }
}
