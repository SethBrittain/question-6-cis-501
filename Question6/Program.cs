﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public enum LibraryState
    {
        Unsynchronized,
        Synchronizing,
        Synchronized,
        OpeningBook
    }
    public enum BookState
    {
        Idle,
        ChangingPage
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());
        }
    }
}
