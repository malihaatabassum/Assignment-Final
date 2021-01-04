using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment.Models
{
    class Database
    {
        public Books Books { get; set; }
        public Database()
        { 
            string connString = "Server= DESKTOP-IL7ISSP\SQLEXPRESS; Integrated Security = true ; Database = Assignment "
            SqlConnection conn = new SqlConnection (connString )
                 
            Books = new Books(conn );


        }
    }
}
