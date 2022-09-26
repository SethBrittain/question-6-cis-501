using System.Diagnostics;

namespace AlarmClock2
{
    public enum State
    {
        AddingAlarm,
        EditingAlarm,
        SnoozingAlarm,
        StoppingAlarm,
        Refreshing,
        DisplayingAlert,
        ClearingAlert,
        CheckingCount,
        Saving,
        Loading
    }

    public partial class View : Form
    {
        public InputHandlerDel Input;
        
        private Model m;

        public View(Model m)
        {
            InitializeComponent();
            this.m = m;
        }

        public void DisplayState(State s, string args)
        {
            switch (s)
            {
                case State.Refreshing:
                    RefreshAlarmList();
                    break;
                case State.CheckingCount:
                    UxAddButton.Enabled = m.Alarms.Count < 5;
                    break;
                case State.DisplayingAlert:
                    UxStatusBar.Text = "Alarm Went Off - " + args;
                    UxSnoozeButton.Enabled = true;
                    UxStopButton.Enabled = true;
                    break;
                case State.ClearingAlert:
                    UxStatusBar.Text = "";
                    UxSnoozeButton.Enabled = false;
                    UxStopButton.Enabled = false;
                    break;
                default:
                    break;
            }

        }

        public void RefreshAlarmList()
        {
            UxAlarmList.Items.Clear();
            
            foreach (Alarm s in m.Alarms)
            {
                 UxAlarmList.Items.Add(s);
            }
        }

        private void UxEditButton_Click(object sender, EventArgs e)
        {
            AlarmEdit ae = new AlarmEdit((Alarm)UxAlarmList.SelectedItem);
            ae.DateTimeUI.ValueChanged += DateTimeUI_ValueChanged;
            ae.FormClosed += Ae_FormClosed;
            ae.EnabledBox.CheckedChanged += EnabledBox_CheckedChanged;
            ae.TypeSelector.SelectedIndexChanged += TypeSelector_SelectedIndexChanged;
            UxEditButton.Enabled = false;
            ae.Show();
        }

        private void TypeSelector_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ((Alarm)UxAlarmList.SelectedItem).Type = (AlarmType)(((ComboBox)sender).SelectedIndex);
        }

        private void EnabledBox_CheckedChanged(object? sender, EventArgs e)
        {
            ((Alarm)UxAlarmList.SelectedItem).Enabled = ((CheckBox)sender).Checked;
        }

        private void Ae_FormClosed(object? sender, FormClosedEventArgs e)
        {
            DisplayState(State.Refreshing, "");
        }

        private void DateTimeUI_ValueChanged(object? sender, EventArgs e)
        {
            ((Alarm)UxAlarmList.SelectedItem).Time = ((DateTimePicker)sender).Value;
        }

        private void UxAddButton_Click(object sender, EventArgs e)
        {
            Input(State.AddingAlarm, "");
            UxSnoozeButton.Enabled = false;
            UxEditButton.Enabled = false;
        }

        private void UxSnoozeButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(((Alarm)UxAlarmList.SelectedItem).Time.ToString());
            //((Alarm)UxAlarmList.SelectedItem).Time = ((Alarm)UxAlarmList.SelectedItem).Time.AddMinutes(5);
        }

        private void UxStopButton_Click(object sender, EventArgs e)
        {
            UxStopButton.Enabled = false;
            UxStatusBar.Text = "";
        }

        private void UxAlarmList_SelectedValueChanged(object sender, EventArgs e)
        {
            UxEditButton.Enabled = UxAlarmList.SelectedItems.Count != 0;
        }

        private void View_FormClosed(object sender, FormClosedEventArgs e)
        {
            Input(State.Saving, "");
        }
    }
}
