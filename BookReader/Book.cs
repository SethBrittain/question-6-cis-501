using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Question6
{
    public class Book
    {
        private String title;

        private int currentPage = 1;

        public int[] bookmarks = new int[5];

        public String[] pages { get; }

        public Book(String title)
        {
            this.title = title;
        }

        public int CurrentPage { get => currentPage; set => currentPage = value; }

        public int GetTotalPages()
        {
            return pages.Length;
        }
    }
}
