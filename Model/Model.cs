using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Model
{
    class Model
    {
        private List<Book> books = new List<Book>();

        public void BookListAdd(Book book)
        {
            books.Add(book);
        }

        public Book BookGet(int index)
        {
            return books[index];
        }
    }
}
