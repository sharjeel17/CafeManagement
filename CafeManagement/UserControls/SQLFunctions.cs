using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.UserControls
{
    internal class SQLFunctions
    {
        protected SqlConnection connect() 
        {
            //establish connection
            string ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=CAFE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }

    }
}
