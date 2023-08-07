using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.UserControls
{
    public partial class UserControl_AddItems : UserControl
    {
        public UserControl_AddItems()
        {
            InitializeComponent();
        }
        private void clearAll()
        {
            itemNameTextBox.Clear();
            categoryComboBox.SelectedIndex = -1;
            priceTextBox.Clear();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            //establish connection
            string ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                //open connection
                connection.Open();

                //query to add items in to database
                string query = "INSERT INTO items (name,category,price) VALUES (@name,@category,@price)";
                SqlCommand cmd = new SqlCommand(query, connection);

                //add parameters to SqlCommand query
                cmd.Parameters.AddWithValue("@name", itemNameTextBox.Text);
                cmd.Parameters.AddWithValue("@category", categoryComboBox.Text);
                cmd.Parameters.AddWithValue("@price", priceTextBox.Text);

                //add to database
                int response = cmd.ExecuteNonQuery();
                if (response != 0)
                MessageBox.Show("Sucess!", "Items have been added to database", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else MessageBox.Show("Failed", "Something went wrong and was not caught by exception", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearAll();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                //close connection
                connection.Close();
            }
        }

        private void UserControl_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
