using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace Question6
{
    public class Model
    {
        public List<Book> books = new List<Book>();

        public void CloudSync()
        {
            string filename = "cloudfile.txt";
            if (!(File.Exists(filename)))
            {
                File.CreateText(filename);
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string text = sr.ReadToEnd();
                string[] books = text.Split('~');
                for (int i = 0; i < books.Length; i++)
                {
                    string[] subs = books[i].Split('`');
                    Book b = new Book(subs[0]);

                    b.SetBookmark(0, subs[1]);
                    b.SetBookmark(1, subs[2]);
                    b.SetBookmark(2, subs[3]);
                    b.SetBookmark(3, subs[4]);
                    b.SetBookmark(4, subs[5]);


                    int curChar = 0;
                    StringBuilder sb = new StringBuilder();
                    for (int cnt = 0; cnt < subs[6].Length; cnt++)
                    {
                        if (curChar == 5)
                        {
                            b.AddPage(sb.ToString());
                            curChar = 0;
                            sb.Clear();
                            cnt--;
                        }
                        else
                        {
                            sb.Append(subs[6][cnt]);
                            curChar++;
                        }
                    }
                    this.books.Add(b);
                }
            }
        }
    }
}
