using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October30Practice.Models
{
    internal class Library
    {
        private Book[] _books = new Book[0];

        public Book[] Books { get => _books; } 

        public void AddBook(Book book)
        {
            Array.Resize(ref _books, Books.Length+1);
            Books[Books.Length - 1] = book;
        }

        public BookGetResult GetBookById(uint Id)
        {
            foreach (var book in _books) 
            {
                if(book.Id == Id)
                {
                    return new BookGetResult(true,book);
                }
            }
            return new BookGetResult(false);
        }
    }

    record BookGetResult(bool IsFound,Book book=null);
}
