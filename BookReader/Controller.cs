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

        public Controller(Model m, View v)
        {
            model = m;
            view = v;
        }

        public string nextPage(int index, out bool isLast)
        {
            if (model.books[index].CurrentPages() + 1 == model.books[index].GetTotalPages())
            {
                isLast = true;
                model.books[index].CurrentPages() += 1;
                return pages;
            }
            else
            {
                model.books[index].CurrentPages() += 1;
            }
        }

        public string prevPage(int index, out bool isFirst)
        {
            if (model.books[index].CurrentPages() - 1 == 0)
            {
                isFirst = true;
                model.books[index].CurrentPages() -= 1;
                return pages;
            }
            else
            {
                model.books[index].CurrentPages() -= 1;
            }
        }

        public bool setMark(int index)
        {
            foreach (int v in model.books[index].Marks)
            {
                if (model.books[index].Marks[v] == -1)
                {
                    model.books[index].Marks[v] = model.books[index].CurrentPages();
                    return false;
                }
            }
            return true;
        }

        public bool removeMark(int index)
        {
            foreach (int v in model.books[index].Marks)
            {
                if (model.books[index].Marks[v] == model.books[index].CurrentPages())
                {
                    model.books[index].Marks[v] = -1;
                    return false;
                }
            }
            return true;
        }

        public bool findPage(int index, int num)
        {
            if (num <= model.books[index].GetTotalPages() && num >= 0)
            {
                model.books[index].CurrentPages() = num;
                return false;
            }
            return false;
        }
    }
}
