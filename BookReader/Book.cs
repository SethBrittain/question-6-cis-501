﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Question6
{
    public class Book
    {
        public String title { get; private set; }

        private int currentPage = 1;

        private int[] bookmarks = new int[5];

        private String[] pages;

        public Book(String title)
        {
            this.title = title;
        }

        public int CurrentPage { get => currentPage; set => currentPage = value; }

        public void AddBookmark(int index, int pageNumber)
        {
            bookmarks[index] = pageNumber;
        }

        public int GetTotalPages()
        {
            return pages.Length;
        }
    }
}
