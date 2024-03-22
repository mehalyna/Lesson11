using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Library(string name) 
        {
            Name = name;
            Books = new List<Book>();

        }

        public void AddBook(Book book)
        { 
            Books.Add(book); 
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string title, string author) 
        {
            Title = title;
            Author = author;
        }
        
    }
}
