using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public enum ViewState
    {
        Unsynchronized,
        Synchronizing,
        Synchronized,
        LoadingBook,
        IncreasingPage,
        DecreasingPage,
        AddingBookmark,
        GettingPageNumber
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model m = new Model();
            View v = new View(m);
            Controller c = new Controller(m, v);
            v.SetController(c);
            Application.Run(v); 
        }
    }
}
