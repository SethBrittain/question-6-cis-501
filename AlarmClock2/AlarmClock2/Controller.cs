using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace AlarmClock2
{
    public class Controller
    {
        public ObserverDel Update;

        private Model m;

        private Timer t = new Timer();

        public Controller(Model m)
        {
            this.m = m;
            t.Interval = 1000;
            t.Tick += CheckAlarms;
            t.Start();
        }

        private void CheckAlarms(object? sender, EventArgs e)
        {
            foreach (Alarm a in m.Alarms)
            {
                if (
                    DateTime.Now.Hour == a.Time.Hour &&
                    DateTime.Now.Minute == a.Time.Minute &&
                    DateTime.Now.Second == a.Time.Second 
                )
                {
                    Update(State.DisplayingAlert, a.Type.ToString());
                }
            }
        }

        public void Handle(State s, string args)
        {
            switch (s)
            {
                case State.Refreshing:
                    break;
                case State.AddingAlarm:
                    m.AddAlarm();
                    Update(State.Refreshing, "");
                    Update(State.CheckingCount, "");
                    break;
                case State.Saving:
                    WriteAlarmsToFile();
                    break;
                case State.Loading:
                    OpenAlarmsFromFile();
                    break;
                default:
                    break;
            }
        }

        public void WriteAlarmsToFile()
        {
            using (StreamWriter sw = new StreamWriter("alarms.txt"))
            {
                foreach (Alarm alarm in m.Alarms)
                {
                    sw.WriteLine(string.Format("{0}:{1}:{2},{3},{4}", alarm.Time.Hour, alarm.Time.Minute, alarm.Time.Second, alarm.Enabled ? "1" : "0", (int)alarm.Type));
                }
            }
        }

        public void OpenAlarmsFromFile()
        {
            if (!File.Exists("alarms.txt")) File.CreateText("alarms.txt");
            string[] lines = File.ReadAllLines("alarms.txt");
            foreach (string line in lines)
            {
                string[] properties = line.Split(',');
                string[] time = properties[0].Split(':');

                int hour = int.Parse(time[0]);
                int min = int.Parse(time[1]);
                int sec = int.Parse(time[2]);

                DateTime dt = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, hour, min, sec);

                m.Alarms.Add(
                    new Alarm(
                        dt,
                        (AlarmType)(int.Parse(properties[2])),
                        int.Parse(properties[1]) == 1
                    )
                );
            }
        }
    }
}
