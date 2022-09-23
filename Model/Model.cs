using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace Model
{
    class Model
    {
        private List<Book> books = new List<Book>();

        public List<Book> GetBooks()
        {
            return books;
        }

        public void CloudSync()
        {
            using (StreamReader sr = new StreamReader("CloudFile.txt"))
            {
                string ln;

                while ((ln = sr.ReadLine()) != null)
                {
                    int counter = 2;
                    string[] subs = ln.Split(',');
                    Book book = new Book(subs[0], Int32.Parse(subs[1]));

                    for (int i = 0; i < 5; i++)
                    {
                        book.SetBookmarkPage(i, subs[counter]);
                        counter++;
                    }
                    books.Add(book);
                }
                sr.Close();
            }
        }
    }
}
