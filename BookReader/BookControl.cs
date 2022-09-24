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
    public partial class BookControl : UserControl
    {
        public RichTextBox Title { get => UxTitle; }
        public BookControl(string title)
        {
            InitializeComponent();
            UxTitle.Text = title;
        }
    }
}
