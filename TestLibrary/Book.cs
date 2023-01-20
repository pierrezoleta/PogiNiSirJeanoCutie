using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    internal class Book
    {
        string bookTitle, authorName;

        public Book(string bookTitle, string authorName) { 
            this.authorName = authorName;
            this.bookTitle = bookTitle; 
        }
    }
}
