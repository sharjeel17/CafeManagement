using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Dashboard : Form
    {
        private string User { get; set; }
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string user)
        {
            InitializeComponent();

            //if user is admin
            if (user == "Admin")
            {
                User = user;
                AddItemButton.Show();
                RemoveItemsButton.Show();
                UpdateItemsButton.Show();
            }

            //normal registered user or Guest
            else 
            {
                User = user;
                AddItemButton.Hide();
                RemoveItemsButton.Hide();
                UpdateItemsButton.Hide();

            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userControl_AddItems1.Hide();
            userControl_PlaceOrder1.Hide();
            userControl_UppdateItems1.Hide();
            userControl_PlaceOrder1.User = User;
        }

        //exit application
        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //LogOut button in dashboard
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CafeLoginPage loginPage = new CafeLoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            userControl_Welcome1.Hide();
            userControl_PlaceOrder1.Hide();
            userControl_UppdateItems1.Hide();
            userControl_AddItems1.Show();
            userControl_AddItems1.BringToFront();

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            userControl_Welcome1.Hide();
            userControl_AddItems1.Hide();
            userControl_UppdateItems1.Hide();
            userControl_PlaceOrder1.Show();
            userControl_PlaceOrder1.BringToFront();
        }

        private void UpdateItemsButton_Click(object sender, EventArgs e)
        {
            userControl_Welcome1.Hide();
            userControl_AddItems1.Hide();
            userControl_PlaceOrder1.Hide();
            userControl_UppdateItems1.Show();
            userControl_UppdateItems1.BringToFront();
        }
    }
}
