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

namespace CafeManagement
{
    public partial class CafeLoginPage : Form
    {
        public CafeLoginPage()
        {
            InitializeComponent();
            SignUpButton.Hide();
            SignInLink.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //establish connection
            string ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                //query to check if valid username
                string Query = "SELECT * FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(Query, connection);

                //avoid sql injection and add username textbox value in to sql query
                cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                var response = cmd.ExecuteReader();

                //CHECK IF VALID USERNAME FIRST
                //if no username matches then give user error
                if (!(response.Read()))
                    MessageBox.Show("Username invalid", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //IF VALID USERNAME THEN CHECK PASSWORD
                else 
                {
                    Console.WriteLine(BCrypt.Net.BCrypt.EnhancedVerify(PasswordTextBox.Text, response["Password"].ToString()));

                    //check if password is the same as stored hashed password using bcrypt
                    //if password is incorrect then show user error message
                    if (!(BCrypt.Net.BCrypt.EnhancedVerify(PasswordTextBox.Text, response["Password"].ToString())))
                        MessageBox.Show("Incorrect password", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //IF VALID PASSWORD, CHECK USER STATUS
                    else 
                    {
                        //if the user is an admin, then give admin dashboard
                        if (response["Username"].ToString() == "Admin")
                        {
                            Dashboard dashboard = new Dashboard("Admin");
                            dashboard.Show();
                            this.Hide();
                        }

                        //otherwise give normal user dashboard, passing in the username as the argument
                        else 
                        {
                            Dashboard dashboard = new Dashboard(response["Username"].ToString());
                            dashboard.Show();
                            this.Hide();
                        }
                    }

                }
            }

            //error handling
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                //close connectyion
                connection.Close();
            }
        }

        //Guest login
        private void GuestLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard dashboard = new Dashboard("Guest");
            dashboard.Show();
            this.Hide();
        }

        //hash password using bcrypt
        private string HashPassword() 
        {
            string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(PasswordTextBox.Text, 13);
            return passwordHash;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //establish connection
            string ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                //query to check if valid username
                string Query = "SELECT * FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(Query, connection);

                //avoid SQL Injection
                cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                var response = cmd.ExecuteReader();

                //check if username matches any in the database already
                if (response.Read()) 
                    MessageBox.Show("Username is already taken", "Please try a different username", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //otherwise add username and password
                else
                {
                    //clear last response 
                    response.Close();
                    response.Dispose();

                    //add username and password to database
                    Query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    cmd = new SqlCommand(Query, connection);
                    cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", HashPassword());
                    int response2 = cmd.ExecuteNonQuery();

                    //show user login button now
                    MessageBox.Show("You have signed up sucessfully!", "Please log in", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    SignUpButton.Hide();
                    LoginButton.Show(); 
                }
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

        //sign up link at bottom right
        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpButton.Show();
            LoginButton.Hide();
            SignUpLink.Hide();
            SignInLink.Show();
            
        }

        //sign in link at bottom right 
        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpButton.Hide();
            LoginButton.Show();
            SignUpLink.Show();
            SignInLink.Hide(); 

        }
    }
}
