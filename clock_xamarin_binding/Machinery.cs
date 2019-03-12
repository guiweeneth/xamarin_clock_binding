using System;
using System.Timers;
namespace clock_xamarin_binding
{
    public class Machinery : NotificationObject
    {
        private int hour;

        public int Hour
        {
            get { return hour; }
            set
            {
                hour = value;
                OnPropertyChanged();
            }
        }

        private int minute;

        public int Minute
        {
            get { return minute; }
            set
            {
                minute = value;
                OnPropertyChanged();
            }
        }

        private int second;

        public int Second
        {
            get { return second; }
            set
            {
                second = value;
                OnPropertyChanged();
            }
        }

        public Machinery()
        {
            var time = new Timer();
            time.Elapsed += HandleTime;
            time.AutoReset = true;
            time.Enabled = true;
        }

        void HandleTime(object sender, ElapsedEventArgs e)
        {
            Hour = e.SignalTime.Hour;
            Minute = e.SignalTime.Minute;
            Second = e.SignalTime.Second;
        }

    }
}
