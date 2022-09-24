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
            using (StreamReader sr = new StreamReader("cloudfile.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    sb.Append(sr.Read());
                }
            }
        }
    }
}
