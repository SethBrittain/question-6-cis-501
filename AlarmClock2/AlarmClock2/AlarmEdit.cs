using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock2
{
    public partial class AlarmEdit : Form
    {
        public DateTimePicker DateTimeUI => UxTimePicker;
        public CheckBox EnabledBox => UxAlarmSet;
        public Button Accept => UxSetButton;
        public Button Cancel => UxCancelButton;
        public ComboBox TypeSelector => UxAlarmTypes;

        public AlarmEdit(Alarm a)
        {
            InitializeComponent();
            UxTimePicker.Value = a.Time;
        }

        private void UxEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
