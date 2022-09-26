using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock2
{
    public class Model
    {
        public List<Alarm> Alarms => _alarms;
        private List<Alarm> _alarms = new List<Alarm>();

        public void AddAlarm()
        {
            Alarm alarm = new Alarm();
            _alarms.Add(alarm);
        }
    }
}
