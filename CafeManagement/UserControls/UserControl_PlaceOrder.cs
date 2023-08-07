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
    public partial class UserControl_PlaceOrder : UserControl
    {
        public UserControl_PlaceOrder()
        {
            InitializeComponent();
        }

        public string User { get; set; }

        private void UserControl_PlaceOrder_Load(object sender, EventArgs e)
        {
            //make sure default values are 0 to reduce arthimetic related errors
            poTotalTextbox.Text = "0";
            poPriceTextbox.Text = "0";
            poQuantityNumeric.Value = 0;

        }

        private void UserControl_PlaceOrder_Leave(object sender, EventArgs e)
        {

        }

        //When selected category changes in combobox
        //Show all items in list from the database that match the category
        private void poCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear any items in listbox from before
            listBox1.Items.Clear();

            //selected category put in to string
            string category = poCategoryComboBox.Text;

            //establish connection
            string ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                connection.Open();

                //get names of items from selected category
                string Query = "SELECT name FROM items where category = @category";
                SqlCommand cmd = new SqlCommand(Query, connection);

                //add category parameter
                cmd.Parameters.AddWithValue("@category", category);

                //make DataAdapter and use it to populate dataset with given query/cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                //fill table up with data
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());

                //CAN DO ABOVE WITH READER INSTEAD, WHICH IS EASIER
                //ABOVE IS DONE FOR LEARNING PURPOSES AND TO LEARN NEW METHODS OF FILLING DATA
            }

            //Exception handler
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //close connection
            finally
            {
                connection.Close();
            }

        }

        //show all items in list from the database that match category and search
        private void poSearch_TextChanged(object sender, EventArgs e)
        {
            //check to see if anything is inside of search box
            if (string.IsNullOrEmpty(poSearch.Text)) return;

            //clear any items in listbox from before
            listBox1.Items.Clear();

            //selected category and searched name
            string category = poCategoryComboBox.Text;
            string name = "%" + poSearch.Text + "%";

            //establish connection
            string ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                connection.Open();

                //get names of items from selected category and use wildcard LIKE to search for pattern
                string Query = "SELECT name FROM items where category = @category AND name LIKE @name";
                SqlCommand cmd = new SqlCommand(Query, connection);

                //add category parameters and execute command
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@name", name);
                var response = cmd.ExecuteReader();

                //read until no more rows in response and add to listbox
                while (response.Read())
                {
                    listBox1.Items.Add(response["name"].ToString());
                }

                //ABOVE METHOD IS EASIER THAN METHOD DONE IN COMBOBOX
            }

            //Exception handler
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //close connection
            finally
            {
                connection.Close();
            }

        }

        //add name & price of selected item from the listbox to textboxes
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            poQuantityNumeric.Value = 0;
            poTotalTextbox.Text = "0";

            //set item name as selected item name from listbox
            poItemNameTextbox.Text = listBox1.GetItemText(listBox1.SelectedItem);

            //establish connection
            SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True");

            try
            {
                //open connection
                connection.Open();

                //query to get price of the item
                string Query = "SELECT price FROM items WHERE name = @name";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@name", poItemNameTextbox.Text);

                //display price on price textbox
                var response = cmd.ExecuteReader();
                response.Read();
                poPriceTextbox.Text = response["price"].ToString();

                //clear last response 
                response.Close();
                response.Dispose();

            }

            catch (Exception ex) { Console.WriteLine(ex); MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally
            {
                connection.Close();
            }

        }

        //calculate and change value of total for current item selected
        private void poQuantityNumeric_ValueChanged(object sender, EventArgs e)
        {
            //if there is nothing in price textbox then simply return
            //otherwise code below will generate error
            if (string.IsNullOrEmpty(poPriceTextbox.Text)) return;

            decimal totalPrice = poQuantityNumeric.Value * decimal.Parse(poPriceTextbox.Text);
            poTotalTextbox.Text = totalPrice.ToString();
        }

        //Add items to cart
        private int cartTotal = 0;
        private void poAddToCart_Click(object sender, EventArgs e)
        {
            //if there is no item selected or the selected item's quantity is 0
            //then item cannot be added to the cart
            if ((string.IsNullOrEmpty(poItemNameTextbox.Text)) || (poQuantityNumeric.Value == 0))
            {
                MessageBox.Show("Please choose an item and select a quantity more than 0", "No selected item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            //add new row and then get new row number
            int row = poCartDataGrid.Rows.Add();

            //add items to each cell/column in row
            poCartDataGrid.Rows[row].Cells[0].Value = poItemNameTextbox.Text;
            poCartDataGrid.Rows[row].Cells[1].Value = poPriceTextbox.Text;
            poCartDataGrid.Rows[row].Cells[2].Value = poQuantityNumeric.Value;
            poCartDataGrid.Rows[row].Cells[3].Value = poTotalTextbox.Text;

            //recalculate grand total
            cartTotal += int.Parse(poTotalTextbox.Text);
            poGrandTotalPrice.Text = cartTotal.ToString();
        }

        private void poRemoveItem_Click(object sender, EventArgs e)
        {
            //if no item has been added to the cart yet
            //then simply return and do nothing
            //row count is 1 when cart is empty
            //Also make sure user does not try to delete empty row (default row)
            if ((this.poCartDataGrid.Rows.Count < 2) || (this.poCartDataGrid.SelectedRows[0].Cells[0].Value == null )) return;

            try 
            {
                //remove item amount from total
                cartTotal -= int.Parse(this.poCartDataGrid.SelectedRows[0].Cells[3].Value.ToString()); 
                poGrandTotalPrice.Text = cartTotal.ToString();

                //remove item from rows/cart
                poCartDataGrid.Rows.RemoveAt(this.poCartDataGrid.SelectedRows[0].Index);

            }

            catch (Exception ex) { Console.WriteLine(ex); MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //User orders
        private void poOrder_Click(object sender, EventArgs e)
        {
            //Don't execute order if there are no items added
            //default starting row value is 1 in datagrid
            if (poCartDataGrid.Rows.Count < 2) return;

            //establish connection
            SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True");

            try
            {
                //open connection
                connection.Open();

                //insert values and get SCOPE_Identity which will give id of row added in current session
                //This table will store what user has what orderId and whether they are completed or not
                string Query = "INSERT INTO UserOrders (Username, Amount, Active) VALUES (@username, @amount, @active); SELECT OrderID FROM UserOrders WHERE OrderID = SCOPE_Identity();";
                SqlCommand cmd = new SqlCommand(Query, connection);

                //add parameters
                cmd.Parameters.AddWithValue("@username", this.User);
                cmd.Parameters.AddWithValue("@amount", poGrandTotalPrice.Text);
                cmd.Parameters.AddWithValue("@active", "1");

                //execute and get returned Order ID
                var response = cmd.ExecuteReader();
                response.Read();
                int OrderID = int.Parse(response["OrderID"].ToString());

                //close and dispose response
                response.Close();
                response.Dispose();

                //Add all of the items ordered in to database with the current OrderID
                //indexing ends at count-1 because last row is default empty row
                for (int i = 0; i < poCartDataGrid.Rows.Count-1; i++) 
                {
                    //query to insert item details for current row
                    Query = "INSERT INTO OrderDetails (OrderID, Item, Quantity, Price) VALUES (@orderID, @item, @quantity, @price)";
                    cmd = new SqlCommand(Query, connection);

                    //add parameters
                    cmd.Parameters.AddWithValue("@orderID", OrderID);
                    cmd.Parameters.AddWithValue("@item", poCartDataGrid.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@quantity", poCartDataGrid.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@price", poCartDataGrid.Rows[i].Cells[3].Value);
                    //execute
                    cmd.ExecuteNonQuery();
                }

                //Clear all of the rows
                poCartDataGrid.Rows.Clear();
                cartTotal = 0;
                poGrandTotalPrice.Text = "0";
            }

            catch (Exception ex) { Console.WriteLine(ex); MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            finally { connection.Close(); }

        }
    }
}
