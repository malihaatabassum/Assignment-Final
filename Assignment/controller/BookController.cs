using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.controller
{
    public class BookController
    {
        static Database db = new Database();
        public static  Book AddBook(string id, string name)
        {

            return db.Books.AddBook(r);
        }
    }
}