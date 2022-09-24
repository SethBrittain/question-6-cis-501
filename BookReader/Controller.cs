using System;
using System.Collections.Generic;
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
            if (currBook.CurrentPage + 1 == currBook.GetTotalPages())
            {
                isLast = true;
                currBook.CurrentPage += 1;
                return currBook.pages[currBook.CurrentPage];
            }
            else
            {
                isLast = false;
                currBook.CurrentPage += 1;
                return currBook.pages[currBook.CurrentPage];
            }
        }

        public string prevPage(out bool isFirst)
        {
            if (currBook.CurrentPage - 1 == 0)
            {
                isFirst = true;
                currBook.CurrentPage -= 1;
                return currBook.pages[currBook.CurrentPage];
            }
            else
            {
                isFirst = false;
                currBook.CurrentPage -= 1;
                return currBook.pages[currBook.CurrentPage];
            }
        }

        public bool setMark()
        {
            foreach (int v in currBook.bookmarks)
            {
                if (currBook.bookmarks[v] == -1)
                {
                    currBook.bookmarks[v] = currBook.CurrentPage;
                    return false;
                }
            }
            return true;
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

        public bool findPage(int index, int num)
        {
            if (num <= currBook.GetTotalPages() && num >= 0)
            {
                currBook.CurrentPage = num;
                return false;
            }
            return false;
        }
    }
}
