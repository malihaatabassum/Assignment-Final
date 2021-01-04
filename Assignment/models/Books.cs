using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment.models
{
    public class Books
    {
        SqlConnection conn;
        
        public Books() { }
        public Books ( SqlConnection conn) {
            this.conn = conn; 
        }
        public bool AddBook(Books book)
        { conn.Open();
            string query = String.Format("INSERT INTO Books VALUES('{0}','{1}','{2}')", book.id, book.name, book.author);

            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
          
            if (result > 0) return true;
            return false; 

                }
        public ArrayList GetAllBooks ()
        { ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Books ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read ())
            { Books book = new Books();
                book.Id = reader.GetInt32(reader.GetOrdinal("Id "));
                book.Name  = reader.GetString(reader.GetOrdinal("Name "));
                book.Author = reader.GetString(reader.GetOrdinal("Author "));
                book.Edition = reader.Getstring(reader.GetOrdinal("Edition "));

                book.Add(book); 

            }
            return Books;
        }

    }
}
