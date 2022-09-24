using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public partial class View : Form
    {
        private BookForm bf;
        private Controller c;
        private Model model;
        private Book currentBook;
        int pageSearch = 1;

        public View(Model m)
        {
            model = m;
            bf = new BookForm();
            bf.BackButton.Click += UxBackButton_Click;
            bf.FormClosed += CloseForm;
            bf.PrevButton.Click += UxPrevButton_Click;
            bf.NextButton.Click += UxNextButton_Click;
            bf.BookmarkButton.Click += UxAddBookmarkButton_Click;
            bf.PageNumber.ValueChanged += UxPageNumberChanged;
            InitializeComponent();
        }

        public void Update(ViewState state)
        {
            switch (state)
            {
                case ViewState.Unsynchronized:
                    Console.WriteLine("Synchronizing");
                    model.CloudSync();
                    Update(ViewState.Synchronized);
                    break;
                case ViewState.Synchronized:
                    List<Book> books = model.books;
                    foreach (Book book in books)
                    {
                        BookControl bc = new BookControl(book);
                        bc.Click += this.BookControl_Click;
                        bc.Title.Click += this.BookControl_Click;
                        UxBookshelf.Controls.Add(bc);
                    }
                    UxBookshelf.Refresh();
                    this.Refresh();
                    UxSynchronizeButton.Enabled = false;
                    break;
                case ViewState.LoadingBook:
                    c.currBook = this.currentBook;
                    bf.PageText.Text = c.currBook.Pages[0];
                    bf.PrevButton.Enabled = false;
                    bf.NextButton.Enabled = c.currBook.Pages.Count > 1;
                    break;
                case ViewState.IncreasingPage:
                    bool isLast;
                    string npage = c.nextPage(out isLast);
                    bf.PageText.Text = npage;
                    bf.NextButton.Enabled = isLast;
                    bf.PageNumber.Text = (int.Parse(bf.PageNumber.Text) + 1).ToString();
                    Update(ViewState.GettingPageNumber);
                    break;
                case ViewState.DecreasingPage:
                    bool isFirst;
                    string ppage = c.prevPage(out isFirst);
                    bf.PageText.Text = ppage;
                    bf.PrevButton.Enabled = isFirst;
                    bf.PageNumber.Text = (int.Parse(bf.PageNumber.Text) - 1).ToString();
                    Update(ViewState.GettingPageNumber);
                    break;
                case ViewState.AddingBookmark:
                    // Tell controller to add a bookmark on current page
                case ViewState.GettingPageNumber:
                    // bv.PageNumber.Text = controller.getPageNumber();
                default:
                    break;
            }
        }



        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void UxSynchronizeButton_Click(object sender, EventArgs e)
        {
            Update(ViewState.Unsynchronized);
        }

        private void BookControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            bf.Show();
            this.currentBook = ((BookControl)sender).currentBook;
            Debug.WriteLine(((BookControl)sender).currentBook);
            Update(ViewState.LoadingBook);
        }

        private void UxBackButton_Click(object sender, EventArgs e)
        {
            bf.Hide();
            this.Show();
        }

        private void UxPrevButton_Click(object sender, EventArgs e)
        {
            Update(ViewState.DecreasingPage);
        }

        private void UxNextButton_Click(object sender, EventArgs e)
        {
            Update(ViewState.IncreasingPage);
        }

        private void UxAddBookmarkButton_Click(object sender, EventArgs e)
        {
            Update(ViewState.AddingBookmark);
        }

        private void UxPageNumberChanged(object sender, EventArgs e)
        {
            NumericUpDown tb = sender as NumericUpDown;
            pageSearch = int.Parse(tb.Text);
        }

        public void SetController(Controller c)
        {
            this.c = c;
        }
    }
}
