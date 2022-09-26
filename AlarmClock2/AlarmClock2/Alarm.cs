using System.Diagnostics;

namespace AlarmClock2
{
    public enum AlarmType
    {
        Radar,
        Beacon,
        Charms,
        Circuit,
        Reflection
    }
    public class Alarm
    {
        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }
        private DateTime _time = DateTime.Today;

        public AlarmType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private AlarmType _type = AlarmType.Radar;

        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }
        private bool _enabled = false;

        public Alarm()
        {
        }

        public Alarm(DateTime alarmTime)
        {
            this._time = alarmTime;
        }

        public Alarm(DateTime alarmTime, AlarmType type, bool enabled)
        {
            this._time = alarmTime;
            this._type = type;
            this._enabled = enabled;
        }

        public override string ToString()
        {
            int hourConvert = _time.Hour > 12 ? _time.Hour - 12 : _time.Hour;
            if (hourConvert == 0) hourConvert = 12;
            string s = string.Format("{0:d2}:{1:d2} {2} {3} - {4}", hourConvert, _time.Minute, _time.Hour >= 12 ? "AM" : "PM", _enabled ? "Enabled" : "Disabled", _type.ToString());
            return s;
        }
    }
}
