using System;
using System.IO;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Model m = new Model();

            using (StreamReader sr = new StreamReader("..\\..\\..\\TextFile1.txt"))
            {
                string ln;

                while ((ln = sr.ReadLine()) != null)
                {
                    int counter = 2;
                    string[] subs = ln.Split(',');
                    Book book = new Book(subs[0], Int32.Parse(subs[1]));

                    for (int i = 0; i < 5; i++)
                    {
                        book.BookmarkPageStatusSet(i, subs[counter]);
                        book.BookmarkPageSet(i, subs[counter + 1]);
                        counter += 2;
                    }
                    m.BookListAdd(book);
                }
                sr.Close();
            }

            Console.WriteLine("Exiting..");
        }
    }
}
