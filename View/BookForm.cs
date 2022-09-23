using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class BookForm : Form
    {
        public Button BackButton => UxBackButton;
        public Button PrevButton => UxPrevPageButton;
        public Button NextButton => UxNextPageButton;
        public Button BookmarkButton => UxAddBookmarkButton;
        public TextBox PageNumber => UxPageNumber;
        public RichTextBox PageText => UxPageText;

        public BookForm()
        {
            InitializeComponent();
        }
    }
}
