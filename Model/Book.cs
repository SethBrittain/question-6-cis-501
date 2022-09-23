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

        private int[] bookmarkPageStatus = new int[5];

        private int[] bookmarkPage = new int[5];

        public Book(String title, int pages)
        {
            this.title = title;
            this.pages = pages;
        }

        public String Title { get => title; set => title = value; }

        public int Pages { get => pages; set => pages = value; }

        public int BookmarkPageStatusGet(int index)
        {
            return bookmarkPageStatus[index];
        }

        public void BookmarkPageStatusSet(int index, string status)
        {
            bookmarkPageStatus[index] = Int32.Parse(status);
        }

        public int BookmarkPageGet(int index)
        {
            return bookmarkPage[index];
        }

        public void BookmarkPageSet(int index, string pageNumber)
        {
            bookmarkPage[index] = Int32.Parse(pageNumber);
        }
    }
}
