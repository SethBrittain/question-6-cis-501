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
    public partial class View : Form
    {
        //Model m = new Model();
        private BookForm bv;
        private int ClickedIndex;
        private Controller c;
        public View(Model m)
        {
            bv = new BookForm();
            bv.BackButton.Click += UxBackButton_Click;
            bv.FormClosed += CloseForm;
            bv.PrevButton.Click += UxPrevButton_Click;
            bv.NextButton.Click += UxNextButton_Click;
            bv.BookmarkButton.Click += UxAddBookmarkButton_Click;
            InitializeComponent();
        }

        public void Update(ViewState state)
        {
            switch (state)
            {
                case ViewState.Unsynchronized:
                    //List<Books> b = inputHandle(ViewState.Synchronizing);
                    //foreach (Book book in b)
                    //{
                    //    UxBookshelf.Controls.Add(new BookControl(b.Title));
                    //}
                    BookControl bc = new BookControl("The Lord of the Rings");
                    bc.Click += this.BookControl_Click;
                    bc.Title.Click += this.BookControl_Click;
                    UxBookshelf.Controls.Add(bc);
                    Update(ViewState.Synchronized);
                    break;
                case ViewState.Synchronized:
                    UxSynchronizeButton.Enabled = false;
                    break;
                case ViewState.LoadingBook:
                    // Get page text from controller
                    bv.PageText.Text =@"she had paid for had been carried off; and she wanted the keys. It
took a long while to satisfy her, as she had brought a complete inventory with her and went right through it. In the end she departed with
Lotho and the spare key and the promise that the other key would
be left at the Gamgees’ in Bagshot Row. She snorted, and showed
plainly that she thought the Gamgees capable of plundering the hole
during the night.Frodo did not offer her any tea.
He took his own tea with Pippin and Sam Gamgee in the kitchen.
It had been officially announced that Sam was coming to Buckland
‘to do for Mr.Frodo and look after his bit of garden’; an arrangement
that was approved by the Gaffer, though it did not console him for
the prospect of having Lobelia as a neighbour.
‘Our last meal at Bag End!’ said Frodo, pushing back his chair.
They left the washing up for Lobelia.Pippin and Sam strapped up
their three packs and piled them in the porch.Pippin went out for
a last stroll in the garden.Sam disappeared.
The sun went down.Bag End seemed sad and gloomy and dishevelled.Frodo wandered round the familiar rooms, and saw the light
of the sunset fade on the walls, and shadows creep out of the corners.
It grew slowly dark indoors.He went out and walked down to the
gate at the bottom of the path, and then on a short way down the
Hill Road.He half expected to see Gandalf come striding up through
the dusk.
The sky was clear and the stars were growing bright. ‘It’s going
to be a fine night,’ he said aloud. ‘That’s good for a beginning. I feel
like walking.I can’t bear any more hanging about.I am going to
start, and Gandalf must follow me.’ He turned to go back, and then
stopped, for he heard voices, just round the corner by the end of
Bagshot Row.One voice was certainly the old Gaffer’s; the other was
strange, and somehow unpleasant. He could not make out what it
said, but he heard the Gaffer’s answers, which were rather shrill.The
old man seemed put out.
‘No, Mr.Baggins has gone away. Went this morning, and my Sam
went with him: anyway all his stuff went.Yes, sold out and gone, I
tell’ee.Why? Why’s none of my business, or yours. Where to? That
ain’t no secret.He’s moved to Bucklebury or some such place, away
down yonder. Yes it is – a tidy way.I’ve never been so far myself;
                    they’re queer folks in Buckland.No, I can’t give no message. Good
                   night to you!’
Footsteps went away down the Hill. Frodo wondered vaguely why
the fact that they did not come on up the Hill seemed a great relief.
‘I am sick of questions and curiosity about my doings, I suppose,’
he thought. ‘What an inquisitive lot they all are!’ He had half a mind";
                    // Ask controller if pages > 1
                    // enable/disable next
                    break;
                case ViewState.IncreasingPage:
                    //Get next page from controller
                    bool isLast;
                    string page = getNextPage(out isLast);
                    bv.NextButton.Enabled = isLast;
                    Update(ViewState.GettingPageNumber);
                    break;
                case ViewState.DecreasingPage:
                    //Get prev page from controller
                    // bool isFirst;
                    // string page = c.getPrevPage(out isFirst);
                    bv.PrevButton.Enabled = isFirst;
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
            BookControl bc = sender as BookControl;
            ClickedIndex = UxBookshelf.Controls.IndexOf(bc);
            this.Hide();
            bv.Show();
            Update(ViewState.LoadingBook);
        }

        private void UxBackButton_Click(object sender, EventArgs e)
        {
            bv.Hide();
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
    }
}
