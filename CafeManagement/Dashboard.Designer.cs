namespace CafeManagement
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewOrders = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.XButton = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.RemoveItemsButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateItemsButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddItemButton = new Guna.UI2.WinForms.Guna2Button();
            this.PlaceOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.MainBackRight = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userControl_UppdateItems1 = new CafeManagement.UserControls.UserControl_UppdateItems();
            this.userControl_PlaceOrder1 = new CafeManagement.UserControls.UserControl_PlaceOrder();
            this.userControl_AddItems1 = new CafeManagement.UserControls.UserControl_AddItems();
            this.userControl_Welcome1 = new CafeManagement.UserControl_Welcome();
            this.panel1.SuspendLayout();
            this.MainBackRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.panel1.Controls.Add(this.ViewOrders);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.XButton);
            this.panel1.Controls.Add(this.RemoveItemsButton);
            this.panel1.Controls.Add(this.UpdateItemsButton);
            this.panel1.Controls.Add(this.AddItemButton);
            this.panel1.Controls.Add(this.PlaceOrderButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 537);
            this.panel1.TabIndex = 0;
            // 
            // ViewOrders
            // 
            this.ViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ViewOrders.BorderRadius = 15;
            this.ViewOrders.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ViewOrders.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.ViewOrders.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(124)))));
            this.ViewOrders.CheckedState.Parent = this.ViewOrders;
            this.ViewOrders.CustomImages.Parent = this.ViewOrders;
            this.ViewOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ViewOrders.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOrders.ForeColor = System.Drawing.Color.White;
            this.ViewOrders.HoverState.Parent = this.ViewOrders;
            this.ViewOrders.Location = new System.Drawing.Point(22, 147);
            this.ViewOrders.Name = "ViewOrders";
            this.ViewOrders.ShadowDecoration.Parent = this.ViewOrders;
            this.ViewOrders.Size = new System.Drawing.Size(194, 45);
            this.ViewOrders.TabIndex = 5;
            this.ViewOrders.Text = "Orders";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Honeydew;
            this.linkLabel1.Location = new System.Drawing.Point(80, 501);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // XButton
            // 
            this.XButton.CheckedState.Parent = this.XButton;
            this.XButton.CustomImages.Parent = this.XButton;
            this.XButton.FillColor2 = System.Drawing.Color.GreenYellow;
            this.XButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.ForeColor = System.Drawing.Color.White;
            this.XButton.HoverState.Parent = this.XButton;
            this.XButton.Location = new System.Drawing.Point(3, 3);
            this.XButton.Name = "XButton";
            this.XButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.XButton.ShadowDecoration.Parent = this.XButton;
            this.XButton.Size = new System.Drawing.Size(24, 24);
            this.XButton.TabIndex = 0;
            this.XButton.Text = "X";
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // RemoveItemsButton
            // 
            this.RemoveItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.RemoveItemsButton.BorderRadius = 15;
            this.RemoveItemsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RemoveItemsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.RemoveItemsButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(124)))));
            this.RemoveItemsButton.CheckedState.Parent = this.RemoveItemsButton;
            this.RemoveItemsButton.CustomImages.Parent = this.RemoveItemsButton;
            this.RemoveItemsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.RemoveItemsButton.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItemsButton.ForeColor = System.Drawing.Color.White;
            this.RemoveItemsButton.HoverState.Parent = this.RemoveItemsButton;
            this.RemoveItemsButton.Location = new System.Drawing.Point(22, 300);
            this.RemoveItemsButton.Name = "RemoveItemsButton";
            this.RemoveItemsButton.ShadowDecoration.Parent = this.RemoveItemsButton;
            this.RemoveItemsButton.Size = new System.Drawing.Size(194, 45);
            this.RemoveItemsButton.TabIndex = 3;
            this.RemoveItemsButton.Text = "Remove Items";
            // 
            // UpdateItemsButton
            // 
            this.UpdateItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.UpdateItemsButton.BorderRadius = 15;
            this.UpdateItemsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UpdateItemsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.UpdateItemsButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(124)))));
            this.UpdateItemsButton.CheckedState.Parent = this.UpdateItemsButton;
            this.UpdateItemsButton.CustomImages.Parent = this.UpdateItemsButton;
            this.UpdateItemsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.UpdateItemsButton.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemsButton.ForeColor = System.Drawing.Color.White;
            this.UpdateItemsButton.HoverState.Parent = this.UpdateItemsButton;
            this.UpdateItemsButton.Location = new System.Drawing.Point(22, 249);
            this.UpdateItemsButton.Name = "UpdateItemsButton";
            this.UpdateItemsButton.ShadowDecoration.Parent = this.UpdateItemsButton;
            this.UpdateItemsButton.Size = new System.Drawing.Size(194, 45);
            this.UpdateItemsButton.TabIndex = 2;
            this.UpdateItemsButton.Text = "Update Items";
            this.UpdateItemsButton.Click += new System.EventHandler(this.UpdateItemsButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.AddItemButton.BorderRadius = 15;
            this.AddItemButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddItemButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.AddItemButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(124)))));
            this.AddItemButton.CheckedState.Parent = this.AddItemButton;
            this.AddItemButton.CustomImages.Parent = this.AddItemButton;
            this.AddItemButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.AddItemButton.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.HoverState.Parent = this.AddItemButton;
            this.AddItemButton.Location = new System.Drawing.Point(22, 198);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.ShadowDecoration.Parent = this.AddItemButton;
            this.AddItemButton.Size = new System.Drawing.Size(194, 45);
            this.AddItemButton.TabIndex = 1;
            this.AddItemButton.Text = "Add Items";
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.PlaceOrderButton.BorderRadius = 15;
            this.PlaceOrderButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.PlaceOrderButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.PlaceOrderButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(124)))));
            this.PlaceOrderButton.CheckedState.Parent = this.PlaceOrderButton;
            this.PlaceOrderButton.CustomImages.Parent = this.PlaceOrderButton;
            this.PlaceOrderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.PlaceOrderButton.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderButton.ForeColor = System.Drawing.Color.White;
            this.PlaceOrderButton.HoverState.Parent = this.PlaceOrderButton;
            this.PlaceOrderButton.Location = new System.Drawing.Point(22, 96);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.ShadowDecoration.Parent = this.PlaceOrderButton;
            this.PlaceOrderButton.Size = new System.Drawing.Size(194, 45);
            this.PlaceOrderButton.TabIndex = 0;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // MainBackRight
            // 
            this.MainBackRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.MainBackRight.Controls.Add(this.userControl_UppdateItems1);
            this.MainBackRight.Controls.Add(this.userControl_PlaceOrder1);
            this.MainBackRight.Controls.Add(this.userControl_AddItems1);
            this.MainBackRight.Controls.Add(this.userControl_Welcome1);
            this.MainBackRight.ForeColor = System.Drawing.Color.GhostWhite;
            this.MainBackRight.Location = new System.Drawing.Point(209, 12);
            this.MainBackRight.Name = "MainBackRight";
            this.MainBackRight.Size = new System.Drawing.Size(763, 537);
            this.MainBackRight.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.MainBackRight;
            // 
            // userControl_UppdateItems1
            // 
            this.userControl_UppdateItems1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.userControl_UppdateItems1.ForeColor = System.Drawing.Color.Black;
            this.userControl_UppdateItems1.Location = new System.Drawing.Point(-3, -3);
            this.userControl_UppdateItems1.Name = "userControl_UppdateItems1";
            this.userControl_UppdateItems1.Size = new System.Drawing.Size(766, 540);
            this.userControl_UppdateItems1.TabIndex = 3;
            // 
            // userControl_PlaceOrder1
            // 
            this.userControl_PlaceOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.userControl_PlaceOrder1.ForeColor = System.Drawing.Color.Black;
            this.userControl_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.userControl_PlaceOrder1.Name = "userControl_PlaceOrder1";
            this.userControl_PlaceOrder1.Size = new System.Drawing.Size(766, 540);
            this.userControl_PlaceOrder1.TabIndex = 2;
            this.userControl_PlaceOrder1.User = null;
            // 
            // userControl_AddItems1
            // 
            this.userControl_AddItems1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
            this.userControl_AddItems1.ForeColor = System.Drawing.Color.Black;
            this.userControl_AddItems1.Location = new System.Drawing.Point(-3, 0);
            this.userControl_AddItems1.Name = "userControl_AddItems1";
            this.userControl_AddItems1.Size = new System.Drawing.Size(766, 540);
            this.userControl_AddItems1.TabIndex = 1;
            // 
            // userControl_Welcome1
            // 
            this.userControl_Welcome1.ForeColor = System.Drawing.Color.Black;
            this.userControl_Welcome1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Welcome1.Name = "userControl_Welcome1";
            this.userControl_Welcome1.Size = new System.Drawing.Size(763, 540);
            this.userControl_Welcome1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MainBackRight);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainBackRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainBackRight;
        private Guna.UI2.WinForms.Guna2Button PlaceOrderButton;
        private Guna.UI2.WinForms.Guna2Button RemoveItemsButton;
        private Guna.UI2.WinForms.Guna2Button UpdateItemsButton;
        private Guna.UI2.WinForms.Guna2Button AddItemButton;
        private Guna.UI2.WinForms.Guna2GradientCircleButton XButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private UserControl_Welcome userControl_Welcome1;
        private UserControls.UserControl_AddItems userControl_AddItems1;
        private UserControls.UserControl_PlaceOrder userControl_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Button ViewOrders;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UserControls.UserControl_UppdateItems userControl_UppdateItems1;
    }
}