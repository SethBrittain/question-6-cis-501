using System.Diagnostics;

namespace AlarmClock2
{
    public delegate void ObserverDel(State s, string args);
    public delegate void InputHandlerDel(State s, string args);

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Model m = new Model();
            View v = new View(m);
            Controller c = new Controller(m);
            c.OpenAlarmsFromFile();
            v.RefreshAlarmList();
            c.Update = v.DisplayState;
            v.Input = c.Handle;

            Application.Run(v);
        }
    }
}