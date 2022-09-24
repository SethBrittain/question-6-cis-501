using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Question6
{
    public class Book
    {
        public String title { get; private set; }

        private int currentPage = 1;

        public int[] bookmarks = new int[5];

        private List<string> pages = new List<string>();
        public List<string> Pages { get => pages; }

        public Book(String title)
        {
            this.title = title;
        }

        public void AddPage(string page)
        {
            pages.Add(page);
        }

        public int CurrentPage { get => currentPage; set => currentPage = value; }

        public void SetBookmark(int index, string pageNumber)
        {
            bookmarks[index] = Int32.Parse(pageNumber);
        }

        public int GetTotalPages()
        {
            return pages.Count;
        }
    }
}
