using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    public class Controller
    {
        private Model model;

        private View view;

        public Book currBook;

        public Controller(Model m, View v)
        {
            model = m;
            view = v;
        }

        public string nextPage(out bool isLast)
        {
            currBook.CurrentPage++;
            Debug.WriteLine(currBook.CurrentPage);
            isLast = currBook.CurrentPage + 1 == currBook.GetTotalPages();
            Debug.WriteLine(currBook.GetTotalPages());
            return currBook.Pages[currBook.CurrentPage-1];
        }

        public string prevPage(out bool isFirst)
        {
            currBook.CurrentPage--;
            Debug.WriteLine(currBook.CurrentPage);
            isFirst = currBook.CurrentPage - 1 == 1;
            Debug.WriteLine(currBook.GetTotalPages());
            return currBook.Pages[currBook.CurrentPage-1];
        }

        public bool setMark()
        {
            for (int i=0; i < currBook.bookmarks.Length; i++)
            {
                if (currBook.bookmarks[i] == -1)
                {
                    currBook.bookmarks[i] = currBook.CurrentPage;
                    break;
                }
            }
            return currBook.bookmarks[4] == -1;
        }

        public bool removeMark()
        {
            foreach (int v in currBook.bookmarks)
            {
                if (currBook.bookmarks[v] == currBook.CurrentPage)
                {
                    currBook.bookmarks[v] = -1;
                    return false;
                }
            }
            return true;
        }

        public string findPage(int pageNum)
        {
            if (pageNum <= currBook.GetTotalPages() && pageNum > 0) currBook.CurrentPage = pageNum;
            return currBook.Pages[currBook.CurrentPage - 1];
        }

        public void saveBooks()
        {
            using (StreamWriter sw = new StreamWriter("cloudfile.txt"))
            {
                int bookCount = 0;
                foreach (Book b in model.books)
                {
                    sw.Write(b.ToString());
                    bookCount++;
                    if (bookCount < model.books.Count) sw.Write("~");
                }
            }
        }
    }
}
