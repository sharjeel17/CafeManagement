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
    public partial class UserControl_UppdateItems : UserControl
    {
        public UserControl_UppdateItems()
        {
            InitializeComponent();
        }

        private void UserControl_UppdateItems_Load(object sender, EventArgs e)
        {
            LoadItems();

        }

        //Load and fill datagrid when page is loaded with default items
        private void LoadItems() 
        {

            //establish connection
            SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True");

            try
            {
                //open connection
                connection.Open();

                //query to get items from default category
                string query = "SELECT * FROM items WHERE category = @category";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@category", uiCategoryComboBox.Text);

                //set up adapter and input command in it
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //add data from queried result to dataset
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                //set datagrid's source to dataset's table
               uiDataGrid.DataSource = ds.Tables[0];

            }

            //exception handling
            catch (Exception ex) { Console.WriteLine(ex); MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //close connection
            finally { connection.Close(); }

        }

        //Get and list all items with selectedcategory in to datagrid
        private void uiCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (uiCategoryComboBox.SelectedIndex < 0) return;
            //Load items to datagrid using current selected category in combobox
            LoadItems();

        }

        //get and list all items with matching text pattern in to datagrid
        private void itemSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if ( (uiCategoryComboBox.SelectedIndex < 0) || (string.IsNullOrEmpty(itemSearchTextBox.Text)) ) return;
            //establish connection
            SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True");

            try
            {
                //open connection
                connection.Open();

                //query to get items from default category
                string query = "SELECT * FROM items WHERE category = @category AND name LIKE @name";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@category", uiCategoryComboBox.Text);
                cmd.Parameters.AddWithValue("@name", "%"+itemSearchTextBox.Text+"%");

                //set up adapter and input command in it
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //add data from queried result to dataset
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                //set datagrid's source to dataset's table
                uiDataGrid.DataSource = ds.Tables[0];

            }

            //exception handling
            catch (Exception ex) { Console.WriteLine(ex); MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //close connection
            finally { connection.Close(); }

        }

        //get item ID of selected item and fill textboxes with item info
        private int itemID = -1;
        private void uiDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //make sure user does not try to select empty row
            if ( (string.IsNullOrEmpty(uiDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString()) ) || ( uiDataGrid.Rows.Count < 2 ) ) return;

            //extract item ID and fill textboxes with item information
            itemID = int.Parse(uiDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            updateItemNameTextBox.Text = uiDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            updateCategoryTextBox.Text = uiDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            updatePriceTextBox.Text = uiDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void updateItemButton_Click(object sender, EventArgs e)
        {

        }
    }
}
