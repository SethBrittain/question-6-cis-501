using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Model
{
    public class Book
    {
        private String title;

        private int pages;

        private int[] bookmarkPages = new int[5];

        public Book(String title, int pages)
        {
            this.title = title;
            this.pages = pages;
        }

        public String Title { get => title; }

        public int Pages { get => pages; }

        public int GetBookmarkPage(int index)
        {
            return bookmarkPages[index];
        }

        public void SetBookmarkPage(int index, string pageNumber)
        {
            bookmarkPages[index] = Int32.Parse(pageNumber);
        }
    }
}
